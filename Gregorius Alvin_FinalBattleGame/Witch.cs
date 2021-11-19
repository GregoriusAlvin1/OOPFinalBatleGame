using System;
using System.Collections.Generic;
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
        public Witch(string name, int life, int health, PictureBox picture, int speed, int healthDamage):base(name, life, health, picture, speed)
        {
            this.HealthDamage = healthDamage;
        }
        #endregion

        #region Properties
        public int HealthDamage { get => healthDamage; set => healthDamage = value; }
        #endregion

        #region Method

        #endregion
    }
}