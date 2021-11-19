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
    }
}
