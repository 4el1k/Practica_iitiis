using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaratoryWorkNum34
{
    public class ColorCMY
    {
        readonly double cyan;
        readonly double magenta;
        readonly double yellow;

        public double Cyan { get { return cyan; } }


        public double Magenta { get { return magenta; } }

        public double Yellow { get { return yellow; } }

        public double Red { get; private set; }
        public double Green { get; private set; }
        public double Blue { get; private set; }


        private ColorCMY(double cyan, double magenta, double yellow)
        {
            if (cyan >= 0 && cyan <= 1)
            {
                this.cyan = cyan;
            }
            else
            {
                throw new ArgumentException("value red in interval [0,1]");
            }

            if (magenta >= 0 && magenta <= 1)
            {
                this.magenta = magenta;
            }
            else
            {
                throw new ArgumentException("value green in interval [0,1]");
            }

            if (yellow >= 0 && yellow <= 1)
            {
                this.yellow = yellow;
            }
            else
            {
                throw new ArgumentException("value red in interval [0,1]");
            }
            Red = 1 - cyan; Green = 1 - magenta; Blue = 1 - yellow;
        }


        public ColorCMY() : this(0, 0, 0)
        {
        }

        public static ColorCMY ColorInRGB(double cyan, double magenta, double yellow)
        {
            return new ColorCMY(1 - cyan, 1 - magenta, 1 - yellow);
        }
        public static ColorCMY ColorInCMY(double cyan, double magenta, double yellow)
        {
            return new ColorCMY(cyan, magenta, yellow);
        }

        public static ColorCMY operator +(ColorCMY color1, ColorCMY color2)
        {
            return new ColorCMY(color1.Cyan + color2.Cyan, color1.Magenta + color2.Magenta, color1.Yellow + color2.Yellow);
        }

        public static ColorCMY operator -(ColorCMY color1, ColorCMY color2)
        {
            return new ColorCMY(color1.Cyan - color2.Cyan, color1.Magenta - color2.Magenta, color1.Yellow - color2.Yellow);
        }

        public override string ToString()
        {
            return $"RGB({Red}/{Green}/{Blue}) " +
                $"CMY({Cyan}/{Magenta}/{Yellow})";
        }
    }
}
