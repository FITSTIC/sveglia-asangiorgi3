using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sveglia.Core
{
    class Program
    {
        static void Main(string[] args)
        {
            IAlarmClock sveglia = new AlarmClock();

            sveglia.PowerOn();
            sveglia.Time = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            sveglia.AlarmTime = new DateTime(2017, 10, 10, 8, 0, 0)
                .ToString("dd/MM/yyyy HH:mm:ss");

            Console.WriteLine("Premi un tasto per terminare... ");
            Console.ReadLine();

            sveglia.PowerOff();
        }
    }

    internal class AlarmClock : IAlarmClock
    {
        private string alarmtime;
        private string time;
        private Timer timer;
        private IClock clock;

        public AlarmClock()
        {
            clock = new Clock();
            
        }

        private void timerClick(object state)
        {
            DateTime t = DateTime.Parse(this.time);
            int h = t.Hour;
            int m = t.Minute;
            int s = t.Second;
            clock.SetTime(h,m,s);

            t = t.AddSeconds(1);

            this.time = t.ToString("dd/MM/yyyy HH:mm:ss");
        }

        public string Time
        {
            set
            {
                time = value;
                timer = new Timer(timerClick, null, 0, 1000);
            }
        }
        public string AlarmTime { set => alarmtime = value; }

        public bool IsTime(int h, int m)
        {
            throw new NotImplementedException();
        }

        public void PowerOff()
        {
            
        }

        public void PowerOn()
        {
            
        }
    }

    
}
