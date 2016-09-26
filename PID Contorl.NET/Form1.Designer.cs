namespace PID_Contorl.NET
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.Picture1 = new System.Windows.Forms.PictureBox();
			this.SliderGoal = new System.Windows.Forms.TrackBar();
			this.txtGoalPos = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lblHPos = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.SliderWind = new System.Windows.Forms.TrackBar();
			this.label2 = new System.Windows.Forms.Label();
			this.txtWind = new System.Windows.Forms.TextBox();
			this.SliderP = new System.Windows.Forms.TrackBar();
			this.SliderI = new System.Windows.Forms.TrackBar();
			this.SliderD = new System.Windows.Forms.TrackBar();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtP = new System.Windows.Forms.TextBox();
			this.txtI = new System.Windows.Forms.TextBox();
			this.txtD = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.lblPPart = new System.Windows.Forms.Label();
			this.lblIPart = new System.Windows.Forms.Label();
			this.lblDPart = new System.Windows.Forms.Label();
			this.lblIPart2 = new System.Windows.Forms.Label();
			this.lblIntegral = new System.Windows.Forms.Label();
			this.lblIntegral2 = new System.Windows.Forms.Label();
			this.lblDiff = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtSebesseg = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.lblFedettseg = new System.Windows.Forms.Label();
			this.LineMax = new System.Windows.Forms.Label();
			this.LineMin = new System.Windows.Forms.Label();
			this.LineAvg = new System.Windows.Forms.Label();
			this.Line1 = new System.Windows.Forms.Label();
			this.ShapeGoal = new System.Windows.Forms.Label();
			this.cmdClear = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.Picture1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SliderGoal)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SliderWind)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SliderP)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SliderI)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SliderD)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// Picture1
			// 
			this.Picture1.BackColor = System.Drawing.Color.White;
			this.Picture1.Location = new System.Drawing.Point(34, 31);
			this.Picture1.Name = "Picture1";
			this.Picture1.Size = new System.Drawing.Size(185, 400);
			this.Picture1.TabIndex = 0;
			this.Picture1.TabStop = false;
			// 
			// SliderGoal
			// 
			this.SliderGoal.Location = new System.Drawing.Point(10, 31);
			this.SliderGoal.Maximum = 100;
			this.SliderGoal.Name = "SliderGoal";
			this.SliderGoal.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.SliderGoal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.SliderGoal.Size = new System.Drawing.Size(45, 400);
			this.SliderGoal.TabIndex = 1;
			this.SliderGoal.TickStyle = System.Windows.Forms.TickStyle.None;
			this.SliderGoal.Value = 10;
			this.SliderGoal.Scroll += new System.EventHandler(this.SliderGoal_Scroll);
			// 
			// txtGoalPos
			// 
			this.txtGoalPos.Location = new System.Drawing.Point(10, 10);
			this.txtGoalPos.Name = "txtGoalPos";
			this.txtGoalPos.Size = new System.Drawing.Size(42, 20);
			this.txtGoalPos.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(58, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Goal--> H=";
			// 
			// lblHPos
			// 
			this.lblHPos.AutoSize = true;
			this.lblHPos.Location = new System.Drawing.Point(122, 13);
			this.lblHPos.Name = "lblHPos";
			this.lblHPos.Size = new System.Drawing.Size(35, 13);
			this.lblHPos.TabIndex = 4;
			this.lblHPos.Text = "label2";
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// SliderWind
			// 
			this.SliderWind.LargeChange = 10;
			this.SliderWind.Location = new System.Drawing.Point(61, 454);
			this.SliderWind.Maximum = 100;
			this.SliderWind.Name = "SliderWind";
			this.SliderWind.Size = new System.Drawing.Size(167, 45);
			this.SliderWind.TabIndex = 5;
			this.SliderWind.TickStyle = System.Windows.Forms.TickStyle.None;
			this.SliderWind.Scroll += new System.EventHandler(this.SliderWind_Scroll);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 438);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Szél erőssége";
			// 
			// txtWind
			// 
			this.txtWind.Location = new System.Drawing.Point(13, 455);
			this.txtWind.Name = "txtWind";
			this.txtWind.Size = new System.Drawing.Size(53, 20);
			this.txtWind.TabIndex = 7;
			// 
			// SliderP
			// 
			this.SliderP.Location = new System.Drawing.Point(236, 105);
			this.SliderP.Maximum = 100;
			this.SliderP.Name = "SliderP";
			this.SliderP.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.SliderP.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.SliderP.RightToLeftLayout = true;
			this.SliderP.Size = new System.Drawing.Size(45, 218);
			this.SliderP.TabIndex = 8;
			this.SliderP.TickFrequency = 5;
			this.SliderP.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
			this.SliderP.Scroll += new System.EventHandler(this.SliderP_Scroll);
			// 
			// SliderI
			// 
			this.SliderI.Location = new System.Drawing.Point(304, 105);
			this.SliderI.Maximum = 100;
			this.SliderI.Name = "SliderI";
			this.SliderI.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.SliderI.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.SliderI.Size = new System.Drawing.Size(45, 218);
			this.SliderI.TabIndex = 9;
			this.SliderI.TickFrequency = 5;
			this.SliderI.Scroll += new System.EventHandler(this.SliderI_Scroll);
			// 
			// SliderD
			// 
			this.SliderD.Location = new System.Drawing.Point(372, 105);
			this.SliderD.Maximum = 100;
			this.SliderD.Name = "SliderD";
			this.SliderD.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.SliderD.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.SliderD.Size = new System.Drawing.Size(45, 218);
			this.SliderD.TabIndex = 10;
			this.SliderD.TickFrequency = 5;
			this.SliderD.Scroll += new System.EventHandler(this.SliderD_Scroll);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label3.Location = new System.Drawing.Point(232, 326);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(23, 24);
			this.label3.TabIndex = 11;
			this.label3.Text = "P";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label4.Location = new System.Drawing.Point(300, 327);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(15, 24);
			this.label4.TabIndex = 12;
			this.label4.Text = "I";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label5.Location = new System.Drawing.Point(368, 326);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(24, 24);
			this.label5.TabIndex = 13;
			this.label5.Text = "D";
			// 
			// txtP
			// 
			this.txtP.Location = new System.Drawing.Point(226, 354);
			this.txtP.Name = "txtP";
			this.txtP.Size = new System.Drawing.Size(43, 20);
			this.txtP.TabIndex = 14;
			// 
			// txtI
			// 
			this.txtI.Location = new System.Drawing.Point(291, 354);
			this.txtI.Name = "txtI";
			this.txtI.Size = new System.Drawing.Size(43, 20);
			this.txtI.TabIndex = 15;
			// 
			// txtD
			// 
			this.txtD.Location = new System.Drawing.Point(361, 354);
			this.txtD.Name = "txtD";
			this.txtD.Size = new System.Drawing.Size(43, 20);
			this.txtD.TabIndex = 16;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(236, 64);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(35, 13);
			this.label6.TabIndex = 17;
			this.label6.Text = "P-part";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(299, 64);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(31, 13);
			this.label7.TabIndex = 18;
			this.label7.Text = "I-part";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(368, 64);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(36, 13);
			this.label8.TabIndex = 19;
			this.label8.Text = "D-part";
			// 
			// lblPPart
			// 
			this.lblPPart.AutoSize = true;
			this.lblPPart.Location = new System.Drawing.Point(239, 81);
			this.lblPPart.Name = "lblPPart";
			this.lblPPart.Size = new System.Drawing.Size(35, 13);
			this.lblPPart.TabIndex = 20;
			this.lblPPart.Text = "label9";
			// 
			// lblIPart
			// 
			this.lblIPart.AutoSize = true;
			this.lblIPart.Location = new System.Drawing.Point(299, 81);
			this.lblIPart.Name = "lblIPart";
			this.lblIPart.Size = new System.Drawing.Size(35, 13);
			this.lblIPart.TabIndex = 21;
			this.lblIPart.Text = "label9";
			// 
			// lblDPart
			// 
			this.lblDPart.AutoSize = true;
			this.lblDPart.Location = new System.Drawing.Point(369, 81);
			this.lblDPart.Name = "lblDPart";
			this.lblDPart.Size = new System.Drawing.Size(35, 13);
			this.lblDPart.TabIndex = 22;
			this.lblDPart.Text = "label9";
			// 
			// lblIPart2
			// 
			this.lblIPart2.AutoSize = true;
			this.lblIPart2.Location = new System.Drawing.Point(301, 94);
			this.lblIPart2.Name = "lblIPart2";
			this.lblIPart2.Size = new System.Drawing.Size(35, 13);
			this.lblIPart2.TabIndex = 23;
			this.lblIPart2.Text = "label9";
			// 
			// lblIntegral
			// 
			this.lblIntegral.AutoSize = true;
			this.lblIntegral.Location = new System.Drawing.Point(291, 381);
			this.lblIntegral.Name = "lblIntegral";
			this.lblIntegral.Size = new System.Drawing.Size(35, 13);
			this.lblIntegral.TabIndex = 24;
			this.lblIntegral.Text = "label9";
			// 
			// lblIntegral2
			// 
			this.lblIntegral2.AutoSize = true;
			this.lblIntegral2.Location = new System.Drawing.Point(294, 398);
			this.lblIntegral2.Name = "lblIntegral2";
			this.lblIntegral2.Size = new System.Drawing.Size(41, 13);
			this.lblIntegral2.TabIndex = 25;
			this.lblIntegral2.Text = "label10";
			// 
			// lblDiff
			// 
			this.lblDiff.AutoSize = true;
			this.lblDiff.Location = new System.Drawing.Point(349, 425);
			this.lblDiff.Name = "lblDiff";
			this.lblDiff.Size = new System.Drawing.Size(41, 13);
			this.lblDiff.TabIndex = 26;
			this.lblDiff.Text = "label11";
			// 
			// pictureBox2
			// 
			this.pictureBox2.Location = new System.Drawing.Point(450, 31);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(247, 400);
			this.pictureBox2.TabIndex = 27;
			this.pictureBox2.TabStop = false;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(209, 9);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(57, 13);
			this.label9.TabIndex = 28;
			this.label9.Text = "Sebesség:";
			// 
			// txtSebesseg
			// 
			this.txtSebesseg.Location = new System.Drawing.Point(273, 5);
			this.txtSebesseg.Name = "txtSebesseg";
			this.txtSebesseg.Size = new System.Drawing.Size(42, 20);
			this.txtSebesseg.TabIndex = 29;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(225, 31);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(57, 13);
			this.label10.TabIndex = 30;
			this.label10.Text = "Fedettség:";
			// 
			// lblFedettseg
			// 
			this.lblFedettseg.AutoSize = true;
			this.lblFedettseg.Location = new System.Drawing.Point(289, 32);
			this.lblFedettseg.Name = "lblFedettseg";
			this.lblFedettseg.Size = new System.Drawing.Size(41, 13);
			this.lblFedettseg.TabIndex = 31;
			this.lblFedettseg.Text = "label11";
			// 
			// LineMax
			// 
			this.LineMax.AutoSize = true;
			this.LineMax.BackColor = System.Drawing.Color.Transparent;
			this.LineMax.ForeColor = System.Drawing.Color.Red;
			this.LineMax.Location = new System.Drawing.Point(58, 64);
			this.LineMax.Name = "LineMax";
			this.LineMax.Size = new System.Drawing.Size(88, 13);
			this.LineMax.TabIndex = 32;
			this.LineMax.Text = "---------------------------";
			// 
			// LineMin
			// 
			this.LineMin.AutoSize = true;
			this.LineMin.BackColor = System.Drawing.Color.Transparent;
			this.LineMin.ForeColor = System.Drawing.Color.Lime;
			this.LineMin.Location = new System.Drawing.Point(58, 247);
			this.LineMin.Name = "LineMin";
			this.LineMin.Size = new System.Drawing.Size(88, 13);
			this.LineMin.TabIndex = 33;
			this.LineMin.Text = "---------------------------";
			// 
			// LineAvg
			// 
			this.LineAvg.AutoSize = true;
			this.LineAvg.BackColor = System.Drawing.Color.Transparent;
			this.LineAvg.ForeColor = System.Drawing.Color.Black;
			this.LineAvg.Location = new System.Drawing.Point(61, 156);
			this.LineAvg.Name = "LineAvg";
			this.LineAvg.Size = new System.Drawing.Size(88, 13);
			this.LineAvg.TabIndex = 34;
			this.LineAvg.Text = "---------------------------";
			// 
			// Line1
			// 
			this.Line1.AutoSize = true;
			this.Line1.BackColor = System.Drawing.Color.Black;
			this.Line1.ForeColor = System.Drawing.Color.Black;
			this.Line1.Location = new System.Drawing.Point(61, 194);
			this.Line1.Name = "Line1";
			this.Line1.Size = new System.Drawing.Size(139, 13);
			this.Line1.TabIndex = 35;
			this.Line1.Text = "                                            ";
			// 
			// ShapeGoal
			// 
			this.ShapeGoal.AutoSize = true;
			this.ShapeGoal.BackColor = System.Drawing.Color.Green;
			this.ShapeGoal.ForeColor = System.Drawing.Color.Green;
			this.ShapeGoal.Location = new System.Drawing.Point(31, 182);
			this.ShapeGoal.Name = "ShapeGoal";
			this.ShapeGoal.Size = new System.Drawing.Size(13, 13);
			this.ShapeGoal.TabIndex = 36;
			this.ShapeGoal.Text = "  ";
			// 
			// cmdClear
			// 
			this.cmdClear.Location = new System.Drawing.Point(450, 7);
			this.cmdClear.Name = "cmdClear";
			this.cmdClear.Size = new System.Drawing.Size(75, 23);
			this.cmdClear.TabIndex = 37;
			this.cmdClear.Text = "clear";
			this.cmdClear.UseVisualStyleBackColor = true;
			this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(721, 485);
			this.Controls.Add(this.cmdClear);
			this.Controls.Add(this.ShapeGoal);
			this.Controls.Add(this.Line1);
			this.Controls.Add(this.LineAvg);
			this.Controls.Add(this.LineMin);
			this.Controls.Add(this.LineMax);
			this.Controls.Add(this.lblFedettseg);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.txtSebesseg);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.lblDiff);
			this.Controls.Add(this.lblIntegral2);
			this.Controls.Add(this.lblIntegral);
			this.Controls.Add(this.lblIPart2);
			this.Controls.Add(this.lblDPart);
			this.Controls.Add(this.lblIPart);
			this.Controls.Add(this.lblPPart);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtD);
			this.Controls.Add(this.txtI);
			this.Controls.Add(this.txtP);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.SliderD);
			this.Controls.Add(this.SliderI);
			this.Controls.Add(this.SliderP);
			this.Controls.Add(this.Picture1);
			this.Controls.Add(this.txtWind);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.SliderWind);
			this.Controls.Add(this.lblHPos);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtGoalPos);
			this.Controls.Add(this.SliderGoal);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.Picture1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SliderGoal)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SliderWind)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SliderP)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SliderI)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SliderD)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Picture1;
        private System.Windows.Forms.TrackBar SliderGoal;
        private System.Windows.Forms.TextBox txtGoalPos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHPos;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar SliderWind;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWind;
        private System.Windows.Forms.TrackBar SliderP;
        private System.Windows.Forms.TrackBar SliderI;
        private System.Windows.Forms.TrackBar SliderD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.TextBox txtI;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblPPart;
        private System.Windows.Forms.Label lblIPart;
        private System.Windows.Forms.Label lblDPart;
        private System.Windows.Forms.Label lblIPart2;
        private System.Windows.Forms.Label lblIntegral;
        private System.Windows.Forms.Label lblIntegral2;
        private System.Windows.Forms.Label lblDiff;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSebesseg;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblFedettseg;
        private System.Windows.Forms.Label LineMax;
        private System.Windows.Forms.Label LineMin;
        private System.Windows.Forms.Label LineAvg;
        private System.Windows.Forms.Label Line1;
        private System.Windows.Forms.Label ShapeGoal;
		private System.Windows.Forms.Button cmdClear;
	}
}

