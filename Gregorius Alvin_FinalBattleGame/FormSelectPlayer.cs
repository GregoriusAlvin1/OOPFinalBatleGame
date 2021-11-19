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
    public partial class FormSelectPlayer : Form
    {
        public FormSelectPlayer()
        {
            InitializeComponent();
        }

        private void radioButtonIncredibleBoy_CheckedChanged(object sender, EventArgs e)
        {
            labelDescription.Text = "I'm the superhero with incredible strength and honor";
        }

        private void radioButtonPerfectaGirl_CheckedChanged(object sender, EventArgs e)
        {
            labelDescription.Text = "I'm the superhero with calm and perfect play";
        }
    }
}

