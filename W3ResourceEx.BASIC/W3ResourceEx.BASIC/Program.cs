using System.Diagnostics.CodeAnalysis;


#region Exercise 1
string Fname = "Memos";
string Lname = "Foteinopoulos";
Console.WriteLine($"Hello,our majestic overlord {Fname}  {Lname}!");
Console.WriteLine("");
#endregion

#region Exercise 2
double p1 = 10;
double p2 = 20;
Console.WriteLine($"the sum of p1 and p2 is: {p1 + p2}");
Console.WriteLine("");
#endregion

#region Exercise 3
Console.WriteLine($"the div of p1 and p2 is:{p1 / p2}");
Console.WriteLine("");
#endregion

#region Exercise 6
Console.WriteLine("Please enter 3 numbers :");
int N1;
int N2;
int N3;

int.TryParse(Console.ReadLine(), out N1);
int.TryParse(Console.ReadLine(), out N2);
int.TryParse(Console.ReadLine(), out N3);


Console.WriteLine($"The multiplication result is: {N1 * N2 * N3}");
Console.WriteLine("");
#endregion 

#region Exercise 8
Console.WriteLine($"Please enter(for once more)a value: ");
int N4;
int.TryParse(Console.ReadLine(), out N4);
Console.WriteLine($"Here is the multiplication table of {N4}");
for (var i = 0; i <= 10; i++)
{
    Console.WriteLine($"{i} times {N4} is :{i * N4}");
}
#endregion

#region exercise 9
Console.WriteLine("I will also not ask for input again and shall show thee the the average of previously inputed numbers");
Console.WriteLine($"the average of {N1} {N2} {N3} {N4} is {(N1 + N2 + N3 + N4) / 4}");
#endregion