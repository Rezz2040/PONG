using System.IO;
using System.Media;

namespace Pong
{
    public partial class GameScreen : Form
    {

        int ballXspeed = 4;
        int ballYspeed = 4;
        int speed = 2;
        Random rand = new Random();
        bool P1GoDown, P1GoUp, P2GoDown, P2GoUp;
        int computerSpeedChange = 50;
        int playerScore = 0;
        int computerScore = 0;
        int playerSpeed = 8;
        int[] computerSpeed = { 5, 6, 8, 9 };
        int[] ballSpeed = { 10, 9, 8, 11, 12 };
        private bool isPvP;
        SoundPlayer hitSound;
        SoundPlayer scoreSound;
        SoundPlayer winSound;
        SoundPlayer loseSound;
        bool teleportMode = false;

        public GameScreen(bool pvpMode)
        {
            InitializeComponent();
            isPvP = pvpMode;


            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, ball.Width, ball.Height);

            ball.Region = new Region(path);


            string basePath = AppDomain.CurrentDomain.BaseDirectory;

            string hitPath = Path.Combine(basePath, "Assets", "hit.wav");
            string scorePath = Path.Combine(basePath, "Assets", "score.wav");
            string winPath = Path.Combine(basePath, "Assets", "win.wav");
            string losePath = Path.Combine(basePath, "Assets", "lose.wav");

            hitSound = new SoundPlayer(hitPath);
            scoreSound = new SoundPlayer(scorePath);
            winSound = new SoundPlayer(winPath);
            loseSound = new SoundPlayer(losePath);
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.White, 2);
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;

            int centerX = this.ClientSize.Width / 2;
            e.Graphics.DrawLine(pen, centerX, 0, centerX, this.ClientSize.Height);

            pen.Dispose();
        }
    }
}
