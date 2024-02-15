using System.Diagnostics.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Text;






#region Exercise 1 && 2 together /store elements show them/reverse array
/*
int[] array =new int[10];
for (int i = 0;i<array.Length;i++)
{
    int a;
    Console.WriteLine("enter a number");
    int.TryParse(Console.ReadLine(),out a);
    array[i] = a;
}


//Console.WriteLine($"Here is your array: {array}");//big mistake i made,should instead print array[i] on seperate loop
Console.WriteLine("here are your numbers");
for (int i = 0;i< 10;i++)
{
    Console.WriteLine(array[i]);
}

Console.WriteLine("here are your numbers reversed");
Array.Reverse(array);
for (int i = 0;i< 10;i++)
{
    Console.WriteLine(array[i]);
}
*/
#endregion

#region Exercise 3 /Array.Copy
/*
int[] array = new int[4];
int sum = 0;
for (int i = 0;i<array.Length;i++)
{
   Console.WriteLine("enter a number");
   array[i] = Convert.ToInt32(Console.ReadLine());
   sum += array[i];
}
Console.WriteLine($"Here is your sum : {sum}");
*/
#endregion

#region Exercise 4
/*
int[] array = [1,2,4,5,6];
int[] array2 = new int[5];
Array.Copy(array,0,array2,0,5);
for (int i = 0;i < array2.Length;i++)
{
    Console.WriteLine(array2[i]);
}

*/
#endregion


#region Exercise 5 count duplicates
/*
class countDub
{
    static void Main()
    {              
        int[] array ={1,3,6,8,2,3,4};
        int counter = 0;
        for (int i = 0; i < array.Length; i++)
        {
            counter = 0;
            for (int I = 0; I < array.Length ; I++)
            {

               if(array[i] == array[I])
               {
                  counter ++;
               }
            }
            Console.WriteLine(array[i] + " appears " + counter + " time(s) ");
            
        }
    }
}

*/
#endregion



#region Exercise 


#endregion