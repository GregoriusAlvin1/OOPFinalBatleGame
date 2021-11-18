using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gregorius_Alvin_FinalBattleGame
{
    public class Monster : Enemy
    {
        

        

        
        #region Data member
        private string hint;
        #endregion
        #region Constructor
        public Monster(string name, int life, int health, PictureBox picture, int speed,string hint):base(name, life, health,picture, speed)
        {
            this.Hint = hint;
        }
        #endregion
        #region Properties
        public string Hint { get => hint; set => hint = value; }
        #endregion
        #region Method

        #endregion
    }
}