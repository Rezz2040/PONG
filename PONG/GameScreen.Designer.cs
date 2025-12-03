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
            pause = new Label();
            exit = new Label();
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
            // pause
            // 
            pause.AutoSize = true;
            pause.BackColor = Color.Transparent;
            pause.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            pause.ForeColor = Color.White;
            pause.Location = new Point(337, 421);
            pause.Name = "pause";
            pause.Size = new Size(73, 20);
            pause.TabIndex = 3;
            pause.Text = "P - pause";
            // 
            // exit
            // 
            exit.AutoSize = true;
            exit.BackColor = Color.Transparent;
            exit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            exit.ForeColor = Color.White;
            exit.Location = new Point(416, 421);
            exit.Name = "exit";
            exit.Size = new Size(59, 20);
            exit.TabIndex = 4;
            exit.Text = "X - exit";
            // 
            // GameScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(800, 450);
            Controls.Add(exit);
            Controls.Add(pause);
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
            PerformLayout();
        }

        #endregion

        private PictureBox player;
        private PictureBox computer;
        private PictureBox ball;
        private System.Windows.Forms.Timer GameTimer;
        private Label pause;
        private Label exit;
    }
}
