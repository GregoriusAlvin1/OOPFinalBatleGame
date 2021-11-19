
namespace Gregorius_Alvin_FinalBattleGame
{
    partial class FormSelectPlayer
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
            this.radioButtonIncredibleBoy = new System.Windows.Forms.RadioButton();
            this.radioButtonPerfectaGirl = new System.Windows.Forms.RadioButton();
            this.labelDescription = new System.Windows.Forms.Label();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioButtonIncredibleBoy
            // 
            this.radioButtonIncredibleBoy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.radioButtonIncredibleBoy.BackgroundImage = global::Gregorius_Alvin_FinalBattleGame.Properties.Resources.player_incredibleBoy;
            this.radioButtonIncredibleBoy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radioButtonIncredibleBoy.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButtonIncredibleBoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonIncredibleBoy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButtonIncredibleBoy.Location = new System.Drawing.Point(89, 24);
            this.radioButtonIncredibleBoy.Name = "radioButtonIncredibleBoy";
            this.radioButtonIncredibleBoy.Size = new System.Drawing.Size(220, 160);
            this.radioButtonIncredibleBoy.TabIndex = 0;
            this.radioButtonIncredibleBoy.TabStop = true;
            this.radioButtonIncredibleBoy.Text = "INCREDIBLE BOY";
            this.radioButtonIncredibleBoy.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButtonIncredibleBoy.UseVisualStyleBackColor = false;
            this.radioButtonIncredibleBoy.CheckedChanged += new System.EventHandler(this.radioButtonIncredibleBoy_CheckedChanged);
            // 
            // radioButtonPerfectaGirl
            // 
            this.radioButtonPerfectaGirl.BackColor = System.Drawing.Color.Fuchsia;
            this.radioButtonPerfectaGirl.BackgroundImage = global::Gregorius_Alvin_FinalBattleGame.Properties.Resources.player_perfectaGirl;
            this.radioButtonPerfectaGirl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radioButtonPerfectaGirl.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButtonPerfectaGirl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonPerfectaGirl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButtonPerfectaGirl.Location = new System.Drawing.Point(397, 24);
            this.radioButtonPerfectaGirl.Name = "radioButtonPerfectaGirl";
            this.radioButtonPerfectaGirl.Size = new System.Drawing.Size(213, 160);
            this.radioButtonPerfectaGirl.TabIndex = 1;
            this.radioButtonPerfectaGirl.TabStop = true;
            this.radioButtonPerfectaGirl.Text = "PERFECTA GIRL";
            this.radioButtonPerfectaGirl.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButtonPerfectaGirl.UseVisualStyleBackColor = false;
            this.radioButtonPerfectaGirl.CheckedChanged += new System.EventHandler(this.radioButtonPerfectaGirl_CheckedChanged);
            // 
            // labelDescription
            // 
            this.labelDescription.BackColor = System.Drawing.Color.Transparent;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDescription.Location = new System.Drawing.Point(12, 269);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(678, 30);
            this.labelDescription.TabIndex = 2;
            this.labelDescription.Text = "Description";
            this.labelDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonPlay.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlay.Location = new System.Drawing.Point(228, 315);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(244, 58);
            this.buttonPlay.TabIndex = 3;
            this.buttonPlay.Text = "PLAY";
            this.buttonPlay.UseVisualStyleBackColor = false;
            // 
            // FormSelectPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gregorius_Alvin_FinalBattleGame.Properties.Resources.game_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(702, 409);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.radioButtonPerfectaGirl);
            this.Controls.Add(this.radioButtonIncredibleBoy);
            this.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormSelectPlayer";
            this.Text = "Select Player";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonIncredibleBoy;
        private System.Windows.Forms.RadioButton radioButtonPerfectaGirl;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Button buttonPlay;
    }
}