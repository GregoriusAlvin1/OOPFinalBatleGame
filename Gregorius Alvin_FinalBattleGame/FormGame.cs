using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

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
        Enemy enemy;
        bool arahAtas = true;
        WindowsMediaPlayer mediaPlayerGame;
        WindowsMediaPlayer mediaPlayerHit;
        WindowsMediaPlayer mediaPlayerWeapon;
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void startNewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSelectPlayer formSelectPlayer = new FormSelectPlayer();
            formSelectPlayer.Owner = this;
            formSelectPlayer.ShowDialog();
        }

        private void FormGame_Load(object sender, EventArgs e)
        {
            //putar sound
            mediaPlayerGame = new WindowsMediaPlayer();
            mediaPlayerGame.URL = Application.StartupPath + "\\sound_game.mp3";
            mediaPlayerGame.controls.play();

            panelPlayer.Visible = false;
            panelTime.Visible = false;
            panelEnemy.Visible = false;

            this.KeyPreview = true;

            //Anti flicker
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
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

            if (enemy != null)
            {
                enemy.Remove(); //hapus pictureBox player
                enemy = null;
            }

            timerEnemy.Stop();

            //EnemyInfo
            CreateEnemy();

            //atur kecepatan timer agar sesuai speed enemy
            timerEnemy.Interval = enemy.Speed;

            //gerakan enemy
            timerEnemy.Start();
        }

        private void CreateEnemy()
        {
            //random type enemy
            Random randomType = new Random();
            int hasilRandomType = randomType.Next(2);
            if (hasilRandomType == 0)
            {
                //create enemy type monster
                //random lagi monster yang muncul (dragon/godzilla/red monster)
                Random randomMonster = new Random();
                int hasilRandomMonster = randomMonster.Next(3);
                if (hasilRandomMonster == 0)
                {
                    enemy = new Monster("DRAGON", 3, 100, Properties.Resources.monster_dragon, 430, 300, 100, "Only the heat can defeat me");
                }
                else if (hasilRandomMonster == 1)
                {
                    enemy = new Monster("GODZILLA", 5, 100, Properties.Resources.monster_godzilla, 430, 300, 30, "Really can't help the hard stuff on me");
                }
                else if (hasilRandomMonster == 2)
                {
                    enemy = new Monster("RED MONSTER", 7, 100, Properties.Resources.monster_red, 430, 300, 150, "Ouch.. no sharp item please..");
                }
            }
            else if (hasilRandomType == 1)
            {
                //create enemy type witch
                //random lagi witch yang muncul (the broom, dancing witch, green witch)
                Random randomWitch = new Random();
                int hasilRandomWitch = randomWitch.Next(3);
                if (hasilRandomWitch == 0)
                {
                    enemy = new Witch("THE BROOM", 1, 100, Properties.Resources.witch_broom, 430, 300, 100, 10);
                }
                else if (hasilRandomWitch == 1)
                {
                    enemy = new Witch("DANCING WITCH", 2, 100, Properties.Resources.witch_dancing, 430, 300, 150, 20);
                }
                else if (hasilRandomWitch == 2)
                {
                    enemy = new Witch("GREEN WITCH", 1, 100, Properties.Resources.witch_green, 430, 300, 200, 50);
                }
            }
            enemy.Picture.Size = new Size(80, 80);

            labelEnemyInfo.Text = enemy.Display();
            enemy.DisplayPicture(this);
        } 

        private void timerGame_Tick(object sender, EventArgs e)
        {
            time.Add(-1);
            labelTime.Text = time.Display();

            if (time.Hour == 0 && time.Minute == 0 && time.Second == 0)
            {
                GameOver();
                MessageBox.Show("Game over ! Time is up");
            }
        }

        private void FormGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                if (player.Picture.Location.Y >= this.panelPlayer.Height + 50)
                {
                    player.MoveUP(10);
                    player.DisplayPicture(this);
                }
            }
            else if (e.KeyCode == Keys.S)
            {
                if (player.Picture.Location.Y + player.Picture.Height + 50 <= this.Height)
                {
                    player.MoveDown(10);
                    player.DisplayPicture(this);
                }
            }
            else if (e.KeyCode == Keys.Space)
            {
                //play souund effect jika menembak
                mediaPlayerWeapon = new WindowsMediaPlayer();
                mediaPlayerWeapon.URL = Application.StartupPath + "\\sound_weapon.mp3";
                mediaPlayerWeapon.controls.play();
                //atur posisi awal weapon sama dengan player
                int x = player.Picture.Location.X + 70;
                int y = player.Picture.Location.Y + 20;
                player.Weapon.Picture.Location = new Point(x, y);
                
                player.Weapon.Picture.Visible = true;
                //menembakkan weapon (start timer weapon)
                timerWeapon.Start();
            }
        }

        private void linkLabelSelectWeapon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Menonaktifkan timer weapon
            timerWeapon.Stop();

            FormSelectWeapon formSelectWeapon = new FormSelectWeapon();
            formSelectWeapon.Owner = this;
            formSelectWeapon.ShowDialog();
        }

        private void GameOver()
        {
            panelEnemy.Visible = false;
            panelPlayer.Visible = false;
            panelTime.Visible = false;
            player.Remove();
            enemy.Remove();
            timerEnemy.Stop();
            timerGame.Stop();
            timerWeapon.Stop();
        }
        private void timerWeapon_Tick(object sender, EventArgs e)
        {
            //Menggerakan weapon dari kiri ke kanan
            player.Weapon.MoveRight(50);
            //tampilkan gambar weapon
            player.Weapon.DisplayPicture(this);

            //Cek apakah weapon player mengenai enemy
            if (player.Weapon.Picture.Bounds.IntersectsWith(enemy.Picture.Bounds) == true)
            {
                //cek apakah weapon yang digunakan benar
                if ((enemy is Monster && enemy.Name == "DRAGON" && player.Weapon.Name == "FIREBALL") || 
                        (enemy is Monster && enemy.Name == "GODZILLA" && player.Weapon.Name == "ROCK") ||
                        (enemy is Monster && enemy.Name == "RED MONSTER" && player.Weapon.Name == "KNIFE") ||
                        (enemy is Witch && player.Weapon.Name == "KNIFE"))
                {
                    //play sound effect
                    mediaPlayerHit = new WindowsMediaPlayer();
                    mediaPlayerHit.URL = Application.StartupPath + "\\sound_hit.mp3";
                    mediaPlayerHit.controls.play();

                    //panggil method untuk mengurangi health dan menambah skor
                    player.DefeatEnemy(enemy);

                    //tampilkan data player dan enemy
                    labelPlayerInfo.Text = player.Display();
                    labelEnemyInfo.Text = enemy.Display();

                    //set visible dari pictureBox weapon menjadi false
                    player.Weapon.Picture.Visible = false;
                    
                    timerWeapon.Stop();

                    if (enemy.Life == 0)
                    {
                        timerEnemy.Stop();
                        timerWeapon.Stop();

                        MessageBox.Show("Congratulation! You win the game");

                        GameOver();
                    }
                }
            }
        }

        private void timerEnemy_Tick(object sender, EventArgs e)
        {
            //Menggerakkan enemy ke atas ke bawah
            if (arahAtas == true)
            {
                enemy.MoveUP(10);
            }
            else
            {
                enemy.MoveDown(10);
            }

            enemy.DisplayPicture(this);

            if (enemy.Picture.Location.Y <= panelEnemy.Height + 50)
            {
                arahAtas = false;
            }
            else if (enemy.Picture.Location.Y + enemy.Picture.Height + 50 >= this.Height)
            {
                arahAtas = true;
            }
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerEnemy.Stop();
            timerGame.Stop();
            mediaPlayerGame.controls.pause();

            continueToolStripMenuItem.Visible = true;
        }

        private void continueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerEnemy.Start();
            timerGame.Start();
            mediaPlayerGame.controls.play();

            continueToolStripMenuItem.Visible = false;
        }
    }
}
