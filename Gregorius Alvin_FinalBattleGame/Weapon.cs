using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gregorius_Alvin_FinalBattleGame
{
    public class Weapon
    {
        #region Data member
        private string name;
        private string description;
        private PictureBox picture; //composition
        #endregion

        #region Constructor
        public Weapon(string name, string description, Image picture)
        {
            this.Name = name;
            this.Description = description;
            this.Picture = new PictureBox();
            this.Picture.Image = picture;
        }
        #endregion

        #region Properties
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public PictureBox Picture { get => picture; set => picture = value; }
        #endregion

        #region Method

        #endregion
    }
}