using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherintance
{
    internal class Car : Vehical
    {

        public string ToCity { get; set; }
        public string FromCity { get; set; }

        public Car(double TSpeed, double maxSpeed, string ToCity, string FromCity) : base(TSpeed, maxSpeed)
        {
            this.ToCity = ToCity;
            this.FromCity = FromCity;
        }
        public override void SpeedDown()
        {
            TSpeed -= 5;
        }
        public override void SpeedUp()
        {
            TSpeed += 5;
        }
        public override string ToString()
        {
            return $"{maxSpeed}, {TSpeed}, {ToCity}, {FromCity}";
        }
    }
}