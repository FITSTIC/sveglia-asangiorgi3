using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sveglia.Core
{
    interface IDisplay
    {
        void ShowTime(int h, int m, int s);
    }
}
