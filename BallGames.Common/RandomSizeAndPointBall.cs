using System.Windows.Forms;

namespace BallGames.Common
{
    public class RandomSizeAndPointBall : RandomPointBall
    {
        public RandomSizeAndPointBall(Form form) : base(form)
        {
            radius = random.Next(30, 70) / 2;
        }
    }
}