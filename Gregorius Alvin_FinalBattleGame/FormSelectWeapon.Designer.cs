
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
            this.radioButtonRock = new System.Windows.Forms.RadioButton();
            this.buttonUSE = new System.Windows.Forms.Button();
            this.labelDescription = new System.Windows.Forms.Label();
            this.radioButtonFireball = new System.Windows.Forms.RadioButton();
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
            this.radioButtonKnife.Location = new System.Drawing.Point(299, 38);
            this.radioButtonKnife.Name = "radioButtonKnife";
            this.radioButtonKnife.Size = new System.Drawing.Size(188, 160);
            this.radioButtonKnife.TabIndex = 3;
            this.radioButtonKnife.TabStop = true;
            this.radioButtonKnife.Text = "KNIFE";
            this.radioButtonKnife.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButtonKnife.UseVisualStyleBackColor = false;
            this.radioButtonKnife.CheckedChanged += new System.EventHandler(this.radioButtonKnife_CheckedChanged);
            // 
            // radioButtonRock
            // 
            this.radioButtonRock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.radioButtonRock.BackgroundImage = global::Gregorius_Alvin_FinalBattleGame.Properties.Resources.weapon_rock;
            this.radioButtonRock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radioButtonRock.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButtonRock.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonRock.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButtonRock.Location = new System.Drawing.Point(57, 38);
            this.radioButtonRock.Name = "radioButtonRock";
            this.radioButtonRock.Size = new System.Drawing.Size(181, 160);
            this.radioButtonRock.TabIndex = 2;
            this.radioButtonRock.TabStop = true;
            this.radioButtonRock.Text = "ROCK";
            this.radioButtonRock.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButtonRock.UseVisualStyleBackColor = false;
            this.radioButtonRock.CheckedChanged += new System.EventHandler(this.radioButtonRock_CheckedChanged);
            // 
            // buttonUSE
            // 
            this.buttonUSE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonUSE.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUSE.Location = new System.Drawing.Point(266, 336);
            this.buttonUSE.Name = "buttonUSE";
            this.buttonUSE.Size = new System.Drawing.Size(244, 58);
            this.buttonUSE.TabIndex = 5;
            this.buttonUSE.Text = "USE";
            this.buttonUSE.UseVisualStyleBackColor = false;
            // 
            // labelDescription
            // 
            this.labelDescription.BackColor = System.Drawing.Color.Transparent;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDescription.Location = new System.Drawing.Point(12, 291);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(759, 30);
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
            this.radioButtonFireball.Location = new System.Drawing.Point(544, 38);
            this.radioButtonFireball.Name = "radioButtonFireball";
            this.radioButtonFireball.Size = new System.Drawing.Size(188, 160);
            this.radioButtonFireball.TabIndex = 6;
            this.radioButtonFireball.TabStop = true;
            this.radioButtonFireball.Text = "FIREBALL";
            this.radioButtonFireball.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButtonFireball.UseVisualStyleBackColor = false;
            this.radioButtonFireball.CheckedChanged += new System.EventHandler(this.radioButtonFireball_CheckedChanged);
            // 
            // FormSelectWeapon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gregorius_Alvin_FinalBattleGame.Properties.Resources.game_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(791, 450);
            this.Controls.Add(this.radioButtonFireball);
            this.Controls.Add(this.buttonUSE);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.radioButtonKnife);
            this.Controls.Add(this.radioButtonRock);
            this.Name = "FormSelectWeapon";
            this.Text = "Select Weapon";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonKnife;
        private System.Windows.Forms.RadioButton radioButtonRock;
        private System.Windows.Forms.Button buttonUSE;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.RadioButton radioButtonFireball;
    }
}