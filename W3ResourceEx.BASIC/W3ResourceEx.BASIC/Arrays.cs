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



#region Exercise 6 dublicates
/*
class countUniq
{
    static void Main()
    {              
        int[] array ={1,3,6,8,2,3,4};
        int counter;

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
            if (counter == 1)
             {
                Console.WriteLine(array[i] + " appears " + counter + " time ");
             }
            
        }
    }
}
*/
#endregion

#region Exercise 7 merge array
/*
class Merge
{
    static void Main()
    {  
        int[] ar1 = {1,3,6};
        int[] ar2 = {5,9,2};
        int[] merged = new int[ar1.Length + ar2.Length];  
        Array.Copy(ar1,merged,ar1.Length);
        Array.Copy(ar2,0,merged,ar1.Length,ar2.Length);
        Array.Sort(merged);
        string str = string.Join(" "+"\n",merged);
        Console.WriteLine(str);      
       
       
    }
}
*/
#endregion


#region Exercise 9 show min and max value in array
/*
class MinMax
{
  static void Main()
  {
    int min;
    int max;
    int[] array = new int[40] ;
    Random r = new Random();
    for (int i = 0;i < array.Length; i++)
    {
        array[i] = r.Next(1,99);
        Console.WriteLine($"Number {i} in the array is {array[i]}");
    }
    Array.Sort(array);
    Console.WriteLine($"the smallest number in the array is {array[0]} and the biggest is {array[array.Length-1]}");




  }



}
*/
#endregion


#region Exercise 10  seperate odd and even
/*
class OddEven
{
  static void Main()
  {
    int even = 0;
    int odd = 0;
    int[] array = new int[40] ;
    int[] ar1 = new int[40];
    int[] ar2 = new int[40];
    Random r = new Random();
    for (int i = 0;i < array.Length; i++)
        {
            array[i] = r.Next(1,99);
            if ( array[i] % 2 == 0 )
            {
                even ++;
                ar1[i] = array[i];
                
            }
            else
            {
                odd  ++;
                ar2[i] = array[i];
                
            }
            
        }  
    Console.WriteLine($"odds are {odd} and even are {even}");
    string str = string.Join(" "+"\n",ar1);
    string str2 = string.Join(" "+"\n",ar2);
    Console.WriteLine($"This is the array of odds: {str2}\n and this is the array of even:\n {str}");

  }
}
*/
#endregion

#region Exercise 13 array resize 
/*
class ArrayEnlarge
{
    static void Main()
    {
       int[] array = [4,7,9];
       Array.Resize(ref array,array.Length + 1);
       array[array.Length-1] = 10;
       foreach (int i in array)  //i can also show input like this
       {
        Console.WriteLine(i);
       }

 
    }
}

*/
#endregion

#region Exercise 
    
#endregion

#region Exercise 
    
#endregion

#region Exercise 
    
#endregion