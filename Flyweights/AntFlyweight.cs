using System.Drawing;

namespace AntColonyFlyweight.Flyweights
{
    public sealed class AntFlyweight
    {
        public string Type { get; private set; }
        public Color Color { get; private set; }
        public int Size { get; private set; }
        public float BaseSpeed { get; private set; }

        public AntFlyweight(string type, Color color, int size, float baseSpeed)
        {
            Type = type;
            Color = color;
            Size = size;
            BaseSpeed = baseSpeed;
        }

        public void Draw(Graphics graphics, float x, float y, bool movingRight)
        {
            float width = Size * 1.7f;
            float height = Size * 1.2f;

            System.Drawing.Drawing2D.GraphicsState state = graphics.Save();
            if (!movingRight)
            {
                graphics.TranslateTransform(x * 2 + width, 0);
                graphics.ScaleTransform(-1, 1);
                x = x;
            }

            using (SolidBrush brush = new SolidBrush(Color))
            using (Pen pen = new Pen(Color, 1.8f))
            {
                graphics.FillEllipse(brush, x, y + Size / 3f, Size, Size / 2f);
                graphics.FillEllipse(brush, x + Size * 0.65f, y + Size / 3f,
                    Size * 0.5f, Size / 2f);
                graphics.FillEllipse(brush, x + Size * 1.05f, y + Size / 4f,
                    Size * 0.5f, Size / 2f);

                graphics.DrawLine(pen, x + Size * 1.35f, y + Size / 4f,
                    x + Size * 1.45f, y);
                graphics.DrawLine(pen, x + Size * 1.35f, y + Size / 4f,
                    x + Size * 1.6f, y + Size / 8f);

                graphics.DrawLine(pen, x + Size * 0.7f, y + Size * 0.6f,
                    x + Size * 0.5f, y + Size);
                graphics.DrawLine(pen, x + Size * 0.9f, y + Size * 0.6f,
                    x + Size * 0.9f, y + Size);
                graphics.DrawLine(pen, x + Size * 1.1f, y + Size * 0.6f,
                    x + Size * 1.3f, y + Size);
            }

            graphics.Restore(state);
        }
    }
}
