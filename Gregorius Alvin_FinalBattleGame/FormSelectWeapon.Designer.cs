
namespace Gregorius_Alvin_FinalBattleGame
{
    partial class FormSelectWeapon
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
            this.radioButtonKnife = new System.Windows.Forms.RadioButton();
            this.buttonUSE = new System.Windows.Forms.Button();
            this.labelDescription = new System.Windows.Forms.Label();
            this.radioButtonFireball = new System.Windows.Forms.RadioButton();
            this.radioButtonRock = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // radioButtonKnife
            // 
            this.radioButtonKnife.BackColor = System.Drawing.Color.Fuchsia;
            this.radioButtonKnife.BackgroundImage = global::Gregorius_Alvin_FinalBattleGame.Properties.Resources.weapon_knive;
            this.radioButtonKnife.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radioButtonKnife.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButtonKnife.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonKnife.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButtonKnife.Location = new System.Drawing.Point(448, 58);
            this.radioButtonKnife.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonKnife.Name = "radioButtonKnife";
            this.radioButtonKnife.Size = new System.Drawing.Size(282, 246);
            this.radioButtonKnife.TabIndex = 3;
            this.radioButtonKnife.TabStop = true;
            this.radioButtonKnife.Text = "KNIFE";
            this.radioButtonKnife.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButtonKnife.UseVisualStyleBackColor = false;
            this.radioButtonKnife.CheckedChanged += new System.EventHandler(this.radioButtonKnife_CheckedChanged);
            // 
            // buttonUSE
            // 
            this.buttonUSE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonUSE.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUSE.Location = new System.Drawing.Point(399, 517);
            this.buttonUSE.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonUSE.Name = "buttonUSE";
            this.buttonUSE.Size = new System.Drawing.Size(366, 89);
            this.buttonUSE.TabIndex = 5;
            this.buttonUSE.Text = "USE";
            this.buttonUSE.UseVisualStyleBackColor = false;
            this.buttonUSE.Click += new System.EventHandler(this.buttonUSE_Click);
            // 
            // labelDescription
            // 
            this.labelDescription.BackColor = System.Drawing.Color.Transparent;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDescription.Location = new System.Drawing.Point(18, 448);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(1138, 46);
            this.labelDescription.TabIndex = 4;
            this.labelDescription.Text = "Description";
            this.labelDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButtonFireball
            // 
            this.radioButtonFireball.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.radioButtonFireball.BackgroundImage = global::Gregorius_Alvin_FinalBattleGame.Properties.Resources.weapon_fireball;
            this.radioButtonFireball.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radioButtonFireball.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButtonFireball.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFireball.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButtonFireball.Location = new System.Drawing.Point(816, 58);
            this.radioButtonFireball.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonFireball.Name = "radioButtonFireball";
            this.radioButtonFireball.Size = new System.Drawing.Size(282, 246);
            this.radioButtonFireball.TabIndex = 6;
            this.radioButtonFireball.TabStop = true;
            this.radioButtonFireball.Text = "FIREBALL";
            this.radioButtonFireball.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButtonFireball.UseVisualStyleBackColor = false;
            this.radioButtonFireball.CheckedChanged += new System.EventHandler(this.radioButtonFireball_CheckedChanged);
            // 
            // radioButtonRock
            // 
            this.radioButtonRock.BackColor = System.Drawing.Color.Blue;
            this.radioButtonRock.BackgroundImage = global::Gregorius_Alvin_FinalBattleGame.Properties.Resources.weapon_rock;
            this.radioButtonRock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radioButtonRock.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButtonRock.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonRock.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButtonRock.Location = new System.Drawing.Point(78, 58);
            this.radioButtonRock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonRock.Name = "radioButtonRock";
            this.radioButtonRock.Size = new System.Drawing.Size(282, 246);
            this.radioButtonRock.TabIndex = 7;
            this.radioButtonRock.TabStop = true;
            this.radioButtonRock.Text = "ROCK";
            this.radioButtonRock.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButtonRock.UseVisualStyleBackColor = false;
            this.radioButtonRock.CheckedChanged += new System.EventHandler(this.radioButtonRock_CheckedChanged);
            // 
            // FormSelectWeapon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gregorius_Alvin_FinalBattleGame.Properties.Resources.game_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1186, 692);
            this.Controls.Add(this.radioButtonRock);
            this.Controls.Add(this.radioButtonFireball);
            this.Controls.Add(this.buttonUSE);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.radioButtonKnife);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormSelectWeapon";
            this.Text = "Select Weapon";
            this.Load += new System.EventHandler(this.FormSelectWeapon_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonKnife;
        private System.Windows.Forms.Button buttonUSE;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.RadioButton radioButtonFireball;
        private System.Windows.Forms.RadioButton radioButtonRock;
    }
}