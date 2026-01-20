using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    public partial class GameScreen
    {
        private void RandomizeGameMode()
        {
            int chance = rand.Next(1, 11);

            if(chance <= 3)
            {
                teleportMode = true;

                this.BackColor = Color.FromArgb(20, 0, 40);
            }
            else
            {
                teleportMode = false;

                this.BackColor = Color.FromArgb(0, 0, 22);
            }
        }
    }
}
