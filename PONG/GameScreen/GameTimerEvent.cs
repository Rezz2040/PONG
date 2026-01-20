using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    public partial class GameScreen
    {
        private void GameTimerEvent(object sender, EventArgs e)
        {
            ball.Top -= ballYspeed;
            ball.Left -= ballXspeed;

            this.Text = "Player Score: " + playerScore + " -- Computer Score: " + computerScore;

            if(teleportMode == true)
            {
                if (ball.Top < 0)
                {
                    ball.Top = this.ClientSize.Height - ball.Height;
                }
                else if(ball.Bottom > this.ClientSize.Height)
                {
                    ball.Top = 0;
                }
            }
            else
            {
                if (ball.Top < 0 || ball.Bottom > this.ClientSize.Height)
                {
                    ballYspeed = -ballYspeed;
                }
            }



            if (ball.Left < -2)
            {
                ball.Left = 300;
                ballXspeed = -ballXspeed;
                computerScore++;
                scoreSound.Play();

                RandomizeGameMode();
            }

            if (ball.Right > this.ClientSize.Width + 2)
            {
                ball.Left = 300;
                ballXspeed = -ballXspeed;
                playerScore++;
                scoreSound.Play();

                RandomizeGameMode();
            }

            if(isPvP == true)
            {
                if(P2GoUp == true && computer.Top > 0)
                {
                    computer.Top -= playerSpeed;
                }

                if(P2GoDown == true && computer.Bottom < this.ClientSize.Height)
                {
                    computer.Top += playerSpeed;
                }
            }
            else
            {
                if (computer.Top <= 1)
                {
                    computer.Top = 0;
                }
                else if (computer.Bottom >= this.ClientSize.Height)
                {
                    computer.Top = this.ClientSize.Height - computer.Height;
                }

                if (ball.Top < computer.Top + (computer.Height / 2) && ball.Left > 300)
                {
                    computer.Top -= speed;
                }

                if (ball.Top > computer.Top + (computer.Height / 2) && ball.Left > 300)
                {
                    computer.Top += speed;
                }


                computerSpeedChange -= 1;

                if (computerSpeedChange < 0)
                {
                    speed = computerSpeed[rand.Next(computerSpeed.Length)];
                    computerSpeedChange = 50;
                }

            }

            if (P1GoDown && player.Top + player.Height < this.ClientSize.Height)
            {
                player.Top += playerSpeed;
            }
            if (P1GoUp && player.Top > 0)
            {
                player.Top -= playerSpeed;
            }

            CheckCollision(ball, player, player.Right + 5);
            CheckCollision(ball, computer, computer.Left - 35);

            if (computerScore > 5)
            {
                if(isPvP == true)
                {
                    winSound.Play();
                    GameOver("Player2 wins!");
                }
                else
                {
                    loseSound.Play();
                    GameOver("You lose!");
                }
            }
            else if (playerScore > 5)
            {
                if (isPvP == true)
                {
                    winSound.Play();
                    GameOver("Player1 wins!");
                }
                else
                {
                    winSound.Play();
                    GameOver("You win!");
                }
                
            }
        }
    }
}
