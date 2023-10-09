using System.Linq.Expressions;

namespace Shotgun.Classes
{
    public class Computer
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
                if (CpuChoice == 1 && AmountOfBullets > 0) Shoot();
                else if (CpuChoice == 2); //Det här är en konstig lösning. Är detta okay?!
                else if (CpuChoice == 3 && AmountOfBullets < 3) Reload();
                else GenerateCpuMove();
            }
            return CpuChoice;
        }
        private void Shoot()
        {
            AmountOfBullets = gameLogic.Shoot(AmountOfBullets);
        }

        //private void Block()
        //{
        //    Den här metoden gör ingenting.
        //}
        public void Reload()
        {
            AmountOfBullets = gameLogic.Reload(AmountOfBullets);
        }

        public void Shotgun()
        {
            AmountOfBullets = gameLogic.Shotgun(AmountOfBullets);
        }
    }
}