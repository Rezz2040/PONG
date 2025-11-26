namespace Pong
{
    partial class GameScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameScreen));
            player = new PictureBox();
            computer = new PictureBox();
            ball = new PictureBox();
            GameTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)computer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ball).BeginInit();
            SuspendLayout();
            // 
            // player
            // 
            player.Image = (Image)resources.GetObject("player.Image");
            player.Location = new Point(12, 138);
            player.Name = "player";
            player.Size = new Size(30, 120);
            player.SizeMode = PictureBoxSizeMode.StretchImage;
            player.TabIndex = 0;
            player.TabStop = false;
            // 
            // computer
            // 
            computer.Image = (Image)resources.GetObject("computer.Image");
            computer.Location = new Point(758, 138);
            computer.Name = "computer";
            computer.Size = new Size(30, 120);
            computer.SizeMode = PictureBoxSizeMode.StretchImage;
            computer.TabIndex = 1;
            computer.TabStop = false;
            // 
            // ball
            // 
            ball.Image = (Image)resources.GetObject("ball.Image");
            ball.Location = new Point(385, 184);
            ball.Name = "ball";
            ball.Size = new Size(30, 30);
            ball.SizeMode = PictureBoxSizeMode.StretchImage;
            ball.TabIndex = 2;
            ball.TabStop = false;
            // 
            // GameTimer
            // 
            GameTimer.Enabled = true;
            GameTimer.Interval = 20;
            GameTimer.Tick += GameTimerEvent;
            // 
            // GameScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(800, 450);
            Controls.Add(ball);
            Controls.Add(computer);
            Controls.Add(player);
            DoubleBuffered = true;
            Name = "GameScreen";
            Text = "Player: 0 -- Computer: 0";
            KeyDown += KeyIsDown;
            KeyUp += KeyIsUp;
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)computer).EndInit();
            ((System.ComponentModel.ISupportInitialize)ball).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox player;
        private PictureBox computer;
        private PictureBox ball;
        private System.Windows.Forms.Timer GameTimer;
    }
}
