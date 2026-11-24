using System;
using System.Drawing;
using AntColonyFlyweight.Flyweights;

namespace AntColonyFlyweight.Models
{
    public sealed class Ant
    {
        private static readonly Random Random = new Random();

        public AntFlyweight Flyweight { get; private set; }
        public float X { get; set; }
        public float Y { get; set; }
        public float Speed { get; set; }
        public float DirectionX { get; set; }
        public float DirectionY { get; set; }

        public Ant(AntFlyweight flyweight, float x, float y)
        {
            Flyweight = flyweight;
            X = x;
            Y = y;

            Speed = flyweight.BaseSpeed *
                (0.8f + (float)Random.NextDouble() * 0.4f);

            double angle = Random.NextDouble() * Math.PI * 2;
            DirectionX = (float)Math.Cos(angle);
            DirectionY = (float)Math.Sin(angle);
        }

        public void Move(int fieldWidth, int fieldHeight)
        {
            float antWidth = Flyweight.Size * 1.7f;
            float antHeight = Flyweight.Size * 1.2f;

            X += DirectionX * Speed;
            Y += DirectionY * Speed;

            if (X < 0 || X + antWidth > fieldWidth)
            {
                DirectionX *= -1;
                X = Math.Max(0, Math.Min(X, Math.Max(0, fieldWidth - antWidth)));
            }

            if (Y < 0 || Y + antHeight > fieldHeight)
            {
                DirectionY *= -1;
                Y = Math.Max(0, Math.Min(Y, Math.Max(0, fieldHeight - antHeight)));
            }
        }

        public void Draw(Graphics graphics)
        {
            Flyweight.Draw(graphics, X, Y, DirectionX >= 0);
        }
    }
}
