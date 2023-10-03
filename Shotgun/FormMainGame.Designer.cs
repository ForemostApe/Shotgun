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
            label1 = new Label();
            labelPlayerBulletCount = new Label();
            labelCPUBulletCount = new Label();
            label4 = new Label();
            labelPlayer = new Label();
            labelComputer = new Label();
            buttonShoot = new Button();
            buttonBlock = new Button();
            buttonReload = new Button();
            buttonShotgun = new Button();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Impact", 48F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitle.Location = new Point(275, 25);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(273, 80);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "SHOTGUN";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 328);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 1;
            label1.Text = "Amount of bullets";
            // 
            // labelPlayerBulletCount
            // 
            labelPlayerBulletCount.AutoSize = true;
            labelPlayerBulletCount.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelPlayerBulletCount.Location = new Point(104, 351);
            labelPlayerBulletCount.Name = "labelPlayerBulletCount";
            labelPlayerBulletCount.Size = new Size(74, 32);
            labelPlayerBulletCount.TabIndex = 3;
            labelPlayerBulletCount.Text = "⦿⦿⦿";
            // 
            // labelCPUBulletCount
            // 
            labelCPUBulletCount.AutoSize = true;
            labelCPUBulletCount.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelCPUBulletCount.Location = new Point(633, 351);
            labelCPUBulletCount.Name = "labelCPUBulletCount";
            labelCPUBulletCount.Size = new Size(74, 32);
            labelCPUBulletCount.TabIndex = 5;
            labelCPUBulletCount.Text = "⦿⦿⦿";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(621, 328);
            label4.Name = "label4";
            label4.Size = new Size(103, 15);
            label4.TabIndex = 4;
            label4.Text = "Amount of bullets";
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
            // 
            // buttonBlock
            // 
            buttonBlock.Location = new Point(377, 306);
            buttonBlock.Name = "buttonBlock";
            buttonBlock.Size = new Size(75, 23);
            buttonBlock.TabIndex = 9;
            buttonBlock.Text = "Block";
            buttonBlock.UseVisualStyleBackColor = true;
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
            buttonShotgun.Location = new Point(275, 343);
            buttonShotgun.Name = "buttonShotgun";
            buttonShotgun.Size = new Size(277, 66);
            buttonShotgun.TabIndex = 11;
            buttonShotgun.Text = "Shotgun!";
            buttonShotgun.UseVisualStyleBackColor = true;
            // 
            // FormMainGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonShotgun);
            Controls.Add(buttonReload);
            Controls.Add(buttonBlock);
            Controls.Add(buttonShoot);
            Controls.Add(labelComputer);
            Controls.Add(labelPlayer);
            Controls.Add(labelCPUBulletCount);
            Controls.Add(label4);
            Controls.Add(labelPlayerBulletCount);
            Controls.Add(label1);
            Controls.Add(labelTitle);
            Name = "FormMainGame";
            Text = "FormMainGame";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Label label1;
        private Label labelPlayerBulletCount;
        private Label labelCPUBulletCount;
        private Label label4;
        private Label labelPlayer;
        private Label labelComputer;
        private Button buttonShoot;
        private Button buttonBlock;
        private Button buttonReload;
        private Button buttonShotgun;
    }
}