using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gregorius_Alvin_FinalBattleGame
{
    public partial class FormSelectWeapon : Form
    {
        public FormSelectWeapon()
        {
            InitializeComponent();
        }

        FormGame formGame;

        private void radioButtonRock_CheckedChanged(object sender, EventArgs e)
        {
            labelDescription.Text = "It's a heavy giant rock";
        }

        private void radioButtonKnife_CheckedChanged(object sender, EventArgs e)
        {
            labelDescription.Text = "It's a sharp rusty knives";
        }

        private void radioButtonFireball_CheckedChanged(object sender, EventArgs e)
        {
            labelDescription.Text = "It's a hot bluish flame";
        }

        private void FormSelectWeapon_Load(object sender, EventArgs e)
        {
            formGame = (FormGame)this.Owner;
        }

        private void buttonUSE_Click(object sender, EventArgs e)
        {
            //ganti weapon player
            if (radioButtonRock.Checked)
            {
                formGame.player.SetWeapon(radioButtonRock.Text, labelDescription.Text, radioButtonRock.BackgroundImage);
            }
            else if (radioButtonKnife.Checked)
            {
                formGame.player.SetWeapon(radioButtonKnife.Text, labelDescription.Text, radioButtonKnife.BackgroundImage);
            }
            else if (radioButtonFireball.Checked)
            {
                formGame.player.SetWeapon(radioButtonFireball.Text, labelDescription.Text, radioButtonFireball.BackgroundImage);
            }
            //tampilkan data player baru di labelPlayerInfo
            formGame.labelPlayerInfo.Text = formGame.player.Display();
            this.Close();
        }
    }
}
