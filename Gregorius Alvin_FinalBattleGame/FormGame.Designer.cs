
namespace Gregorius_Alvin_FinalBattleGame
{
    partial class FormGame
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startNewGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playPauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelTime = new System.Windows.Forms.Panel();
            this.labelTime = new System.Windows.Forms.Label();
            this.panelEnemy = new System.Windows.Forms.Panel();
            this.labelEnemyInfo = new System.Windows.Forms.Label();
            this.panelPlayer = new System.Windows.Forms.Panel();
            this.linkLabelSelectWeapon = new System.Windows.Forms.LinkLabel();
            this.labelPlayerInfo = new System.Windows.Forms.Label();
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.panelTime.SuspendLayout();
            this.panelEnemy.SuspendLayout();
            this.panelPlayer.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(542, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startNewGameToolStripMenuItem,
            this.playPauseToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // startNewGameToolStripMenuItem
            // 
            this.startNewGameToolStripMenuItem.Name = "startNewGameToolStripMenuItem";
            this.startNewGameToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.startNewGameToolStripMenuItem.Text = "Start New Game";
            this.startNewGameToolStripMenuItem.Click += new System.EventHandler(this.startNewGameToolStripMenuItem_Click);
            // 
            // playPauseToolStripMenuItem
            // 
            this.playPauseToolStripMenuItem.Name = "playPauseToolStripMenuItem";
            this.playPauseToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.playPauseToolStripMenuItem.Text = "Play/Pause";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panelTime
            // 
            this.panelTime.BackColor = System.Drawing.Color.Black;
            this.panelTime.Controls.Add(this.labelTime);
            this.panelTime.Location = new System.Drawing.Point(190, 36);
            this.panelTime.Name = "panelTime";
            this.panelTime.Size = new System.Drawing.Size(167, 55);
            this.panelTime.TabIndex = 6;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.Color.Black;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.White;
            this.labelTime.Location = new System.Drawing.Point(25, 10);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(120, 31);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "00:00:00";
            // 
            // panelEnemy
            // 
            this.panelEnemy.BackColor = System.Drawing.Color.Black;
            this.panelEnemy.Controls.Add(this.labelEnemyInfo);
            this.panelEnemy.Location = new System.Drawing.Point(363, 36);
            this.panelEnemy.Name = "panelEnemy";
            this.panelEnemy.Size = new System.Drawing.Size(167, 85);
            this.panelEnemy.TabIndex = 5;
            // 
            // labelEnemyInfo
            // 
            this.labelEnemyInfo.AutoSize = true;
            this.labelEnemyInfo.BackColor = System.Drawing.Color.Black;
            this.labelEnemyInfo.ForeColor = System.Drawing.Color.White;
            this.labelEnemyInfo.Location = new System.Drawing.Point(12, 10);
            this.labelEnemyInfo.Name = "labelEnemyInfo";
            this.labelEnemyInfo.Size = new System.Drawing.Size(60, 13);
            this.labelEnemyInfo.TabIndex = 0;
            this.labelEnemyInfo.Text = "Enemy Info";
            // 
            // panelPlayer
            // 
            this.panelPlayer.BackColor = System.Drawing.Color.Black;
            this.panelPlayer.Controls.Add(this.linkLabelSelectWeapon);
            this.panelPlayer.Controls.Add(this.labelPlayerInfo);
            this.panelPlayer.Location = new System.Drawing.Point(12, 36);
            this.panelPlayer.Name = "panelPlayer";
            this.panelPlayer.Size = new System.Drawing.Size(167, 85);
            this.panelPlayer.TabIndex = 4;
            // 
            // linkLabelSelectWeapon
            // 
            this.linkLabelSelectWeapon.AutoSize = true;
            this.linkLabelSelectWeapon.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.linkLabelSelectWeapon.Location = new System.Drawing.Point(83, 63);
            this.linkLabelSelectWeapon.Name = "linkLabelSelectWeapon";
            this.linkLabelSelectWeapon.Size = new System.Drawing.Size(81, 13);
            this.linkLabelSelectWeapon.TabIndex = 1;
            this.linkLabelSelectWeapon.TabStop = true;
            this.linkLabelSelectWeapon.Text = "Select Weapon";
            // 
            // labelPlayerInfo
            // 
            this.labelPlayerInfo.AutoSize = true;
            this.labelPlayerInfo.BackColor = System.Drawing.Color.Black;
            this.labelPlayerInfo.ForeColor = System.Drawing.Color.White;
            this.labelPlayerInfo.Location = new System.Drawing.Point(12, 10);
            this.labelPlayerInfo.Name = "labelPlayerInfo";
            this.labelPlayerInfo.Size = new System.Drawing.Size(57, 13);
            this.labelPlayerInfo.TabIndex = 0;
            this.labelPlayerInfo.Text = "Player Info";
            // 
            // timerGame
            // 
            this.timerGame.Tick += new System.EventHandler(this.timerGame_Tick);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gregorius_Alvin_FinalBattleGame.Properties.Resources.game_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(542, 401);
            this.Controls.Add(this.panelTime);
            this.Controls.Add(this.panelEnemy);
            this.Controls.Add(this.panelPlayer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormGame";
            this.Text = "Final Battle";
            this.Load += new System.EventHandler(this.FormGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormGame_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelTime.ResumeLayout(false);
            this.panelTime.PerformLayout();
            this.panelEnemy.ResumeLayout(false);
            this.panelEnemy.PerformLayout();
            this.panelPlayer.ResumeLayout(false);
            this.panelPlayer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startNewGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playPauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panelTime;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Panel panelEnemy;
        private System.Windows.Forms.Label labelEnemyInfo;
        private System.Windows.Forms.Panel panelPlayer;
        private System.Windows.Forms.LinkLabel linkLabelSelectWeapon;
        private System.Windows.Forms.Label labelPlayerInfo;
        private System.Windows.Forms.Timer timerGame;
    }
}

