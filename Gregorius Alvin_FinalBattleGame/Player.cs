using System;
using System.Collections.Generic;
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
        public Player(string name, int life, int health, PictureBox picture,string description, int score, Weapon weapon):base(name, life, health, picture)
        {
            this.Description = description;
            this.Score = score;
            this.Weapon = weapon;
        }
        #endregion

        #region Properties
        public string Description { get => description; set => description = value; }
        public int Score { get => score; set => score = value; }
        public Weapon Weapon { get => weapon; set => weapon = value; }
        #endregion
        #region Method

        #endregion


    }
}