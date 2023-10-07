using Shotgun.Classes;
using System.Numerics;

namespace Shotgun
{
    public partial class FormMainGame : Form
    {
        GameLogic gameLogic = new GameLogic();
        Player player = new Player();
        Computer computer = new Computer();

        public FormMainGame()
        {
            InitializeComponent();
        }

        #region Button-events

        private void buttonShoot_Click(object sender, EventArgs e)
        {
            if (player.AmountOfBullets > 0)
            {
                player.Shoot();
                labelPlayerChoice.Text = "Player shot";
                labelCPUChoice.Text = CPUChoice(computer.GenerateCpuMove());
                PlayerBulletUpdater();
                ComputerBulletUpdater();
                ShowEvents(gameLogic.CheckOutcome(player.PlayerChoice, computer.CpuChoice));
                ShotgunButtonEnabler();
            }
            else
            {
                labelEvents.Text = "You don't have enough ammo to shoot.";
                labelPlayerChoice.Text = "";
                labelCPUChoice.Text = "";
            }

        }

        private void buttonBlock_Click(object sender, EventArgs e)
        {
            player.Block();
            labelPlayerChoice.Text = "Player blocked";
            labelCPUChoice.Text = CPUChoice(computer.GenerateCpuMove());
            ShowEvents(gameLogic.CheckOutcome(player.PlayerChoice, computer.CpuChoice));
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            player.Reload();
            labelPlayerChoice.Text = "Player reloaded";
            labelCPUChoice.Text = CPUChoice(computer.GenerateCpuMove());
            PlayerBulletUpdater();
            ComputerBulletUpdater();
            ShowEvents(gameLogic.CheckOutcome(player.PlayerChoice, computer.CpuChoice));
            ShotgunButtonEnabler();
        }

        private void buttonShotgun_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Methods
        private string CPUChoice(int x)
        {
            if (x == 1)
            {
                return "CPU shot";
            }
            else if (x == 2)
            {
                return "CPU blocked";
            }
            else if (x == 3)
            {
                return "CPU reloaded";
            }
            else
            {
                return "Shotgun!";
            }
        }

        private void PlayerBulletUpdater()
        {
            if (player.AmountOfBullets == 0)
            {
                labelPlayerBulletCount.Text = "";
            }
            else if (player.AmountOfBullets == 1)
            {
                labelPlayerBulletCount.Text = "⦿";
            }
            else if (player.AmountOfBullets == 2)
            {
                labelPlayerBulletCount.Text = "⦿ ⦿";
            }
            else if (player.AmountOfBullets == 3)
            {
                labelPlayerBulletCount.Text = "⦿ ⦿ ⦿";
            }

        }

        private void ShotgunButtonEnabler()
        {
            if (player.AmountOfBullets >= 3) buttonShotgun.Enabled = true;
            else buttonShotgun.Enabled = false;
        }

        private void ComputerBulletUpdater()
        {
            if (computer.AmountOfBullets == 0)
            {
                labelCPUBulletCount.Text = "";
            }
            else if (computer.AmountOfBullets == 1)
            {
                labelCPUBulletCount.Text = "⦿";
            }
            else if (computer.AmountOfBullets == 2)
            {
                labelCPUBulletCount.Text = "⦿ ⦿";
            }
            else if (computer.AmountOfBullets == 3)
            {
                labelCPUBulletCount.Text = "⦿ ⦿ ⦿";
            }
        }

        private void ShowEvents(string displayEvent)
        {
            labelEvents.Text = displayEvent;
        }

        #endregion
    }
}
