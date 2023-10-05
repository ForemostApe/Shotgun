using Shotgun.Classes;
using System.Numerics;

namespace Shotgun
{
    public partial class FormMainGame : Form
    {
        public FormMainGame()
        {
            InitializeComponent();
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            Player player = new Player();
            player.Reload();

            Computer computer = new Computer();
            computer.GenerateCpuMove();

            PlayerBulletUpdater();
        }

        private void buttonShoot_Click(object sender, EventArgs e)
        {
            Computer computer = new Computer();
            computer.GenerateCpuMove();

            Player player = new Player();
            player.Shoot();
            PlayerBulletUpdater();
            ShowEvents();
 
        }

        private void PlayerBulletUpdater()
        {
            Player player = new Player();
            if (player.PlayerAmountOfBullets == 0)
            {
                labelPlayerBulletCount.Text = "";
            }
            else if (player.PlayerAmountOfBullets == 1)
            {
                labelPlayerBulletCount.Text = "⦿";
            }
            else if (player.PlayerAmountOfBullets == 2)
            {
                labelPlayerBulletCount.Text = "⦿ ⦿";
            }
            else if (player.PlayerAmountOfBullets == 3)
            {
                labelPlayerBulletCount.Text = "⦿ ⦿ ⦿";
            }
        }

        private void ShowEvents()
        {
            Computer computer = new Computer();
            labelEvents.Text = computer.CpuChoice.ToString();
        }
    }
}
