using Exercise_3;


public class Test
{
  public static void Main()
    {
        Console.WriteLine("Please enter a name for the dog");
        helper.Dog newDog = new helper.Dog();
        newDog.name = Console.ReadLine();
        Console.WriteLine($"The dogs name is {newDog.name}");
        newDog.Eat();
        newDog.GetName();


    }
   



}
