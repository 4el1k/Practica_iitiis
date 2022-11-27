using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_oop_practica_
{
    public class Time
    {
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }

        public Time(int h, int m, int s)
        {
            Hour = FromSeconds(InSeconds(h, m, s))[0];
            Minute = FromSeconds(InSeconds(h, m, s))[1];
            Second = FromSeconds(InSeconds(h, m, s))[2];

        }
        private int[] FromSeconds(int seconds)
        {
            int hours, minutes;
            minutes = seconds / 60;
            seconds %= 60;
            hours = minutes / 60;
            minutes %= 60;
            if (hours > 23)
            {
                hours %= 24;
            }
            return new int[] { hours, minutes, seconds };
        }
        public int InSeconds(int hours, int minutes, int seconds)
        {
            return hours * 3600 + minutes * 60 + seconds;
        }

        

        public static bool operator !=(Time t1, Time t2)
        {
            return t1.Hour != t2.Hour && t1.Minute != t2.Minute && t1.Second != t2.Second;
        }
        public static bool operator ==(Time t1, Time t2)
        {
            return t1.Hour == t2.Hour && t1.Minute == t2.Minute && t1.Second == t2.Second;
        }
        public static bool operator <=(Time t1, Time t2)
        {
            if (t1.Minute==t2.Minute && t1.Second==t2.Second && t1.Hour==t2.Hour)
            {
                return true;
            }
            return t1 < t2;
        }

        public static bool operator >=(Time t1, Time t2)
        {
            if (t1.Minute == t2.Minute && t1.Second == t2.Second && t1.Hour == t2.Hour)
            {
                return true;
            }
            return t1 > t2;
        }

        public static bool operator <(Time t1, Time t2)
        {
            if (t1.Hour==t2.Hour)
            {
                if (t2.Minute == t1.Minute)
                {
                    return t1.Second < t2.Second;
                }
                return t1.Minute < t2.Minute;
            }
            return t1.Hour < t1.Hour;
        }

        
        public static bool operator >(Time t1, Time t2)
        {
            if (t1.Hour == t2.Hour)
            {
                if (t2.Minute == t1.Minute)
                {
                    return t1.Second > t2.Second;
                }
                return t1.Minute > t2.Minute;
            }
            return t1.Hour > t1.Hour;
        }


        public static Time operator+(Time t1, Time t2)
        {
            return new Time(t1.Hour+t2.Hour, t1.Minute+t2.Minute, t1.Second+t2.Second);
        }

        public static Time operator -(Time t1, Time t2)
        {
            if (t1>=t2)
            {
                return new Time(t1.Hour - t2.Hour, t1.Minute - t2.Minute, t1.Second - t2.Second);
            }
            throw new ArgumentException("Дорогой пользователь, Вы не можете получать отрицательное время," +
                "поэтому будьте так добры, не вычитайте из меньшего время большее");
        }
        public static Time operator *(Time t1, int k)
        {
            return new Time(k*t1.Hour, k*t1.Minute, k*t1.Second);
        }
        public static Time operator /(Time t1, int k)
        {
            return new Time(k / t1.Hour, k / t1.Minute, k / t1.Second);
        }
        public override string ToString()
        {
            return $"{string.Format("{0:d2}", Hour)}:{string.Format("{0:d2}", Minute)}:{string.Format("{0:d2}", Second)}"; ;
        }

    }
}
