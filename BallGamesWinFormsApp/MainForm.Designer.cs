namespace BallGamesWinFormsApp
{
    partial class MainForm
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
            createBallsButton = new Button();
            stopBallsButton = new Button();
            moveTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // createBallsButton
            // 
            createBallsButton.Location = new Point(921, 12);
            createBallsButton.Name = "createBallsButton";
            createBallsButton.Size = new Size(118, 34);
            createBallsButton.TabIndex = 2;
            createBallsButton.Text = "Создать";
            createBallsButton.UseVisualStyleBackColor = true;
            createBallsButton.Click += createBallsButton_Click;
            // 
            // stopBallsButton
            // 
            stopBallsButton.Location = new Point(921, 62);
            stopBallsButton.Name = "stopBallsButton";
            stopBallsButton.Size = new Size(118, 34);
            stopBallsButton.TabIndex = 3;
            stopBallsButton.Text = "Остановить";
            stopBallsButton.UseVisualStyleBackColor = true;
            stopBallsButton.Click += stopBallsButton_Click;
            // 
            // moveTimer
            // 
            moveTimer.Tick += moveTimer_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(1074, 940);
            Controls.Add(stopBallsButton);
            Controls.Add(createBallsButton);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Мячики";
            ResumeLayout(false);
        }

        #endregion
        private Button createBallsButton;
        private Button stopBallsButton;
        private System.Windows.Forms.Timer moveTimer;
    }
}