using System;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;
using System.Timers;

namespace HanshasinkeiTEST
{
    public class Trainer
    {
        private TimeSpan BestTime;
        public static Color AreaColor;
        public static Color NextColor = Color.Yellow;
        private Stopwatch Timekeeper;
        private System.Timers.Timer ColorChangeTimekeeper;
        private readonly Random RandGen = new Random();
        private readonly PictureBox Area;

        public Trainer(PictureBox Area)
        {
            this.Area = Area;
        }

        public void BlackArea()
        {
            AreaColor = Color.Black;
            Area.BackColor = Color.Black;
        }

        public void YellowArea()
        {
            AreaColor = NextColor;
            Area.BackColor = AreaColor;
        }
        //public void PinkArea() //Pink色に切替
        //{
        //    AreaColor = Color.Pink;
        //    Area.BackColor = AreaColor;
        //}

        public void StartCounting()
        {
            Timekeeper = new Stopwatch();
            ColorChangeTimekeeper = new System.Timers.Timer();
            ColorChangeTimekeeper.Interval = RandGen.Next(5000,10000);
            ColorChangeTimekeeper.Elapsed += new ElapsedEventHandler(TimerTick);
            ColorChangeTimekeeper.Enabled = true;
        }
        public void StopCounting()
        {
            Timekeeper.Stop();
            ColorChangeTimekeeper.Enabled =false;
        }

        public TimeSpan GetBestTime()
        {
            BestTime = Timekeeper.Elapsed;
            return BestTime;
        }

        public Color GetAreaColor()
        {
            return AreaColor;
        }

        private void TimerTick(object a, ElapsedEventArgs b)
        {
            YellowArea();
            Timekeeper.Start();
        }
        public void ClearScore()
        {
            BestTime = new TimeSpan(0, 0, 0, 0, 0);
            Timekeeper = new Stopwatch();
        }
    }
}
