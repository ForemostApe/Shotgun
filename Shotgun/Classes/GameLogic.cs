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
        public int playerChoice { get; set; }
        public int playerAmountOfBullets { get; set; }
        public int cpuAmountOfBullets { get; set; }


        bool isOngoing = true;

        public GameLogic()
        {

            Random random = new Random();
            int cpuChoice = random.Next(1, 3);
        }
        public int Shoot(int bulletAmount)
        {
            playerChoice = 1;

            if (bulletAmount > 0) bulletAmount--;
            return bulletAmount;

            }

        //public void Block()
        //{
        //    playerChoice = 2;
        //}

        public int Reload(int bulletAmount)
        {
            playerChoice = 3;
            if (bulletAmount < 3) bulletAmount++;
            return bulletAmount;
        }

        private void CheckOutcome(int player, int cpu)
        {
            if ((player == 1) && (cpu == 1) || (player == 1 && cpu == 2))
            {
                Shoot(playerAmountOfBullets);
                Shoot(cpuAmountOfBullets);
            }
            else if  (player == 2 && cpu == 1)
            {
                Shoot(cpuAmountOfBullets);
            }
            else if ((player == 1) && (cpu == 3)) //Här tar spelet slut, spelaren skjuter datorn.
            {
                GameOver("You");
            }
            else if ((player == 3) && (cpu == 1)) //Här tar spelet slut, datorn skjuter spelaren.
            {
                GameOver("The computer");
            }
        }

        public void GameOver(string winner)
        {
            MessageBox.Show($"{winner} won!");
        }
    }
}
