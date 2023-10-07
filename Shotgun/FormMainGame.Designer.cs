namespace Shotgun
{
    partial class FormMainGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelTitle = new Label();
            labelPlayerAmountOfBullets = new Label();
            labelPlayerBulletCount = new Label();
            labelCPUBulletCount = new Label();
            labelCPUAmountOfBullets = new Label();
            labelPlayer = new Label();
            labelComputer = new Label();
            buttonShoot = new Button();
            buttonBlock = new Button();
            buttonReload = new Button();
            buttonShotgun = new Button();
            labelEvents = new Label();
            labelPlayerChoice = new Label();
            labelCPUChoice = new Label();
            buttonRestart = new Button();
            buttonCloseApp = new Button();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Impact", 48F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitle.Location = new Point(279, 25);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(273, 80);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "SHOTGUN";
            // 
            // labelPlayerAmountOfBullets
            // 
            labelPlayerAmountOfBullets.AutoSize = true;
            labelPlayerAmountOfBullets.Location = new Point(92, 328);
            labelPlayerAmountOfBullets.Name = "labelPlayerAmountOfBullets";
            labelPlayerAmountOfBullets.Size = new Size(103, 15);
            labelPlayerAmountOfBullets.TabIndex = 1;
            labelPlayerAmountOfBullets.Text = "Amount of bullets";
            // 
            // labelPlayerBulletCount
            // 
            labelPlayerBulletCount.AutoSize = true;
            labelPlayerBulletCount.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelPlayerBulletCount.Location = new Point(104, 351);
            labelPlayerBulletCount.Name = "labelPlayerBulletCount";
            labelPlayerBulletCount.Size = new Size(0, 32);
            labelPlayerBulletCount.TabIndex = 3;
            // 
            // labelCPUBulletCount
            // 
            labelCPUBulletCount.AutoSize = true;
            labelCPUBulletCount.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelCPUBulletCount.Location = new Point(633, 351);
            labelCPUBulletCount.Name = "labelCPUBulletCount";
            labelCPUBulletCount.Size = new Size(0, 32);
            labelCPUBulletCount.TabIndex = 5;
            // 
            // labelCPUAmountOfBullets
            // 
            labelCPUAmountOfBullets.AutoSize = true;
            labelCPUAmountOfBullets.Location = new Point(621, 328);
            labelCPUAmountOfBullets.Name = "labelCPUAmountOfBullets";
            labelCPUAmountOfBullets.Size = new Size(103, 15);
            labelCPUAmountOfBullets.TabIndex = 4;
            labelCPUAmountOfBullets.Text = "Amount of bullets";
            // 
            // labelPlayer
            // 
            labelPlayer.AutoSize = true;
            labelPlayer.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelPlayer.Location = new Point(106, 288);
            labelPlayer.Name = "labelPlayer";
            labelPlayer.Size = new Size(73, 30);
            labelPlayer.TabIndex = 6;
            labelPlayer.Text = "Player";
            // 
            // labelComputer
            // 
            labelComputer.AutoSize = true;
            labelComputer.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelComputer.Location = new Point(616, 288);
            labelComputer.Name = "labelComputer";
            labelComputer.Size = new Size(111, 30);
            labelComputer.TabIndex = 7;
            labelComputer.Text = "Computer";
            // 
            // buttonShoot
            // 
            buttonShoot.Location = new Point(275, 307);
            buttonShoot.Name = "buttonShoot";
            buttonShoot.Size = new Size(75, 23);
            buttonShoot.TabIndex = 8;
            buttonShoot.Text = "Shoot";
            buttonShoot.UseVisualStyleBackColor = true;
            buttonShoot.Click += buttonShoot_Click;
            // 
            // buttonBlock
            // 
            buttonBlock.Location = new Point(377, 306);
            buttonBlock.Name = "buttonBlock";
            buttonBlock.Size = new Size(75, 23);
            buttonBlock.TabIndex = 9;
            buttonBlock.Text = "Block";
            buttonBlock.UseVisualStyleBackColor = true;
            buttonBlock.Click += buttonBlock_Click;
            // 
            // buttonReload
            // 
            buttonReload.Location = new Point(477, 306);
            buttonReload.Name = "buttonReload";
            buttonReload.Size = new Size(75, 23);
            buttonReload.TabIndex = 10;
            buttonReload.Text = "Reload";
            buttonReload.UseVisualStyleBackColor = true;
            buttonReload.Click += buttonReload_Click;
            // 
            // buttonShotgun
            // 
            buttonShotgun.Enabled = false;
            buttonShotgun.Location = new Point(275, 343);
            buttonShotgun.Name = "buttonShotgun";
            buttonShotgun.Size = new Size(277, 66);
            buttonShotgun.TabIndex = 11;
            buttonShotgun.Text = "Shotgun!";
            buttonShotgun.UseVisualStyleBackColor = true;
            buttonShotgun.Click += buttonShotgun_Click;
            // 
            // labelEvents
            // 
            labelEvents.Location = new Point(275, 105);
            labelEvents.Name = "labelEvents";
            labelEvents.Size = new Size(273, 178);
            labelEvents.TabIndex = 12;
            labelEvents.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelPlayerChoice
            // 
            labelPlayerChoice.AutoSize = true;
            labelPlayerChoice.Location = new Point(111, 155);
            labelPlayerChoice.Name = "labelPlayerChoice";
            labelPlayerChoice.Size = new Size(0, 15);
            labelPlayerChoice.TabIndex = 13;
            // 
            // labelCPUChoice
            // 
            labelCPUChoice.AutoSize = true;
            labelCPUChoice.Location = new Point(642, 155);
            labelCPUChoice.Name = "labelCPUChoice";
            labelCPUChoice.Size = new Size(0, 15);
            labelCPUChoice.TabIndex = 14;
            // 
            // buttonRestart
            // 
            buttonRestart.Location = new Point(275, 260);
            buttonRestart.Name = "buttonRestart";
            buttonRestart.Size = new Size(130, 25);
            buttonRestart.TabIndex = 15;
            buttonRestart.Text = "New game";
            buttonRestart.UseVisualStyleBackColor = true;
            buttonRestart.Visible = false;
            // 
            // buttonCloseApp
            // 
            buttonCloseApp.Location = new Point(422, 260);
            buttonCloseApp.Name = "buttonCloseApp";
            buttonCloseApp.Size = new Size(130, 25);
            buttonCloseApp.TabIndex = 16;
            buttonCloseApp.Text = "Quit";
            buttonCloseApp.UseVisualStyleBackColor = true;
            buttonCloseApp.Visible = false;
            // 
            // FormMainGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCloseApp);
            Controls.Add(buttonRestart);
            Controls.Add(labelCPUChoice);
            Controls.Add(labelPlayerChoice);
            Controls.Add(labelEvents);
            Controls.Add(buttonShotgun);
            Controls.Add(buttonReload);
            Controls.Add(buttonBlock);
            Controls.Add(buttonShoot);
            Controls.Add(labelComputer);
            Controls.Add(labelPlayer);
            Controls.Add(labelCPUBulletCount);
            Controls.Add(labelCPUAmountOfBullets);
            Controls.Add(labelPlayerBulletCount);
            Controls.Add(labelPlayerAmountOfBullets);
            Controls.Add(labelTitle);
            Name = "FormMainGame";
            Text = "FormMainGame";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Label labelPlayerAmountOfBullets;
        private Label labelPlayerBulletCount;
        private Label labelCPUBulletCount;
        private Label labelCPUAmountOfBullets;
        private Label labelPlayer;
        private Label labelComputer;
        private Button buttonShoot;
        private Button buttonBlock;
        private Button buttonReload;
        private Button buttonShotgun;
        private Label labelEvents;
        private Label labelPlayerChoice;
        private Label labelCPUChoice;
        private Button buttonRestart;
        private Button buttonCloseApp;
    }
}