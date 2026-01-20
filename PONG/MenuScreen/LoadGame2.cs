using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    public partial class MenuScreen
    {
        private void LoadGame2(object sender, EventArgs e)
        {
            GameScreen gameWindow = new GameScreen(true);
            gameWindow.Show();
        }
    }
}
