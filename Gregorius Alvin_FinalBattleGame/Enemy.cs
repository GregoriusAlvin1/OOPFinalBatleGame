using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gregorius_Alvin_FinalBattleGame
{
    public class Enemy : GameActor
    {
        #region Data member
        private int speed;
        #endregion
        #region Constructor
        public Enemy(string name, int life, int health, PictureBox picture,int speed):base(name,life, health, picture)
        {
            this.Speed = speed;
        }
        #endregion
        #region Properties
        public int Speed { get => speed; set => speed = value; }
        #endregion
        #region Method

        #endregion
    }
}