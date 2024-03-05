using System.Runtime.CompilerServices;
using System;
using System.Diagnostics;
using System.Runtime.Intrinsics.X86;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;















#region EX1(CONSTRUCTOR)
/*
Exercise 1: Constructors
Scenario: Create a Book class that must always have a title and author at the time of its creation. 
Use a constructor to ensure these properties are set.

Task:
-Define a Book class with properties Title and Author.

-Create a constructor for the Book class
 that accepts title and author as parameters and sets the corresponding properties.

-Instantiate a Book object with the title "1984" and author "George Orwell".
*/
#endregion
#region EX1 (CONSTRUCTOR SOLUTION)
/*
namespace Exercise1
{

    public class Book
    {
        public string title  { get; set; }
        public string author { get; set; }

        public Book(string title, string author)
        {
            this.title = title;
            this.author = author;
        }



    }

    class program
    {
        static void Main()
        {
            Book book = new Book("1984", "George Orwell");
            Console.WriteLine($"The books name is '{book.title}' and the author is '{book.author}'");
        }
    }
}





*/
#endregion

#region EX1 (OBJECT INITIALIZER)
/*
Exercise 1 (Revised for Object Initializers)
Scenario: Implement a Book class with properties for Title and Author. 
Instead of using a constructor to ensure these properties are set at the time of creation,
use object initializers to set these properties.

Task:

-Define a Book class with Title and Author as properties.

-Create instances of the Book class using object initializers, 
 setting the Title and Author for each instance.

-Demonstrate creating two Book instances with different titles and authors 
 using object initializers, and print out their details to verify the properties 
 were set correctly.
*/
#endregion region
#region EX1 (OBJ.INIT.SOLUTION)

namespace EX1
    
{
    public class Book
    {
        internal string title { get; set; }
        internal string author { get; set; }


    }

    public class Program
    {
        static void Main()
        {
            Book num1 = new Book()
            {
               title = "Harry Potter and the chamber of secrets",
               author = "J.K.Rowling"
            };

            Book num2 = new Book()
            {
                title = "the man who would be free"
            };


            Console.WriteLine($"The first book is called : {num1.title} and its author is : {num1.author}");
            Console.WriteLine($"The second book is called : {num2.title} and its author is : {(string.IsNullOrEmpty(num2.author) ? "unknown" :num2.author )}");
        }

    }
}

#endregion

#region EX1(METHODS)
/*
 Exercise 1 (Revised for Methods)

 Scenario: Design a Book class where Title and Author can be set after the object
 is created. Use methods to set these properties
 instead of setting them directly or using a constructor.

 Task:

-Define a Book class with Title and Author as properties. Include private setters 
 to enforce encapsulation.

-Implement methods in the Book class to set the Title and Author.These methods 
 should validate the input to ensure that neither Title nor Author
 is set to a null or empty string.

-Instantiate a Book object, then use the methods to set its Title and Author.
 Demonstrate this with at least one Book instance, a
 and print the book's details to ensure the methods work as expected.
*/
#endregion
#region EX1(METHODS SOLUTION)
/*
namespace Ex1M
{
    public class Book
    {
        private string title;
        private string author;

        public string Title
        {
            get { return title; }
            private set { title = value; }
        }

        public string Author
        {
            get { return author; }
            private set { author = value; }
        }

        public void TitleSet(string NameOfTitle)
        {
            if (string.IsNullOrWhiteSpace(NameOfTitle))
            {

                throw new ArgumentNullException("Invalid");
            }
            else
            {
                Title = NameOfTitle;
                Console.WriteLine($"Book's title is {NameOfTitle}");
               
            }

        }
        public void AuthorSet(string NameOfAuthor)
        {
            if (string.IsNullOrWhiteSpace(NameOfAuthor))
            {

                throw new ArgumentNullException("Invalid");
            }
            else
            {
                Author = NameOfAuthor;
                Console.WriteLine($"Book's author is {NameOfAuthor}");

            }

        }
    }
    class Program
    {
        static void Main()
        {
            Book book1 = new Book();
            book1.TitleSet("Naruto");
            book1.AuthorSet("Dont Remember");
            Book book2 = new Book();
            book2.TitleSet("One piece");
            book2.AuthorSet("Eichiro oda");
                
                
            
            



        }
    }



}
*/

#endregion


#region EX2 (OBJECT INITIALIZER)
/*
Exercise 2: Object Initializers
Scenario: Design a Vehicle class where the color and the number of wheels are optional properties
that may or may not be set at the time of object creation.

Task:

-Define a Vehicle class with properties Color and NumberOfWheels.

-Use object initializer syntax to create a Vehicle object. 

-Set the Color to "Red" but leave NumberOfWheels unset.

-Create another Vehicle object, this time setting both Color to "Blue" and NumberOfWheels to 4.
*/
#endregion
#region EX2(OBJ.INIT. SOLUTION)
/*
namespace Exercise2
    
{
    public class Vehicle
    {
        public string Color { get; set; }
        public int? NumberOfWheels { get; set; } //int is null here so it can be left unset
                         
    }

    public class Program
    {
        static void Main()
        {
            Vehicle car = new Vehicle { Color = "Red" };
            Vehicle car2 = new Vehicle { Color = "Blue", NumberOfWheels = 4 };
            // Console.WriteLine($"Vehicle number 1 color is {car.Color}.");
            // Console.WriteLine($"Vehicle number 2  color is {car2.Color} and it has {car2.NumberOfWheels} wheels");
            Console.WriteLine($"Vehicle 1: Color = {car.Color}, Number of Wheels = {(car.NumberOfWheels.HasValue ? car.NumberOfWheels.ToString() : "Not Set")}");
            Console.WriteLine($"Vehicle 2: Color = {car2.Color}, Number of Wheels = {car2.NumberOfWheels}");
        }


    }


    
}
    */
#endregion


#region EX3(METHODS)
/*
Exercise 3: Methods
Scenario: Implement a Student class where the GPA(Grade Point Average) can be updated 
after the object is created, but it must always be within the range 0.0 to 4.0.

Task:

-Define a Student class with a property GPA.

-Add a method SetGPA(double gpa) to the Student class that checks if the gpa is within
 the 0.0 to 4.0 range before setting it. If the gpa is outside this range, 
 it should not update the property and optionally print a message indicating the error.

-Instantiate a Student object and use the SetGPA method to set the GPA to 3.5.
 Try setting the GPA again with a value outside the valid range to test the validation logic.
*/
#endregion
#region EX3 (METHODS SOLUTION)
/*
namespace Exercise3
{
    public class Student
    {
        // Private field to hold the GPA value
        private double gpa;

        // Property to access the GPA. Note: Set is private to enforce the use of SetGPA method
        public double GPA
        {
            get { return gpa; }
            private set { gpa = value; }
        }
        // Method to set the GPA with validation
        public void SetGPA(double value)
        {
            if (value >= 0.0 && value <= 4.0)
            {
                GPA = value;
                Console.WriteLine($"GPA successfully set to: {GPA}");
            }
            else
            {
                Console.WriteLine("Invalid GPA. Please enter a value between 0.0 and 4.0.");
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate a Student object
            Student student = new Student();

            // Set the GPA to 3.5 using the SetGPA method
            student.SetGPA(3.5);

            // Attempt to set the GPA to an invalid value
            student.SetGPA(4.5);
        }
    }
}
*/
#endregion


#region EX4(CONSTRUCTORS)
/*
 Exercise 4: Constructors
Scenario: Create a Person class that must always have a Name and Age at the time of its creation.
Use a constructor to ensure these properties are set and validate that Age is a positive number.

Task:

-Define a Person class with properties Name (string) and Age (int).

-Create a constructor for the Person class that accepts name and age as parameters,
 validates that age is positive, and sets the corresponding properties.

-Instantiate a Person object with the name "Alice" and age 30.
*/
#endregion
#region EX4 (CONSTRUCTORS SOLUTION)
/*
namespace Exercise4
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {

            Name = name;
            Age = age;
            if (age <= 0)
            {
                throw new ArgumentException("Age must be positive.", nameof(age));
            }


        }
    }

    class Program
    {

        static void Main()
        {
            Person Alice = new Person("Alice",29);
            Console.WriteLine($"Hello my name is {Alice.Name} and i am {Alice.Age} years old");


        }



    }

}
*/
#endregion


#region EX5 (OBJ.INIT)
/*
Exercise 5: Object Initializers
Scenario: Design a Product class with properties for Name, Price, and Category. 
The Price should be a non-negative number,
but the validation will be simplified for the sake of focusing on object initializers.

Task:

-Define a Product class with properties Name(string), Price(decimal), and Category(string).

-Use object initializer syntax to create 
 a Product object named "Laptop", priced at 999.99, and categorized under "Electronics".

-Create another Product object named "Coffee", priced at 3.99, without setting the Category.
*/
#endregion
#region EX5 (OBJ.INIT SOLUTION)
/*
namespace Exercise5
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }

    }

    class Program
    {
        static void Main()
        {
            Product Laptop = new Product()
            {
                Name = "Laptop",
                Price = 999.99,
                Category = "Electronics"
            };
            Product Coffee = new Product()
            {
                Name = "Coffee",
                Price = 3.99
            };

            Console.WriteLine($"Product 1:{Laptop.Name} is worth {Laptop.Price} and is categorized as {Laptop.Category}");
            Console.WriteLine($"Product 2:{Coffee.Name} is worth {Coffee.Price}.Its category is {(string.IsNullOrEmpty(Coffee.Category) ? "Not Set" : Coffee.Category)}");
        }
    }
}

*/
#endregion


#region EX6 (METHODS)
/*
Exercise 6: Methods

Scenario: Implement an Account class where the balance can be updated 
through deposits and withdrawals. The balance cannot go below 0.

Task:

-Define an Account class with a private property Balance(decimal).

-Add methods Deposit(decimal amount) and Withdraw(decimal amount) to the Account class
 that update the Balance. Ensure that Withdraw does not allow the balance to go below 0
 and prints a message if the withdrawal cannot be processed due to insufficient funds.

-Instantiate an Account object, deposit 100.00 into it,
 and then attempt to withdraw 50.00. Try another withdrawal
 that would exceed the balance to test the validation.
*/
#endregion
#region EX6 (METHODS SOLUTION)
/*
namespace Exercise6
    
{
    public class Account
    {
        private double balance;

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public void Withdraw(double amount)
        {
            if (amount > balance || balance == 0)
            {
                Console.WriteLine("Insufficient funds");
            }
            else
            {
                Balance -= amount;
                Console.WriteLine($"You successfuly withdrew the amount of {amount}");
                Console.WriteLine($"You balance is {balance}");
            }
        }

        public void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine($"You sucessfuly deposited {amount} to your account");
            Console.WriteLine($"You balance is {balance}");

        }
        
    }

    public class Program
    {
        static void Main()
        {
            Account bankAcc = new Account();
            bankAcc.Withdraw(200);
            bankAcc.Deposit(1234);
            bankAcc.Withdraw(200);
        }
    }
}   

*/
#endregion





