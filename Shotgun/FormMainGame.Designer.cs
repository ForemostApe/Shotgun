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
            labelEvents = new Label();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Impact", 48F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitle.Location = new Point(511, 53);
            labelTitle.Margin = new Padding(6, 0, 6, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(541, 156);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "SHOTGUN";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(171, 700);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(207, 32);
            label1.TabIndex = 1;
            label1.Text = "Amount of bullets";
            // 
            // labelPlayerBulletCount
            // 
            labelPlayerBulletCount.AutoSize = true;
            labelPlayerBulletCount.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelPlayerBulletCount.Location = new Point(193, 749);
            labelPlayerBulletCount.Margin = new Padding(6, 0, 6, 0);
            labelPlayerBulletCount.Name = "labelPlayerBulletCount";
            labelPlayerBulletCount.Size = new Size(0, 65);
            labelPlayerBulletCount.TabIndex = 3;
            // 
            // labelCPUBulletCount
            // 
            labelCPUBulletCount.AutoSize = true;
            labelCPUBulletCount.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelCPUBulletCount.Location = new Point(1176, 749);
            labelCPUBulletCount.Margin = new Padding(6, 0, 6, 0);
            labelCPUBulletCount.Name = "labelCPUBulletCount";
            labelCPUBulletCount.Size = new Size(148, 65);
            labelCPUBulletCount.TabIndex = 5;
            labelCPUBulletCount.Text = "⦿⦿⦿";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1153, 700);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(207, 32);
            label4.TabIndex = 4;
            label4.Text = "Amount of bullets";
            // 
            // labelPlayer
            // 
            labelPlayer.AutoSize = true;
            labelPlayer.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelPlayer.Location = new Point(197, 614);
            labelPlayer.Margin = new Padding(6, 0, 6, 0);
            labelPlayer.Name = "labelPlayer";
            labelPlayer.Size = new Size(149, 57);
            labelPlayer.TabIndex = 6;
            labelPlayer.Text = "Player";
            // 
            // labelComputer
            // 
            labelComputer.AutoSize = true;
            labelComputer.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelComputer.Location = new Point(1144, 614);
            labelComputer.Margin = new Padding(6, 0, 6, 0);
            labelComputer.Name = "labelComputer";
            labelComputer.Size = new Size(222, 57);
            labelComputer.TabIndex = 7;
            labelComputer.Text = "Computer";
            // 
            // buttonShoot
            // 
            buttonShoot.Location = new Point(511, 655);
            buttonShoot.Margin = new Padding(6);
            buttonShoot.Name = "buttonShoot";
            buttonShoot.Size = new Size(139, 49);
            buttonShoot.TabIndex = 8;
            buttonShoot.Text = "Shoot";
            buttonShoot.UseVisualStyleBackColor = true;
            buttonShoot.Click += buttonShoot_Click;
            // 
            // buttonBlock
            // 
            buttonBlock.Location = new Point(700, 653);
            buttonBlock.Margin = new Padding(6);
            buttonBlock.Name = "buttonBlock";
            buttonBlock.Size = new Size(139, 49);
            buttonBlock.TabIndex = 9;
            buttonBlock.Text = "Block";
            buttonBlock.UseVisualStyleBackColor = true;
            // 
            // buttonReload
            // 
            buttonReload.Location = new Point(886, 653);
            buttonReload.Margin = new Padding(6);
            buttonReload.Name = "buttonReload";
            buttonReload.Size = new Size(139, 49);
            buttonReload.TabIndex = 10;
            buttonReload.Text = "Reload";
            buttonReload.UseVisualStyleBackColor = true;
            buttonReload.Click += buttonReload_Click;
            // 
            // buttonShotgun
            // 
            buttonShotgun.Location = new Point(511, 732);
            buttonShotgun.Margin = new Padding(6);
            buttonShotgun.Name = "buttonShotgun";
            buttonShotgun.Size = new Size(514, 141);
            buttonShotgun.TabIndex = 11;
            buttonShotgun.Text = "Shotgun!";
            buttonShotgun.UseVisualStyleBackColor = true;
            // 
            // labelEvents
            // 
            labelEvents.AutoSize = true;
            labelEvents.Location = new Point(733, 368);
            labelEvents.Margin = new Padding(6, 0, 6, 0);
            labelEvents.Name = "labelEvents";
            labelEvents.Size = new Size(78, 32);
            labelEvents.TabIndex = 12;
            labelEvents.Text = "label2";
            // 
            // FormMainGame
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1486, 960);
            Controls.Add(labelEvents);
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
            Margin = new Padding(6);
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
        private Label labelEvents;
    }
}