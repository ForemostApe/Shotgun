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
                else if (CpuChoice == 3 && AmountOfBullets < 3) Reload();
                else GenerateCpuMove();
            }

            return CpuChoice;
        }

        
        private void Shoot()
        {
            GameLogic gameLogic = new GameLogic();
            AmountOfBullets = gameLogic.Shoot(AmountOfBullets);
        }

        public void Reload()
        {
            GameLogic gameLogic = new GameLogic();
            AmountOfBullets = gameLogic.Reload(AmountOfBullets);
        }

        public void Shotgun()
        {
            GameLogic gameLogic = new GameLogic();
            AmountOfBullets = gameLogic.Shotgun(AmountOfBullets);
        }
    }
}
