using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport
{
    interface ITransport
    {
        int MaxSpeed { get; protected set; }
        int TransportSpeed { get; protected set; }
        void SpeedUp(); 
        void SpeedDown();
    }
}
