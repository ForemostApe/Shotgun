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
            return AmountOfBullets = gameLogic.Shoot(AmountOfBullets);
        }

        public void Block()
        {
            PlayerChoice = 2;
        }

        public void Reload()
        { 
            PlayerChoice = 3;
            if (AmountOfBullets < 3);
            AmountOfBullets = gameLogic.Reload(AmountOfBullets);
        }

        public void Shotgun()
        {
            PlayerChoice = 4;
            AmountOfBullets = gameLogic.Shotgun(AmountOfBullets);
        }
    }

}
