using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed
{
    internal class RemoteControlCar
    {
        internal int speed {  get; set; }
        internal int batteryDrain { get; set; }
        private int distanceDriven { get; set; }
        private int battery = 100;

        public RemoteControlCar(int speed,int batteryDrain)
        {
            this.speed = speed;
            this.batteryDrain = batteryDrain;

        }
               
        public void Drive()
        {
            if (battery >= batteryDrain)
            {
                distanceDriven += speed;
                battery -= batteryDrain;
            }
        }
         


        public int DistanceDriven()
        {
            return distanceDriven;
        }

        public bool BatteryDrained()
        {
            if (battery <= 0)
                return true;
            else
                return false;
        }

        public static RemoteControlCar Nitro()
        {
            return new RemoteControlCar(50, 4);
        }




    }
}
