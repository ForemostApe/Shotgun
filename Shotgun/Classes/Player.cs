namespace Shotgun.Classes
{
    public class Player
    {

        public int PlayerChoice { get; set; }
        public int AmountOfBullets { get; set; }

        GameLogic gameLogic = new GameLogic();
        public Player()
        {
            
        }
        public int Shoot()
        {
            PlayerChoice = 1;
            AmountOfBullets = gameLogic.Shoot(AmountOfBullets);
            return AmountOfBullets;
        }
        public int Block()
        {
            PlayerChoice = 2;
            return AmountOfBullets;
        }
        public int Reload()
        { 
            PlayerChoice = 3;
            if (AmountOfBullets < 3) AmountOfBullets = gameLogic.Reload(AmountOfBullets);
            return AmountOfBullets;
        }
        public void Shotgun()
        {
            PlayerChoice = 4;
            AmountOfBullets = gameLogic.Shotgun(AmountOfBullets);
        }
    }
}
