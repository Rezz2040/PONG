namespace Pong
{
    partial class MenuScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PONG = new Label();
            Play = new Button();
            Exit = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // PONG
            // 
            PONG.AutoSize = true;
            PONG.Font = new Font("Consolas", 72F, FontStyle.Bold, GraphicsUnit.Point, 238);
            PONG.ForeColor = Color.Magenta;
            PONG.Location = new Point(78, 48);
            PONG.Name = "PONG";
            PONG.Size = new Size(323, 140);
            PONG.TabIndex = 0;
            PONG.Text = "PONG";
            // 
            // Play
            // 
            Play.BackColor = Color.FromArgb(20, 20, 20);
            Play.FlatAppearance.BorderColor = Color.Cyan;
            Play.FlatAppearance.BorderSize = 2;
            Play.FlatAppearance.MouseDownBackColor = Color.Black;
            Play.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 64, 64);
            Play.FlatStyle = FlatStyle.Flat;
            Play.Font = new Font("Consolas", 13.8F);
            Play.ForeColor = Color.Cyan;
            Play.Location = new Point(165, 205);
            Play.Name = "Play";
            Play.Size = new Size(142, 42);
            Play.TabIndex = 1;
            Play.Text = "Play";
            Play.UseVisualStyleBackColor = false;
            Play.Click += LoadGame1;
            // 
            // Exit
            // 
            Exit.BackColor = Color.FromArgb(20, 20, 20);
            Exit.FlatAppearance.BorderColor = Color.Cyan;
            Exit.FlatAppearance.BorderSize = 2;
            Exit.FlatAppearance.MouseDownBackColor = Color.Black;
            Exit.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 64, 64);
            Exit.FlatStyle = FlatStyle.Flat;
            Exit.Font = new Font("Consolas", 13.8F);
            Exit.ForeColor = Color.Cyan;
            Exit.Location = new Point(165, 315);
            Exit.Name = "Exit";
            Exit.Size = new Size(142, 42);
            Exit.TabIndex = 2;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = false;
            Exit.Click += ExitGame;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(20, 20, 20);
            button1.FlatAppearance.BorderColor = Color.Cyan;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatAppearance.MouseDownBackColor = Color.Black;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 64, 64);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Consolas", 13.8F);
            button1.ForeColor = Color.Cyan;
            button1.Location = new Point(165, 259);
            button1.Name = "button1";
            button1.Size = new Size(142, 42);
            button1.TabIndex = 3;
            button1.Text = "2 Players";
            button1.UseVisualStyleBackColor = false;
            button1.Click += LoadGame2;
            // 
            // MenuScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 22);
            ClientSize = new Size(479, 450);
            Controls.Add(button1);
            Controls.Add(Exit);
            Controls.Add(Play);
            Controls.Add(PONG);
            Name = "MenuScreen";
            Text = "MenuScreen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PONG;
        private Button Play;
        private Button Exit;
        private Button button1;
    }
}