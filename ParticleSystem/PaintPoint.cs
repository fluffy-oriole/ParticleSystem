using System;
using System.Collections.Generic;
using System.Text;

namespace ParticleSystem
{
    internal class PaintPoint : IImpactPoint
    {
        public Color NewFromColor = Color.Green;
        public Color NewToColor = Color.White;
        public int Wide = 100;

        public override void ImpactParticle(Particle particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;
            double r = Math.Sqrt(gX * gX + gY * gY);
            if (particle is ParticleColorful && r + particle.Radius < Wide / 2)
            {
                ParticleColorful colorfulParticle = (ParticleColorful)particle;
                colorfulParticle.FromColor = NewFromColor;
                colorfulParticle.ToColor = NewToColor;
            }
        }

        public override void Render(Graphics g)
        {
            g.DrawEllipse(
                    new Pen(NewFromColor),
                    X - Wide / 2,
                    Y - Wide/ 2,
                    Wide,
                    Wide
                );
        }
    }
}
