using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    public partial class MenuScreen
    {
        private void LoadGame1(object sender, EventArgs e)
        {
            GameScreen gameWindow = new GameScreen(false);
            gameWindow.Show();
        }
    }
}
