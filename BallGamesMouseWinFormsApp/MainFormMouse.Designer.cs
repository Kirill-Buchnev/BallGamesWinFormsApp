namespace BallGamesMouseWinFormsApp
{
    partial class MainFormMouse
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            startBallsButton = new Button();
            scoreLabel = new Label();
            moveTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // startBallsButton
            // 
            startBallsButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            startBallsButton.ForeColor = SystemColors.Highlight;
            startBallsButton.Location = new Point(433, 33);
            startBallsButton.Name = "startBallsButton";
            startBallsButton.Size = new Size(280, 89);
            startBallsButton.TabIndex = 2;
            startBallsButton.Text = "Старт!";
            startBallsButton.UseVisualStyleBackColor = true;
            startBallsButton.Click += startBallsButton_Click;
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            scoreLabel.Location = new Point(434, 874);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(306, 38);
            scoreLabel.TabIndex = 3;
            scoreLabel.Text = "Поймано мячиков: 0";
            scoreLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // moveTimer
            // 
            moveTimer.Tick += moveTimer_Tick;
            // 
            // MainFormMouse
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(1078, 944);
            Controls.Add(scoreLabel);
            Controls.Add(startBallsButton);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "MainFormMouse";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Мячики";
            MouseDown += MainFormMouse_MouseDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button startBallsButton;
        private Label scoreLabel;
        private System.Windows.Forms.Timer moveTimer;
    }
}