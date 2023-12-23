using System.Windows.Forms;

namespace BallGames.Common
{
    public class PointBall : MoveBall
    {
        public PointBall(Form form, int x, int y) : base(form)
        {
            this.centerX = x;
            this.centerY = y;
        }
    }
}