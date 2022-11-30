using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaratoryWorkNum34
{
    public class ColorRGB
    {
        readonly double red;
        readonly double green;
        readonly double blue;

        public double Red
        {
            get { return red; }
        }

        public double Green { get { return green; } }

        public double Blue { get { return blue; } }

        public double Cyan { get; private set; }
        public double Magenta { get; private set; }
        public double Yellow { get; private set; }


        private ColorRGB(double red, double green, double blue)
        {

            if (red >= 0 && red <= 1)
            {
                this.red = red;
            }
            else
            {
                throw new ArgumentException("value red in interval [0,1]");
            }

            if (green >= 0 && green <= 1)
            {
                this.green = green;
            }
            else
            {
                throw new ArgumentException("value green in interval [0,1]");
            }
            
            if (blue >= 0 && blue <= 1)
            {
                this.blue = blue;
            }
            else
            {
                throw new ArgumentException("value red in interval [0,1]");
            }
            Cyan = 1 - red; Magenta = 1 - green; Yellow = 1 - blue;
        }

        public ColorRGB() : this(0, 0, 0)
        {
        }

        public static ColorRGB ColorInRGB(double red, double green, double blue)
        {
            return new ColorRGB(red, green, blue);
        }
        public static ColorRGB ColorInCMY(double cyan, double magenta, double yellow)
        {
            return new ColorRGB(1 - cyan, 1 - magenta, 1 - yellow);
        }

        public static ColorRGB operator +(ColorRGB color1, ColorRGB color2)
        {
            return new ColorRGB(color1.Red + color2.Red, color1.Green + color2.Green, color1.Blue + color2.Blue);
        }

        public static ColorRGB operator -(ColorRGB color1, ColorRGB color2)
        {
            return new ColorRGB(color1.Red - color2.Red, color1.Green - color2.Green, color1.Blue - color2.Blue);
        }

        public override string ToString()
        {
            return $"RGB({red}/{green}/{blue}) CMY({Cyan}/{Magenta}/{Yellow})";
        }
    }
}
