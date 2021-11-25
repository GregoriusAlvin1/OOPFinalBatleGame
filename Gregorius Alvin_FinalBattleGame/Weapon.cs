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
            this.Picture.Size = new Size(30, 30);
            this.Picture.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Picture.BackColor = Color.Transparent;
        }
        #endregion

        #region Properties
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public PictureBox Picture { get => picture; set => picture = value; }
        #endregion

        #region Method
        public void DisplayPicture(Control container)
        {
            this.Picture.Parent = container;
            this.Picture.BringToFront();
        }

        public void MoveRight(int distance)
        {
            int newX = this.Picture.Location.X + distance;
            int y = this.Picture.Location.Y;
            this.Picture.Location = new Point(newX, y);
        }
        #endregion
    }
}