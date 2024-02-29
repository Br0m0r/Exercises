namespace Exercise
{
    class AssemblyLine
    {
        
        public static double SuccessRate(int speed)
        {
            
            if (speed == 0)
            {
                return 0.0;
            }
            else if (speed >= 1 && speed <= 4)
            {
                return 1.0;
            }
            else if (speed >= 5 && speed <= 8)
            {
                return 0.9;
            }
            else if (speed == 9)
            {
                return 0.8;
            }
            else 
            {
                return 0.77;
            }
        }

        public static double ProductionRatePerHour(int speed)
        {
            int CarsPerHour = 221 * speed;
            return SuccessRate(speed) * CarsPerHour;  
        }


        public static int WorkingItemsPerMinute(int speed)
        {
            int CarsPerHour = 221 * speed;
            int CarsPerMinute = CarsPerHour / 60;
            double ToConvert = CarsPerMinute * SuccessRate(speed);
            int ToReturn = (int)ToConvert;
            return ToReturn;
        }


        static void Main()
        {

        }
        

    }
}