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
        FormGame formGame;
        private void radioButtonIncredibleBoy_CheckedChanged(object sender, EventArgs e)
        {
            labelDescription.Text = "I'm the superhero with incredible strength and honor";
        }

        private void radioButtonPerfectaGirl_CheckedChanged(object sender, EventArgs e)
        {
            labelDescription.Text = "I'm the superhero with calm and perfect play";
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if (formGame.player != null)
            {
                formGame.player.Remove(); //hapus pictureBox player
                formGame.player = null;
            }
            if (radioButtonIncredibleBoy.Checked)
            {
                formGame.player = new Player(radioButtonIncredibleBoy.Text, 10, 100, radioButtonIncredibleBoy.BackgroundImage, 12, 300, labelDescription.Text, 0);
                formGame.player.SetWeapon("Rock", "It's a heavy giant rock", Properties.Resources.weapon_rock);
            }
            else
            {
                formGame.player = new Player(radioButtonPerfectaGirl.Text, 10, 100, radioButtonPerfectaGirl.BackgroundImage, 12, 300, labelDescription.Text, 0);
                formGame.player.SetWeapon("Fireball", "It's a hot bluish flame", Properties.Resources.weapon_fireball);
            }
            //Start Game
            formGame.StartNewGame();
            this.Close();
        }

        private void FormSelectPlayer_Load(object sender, EventArgs e)
        {
            formGame = (FormGame)this.Owner;
        }
    }
}

