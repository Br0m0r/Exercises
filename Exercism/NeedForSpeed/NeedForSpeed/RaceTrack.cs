using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed
{
    internal class RaceTrack
    {
        private int distance {  get; set; }

        public RaceTrack(int distance)
        {
            this.distance = distance;
        }

        public bool TryFinishTrack(RemoteControlCar car)
        {
            while (!car.BatteryDrained())
            {
                car.Drive();
            }
            return car.DistanceDriven() >= distance;
        }
    }
}
