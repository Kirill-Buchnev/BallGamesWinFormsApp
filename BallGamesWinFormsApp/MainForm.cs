using BallGames.Common;
using System;

namespace BallGamesWinFormsApp
{
    public partial class MainForm : Form
    {
        List<Ball> balls = new List<Ball>();
        Random random = new Random();
        int countBalls;
        bool ballsCreated;
        int ballsNumber;
        public MainForm()
        {
            InitializeComponent();
            ballsNumber = random.Next(5, 15);
            moveTimer.Start();
        }

        private void GameOver()
        {
            balls.ForEach(ball => ball.Stop());
            moveTimer.Stop();
            MessageBox.Show($"You caught {countBalls} balls!");
            Application.Restart();
        }

        private void createBallsButton_Click(object sender, EventArgs e)
        {
            if (ballsCreated) return;
            for (int i = 0; i < ballsNumber; i++)
            {
                var ballType = random.Next(0, 1);
                if (ballType == 0)
                {
                    var moveBall = new MoveBall(this);
                    balls.Add(moveBall);
                    moveBall.Start();
                }
                else
                {
                    var ball = new RandomSizeAndPointBall(this);
                    balls.Add(ball);
                    ball.Start();
                }
            }
            ballsCreated = true;
        }

        private void stopBallsButton_Click(object sender, EventArgs e)
        {
            if (!ballsCreated) return;
            balls.ToList().ForEach(ball =>
            {
                Catch(ball);
            });
            GameOver();
        }

        private void Catch(Ball ball)
        {
            if (ball.OnForm())
            {
                ball.Stop();
                countBalls++;
                balls.Remove(ball);
            }
        }

        private void moveTimer_Tick(object sender, EventArgs e)
        {
            if (!ballsCreated) return;
            if (!balls.ToList().Any(ball => ball.OnForm())) GameOver();
        }
    }
}