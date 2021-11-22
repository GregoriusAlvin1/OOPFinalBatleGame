using System;
using System.Collections.Generic;
using System.Drawing;
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
        public Enemy(string name, int life, int health, Image picture, int x, int y, int speed) : base (name,life, health, picture, x, y)
        {
            this.Speed = speed;
        }
        #endregion

        #region Properties
        public int Speed { get => speed; set => speed = value; }
        #endregion

        #region Method
        public override string Display()
        {
            string data = base.DisplayGameActor() + "\nSpeed : " + this.Speed;
            return data;
        }
        #endregion
    }
}