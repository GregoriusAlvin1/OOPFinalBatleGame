using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gregorius_Alvin_FinalBattleGame
{
    public abstract class GameActor
    {
        #region Data member
        private string name;
        private int life;
        private int health;
        private PictureBox picture; //composition
        #endregion

        #region Constructor
        public GameActor(string name, int life, int health, Image picture, int x, int y)
        {
            this.Name = name;
            this.Life = life;
            this.Health = health;
            this.Picture = new PictureBox();
            this.Picture.Image = picture;
            this.Picture.Size = new Size(100, 100);
            this.Picture.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Picture.Location = new Point(x, y);
            this.Picture.BackColor = Color.Transparent;
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
        public abstract string Display();

        protected string DisplayGameActor()
        {
            string data = this.Name + "\nHealth : " + this.Health + " % Life : " + this.Life;
            return data;
        }

        public virtual void DisplayPicture(Control container)
        {
            this.Picture.Parent = container;
            this.Picture.BringToFront();
        }

        public void MoveUP(int distance)
        {
            int x = this.Picture.Location.X;
            int newY = this.Picture.Location.Y - distance;
            this.Picture.Location = new Point(x, newY);
        }

        public void MoveDown(int distance)
        {
            int x = this.Picture.Location.X;
            int newY = this.Picture.Location.Y + distance;
            this.Picture.Location = new Point(x, newY);
        }
        #endregion
    }
}