using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gregorius_Alvin_FinalBattleGame
{
    public class elianTime
    {
        private int hour;
        private int minute;
        private int second;

        #region Constructor

        //Parameterized Constructor
        public elianTime(int pHour, int pMinute, int pSecond)
        {
            this.Hour = pHour;
            this.Minute = pMinute;
            this.second = pSecond;
        }

        #endregion 

        #region Properties
        public int Hour 
        { 
            get => hour;
            set 
            {
                if (value >= 0 && value < 24)
                {
                    hour = value; 
                }
                else
                {
                    throw new Exception("Please enter the number range correctly!");
                }
            }
        }

        public int Minute 
        {
            get => minute;
            set
            {
                if (value >= 0 && value < 60)
                {
                    minute = value;
                }
                else
                {
                    throw new Exception("Please enter the number range correctly!");
                }
            }
        }

        public int Second 
        { 
            get => second;
            set 
            {
                if (value >= 0 && value < 60)
                {
                    second = value;
                }
                else
                {
                    throw new Exception("Please enter the number range correctly!");
                }
            } 
        }
        #endregion

        #region Method
        public string Display()
        {
            string data = this.Hour.ToString().PadLeft(2, '0') + ":" + this.Minute.ToString().PadLeft(2, '0') +
                ":" + this.Second.ToString().PadLeft(2, '0');
            return data;
        }

        public int ConvertToSec()
        {
            int totalSec = (this.Hour * 3600) + (this.Minute * 60) + this.Second;
            return totalSec;
        }

        public void Add(int secToAdd)
        {
            int totalSec = this.ConvertToSec();
            int totalSecondCurrentTime = totalSec + secToAdd;
            this.Hour = totalSecondCurrentTime / 3600;
            this.Minute = (totalSecondCurrentTime % 3600) / 60;
            this.Second = (totalSecondCurrentTime % 3600) % 60;
        }
        #endregion 
    }
}