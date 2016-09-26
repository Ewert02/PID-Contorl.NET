using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PID_Contorl.NET
{
    public partial class Form1 : Form
    {

        double[] arrPos=new double[1000];  // Átlagolás céljából eltároljuk, hogy milyen magasság értékek voltak
        int PosFirst;       // Ez a legrégebbi tárolt érték
        int PosLast;        // Ide írjuk a következő értéket
        int nPos;           // Ennyi érték van most a tárolt listában
        int arrMax;
        double MaxPos;      // A tárolt értékekből a max (piros vonal)
        double MinPos;      // A tárolt értékekből a min (zöld vonal)
        double AvgPos;		// A tárolt értékekből a átlag (fekete vonal)

        double GoalPos;     // A Célérték. Ezt a magasságot kell elérnie a vastag vonalnak
        double hPos;        // A vastag vonal jelenlegi magassága
        double actV;        // A vastag vonal jelenlegi sebessége
        double lastT;       // Az utolsó kiérétkelés az ipőpontja
        double Fedettseg;   // A vastag vonal mennyire áll ellent a szélnek (0=mindent átenged; 1=semmit nem enged át)
        double windV;       // Jelenlegi szélsebesség

		const double g = 0.1;  //9.81 // kg*N/s^2   A szimuláció gravitációs gyorsulása ("kissé" alulbecsült). Még finomhangolni kell a ténylegeshez

		double Kp;            // A szabályozás arányos paramétere (a célérték és a jelen érték kölönbségét ennyivel szorozzuk a beavatkozó jelhez)
		double Ki;            // A szabályozás integráló paramétere (az átlagos hibát ennyivel szorozzuk a beavatkozási értékhez)
		double Kd;            // A szabályozás differenciális paramétere (a célértéktől távol gyorsít, ahogy közeledünk lassít. Ennek a szorzója)

		const double MaxKp = 5.0;
		const double MaxKi = 5.0;
		const double MaxKd = 20.0;
		const double MaxWnd = 2.0;

		double Integral;
		double IntegralTime;
		long IntegralCnt;
		double DiffErr;
		double lastErr;
		const double MaxRange = 2.0;        // A "tér" magassága. Ezt látjuk a fehér ablakban
		const double FineRange = 1.0;		// MaxRange / 20# Nem használt...

		public Form1()
        {
            InitializeComponent();
        }

		void SliderP_Change()
		{
			//Kp = -(SliderP.value * 1# / (SliderP.Max - SliderP.Min)) * MaxKp   '-50..50 range
			Kp = (1 - SliderP.Value * 1.0 / (SliderP.Maximum - SliderP.Minimum)) * MaxKp;
			txtP.Text = Kp.ToString("F");
		}

		void SliderI_Change()
		{
			//Ki = -(SliderI.value * 1# / (SliderI.Max - SliderI.Min)) * MaxKi   '-50..50 range
			Ki = (1 - SliderI.Value * 1.0 / (SliderI.Maximum - SliderI.Minimum)) * MaxKp;
			txtI.Text = Ki.ToString("F");
		}

		void SliderD_Change()
		{
			//Kd = -(SliderD.value * 1# / (SliderD.Max - SliderD.Min)) * MaxKd   '-50..50 range
			Kd = (1 - SliderD.Value * 1.0 / (SliderD.Maximum - SliderD.Minimum)) * MaxKp;
			txtD.Text = Kd.ToString("F");
		}

		void SliderGoal_Change()
		{
			GoalPos = MaxRange - MaxRange * (SliderGoal.Value * 1.0 / (SliderGoal.Maximum - SliderGoal.Minimum));
			txtGoalPos.Text = GoalPos.ToString("F");  // = Format(GoalPos, "F")

			Integral = 0.0;
			IntegralTime = 0.0;

			//IntegralCnt = 0

			ClearAvg();

			ShapeGoal.Top = Convert.ToInt32((MaxRange - GoalPos) / MaxRange * Picture1.Height - ShapeGoal.Height / 2);
		}

		void SliderWind_Change()
		{
			windV = MaxWnd * SliderWind.Value * 1.0 / (SliderWind.Maximum - SliderWind.Minimum);
			txtWind.Text = windV.ToString("F");
		}

		void ClearAvg()
		{
			PosFirst = 1;
			PosLast = 1;
			nPos = 0;
		}


		double Limit(double Val, double Max, double Min)
		{
			if (Val > Max)
			{
				return Max;
			}else if (Val < Min)
			{
				return Min;
			}
			else
			{
				return Val;
			}
		}

		double Boost(double Val, double Mul, double Pow)
		{
			return ( Mul * Val + Math.Sign(Val) * (Math.Pow(Math.Abs(Val), Pow)));
		}

		System.Diagnostics.Stopwatch Timer1 = new System.Diagnostics.Stopwatch(); 

		private void Form1_Load(object sender, EventArgs e)
        {
			actV = 0;
			lastT = timer1.Interval;
			hPos = 1.5;     // fél magasságban van

			/* -50..50 range esetén
			'Kp = 2#:        SliderP = (1 - Kp / MaxKp * 100): Call SliderP_Change
			'Ki = 1#:        SliderI = (1 - Ki / MaxKi * 100): Call SliderI_Change
			'Kd = 10#:        SliderD = (1 - Kd / MaxKd * 100): Call SliderD_Change*/

			
			Kp = 2.0;
			SliderP.Value = Convert.ToInt32(Math.Round((1 - Kp / MaxKp) * 100 ));
			SliderP_Change();

			Ki = 1.0;
			SliderI.Value = Convert.ToInt32(Math.Round((1 - Ki / MaxKi) * 100));
			SliderI_Change();

			Kd = 10.0;
			SliderD.Value = Convert.ToInt32(Math.Round( ((1 - Kd / MaxKd) * 100),0));
			SliderD_Change();

			windV = 0.5;
			SliderWind.Value = Convert.ToInt32(Math.Round(windV / MaxWnd * 100));
			SliderWind_Change();

			Fedettseg = 0.5;

			//curPos = 1

			ClearAvg();
			//PosFirst = 1
			//PosLast = 1
			//nPos = 0
			GoalPos = MaxRange / 2.0;
			SliderGoal.Value = Convert.ToInt32(Math.Round((1 - GoalPos / MaxRange) * SliderGoal.Maximum));
			SliderGoal_Change();

			Integral = 0;
			IntegralTime = 0;
			IntegralCnt = 0;

			arrMax = 50;

			timer1.Interval = 50;
			timer1.Enabled = true;
			timer1.Start();
			Timer1.Start();	// ez egy StopWatch
			
		}

		private void cmdClear_Click(object sender, EventArgs e)
		{
			IntegralCnt = 0;
		}

		private void SliderWind_Scroll(object sender, EventArgs e)
		{
			SliderWind_Change();
		}

		private void SliderP_Scroll(object sender, EventArgs e)
		{
			SliderP_Change();
		}

		private void SliderI_Scroll(object sender, EventArgs e)
		{
			SliderI_Change();
		}

		private void SliderD_Scroll(object sender, EventArgs e)
		{
			SliderD_Change();
		}

		private void SliderGoal_Scroll(object sender, EventArgs e)
		{
			SliderGoal_Change();
		}

		double Max(double a, double b)
		{
			if (a > b)
			{
				return a;
			}
			else
			{
				return b;
			}
		}

		double Min(double a, double b)
		{
			if (a < b)
			{
				return a;
			}
			else
			{
				return b;
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			double dt, dv, v;
			int BinFed;
			double Err, Err2, Err3;
			int i, j;
			double Mn, Mx, Av, Sm;
			double PPart, IPart, IPart2, DPart;
			string Imode;
			double ErrGoalAvg;

			dt = Timer1.ElapsedMilliseconds - lastT; //Itt most nemtudom, hogy mit csináljak, hogy a VB6 dt=Timer-lasT az mit csinál, szóval a StopWatchot használom.

			IntegralTime = IntegralTime + dt;
			IntegralCnt = IntegralCnt + 1;

			/*dt = 1#
			' ----------------------- ------------
			' Lefelé ható erő a gravitáció
			'dh = 0.5 * g * dt * dt + curV * dt*/

			v = actV - g * dt;   // A jelenlegi sebesség

			/*' -----------------------------------
			' Felfelé ható erők
			' A szél sebessége csökkenti az esési sebességet. Ez arányos a szél elleni fedettséggel.
			'v = v + windV * Fedettseg * dt*/

			v = v + windV * Fedettseg * dt;
			hPos = hPos + v * dt;

			// Nem mehetünk ki a tartományból

			if (hPos >= MaxRange)
			{
				v = 0;
				hPos = MaxRange;
			}

			if (hPos <= 0)
			{
				v = 0;
				hPos = 0;
			}

			lastT = Timer1.ElapsedMilliseconds; // jelenlegi idő
			actV = v;

			/* ===============================================
			 * Szabályozás */

			Err = GoalPos - hPos; // A cél, hogy középen maradjon a lapocska
			DiffErr = Err - lastErr;
			Integral = Integral + Err;
			ErrGoalAvg = GoalPos - AvgPos;

			//Fedettseg = Kp * Err + (Ki * Integral * dt) + (Kd * DiffErr / dt)
			//Fedettseg = Kp * (Err) + (Ki * (GoalPos - AvgPos) * dt) + (Kd * DiffErr / dt)

			PPart = Kp * Boost(Err / FineRange, 1.0, 2.0);   //Err3 = Err + Err ^ 3;
			IPart = Ki * Boost((GoalPos - AvgPos) / FineRange, 0.0, 0.5);


			//IPart2 = Boost(Sin(Limit(Integral / IntegralTime * 3.14, 3.14, -3.14)), 0, 2)
			//IPart2 = 0
			//IPart2 = Boost(Sin(Limit(Integral / 20, 3.14, -3.14)), 0, 2)
			//IPart2 = (Sin(Limit(ErrGoalAvg * IntegralTime, 3.14 / 2, -3.14 / 2))) * 0.15 ' max 0.15 - el dolgozik

			Imode = "avg";

			//DPart = (Kd * (DiffErr) / dt)

			DPart = Kd * Boost(DiffErr / dt / FineRange, 1.0, 2.0);   //DPart = Kd * ((DiffErr / dt) + (DiffErr / dt) ^ 3);

			//IPart2 = IIf(Abs(DPart) < 0.2, Boost(ErrGoalAvg * IntegralTime, 0, 1 / 2) * 0.15, 0) ' max 0.15 - el dolgozik

			IPart2 = 0;

			Fedettseg = PPart + IPart + IPart2 + DPart;
			Fedettseg = Min(1, Fedettseg);
			Fedettseg = Max(0, Fedettseg);
			lastErr = Err;


			// -----------------
			// Animáció megjelenítése

			lblPPart.Text = PPart.ToString("F");
			lblIPart.Text = IPart.ToString("F");
			lblIPart2.Text = IPart2.ToString("F");
			lblDPart.Text = DPart.ToString("F");

			lblFedettseg.Text = String.Format(Convert.ToString(Fedettseg));
			BinFed = Convert.ToInt32((1 - Fedettseg) * 240);
			if (Imode == "avg")
			{
				Line1.BackColor = Color.FromArgb(BinFed, BinFed, BinFed);
			}
			else
			{
				Line1.BackColor = Color.FromArgb(BinFed / 2, BinFed / 2, BinFed);
			}

			//Line1.Bottom = Convert.ToInt32((1 - hPos / MaxRange) * Picture1.Height);
			Line1.Top = Convert.ToInt32((1 - hPos / MaxRange) * Picture1.Height);

			txtSebesseg.Text = v.ToString("F");
			lblHPos.Text = hPos.ToString("F");
			//PictureChart.PSet (IntegralCnt, Line1.Y2), vbBlack

			lblIntegral.Text = ErrGoalAvg.ToString("F");
			lblIntegral2.Text = (ErrGoalAvg*IntegralTime).ToString("F");
			lblDiff.Text = DiffErr.ToString("F");

			// Átlagolás
			arrPos[PosLast] = hPos;
			//PosLast = PosLast + 1;
			PosLast++;

			if (PosLast > arrMax)
			{
				PosLast = arrPos.GetLowerBound(0); // LBound(arrPos);
			}

			if (nPos >= arrMax - 1)
			{

			}
			else
			{
				nPos++;
			}

			Sm = 0;
			i = 1;

			Mx = 0;
			Mn = 0;
			Av = 0;
			while(i<=nPos)
			{
				if (i == arrPos.GetLowerBound(0))
				{
					Mn = arrPos[i];
					Mx = Mn;
					Av = Mn;
					Sm = arrPos[i];
				}
				else
				{
					Sm = Sm + arrPos[i];
					Mx = Max(Mx, arrPos[i]);
					Mn = Min(Mn, arrPos[i]);
				}
				i++;
			} //while (i <= nPos);
			Av = Sm / nPos;

			LineMax.Top = Convert.ToInt32((1 - Mx / MaxRange) * Picture1.Height);
			LineMin.Top = Convert.ToInt32((1 - Mn / MaxRange) * Picture1.Height);
			LineAvg.Top = Convert.ToInt32((1 - Av / MaxRange) * Picture1.Height);

			/*
			 * LineMax.Bottom = Convert.ToInt32((1 - Mx / MaxRange) * Picture1.Height);
			LineMin.Bottom = Convert.ToInt32((1 - Mn / MaxRange) * Picture1.Height);
			LineAvg.Bottom = Convert.ToInt32((1 - Av / MaxRange) * Picture1.Height);
			*/

			MaxPos = Mx;
			MinPos = Mn;
			AvgPos = Av;
		}
	}
}
