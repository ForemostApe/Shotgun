﻿using Shotgun.Classes;
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
                GameOver();
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
            PlayerBulletUpdater();
            ComputerBulletUpdater();
            GameOver();
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            if (player.AmountOfBullets < 3)
            {
                player.Reload();
                labelPlayerChoice.Text = "Player reloaded";
                labelCPUChoice.Text = CPUChoice(computer.GenerateCpuMove());
                PlayerBulletUpdater();
                ComputerBulletUpdater();
                ShowEvents(gameLogic.CheckOutcome(player.PlayerChoice, computer.CpuChoice));
                ShotgunButtonEnabler();
                GameOver();
            }
            else
            {
                labelEvents.Text = "You're already at full capacity.";
                labelPlayerChoice.Text = "";
                labelCPUChoice.Text = "";
            }

        }

        private void buttonShotgun_Click(object sender, EventArgs e)
        {
            player.Shotgun();
            labelPlayerChoice.Text = "Player used shotgun";
            labelCPUChoice.Text = CPUChoice(computer.GenerateCpuMove());
            PlayerBulletUpdater();
            ComputerBulletUpdater();
            ShowEvents(gameLogic.CheckOutcome(player.PlayerChoice, computer.CpuChoice));
            GameOver();
        }


        private void buttonRestart_Click(object sender, EventArgs e)
        {
            NewGame();
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
                return "CPU used shotgun";
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

        private void GameOver()
        {
            if (!gameLogic.isOngoing)
            {
                buttonRestart.Visible = true;
                buttonCloseApp.Visible = true;
                buttonShoot.Enabled = false;
                buttonBlock.Enabled = false;
                buttonReload.Enabled = false;
                buttonShotgun.Enabled = false;
            }
        }

        private void NewGame()
        {
            gameLogic.isOngoing = true;

            buttonRestart.Visible = false;
            buttonCloseApp.Visible = false;
            buttonShoot.Enabled = true;
            buttonBlock.Enabled = true;
            buttonReload.Enabled = true;
            buttonShotgun.Enabled = true;

            computer.CpuChoice = 0;
            computer.AmountOfBullets = 0;
            player.PlayerChoice = 0;
            player.AmountOfBullets = 0;

            labelCPUChoice.Text = "";
            labelPlayerChoice.Text = "";

            labelEvents.Text = "";

            PlayerBulletUpdater();
            ComputerBulletUpdater();
        }

        #endregion

        private void buttonCloseApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
