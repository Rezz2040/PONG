using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    public partial class GameScreen
    {
        private void GameOver(string message)
        {
            GameTimer.Stop();
            MessageBox.Show(message);
            computerScore = 0;
            playerScore = 0;
            ballXspeed = ballYspeed = 4;
            computerSpeedChange = 50;
            this.Close();
        }
    }
}