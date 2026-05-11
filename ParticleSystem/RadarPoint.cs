using System;
using System.Collections.Generic;
using System.Text;

namespace ParticleSystem
{
    internal class RadarPoint : IImpactPoint
    {
        public int Wide = 100;
        public List<Particle> insideParticles = new List<Particle>();
        public override void ImpactParticle(Particle particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;
            double r = Math.Sqrt(gX * gX + gY * gY);
            if (particle is ParticleColorful && r + particle.Radius < Wide / 2)
            {
                if (!insideParticles.Contains(particle))
                {
                    insideParticles.Add(particle);
                    if (particle is ParticleColorful)
                    {
                        ParticleColorful particleWithColor = (ParticleColorful)particle;
                        particleWithColor.FromColor = Color.Lime;
                        particleWithColor.ToColor = Color.Lime;
                    }
                    else
                    {
                        particle.mainColor = Color.Green;
                    }
                }                
            }
            else
            {
                if (insideParticles.Contains(particle))
                {
                    insideParticles.Remove(particle);
                    if (particle is ParticleColorful)
                    {
                        ParticleColorful particleWithColor = (ParticleColorful)particle;
                        particleWithColor.FromColor = Color.Gold;
                        particleWithColor.ToColor = Color.FromArgb(0, Color.Red);
                    }
                    else
                    {
                        particle.mainColor = Color.Red;
                    }
                }
            }
        }
        public override void Render(Graphics g)
        {
            g.DrawEllipse(
                    new Pen(Color.Lime),
                    X - 100 / 2,
                    Y - 100 / 2,
                    100,
                    100
                );
            var stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;

            var text = insideParticles.Count.ToString();
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
