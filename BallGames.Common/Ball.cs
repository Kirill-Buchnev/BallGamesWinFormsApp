using System.Drawing;
using System.Windows.Forms;

namespace BallGames.Common
{
    public class Ball
    {
        private static Random random = new Random();
        private System.Windows.Forms.Timer timer;
        private Form form;
        protected int vx = 10;
        protected int vy = 10;
        protected int centerX = 10;
        protected int centerY = 10;
        protected int radius = random.Next(15, 50);

        public Ball(Form form)
        {
            this.form = form;
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 10;
            timer.Tick += Timer_Tick;
        }

        public void Show()
        {
            var brush = Brushes.Aqua;
            Draw(brush);
        }

        public void Move()
        {
            Clear();
            Go();
            Show();
        }

        public int LeftSide()
        {
            return radius;
        }

        public int RightSide()
        {
            return form.ClientSize.Width - radius;
        }

        public int TopSide()
        {
            return radius;
        }

        public int DownSide()
        {
            return form.ClientSize.Height - radius;
        }

        public bool OnForm()
        {
            return centerX >= LeftSide() && centerX <= RightSide() &&
                centerY >= TopSide() && centerY <= DownSide();
        }

        public bool ClickInside(MouseEventArgs e)
        {
            return Math.Pow((e.X - centerX), 2) + Math.Pow((e.Y - centerY), 2) <= Math.Pow(radius, 2);
        }

        protected virtual void Go()
        {
            centerX += vx;
            centerY += vy;
        }

        private void Clear()
        {
            var brush = new SolidBrush(form.BackColor);
            Draw(brush);
        }

        private void Draw(Brush brush)
        {
            var graphics = form.CreateGraphics();
            var rectangle = new Rectangle(centerX - radius, centerY - radius, 2 * radius, 2 * radius);
            graphics.FillEllipse(brush, rectangle);
        }

        public void Timer_Tick(object sender, EventArgs e)
        {
            Move();
        }

        public void Start()
        {
            timer.Start();
        }
        public void Stop()
        {
            timer.Stop();
        }
    }
}