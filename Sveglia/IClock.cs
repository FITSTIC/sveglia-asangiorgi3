using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sveglia.Core
{
    public interface IClock
    {
        void TurnOn();
        void SetAlarm(int h, int m, int s);
        void SetTime(int h, int m, int s);
        void TurnOff();
    }

    internal class Clock : IClock
    {
        private IDisplay display;
        public Clock()
        {
            display = new Display();
        }
        public void SetAlarm(int h, int m, int s)
        {
            throw new NotImplementedException();
        }

        public void SetTime(int h, int m, int s)
        {
            this.display.ShowTime(h, m, s);
        }

        public void TurnOff()
        {
            throw new NotImplementedException();
        }

        public void TurnOn()
        {
            throw new NotImplementedException();
        }
    }

    internal class Display : IDisplay
    {
        public void ShowTime(int h, int m, int s)
        {
            Console.WriteLine(string.Format("{0}:{1}:{2}", h, m, s));
        }
    }
}
