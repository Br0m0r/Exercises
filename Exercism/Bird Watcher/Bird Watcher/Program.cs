using System;
using System.Linq;


namespace Exercise
{
    public class BirdCount
    {
        public static int[] lastW = { 0, 2, 5, 3, 7, 8, 4 };
        public static int[] birdsPerDay = { 2, 5, 0, 7, 4, 1 };
        public   int[] LastWeek()
        {
           
            return lastW;
        }

        public int Today()
        {
            
            return birdsPerDay[birdsPerDay.Length - 1];

        }

        public void IncrementTodaysCount()
        {
            birdsPerDay[birdsPerDay.Length - 1] += 1;
        }

        public  bool HasDayWithoutBirds()
        {
            for (int i = 0; i < birdsPerDay.Length; i++)
            {
                if (birdsPerDay[i] == 0)
                {
                   Console.WriteLine("There were no birds today;");
                   return true;
                }
               
            }
            Console.WriteLine("There were some birds seen today");
            return false;

        }

        public int CountForFirstDays(int UpTo)
        {
            int count = 0;
            for (int i = 0; i < UpTo;i++)
            {
                count += birdsPerDay[i];

            }
            return count;

        }

        public int BusyDays()
        {
            int busydays = 0;

            for (int i = 0; i < birdsPerDay.Length; i++)
            {
                if (birdsPerDay[i] >= 5)
                {
                    busydays += 1;    

                }

            }
            return busydays;


        }

        static void Main()
        {
            BirdCount bird = new BirdCount();
            int dayCount = 1;
            foreach (int i in bird.LastWeek())
            {
                Console.WriteLine($"Number of birds seen on Day {dayCount++} : {i}");
            }
            Console.WriteLine($"Todays bird count is : {bird.Today()}");
            bird.IncrementTodaysCount();
            Console.WriteLine($"I saw 1 more bird.Todays count is: {bird.Today()}");
            bird.HasDayWithoutBirds();
            
            Console.WriteLine($"The number of birds seen up  to day 4 is {bird.CountForFirstDays(4)}");
            Console.WriteLine($"Number of busy days were {bird.BusyDays()}");

            


        }




    }





}