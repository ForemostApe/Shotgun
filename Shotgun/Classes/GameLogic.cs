using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shotgun.Classes
{
    public class GameLogic
    {
        public  bool isOngoing { get; set; }
        public GameLogic()
        {
            isOngoing = true;
        }

        public string CheckOutcome(int x, int y)
        {

            if ((x == 1) && (y == 1))
            {
                return "You both shoot!\nNothing happens!";
            }
            if ((x == 2) && (y == 2))
            {
                return "You both block!\nNothing happens!";
            }
            if (x == 2 && y == 1)
            {
                return "You blocked the computers shot!\nNothing happens!";
            }
            if (x == 1 && y == 2)
            {
                return "The computer blocked your shot!\nNothing happens!";
            }
            if ((x == 3) && (y == 3))
            {
                return "You both reload!\nNothing happens!";
            }
            if ((x == 1) && (y == 3)) //Här tar spelet slut, spelaren skjuter datorn.
            {
                isOngoing = false;
                return "You shot the computer while it was reloading!\nYou win!";
            }
            if ((x == 3) && (y == 1)) //Här tar spelet slut, datorn skjuter spelaren.
            {
                isOngoing = false;
                return "The computer shot you while you were reloading!\nYou lose!";
            }
            if ((x == 2) && (y == 3))
            {
                return "You block and the computer reloads!\nNothing happens!";
            }
            if ((x == 3) && y == 2)
            {
                return "You reload and the computer blocks!\nNothing happens!";
            }

            if ((x == 4) && (y == 4))
            {
                return "You both blast shotguns!\nNothing happens!";
            }

            if ((x == 4) && (y != 4))
            {
                isOngoing = false;
                return "You blast the computer with a shotgun-blast!\nYou win!";
            }
            if ((x != 4) && (y == 4))
            {
                isOngoing = false;
                return "The computer blasts you with a shotgun-blast!\nYou lose!";
            }
            return "Something went wrong!";
        }

        public int Shoot(int bulletAmount)
        {
            if (bulletAmount > 0) bulletAmount--;
            return bulletAmount;
        }

        public int Reload(int bulletAmount)
        {
            if (bulletAmount < 3) bulletAmount++;
            return bulletAmount;
        }

        public int Shotgun(int bulletAmount)
        {
            return bulletAmount = 0;
        }
    }
}
