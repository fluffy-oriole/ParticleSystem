namespace ParticleSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            picDisplay = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            tbDirection = new TrackBar();
            lbldirection = new Label();
            tbGraviton1 = new TrackBar();
            tbGraviton2 = new TrackBar();
            tbPaint1X = new TrackBar();
            tbPaint1Y = new TrackBar();
            tbPaint2X = new TrackBar();
            tbPaint2Y = new TrackBar();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            tbNumberOfParticles = new TrackBar();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)picDisplay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbDirection).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbGraviton1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbGraviton2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbPaint1X).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbPaint1Y).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbPaint2X).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbPaint2Y).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbNumberOfParticles).BeginInit();
            SuspendLayout();
            // 
            // picDisplay
            // 
            picDisplay.Location = new Point(12, 12);
            picDisplay.Name = "picDisplay";
            picDisplay.Size = new Size(1156, 645);
            picDisplay.TabIndex = 0;
            picDisplay.TabStop = false;
            picDisplay.Click += picDisplay_Click;
            picDisplay.MouseMove += picDisplay_MouseMove;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 40;
            timer1.Tick += timer1_Tick;
            // 
            // tbDirection
            // 
            tbDirection.Location = new Point(12, 775);
            tbDirection.Maximum = 359;
            tbDirection.Name = "tbDirection";
            tbDirection.Size = new Size(505, 69);
            tbDirection.TabIndex = 1;
            tbDirection.Scroll += trackBar1_Scroll;
            // 
            // lbldirection
            // 
            lbldirection.AutoSize = true;
            lbldirection.Location = new Point(523, 789);
            lbldirection.Name = "lbldirection";
            lbldirection.Size = new Size(29, 25);
            lbldirection.TabIndex = 2;
            lbldirection.Text = "0°";
            // 
            // tbGraviton1
            // 
            tbGraviton1.Location = new Point(578, 775);
            tbGraviton1.Maximum = 100;
            tbGraviton1.Name = "tbGraviton1";
            tbGraviton1.Size = new Size(287, 69);
            tbGraviton1.TabIndex = 3;
            tbGraviton1.Value = 100;
            tbGraviton1.Scroll += tbGraviton_Scroll;
            // 
            // tbGraviton2
            // 
            tbGraviton2.Location = new Point(871, 775);
            tbGraviton2.Maximum = 100;
            tbGraviton2.Name = "tbGraviton2";
            tbGraviton2.Size = new Size(297, 69);
            tbGraviton2.TabIndex = 3;
            tbGraviton2.Value = 100;
            tbGraviton2.Scroll += tbGraviton2_Scroll;
            // 
            // tbPaint1X
            // 
            tbPaint1X.Location = new Point(12, 685);
            tbPaint1X.Maximum = 1106;
            tbPaint1X.Minimum = 50;
            tbPaint1X.Name = "tbPaint1X";
            tbPaint1X.Size = new Size(271, 69);
            tbPaint1X.TabIndex = 4;
            tbPaint1X.Value = 100;
            tbPaint1X.Scroll += tbPaint1X_Scroll;
            // 
            // tbPaint1Y
            // 
            tbPaint1Y.Location = new Point(289, 685);
            tbPaint1Y.Maximum = 595;
            tbPaint1Y.Minimum = 50;
            tbPaint1Y.Name = "tbPaint1Y";
            tbPaint1Y.Size = new Size(228, 69);
            tbPaint1Y.TabIndex = 4;
            tbPaint1Y.Value = 50;
            tbPaint1Y.Scroll += tbPaint1Y_Scroll;
            // 
            // tbPaint2X
            // 
            tbPaint2X.Location = new Point(578, 685);
            tbPaint2X.Maximum = 1106;
            tbPaint2X.Minimum = 50;
            tbPaint2X.Name = "tbPaint2X";
            tbPaint2X.Size = new Size(287, 69);
            tbPaint2X.TabIndex = 4;
            tbPaint2X.Value = 100;
            tbPaint2X.Scroll += tbPaint2X_Scroll;
            // 
            // tbPaint2Y
            // 
            tbPaint2Y.Location = new Point(871, 685);
            tbPaint2Y.Maximum = 595;
            tbPaint2Y.Minimum = 50;
            tbPaint2Y.Name = "tbPaint2Y";
            tbPaint2Y.Size = new Size(297, 69);
            tbPaint2Y.TabIndex = 4;
            tbPaint2Y.Value = 50;
            tbPaint2Y.Scroll += tbPaint2Y_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 660);
            label1.Name = "label1";
            label1.Size = new Size(251, 25);
            label1.TabIndex = 5;
            label1.Text = "Позиция зеленого PaintBox X";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(289, 660);
            label2.Name = "label2";
            label2.Size = new Size(250, 25);
            label2.TabIndex = 5;
            label2.Text = "Позиция зеленого PaintBox Y";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(578, 660);
            label3.Name = "label3";
            label3.Size = new Size(232, 25);
            label3.TabIndex = 5;
            label3.Text = "Позиция синего PaintBox X";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(855, 660);
            label4.Name = "label4";
            label4.Size = new Size(231, 25);
            label4.TabIndex = 5;
            label4.Text = "Позиция синего PaintBox Y";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(578, 757);
            label5.Name = "label5";
            label5.Size = new Size(205, 25);
            label5.TabIndex = 5;
            label5.Text = "Сила левой GravityPoint";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(885, 757);
            label6.Name = "label6";
            label6.Size = new Size(217, 25);
            label6.TabIndex = 5;
            label6.Text = "Сила правой GravityPoint";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 757);
            label7.Name = "label7";
            label7.Size = new Size(351, 25);
            label7.TabIndex = 5;
            label7.Text = "Угол начального вектора скорости точек";
            // 
            // tbNumberOfParticles
            // 
            tbNumberOfParticles.Location = new Point(1196, 62);
            tbNumberOfParticles.Maximum = 300;
            tbNumberOfParticles.Name = "tbNumberOfParticles";
            tbNumberOfParticles.Orientation = Orientation.Vertical;
            tbNumberOfParticles.Size = new Size(69, 595);
            tbNumberOfParticles.TabIndex = 1;
            tbNumberOfParticles.Value = 300;
            tbNumberOfParticles.Scroll += tbNumberOfParticles_scroll;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1174, 9);
            label8.Name = "label8";
            label8.Size = new Size(107, 50);
            label8.TabIndex = 5;
            label8.Text = "Количество\r\nчастиц";
            label8.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1306, 921);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(tbPaint2Y);
            Controls.Add(tbPaint2X);
            Controls.Add(tbPaint1Y);
            Controls.Add(tbPaint1X);
            Controls.Add(tbGraviton2);
            Controls.Add(tbGraviton1);
            Controls.Add(lbldirection);
            Controls.Add(tbNumberOfParticles);
            Controls.Add(tbDirection);
            Controls.Add(picDisplay);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picDisplay).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbDirection).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbGraviton1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbGraviton2).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbPaint1X).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbPaint1Y).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbPaint2X).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbPaint2Y).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbNumberOfParticles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picDisplay;
        private System.Windows.Forms.Timer timer1;
        private TrackBar tbDirection;
        private Label lbldirection;
        private TrackBar tbGraviton1;
        private TrackBar tbGraviton2;
        private TrackBar tbPaint1X;
        private TrackBar tbPaint1Y;
        private TrackBar tbPaint2X;
        private TrackBar tbPaint2Y;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TrackBar tbNumberOfParticles;
        private Label label8;
    }
}
