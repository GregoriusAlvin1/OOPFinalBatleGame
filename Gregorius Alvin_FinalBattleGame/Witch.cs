using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gregorius_Alvin_FinalBattleGame
{
    public class Witch : Enemy
    {
        #region Data member
        private int healthDamage;
        #endregion

        #region Constructor
        public Witch(string name, int life, int health, Image picture, int x, int y, int speed, int healthDamage) : base(name, life, health, picture, x, y, speed)
        {
            this.HealthDamage = healthDamage;
        }
        #endregion

        #region Properties
        public int HealthDamage { get => healthDamage; set => healthDamage = value; }
        #endregion

        #region Method
        public override string Display()
        {
            string data = base.Display() + "\nHealth Damage : " + this.HealthDamage + " %";
            return data;
        }
        #endregion
    }
}