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
        public GameLogic()
        {
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
                return "You shot the computer while it was reloading!\nYou win!";
            }
            if ((x == 3) && (y == 1)) //Här tar spelet slut, datorn skjuter spelaren.
            {
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

            if ((x == 4) && (y != 4))
            {
                return "You blast the computer with a shotgun-blast!\nYou win!";
            }
            if ((x != 4) && (y == 4))
            {
                return "The computer blasts you with a shotgun-blast!\nYou lose!";
            }
            return "Something went wrong!";
        }

        //public void CheckOutcome()
        //{
        //    Player player = new Player();
        //    Computer computer = new Computer();

        //    if ((player.PlayerChoice == 1) && (computer.CpuChoice == 1) || (player.PlayerChoice == 1 && computer.CpuChoice == 2))
        //    {
        //        Shoot(player.AmountOfBullets);
        //        Shoot(computer.AmountOfBullets);
        //    }
        //    else if  (player.PlayerChoice == 2 && computer.CpuChoice == 1)
        //    {
        //        Shoot(computer.AmountOfBullets);
        //    }
        //    else if ((player.PlayerChoice == 1) && (computer.CpuChoice == 3)) //Här tar spelet slut, spelaren skjuter datorn.
        //    {
        //        GameOver("You");
        //    }
        //    else if ((player.PlayerChoice == 3) && (computer.CpuChoice == 1)) //Här tar spelet slut, datorn skjuter spelaren.
        //    {
        //        GameOver("The computer");
        //    }
        //}

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

        //public void GameOver(string winner)
        //{
        //    MessageBox.Show($"{winner} won!");
        //}
    }
}
