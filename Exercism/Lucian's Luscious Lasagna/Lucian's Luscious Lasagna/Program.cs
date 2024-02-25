namespace Exercise
{
    public class Lasagna
    {
        public int ExpectedMinutesInOven()
        {
            return 40;

        }

        public int RemainingMinutesInOven(int minutes)
        {
            return 40 - minutes;
        }

        public int PreparationTimeInMinutes(int layers)
        {
            return layers * 2;
        }

        public int ElapsedTimeInMinutes(int layers,int minutes)
        {
            return PreparationTimeInMinutes(layers) + 40 - RemainingMinutesInOven(minutes);
        }




        static void Main()
        {
             
            var lasagna = new Lasagna();
            Console.WriteLine($"Expected time : {lasagna.ExpectedMinutesInOven()}");
            Console.WriteLine($"Remaining minutes in oven : {lasagna.RemainingMinutesInOven(10)}");
            Console.WriteLine($"Preparation time : {lasagna.PreparationTimeInMinutes(14)}");
            Console.WriteLine($"Elapsed time  : {lasagna.ElapsedTimeInMinutes(14,20)}");

        }



    }
    

}