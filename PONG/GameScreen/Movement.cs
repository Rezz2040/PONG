using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    public partial class GameScreen
    {
        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S)
            {
                P1GoDown = true;
            }
            if (e.KeyCode == Keys.W)
            {
                P1GoUp = true;
            }

            if(isPvP == true)
            {
                if(e.KeyCode == Keys.Down)
                {
                    P2GoDown = true;
                }
                if(e.KeyCode == Keys.Up)
                {
                    P2GoUp = true;
                }
            }

            //pause button
            if (e.KeyCode == Keys.P)
            {
                GameTimer.Stop();
                MessageBox.Show("Game paused");
                GameTimer.Start();
            }

            //exit button
            if (e.KeyCode == Keys.X)
            {
                this.Close();
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S)
            {
                P1GoDown = false;
            }
            if (e.KeyCode == Keys.W)
            {
                P1GoUp = false;
            }

            if(isPvP == true)
            {
                if(e.KeyCode == Keys.Down)
                {
                    P2GoDown = false;
                }
                if(e.KeyCode == Keys.Up)
                {
                    P2GoUp= false;
                }
            }
        }
    }

}