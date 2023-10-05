using Microsoft.VisualBasic.Devices;
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
        public int AmountOfBullets { get; set; }

        public Player()
        {
        }

        public int Shoot()
        {
                PlayerChoice = 1;
                GameLogic gameLogic = new GameLogic();
                return AmountOfBullets = gameLogic.Shoot(AmountOfBullets);
        }

        public void Block()
        {
            PlayerChoice = 2;
        }

        public void Reload()
        { 
            PlayerChoice = 3;
            if (AmountOfBullets < 3);
            GameLogic gameLogic = new GameLogic();
            AmountOfBullets = gameLogic.Reload(AmountOfBullets);
        }
    }

}
