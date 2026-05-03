using System.Diagnostics.Metrics;
using System.Reflection;

namespace ParticleSystem
{
    public partial class Form1 : Form
    {
        Emitter emitter;
        GravityPoint point1;
        GravityPoint point2;
        PaintPoint PaintPoint1;
        PaintPoint PaintPoint2;

        public Form1()
        {
            InitializeComponent();
            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);

            this.emitter = new Emitter
            {
                Direction = 0,
                Spreading = 10,
                SpeedMin = 10,
                SpeedMax = 10,
                ColorFrom = Color.Gold,
                ColorTo = Color.FromArgb(0, Color.Red),
                ParticlesPerTick = 10,
                X = picDisplay.Width / 2,
                Y = picDisplay.Height / 2,
            };

            point1 = new GravityPoint
            {
                X = picDisplay.Width / 2 + 100,
                Y = picDisplay.Height / 2,
            };

            point2 = new GravityPoint
            {
                X = picDisplay.Width / 2 - 100,
                Y = picDisplay.Height / 2,
            };

            PaintPoint1 = new PaintPoint
            {
                NewFromColor = Color.Green,
                NewToColor = Color.White,
                X = picDisplay.Width / 2 - 200,
                Y = picDisplay.Height / 2 + 100,
            };

            PaintPoint2 = new PaintPoint
            {
                NewFromColor = Color.Blue,
                NewToColor = Color.White,
                X = picDisplay.Width / 2 + 200,
                Y = picDisplay.Height / 2 + 100,
            };

            emitter.impactPoints.Add(point1);
            emitter.impactPoints.Add(point2);
            emitter.impactPoints.Add(PaintPoint1);
            emitter.impactPoints.Add(PaintPoint2);
        }

        int counter = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            using (var g = Graphics.FromImage(picDisplay.Image))
            {
                g.Clear(Color.White);
                emitter.UpdateState();
                emitter.Render(g);
            }
            picDisplay.Invalidate();
        }

        private void picDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            emitter.MousePositionX = e.X;
            emitter.MousePositionY = e.Y;

            point1.X = e.X;
            point1.Y = e.Y;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            emitter.Direction = tbDirection.Value;
            lbldirection.Text = $"{tbDirection.Value}°";
        }

        private void tbGraviton_Scroll(object sender, EventArgs e)
        {
            point1.Power = tbGraviton1.Value;
        }

        private void tbGraviton2_Scroll(object sender, EventArgs e)
        {
            point2.Power = tbGraviton2.Value;
        }

        private void tbPaint1X_Scroll(object sender, EventArgs e)
        {
            PaintPoint1.X = tbPaint1X.Value;
        }

        private void tbPaint1Y_Scroll(object sender, EventArgs e)
        {
            PaintPoint1.Y = tbPaint1Y.Value;
        }

        private void tbPaint2X_Scroll(object sender, EventArgs e)
        {
            PaintPoint2.X = tbPaint2X.Value;
        }

        private void tbPaint2Y_Scroll(object sender, EventArgs e)
        {
            PaintPoint2.Y = tbPaint2Y.Value;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
