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
        public int CpuAmountOfBullets { get; set; }

        public void GenerateCpuMove()
        {
            Random random = new Random();
            CpuChoice = random.Next(0, 3);

            if (CpuAmountOfBullets == 3) Shotgun();
            else if (CpuChoice == 1 && CpuAmountOfBullets > 0) Shoot();
            else if (CpuChoice == 2) Block();
            else if (CpuChoice == 3 && CpuAmountOfBullets < 3) Reload();
            else GenerateCpuMove();
        }

        
        private void Shoot()
        {
            GameLogic gameLogic = new GameLogic();
            CpuAmountOfBullets = gameLogic.Shoot(CpuAmountOfBullets);
        }
        private void Block()
        {
        }
        public void Reload()
        {
            GameLogic gameLogic = new GameLogic();
            CpuAmountOfBullets = gameLogic.Reload(CpuAmountOfBullets);
        }
        private void Shotgun()
        {

        }
    }



}
