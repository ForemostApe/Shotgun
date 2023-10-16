using System.Security.Cryptography.Xml;

namespace Shotgun.Classes
{
    public class GameLogic
    {
        public bool isOngoing { get; set; }
        public GameLogic()
        {
            isOngoing = true;
        }

        public string CheckOutcome(int x, int y)
        {
            switch ((x, y))
            {
                case (1, 1):
                    return "You both shoot!\nNothing happens!";
                case (1, 2):
                    return "The computer blocked your shot!\nNothing happens!";
                case (1, 3):
                    isOngoing = false;
                    return "You shot the computer while it was reloading!\nYou win!";
                case (2, 1):
                    return "You blocked the computer's shot!\nNothing happens!";
                case (2, 2):
                    return "You both block!\nNothing happens!";
                case (2, 3):
                    return "You block, and the computer reloads!\nNothing happens!";
                case (3, 1):
                    isOngoing = false;
                    return "The computer shot you while you were reloading!\nYou lose!";
                case (3, 2):
                    return "You reload, and the computer blocks!\nNothing happens!";
                case (3, 3):
                    return "You both reload!\nNothing happens!";
                case (4, 4):
                    return "You both blast shotguns!\nNothing happens!";
                case (4, _):
                    isOngoing = false;
                    return "You blast the computer with a shotgun blast!\nYou win!";
                case (_, 4):
                    isOngoing = false;
                    return "The computer blasts you with a shotgun blast!\nYou lose!";
                default:
                    return "Something went wrong!";
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

        public int Shotgun(int bulletAmount)
        {
            return bulletAmount = 0;
        }
    }
}
