using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gregorius_Alvin_FinalBattleGame
{
    public class GameActor
    {
        #region Data member
        private string name;
        private int life;
        private int health;
        private PictureBox picture;
        #endregion
        #region Constructor
        public GameActor(string name, int life, int health, PictureBox picture)
        {
            this.Name = name;
            this.Life = life;
            this.Health = health;
            this.Picture = picture;
        }
        #endregion
        #region Properties
        public string Name { get => name; set => name = value; }
        public int Life 
        { 
            get => life;
            set
            {
                if (value >= 0)
                    life = value;
                else
                    life = 0;
            }
        }
        public int Health 
        { 
            get => health;
            set 
            {
                if (value >= 0 && value <= 100)
                    health = value;
                else if (value < 0)
                    health = 0;
                else if (value > 100)
                    health = 0;
            }
        }
        public PictureBox Picture { get => picture; set => picture = value; }
        #endregion
        #region Method

        #endregion





    }
}