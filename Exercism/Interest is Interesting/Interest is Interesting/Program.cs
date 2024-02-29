namespace Exercise
{
    class SavingsAccount
    {
        static double InterestRate(double balance = 200.75)
        {
            if (balance < 0)
            {
                return 3.213;
            }
            else if (balance < 1000 && balance >= 0)
            {
                return 0.5;
            }
            else if (balance >= 1000 && balance < 5000)
            {
                return 1.621;
            }
            else
            {
                return 2.475;
            }

        }

        static decimal Interest(double balance = 200.75)
        {
           double result = balance * InterestRate(balance) / 100;
            return (decimal)result;
        }

        static decimal AnnualBalanceUpdate(double balance = 200.75)
        {
            return Interest(balance) + (decimal)balance;
        }

        static int YearsBeforeDesiredBalance(double balance = 200.75, double DesiredBalance = 250.75)
        {
            int counter = 0;
            decimal balance2 = (decimal)balance;
            decimal DesiredBalance2 = (decimal)DesiredBalance;
            do
            {

                balance2 += Interest((double)balance2);
                counter += 1;


            }
            while (balance2 <= DesiredBalance2);
            return counter;
        }

       
    }


}