using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using AntColonyFlyweight.Flyweights;
using AntColonyFlyweight.Models;

namespace AntColonyFlyweight
{
    public partial class MainForm : Form
    {
        private readonly AntFactory factory = new AntFactory();
        private readonly List<Ant> ants = new List<Ant>();
        private readonly Random random = new Random();

        public MainForm()
        {
            InitializeComponent();

            btnAddWorker.Click += (s, e) => AddAnt("Робоча");
            btnAddSoldier.Click += (s, e) => AddAnt("Солдат");
            btnAddScout.Click += (s, e) => AddAnt("Розвідник");
            btnStart.Click += BtnStart_Click;
            btnClear.Click += BtnClear_Click;

            pnlField.Paint += PnlField_Paint;
            pnlField.Resize += (s, e) => pnlField.Invalidate();
            timer1.Tick += Timer1_Tick;

            UpdateStatistics();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            typeof(Panel).InvokeMember(
                "DoubleBuffered",
                System.Reflection.BindingFlags.NonPublic |
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.SetProperty,
                null,
                pnlField,
                new object[] { true }
            );
        }

        private void AddAnt(string type)
        {
            int maxX = Math.Max(1, pnlField.ClientSize.Width - 35);
            int maxY = Math.Max(1, pnlField.ClientSize.Height - 30);

            Ant ant = new Ant(
                factory.GetAnt(type),
                random.Next(0, maxX),
                random.Next(0, maxY));

            ants.Add(ant);
            UpdateStatistics();
            pnlField.Invalidate();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
            btnStart.Text = timer1.Enabled ? "Пауза" : "Почати рух";
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            btnStart.Text = "Почати рух";
            ants.Clear();
            UpdateStatistics();
            pnlField.Invalidate();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            foreach (Ant ant in ants)
            {
                ant.Move(
                    pnlField.ClientSize.Width,
                    pnlField.ClientSize.Height
                );
            }

            pnlField.Invalidate();
        }

        private void PnlField_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode =
            System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            e.Graphics.Clear(Color.White);

            using (Pen gridPen = new Pen(Color.FromArgb(242, 245, 249)))
            {
                for (int x = 20; x < pnlField.Width; x += 30)
                    for (int y = 20; y < pnlField.Height; y += 30)
                        e.Graphics.DrawEllipse(gridPen, x, y, 1, 1);
            }

            foreach (Ant ant in ants)
                ant.Draw(e.Graphics);
        }

        private void UpdateStatistics()
        {
            lblTotal.Text = "Мурашок: " + ants.Count;
            lblTypes.Text = "Спільних типів: " + factory.GetCreatedTypesCount();
        }
    }
}
