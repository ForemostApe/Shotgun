using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Shotgun.Classes
{
    public class Player
    {
        public int PlayerChoice { get; set; }
        public int PlayerAmountOfBullets { get; set; }
    
        public void Shoot()
        {
            PlayerChoice = 1;
            GameLogic gameLogic = new GameLogic();
            PlayerAmountOfBullets = gameLogic.Shoot(PlayerAmountOfBullets);
        }
        private void Block()
        {
            PlayerChoice = 2;
        }

        public void Reload()
        { 
            PlayerChoice = 3;
            GameLogic gameLogic = new GameLogic();
            PlayerAmountOfBullets = gameLogic.Reload(PlayerAmountOfBullets);
        }
    }

}
