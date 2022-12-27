using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrackt
{
    abstract class Vehical
    {
        protected double TSpeed;
        protected double maxSpeed;

        public Vehical(double TSpeed, double maxSpeed)
        {
            this.TSpeed = TSpeed;
            this.maxSpeed = maxSpeed;
        }
        public abstract void SpeedUp();
        public abstract void SpeedDown();

    }
}