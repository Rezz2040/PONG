namespace Pong
{
    public partial class GameScreen : Form
    {
        int ballXspeed = 4;
        int ballYspeed = 4;
        int speed = 2;
        Random rand = new Random();
        bool goDown, goUp;
        int computerSpeedChange = 50;
        int playerScore = 0;
        int computerScore = 0;
        int playerSpeed = 8;
        int[] computerSpeed = { 5, 6, 8, 9 };
        int[] ballSpeed = { 10, 9, 8, 11, 12 };


        public GameScreen()
        {
            InitializeComponent();
        }
    }
}
