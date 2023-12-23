using System.Windows.Forms;

namespace BallGames.Common
{
    public class BilliardBall : MoveBall
    {
        public event EventHandler<HitEventArgs> OnHit;
        public BilliardBall(Form form) : base(form)
        {
        }

        protected override void Go()
        {
            base.Go();
            if (centerX <= LeftSide())
            {
                vx = -vx;
                OnHit.Invoke(this, new HitEventArgs(Side.Left));
            }
            if (centerX >= RightSide())
            {
                vx = -vx;
                OnHit.Invoke(this, new HitEventArgs(Side.Right));
            }
            if (centerY <= TopSide())
            {
                vy = -vy;
                OnHit.Invoke(this, new HitEventArgs(Side.Top));
            }
            if (centerY >= DownSide())
            {
                vy = -vy;
                OnHit.Invoke(this, new HitEventArgs(Side.Down));
            }
        }
    }
}
