using System.Linq.Expressions;

namespace Shotgun.Classes
{
    public class Computer : Player
    {
        public int CpuChoice { get; set; }
        public int AmountOfBullets { get; set; }

        public Computer()
        {
        }

        GameLogic gameLogic = new GameLogic();

        public int GenerateCpuMove()
        {
            if (AmountOfBullets == 3)
            {
                CpuChoice = 4;
                Shotgun();
            }
            else
            {
                Random random = new Random();
                CpuChoice = random.Next(1, 4);
                if (CpuChoice == 1 && AmountOfBullets > 0) AmountOfBullets = updateBullets(CpuChoice, AmountOfBullets);
                else if (CpuChoice == 2) AmountOfBullets = updateBullets(CpuChoice, AmountOfBullets);
                else if (CpuChoice == 3 && AmountOfBullets < 3) AmountOfBullets = updateBullets(CpuChoice, AmountOfBullets);
                else GenerateCpuMove();
            }
            return CpuChoice;
        }
    }
}