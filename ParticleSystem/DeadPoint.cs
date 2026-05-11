using System;
using System.Collections.Generic;
using System.Text;

namespace ParticleSystem
{
    internal class DeadPoint : IImpactPoint
    {
        public int killedPointsCount = 0;
        public int Wide = 100;
        public override void ImpactParticle(Particle particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;
            double r = Math.Sqrt(gX * gX + gY * gY);
            if (particle is ParticleColorful && r + particle.Radius < Wide / 2)
            {
                ParticleColorful colorfulParticle = (ParticleColorful)particle;
                particle.Life = 0;
                killedPointsCount += 1;
            }
        }
        
        public override void Render(Graphics g)
        {

            g.DrawEllipse(
                    new Pen(Color.Red),
                    X - 50,
                    Y - 50,
                    100,
                    100
                );
            var stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;

            var text = killedPointsCount.ToString();
            var font = new Font("Verdana", 10);

            var size = g.MeasureString(text, font);

            g.FillRectangle(
                new SolidBrush(Color.Red),
                X - size.Width / 2,
                Y - size.Height / 2,
                size.Width,
                size.Height
            );

            g.DrawString(
                text,
                font,
                new SolidBrush(Color.White),
                X,
                Y,
                stringFormat
            );
        }
        
    }
}
