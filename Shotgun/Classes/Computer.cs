using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Shotgun.Classes
{
    public class Computer
    {
        public int CpuChoice { get; set; }
        public int AmountOfBullets { get; set; }

        public Computer()
        {
        }

        public int GenerateCpuMove()
        {
            Random random = new Random();
            CpuChoice = random.Next(1, 4);

            if (AmountOfBullets == 3) Shotgun();
            else if (CpuChoice == 1 && AmountOfBullets > 0) Shoot();
            //else if (CpuChoice == 2) Block();
            else if (CpuChoice == 2);
            else if (CpuChoice == 3 && AmountOfBullets < 3) Reload();
            else GenerateCpuMove();

            return CpuChoice;
        }

        
        private void Shoot()
        {
            GameLogic gameLogic = new GameLogic();
            AmountOfBullets = gameLogic.Shoot(AmountOfBullets);
        }
        //private void Block()
        //{
        //}
        public void Reload()
        {
            GameLogic gameLogic = new GameLogic();
            AmountOfBullets = gameLogic.Reload(AmountOfBullets);
        }
        private void Shotgun()
        {
            MessageBox.Show("Shotgun");
        }
    }



}
