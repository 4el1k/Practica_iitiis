using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport
{
    internal class Car : ITransport
    {
        public Car(int maxSpeed, int transportSpeed)
        {
            MaxSpeed = maxSpeed;
            TransportSpeed = transportSpeed;
        }
        public int MaxSpeed { get; set; }
        public int TransportSpeed { get; set; }
        public void SpeedDown()
        {
            if (TransportSpeed - 5 < 0)
            {
                throw new ArgumentException("Скорость транспорта не может быть меньше нуля");
            }
            TransportSpeed -= 5;
        }
        public void SpeedUp()
        {
            TransportSpeed += 5;
        }

        public override string ToString()
        {
            return $"Car current speed: {TransportSpeed}, maximal speed: {MaxSpeed}";
        }
    }
}
