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
        bool isOngoing = true;

        public GameLogic()
        {
        }

        private void CheckOutcome()
        {
            Player player = new Player();
            Computer computer = new Computer();

            if ((player.PlayerChoice == 1) && (computer.CpuChoice == 1) || (player.PlayerChoice == 1 && computer.CpuChoice == 2))
            {
                Shoot(player.PlayerAmountOfBullets);
                Shoot(computer.CpuAmountOfBullets);
            }
            else if  (player.PlayerChoice == 2 && computer.CpuChoice == 1)
            {
                Shoot(computer.CpuAmountOfBullets);
            }
            else if ((player.PlayerChoice == 1) && (computer.CpuChoice == 3)) //Här tar spelet slut, spelaren skjuter datorn.
            {
                GameOver("You");
            }
            else if ((player.PlayerChoice == 3) && (computer.CpuChoice == 1)) //Här tar spelet slut, datorn skjuter spelaren.
            {
                GameOver("The computer");
            }
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

        public void GameOver(string winner)
        {
            MessageBox.Show($"{winner} won!");
        }
    }
}
