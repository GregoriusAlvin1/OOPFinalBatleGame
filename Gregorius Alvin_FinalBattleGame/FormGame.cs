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
    public partial class FormGame : Form
    {
        public FormGame()
        {
            InitializeComponent();
        }
        elianTime time;
        public Player player;

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void startNewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSelectPlayer form = new FormSelectPlayer();
            form.Owner = this;
            form.ShowDialog();
        }

        private void FormGame_Load(object sender, EventArgs e)
        {
            panelPlayer.Visible = false;
            panelTime.Visible = false;
            panelEnemy.Visible = false;

            this.KeyPreview = true;
        }

        public void StartNewGame()
        {
            //Enable Panel
            panelPlayer.Visible = true;
            panelTime.Visible = true;
            panelEnemy.Visible = true;

            //Display Time
            time = new elianTime(0, 10, 0);
            timerGame.Interval = 1000;
            timerGame.Start();

            //Display Picture
            player.DisplayPicture(this);

            //Player Info
            labelPlayerInfo.Text = player.Display(); 
        }

        private void timerGame_Tick(object sender, EventArgs e)
        {
            time.Add(-1);
            labelTime.Text = time.Display();
        }

        private void FormGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                player.MoveUP(10);
                player.DisplayPicture(this);
            }
            else if (e.KeyCode == Keys.S)
            {
                player.MoveDown(10);
                player.DisplayPicture(this);
            }
        }
    }
}
