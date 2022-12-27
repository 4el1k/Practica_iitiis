using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport
{
    internal class AirPlane : ITransport
    {   
        public AirPlane(int maxSpeed, int transportSpeed, string cityFrom, string cityTo)
        {
            MaxSpeed = maxSpeed;
            TransportSpeed = transportSpeed;
            CityFrom = cityFrom;
            CityTo = cityTo;
        }
        public string CityFrom { get; private set; }
        public string CityTo { get; private set; }
        public int MaxSpeed { get; set; }
        public int TransportSpeed { get; set; }
        public void SpeedDown()
        {
            if (TransportSpeed - 20 < 0)
            {
                throw new ArgumentException("Скорость транспорта не может быть меньше нуля");
            }
            TransportSpeed -= 20;
        }
        
        public void SpeedUp()
        {
            TransportSpeed += 20;
        }
        public override string ToString()
        {
            return $"AirLpane go from {CityFrom} to {CityTo}. Current speed: {TransportSpeed}, maximal speed: {MaxSpeed}";
        }
    }
}
