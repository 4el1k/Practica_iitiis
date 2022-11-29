using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_oop_practica_
{

    //исправил сеттеры в свойствах Hour, Minute, Second
    //подправил коструктор Time
    public class Time
    {
        private int hour, minute, second;

        public int Hour
        {
            get { return hour; }
            set
            {
                if (value>=0)
                {
                    if (value > 23)
                    {
                        hour = value % 24;
                    }
                    else
                    {
                        hour = value;
                    }
                    
                }
                else
                {
                    throw new ArgumentException("часы не могут быть отрицательными");
                }
            }
        }
        public int Minute
        {
            get { return minute; }
            set
            {
                if (value >= 0)
                {
                    if (value>59)
                    {
                        hour += minute / 60;
                        minute = value % 60;
                    }
                    else
                    {
                        minute = value;
                    }
                }
                else
                {
                    throw new ArgumentException("минуты не могут быть отрицательными");
                }
            }
        }
        public int Second
        {
            get { return second; }
            set
            {
                if (value >= 0)
                {
                    if (value>59)
                    {
                        minute += value / 60;
                        second = value % 60;
                    }
                    else
                    {
                        second = value;
                    }
                    
                }
                else
                {
                    throw new ArgumentException("секунды не могут быть отрицательными");
                }
            }
        }

        public Time(int h, int m, int s)
        {
            int[] times = FromSeconds(InSeconds(h, m, s));
            Hour = times[0];
            Minute = times[1];
            Second = times[2];

        }
        public Time() : this(0, 0, 0)
        {
        }
        private static int[] FromSeconds(int seconds)
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
        public static int InSeconds(int hours, int minutes, int seconds)
        {
            return hours * 3600 + minutes * 60 + seconds;
        }

        

        public static bool operator !=(Time t1, Time t2)
        {
            return !(t1.Hour == t2.Hour && t1.Minute == t2.Minute && t1.Second == t2.Second);
        }
        public static bool operator ==(Time t1, Time t2)
        {
            return InSeconds(t1.Hour, t1.Minute, t1.Second) == InSeconds(t2.Hour, t2.Minute, t2.Second);
        }
        public static bool operator <=(Time t1, Time t2)
        {
            return InSeconds(t1.Hour, t1.Minute, t1.Second) <= InSeconds(t2.Hour, t2.Minute, t2.Second);                
        }

        public static bool operator >=(Time t1, Time t2)
        {
            return InSeconds(t1.Hour, t1.Minute, t1.Second) >= InSeconds(t2.Hour, t2.Minute, t2.Second);
        }

        public static bool operator <(Time t1, Time t2)
        {
            return InSeconds(t1.Hour, t1.Minute, t1.Second) < InSeconds(t2.Hour, t2.Minute, t2.Second);
        }

        
        public static bool operator >(Time t1, Time t2)
        {
            return InSeconds(t1.Hour, t1.Minute, t1.Second) > InSeconds(t2.Hour, t2.Minute, t2.Second);
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
