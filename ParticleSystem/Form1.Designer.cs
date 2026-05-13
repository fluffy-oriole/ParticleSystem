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
            ((System.ComponentModel.ISupportInitialize)picDisplay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbDirection).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbGraviton1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbGraviton2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbPaint1X).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbPaint1Y).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbPaint2X).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbPaint2Y).BeginInit();
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
            lbldirection.Location = new Point(523, 792);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 840);
            Controls.Add(tbPaint2Y);
            Controls.Add(tbPaint2X);
            Controls.Add(tbPaint1Y);
            Controls.Add(tbPaint1X);
            Controls.Add(tbGraviton2);
            Controls.Add(tbGraviton1);
            Controls.Add(lbldirection);
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
    }
}
