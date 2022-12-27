using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport
{
    internal class Ship : ITransport
    {
        public Ship(int maxSpeed, int transportSpeed, string townFrom, string townTo)
        {
            MaxSpeed = maxSpeed;
            TransportSpeed = transportSpeed;
            TownFrom = townFrom;
            TownTo = townTo;
        }

        public int MaxSpeed { get; set; }
        public int TransportSpeed { get; set; }
        public string TownFrom { get; set; }
        public string TownTo { get; set; }
        public void SpeedDown()
        {
            if (TransportSpeed - 1 < 0)
            {
                throw new ArgumentException("Скорость транспорта не может быть меньше нуля");
            }
            TransportSpeed -= 1;
        }

        public void SpeedUp()
        {
            TransportSpeed += 1;
        }

        public override string ToString()
        {
            return $"Ship go from {TownFrom} to {TownTo}. Current speed: {TransportSpeed}, maximal speed: {MaxSpeed}";
        }
    }
}
