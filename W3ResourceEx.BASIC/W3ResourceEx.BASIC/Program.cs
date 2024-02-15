using System.Diagnostics.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;


#region Exercise 1 / string interpolation
/*
string Fname = "Memos";
string Lname = "Foteinopoulos";
Console.WriteLine($"Hello,our majestic overlord {Fname}  {Lname}!");
Console.WriteLine("");
*/
#endregion

#region Exercise 2 / sum
/*
double p1 = 10;
double p2 = 20;
Console.WriteLine($"the sum of p1 and p2 is: {p1 + p2}");
Console.WriteLine("");*/
#endregion

#region Exercise 3 / div
/*
Console.WriteLine($"the div of p1 and p2 is:{p1 / p2}");
Console.WriteLine("");
*/
#endregion

#region Exercise 6 / mult
/*
Console.WriteLine("Please enter 3 numbers :");
int N1;
int N2;
int N3;

int.TryParse(Console.ReadLine(), out N1);
int.TryParse(Console.ReadLine(), out N2);
int.TryParse(Console.ReadLine(), out N3);


Console.WriteLine($"The multiplication result is: {N1 * N2 * N3}");
Console.WriteLine("");
*/
#endregion 

#region Exercise 8 / TryParse read input  / for loop
/*
Console.WriteLine($"Please enter(for once more)a value: ");
int N4;
int.TryParse(Console.ReadLine(), out N4);
Console.WriteLine($"Here is the multiplication table of {N4}");
for (var i = 0; i <= 10; i++)
{
    Console.WriteLine($"{i} times {N4} is :{i * N4}");
}
*/
#endregion

#region exercise 9 / average
/*
Console.WriteLine("I will also not ask for input again and shall show thee the the average of previously inputed numbers");
Console.WriteLine($"the average of {N1} {N2} {N3} {N4} is {(N1 + N2 + N3 + N4) / 4}");
*/
#endregion

#region exercise 11
/*
int age;
Console.WriteLine("Please enter your age");
int.TryParse(Console.ReadLine(), out age);
Console.WriteLine($"You look older than {age}");56
*/
#endregion

#region exercise 12
/*
Console.WriteLine("Enter a number");
string str = Console.ReadLine();
Console.WriteLine($"{str} {str} {str} {str}  ");
Console.WriteLine($"{str}{str}{str}{str} ");
Console.WriteLine("{0} {0} {0} {0}",str);
*/
#endregion

#region exercise 14 / celcius to fahrenheit
/*
int C;
Console.WriteLine("Please enter Celsius degrees to convert ");
int.TryParse(Console.ReadLine(),out C);
Console.WriteLine($"For {C} Celsius degrees,Fahrenheit equals to {C*1.8 + 32}");
*/
#endregion

#region exercise 15 str.Remove
/*
string str1 = "w3resource";
string str2 = str1.Remove(1,1); //removes the char at index 1 ,for 1 char length
Console.WriteLine(str2);
string str3 = str2.Remove(str2.Length-1,1);//removes the last char,without refering to index directly
Console.WriteLine(str3);
*/
#endregion

#region exercise 16 .ToCharArray() /  .Join
/*
string str = "w3Resource";
char[] array = str.ToCharArray();
char temp = array[0];
array[0] = array[array.Length-1];
array[array.Length-1] = temp;

string str2 = string.Join("",array); //potential way of safe convertion ???dont know...
Console.WriteLine(str2);
Console.WriteLine(array);
*/
#endregion

#region exercise 17 .Substring
/*
Console.WriteLine("Write something here");
string str = Console.ReadLine();
if (str.Length >= 1)
{
string str2 = str.Remove(1); //Suggested Solution was with str.Substring method
Console.WriteLine(str2 + str + str2);
}
else
{
Console.WriteLine("Not valid input");
}
*/
#endregion

#region exercise 18
/*
int ps;
int ng;
Console.WriteLine("Enter a positive number ");
int.TryParse(Console.ReadLine(),out ps);
Console.WriteLine("Enter a negative number ");
int.TryParse(Console.ReadLine(),out ng);
Console.WriteLine($"Is ps positive: {ps>0} ,is ng negative: {ng<0}"); 
Console.WriteLine($"Are both statements true : {ps > 0  && ng < 0 }");
*/



#endregion

#region Exercise 19
/*
public class Ex19
{
    
 public static int Sum(int a,int b)
 { 
   if (a != b)
   {
     return a+b;
     
   }
   else 
   {
    return (a+b)*3;
   }
 }

 public static void Main()
 {
   int A;
   int B; 
  Console.WriteLine("Give me 1 number");
  int.TryParse(Console.ReadLine(),out A);
  Console.WriteLine("Give me 1 more!");
  int.TryParse(Console.ReadLine(),out B);
  Console.WriteLine($"Here is your result : {Sum(A,B)}\nIf numbers  were same ,the sum was tripled"); 
  

 }




}
*/
#endregion


#region Exercise 20 / Math.Abs()
/*
public class Absolute
{
  public static int absol(int a,int  b)
  {
    if (a <= b)
    {
        return     Math.Abs(a-b);
    }
    else
    {
        return 2 * Math.Abs(a-b);
    }
  }
  public static void Main()
  {
     int A;
     int B;
     Console.WriteLine("Gimme one number");
     int.TryParse(Console.ReadLine(),out A);
     Console.WriteLine("Gimme one more");
     int.TryParse(Console.ReadLine(),out B);
     Console.WriteLine($"Absolute value of the difference between the two given numbers is: {absol(A,B)}\nIf first number was bigger than the second,the result was doubled");

  }








}
*/


#endregion

#region Exercise 22  / bool


/*
public class Check
{
    public static bool checker(int x)
    {
      if (x <= 120 &&  x >= 80 || x >= 180 && x <= 220) 
      {
        return true;
      }
      else
      {
        return false;
      }

    }
   public static void Main()
   {
   Console.WriteLine("Give me a number for once more");
   int v;
   int.TryParse(Console.ReadLine(),out v);
   Console.WriteLine($"Is the given number within the suggested range: {checker(v)}");
   }

    
}
*/
#endregion

#region Exercise 23 / .ToString  / .ToLower
/*
Console.WriteLine("Write a sentence here to convert to lowercase");
var str = Console.ReadLine();
string str2 = str.ToString();
string str3 = str2.ToLower();
Console.WriteLine(str3);
*/
#endregion



