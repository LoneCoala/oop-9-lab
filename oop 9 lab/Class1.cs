using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_9_lab
{
    public class Time
    {
        public int hour = 0;
        public int minutes = 0;
        public Time() { hour = 0;  minutes = 0; }

        //public int Min(Time _a)
        //{
        //    int p;
        //    p = _a.hour * 60 + _a.minutes;
        //    return p;
        //}

        //public Time FreeTime(Time _a, Time _b)
        //{
        //    int p1, p2, p;
        //    p1 = Min(_a);
        //    p2 = Min(_b);
        //    p = p2 - p1;
        //    Time o = new Time();
        //    o.hour = p / 60;
        //    o.minutes = p % 60;
        //    return o;
        //}
    };

}
