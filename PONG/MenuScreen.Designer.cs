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
            SuspendLayout();
            // 
            // PONG
            // 
            PONG.AutoSize = true;
            PONG.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 238);
            PONG.Location = new Point(102, 78);
            PONG.Name = "PONG";
            PONG.Size = new Size(275, 106);
            PONG.TabIndex = 0;
            PONG.Text = "PONG";
            // 
            // Play
            // 
            Play.Location = new Point(191, 206);
            Play.Name = "Play";
            Play.Size = new Size(94, 29);
            Play.TabIndex = 1;
            Play.Text = "Play";
            Play.UseVisualStyleBackColor = true;
            Play.Click += LoadGame;
            // 
            // Exit
            // 
            Exit.Location = new Point(191, 260);
            Exit.Name = "Exit";
            Exit.Size = new Size(94, 29);
            Exit.TabIndex = 2;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += ExitGame;
            // 
            // MenuScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(479, 450);
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
    }
}