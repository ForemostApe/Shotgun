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
            AmountOfBullets = updateBullets(PlayerChoice, AmountOfBullets);
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
            if (AmountOfBullets < 3) AmountOfBullets = updateBullets(PlayerChoice, AmountOfBullets);
            return AmountOfBullets;
        }
        public void Shotgun()
        {
            PlayerChoice = 4;
            AmountOfBullets = updateBullets(PlayerChoice, AmountOfBullets);
        }

        public int updateBullets(int choice, int bullets)
        {
            if (choice == 1)
            {
                if (bullets > 0) bullets--;
                return bullets;
            }
            else if (choice == 2)
            { 
                return bullets;
            }
            else if (choice == 3)
                {
                    if (bullets < 3) bullets++;
                    return bullets;
                }
                else if (choice == 4) return bullets = 0;
                else return 0;
        }
    }
}
