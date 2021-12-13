using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gregorius_Alvin_FinalBattleGame
{
    public class Player : GameActor
    {
        #region Data member
        private string description;
        private int score;
        private Weapon weapon; //composition
        #endregion

        #region Constructor
        public Player(string name, int life, int health, Image picture, int x, int y, string description, int score):base(name, life, health, picture, x, y)
        {
            this.Description = description;
            this.Score = score;
        }
        #endregion

        #region Properties
        public string Description { get => description; set => description = value; }
        public int Score { get => score; set => score = value; }
        public Weapon Weapon { get => weapon; set => weapon = value; }
        #endregion

        #region Method
        public override string Display()
        {
            string data = base.DisplayGameActor() + "\nSCORE : " + this.Score + "\nWEAPON : " + this.Weapon.Name;
            return data;
        }

        public void SetWeapon(string name, string description, Image picture)
        {
            this.Weapon = new Weapon(name, description, picture);
        }

        //method untuk mengubah score dan health enemy waktu player berhasil menembak enemy
        public void DefeatEnemy(Enemy enemy)
        {
            if (enemy is Monster)
            {
                int damage = (int)(0.5 * enemy.Health);
                enemy.Health -= damage;
                this.Score += 100;

                if (damage == 0)
                {
                    enemy.Health = 0;
                }
                
            }
            else if (enemy is Witch)
            {
                //gunakan down casting untuk mengakses data yang hanya ada di child
                enemy.Health -= ((Witch)enemy).HealthDamage;
                this.Score += (50 * ((Witch)enemy).HealthDamage);
            }

            //jika health mencapai 0% maka kurangi life
            if (enemy.Health == 0)
            {
                enemy.Life--;
                enemy.Health = 100;
            }

            if (enemy.Life == 0)
            {
                //jika musuh yang berhasil dilahkan adalah witch maka player akan terkena health damage
                if (enemy is Witch && enemy.Name == "THE BROOM")
                {
                    base.Health -= (int)(0.1 * base.Health);
                }
                else if (enemy is Witch && enemy.Name == "DANCING WITCH")
                {
                    base.Health -= (int)(0.2 * base.Health);
                }
                else if (enemy is Witch && enemy.Name == "GREEN WITCH")
                {
                    base.Health -= (int)(0.5 * base.Health);
                }
            }
        }
        #endregion
    }
}