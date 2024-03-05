using System;
using System.Linq;

class StringExamples
{
    static void Main()
    {
        /*
        string myString = "Hello, World! Programming is fun.";

        // Length
        Console.WriteLine($"Length: {myString.Length}"); // Output: Length of the string

        // Substring
        Console.WriteLine(myString.Substring(7, 5)); // Output: "World"

        // IndexOf
        Console.WriteLine(myString.IndexOf('W')); // Output: 7

        // LastIndexOf
        Console.WriteLine(myString.LastIndexOf('i')); // Output: Index of last 'i'

        // Replace
        Console.WriteLine(myString.Replace("World", "C#")); // Output: "Hello, C#! Programming is fun."

        // ToLower / ToUpper
        Console.WriteLine(myString.ToLower()); // Output: string in lowercase
        Console.WriteLine(myString.ToUpper()); // Output: string in uppercase

        // Trim
        string spaceyString = "  Hello, World!  ";
        Console.WriteLine($"'{spaceyString.Trim()}'"); // Output: "Hello, World!" without leading/trailing spaces

        // StartsWith / EndsWith
        Console.WriteLine(myString.StartsWith("Hello")); // Output: True
        Console.WriteLine(myString.EndsWith("fun.")); // Output: True

        // Split
        string[] words = myString.Split(' ');
        foreach (var word in words)
        {
            Console.WriteLine(word);
        }

        // String.Concat
        string greeting = String.Concat("Hello", ", ", "World!");
        Console.WriteLine(greeting); // Output: "Hello, World!"

        // String.Join
        string[] items = { "Apples", "Oranges", "Bananas" };
        string itemList = String.Join("; ", items);
        Console.WriteLine(itemList); // Output: "Apples; Oranges; Bananas"

        // String.IsNullOrEmpty / String.IsNullOrWhiteSpace
        string emptyString = "";
        Console.WriteLine(String.IsNullOrEmpty(emptyString)); // Output: True
        string whiteSpaceString = "   ";
        Console.WriteLine(String.IsNullOrWhiteSpace(whiteSpaceString)); // Output: True
        */






        /*
        Exercise 1: Basic String Formatting
        Create a string variable that contains your first and last name separated by a space. 
        Then, write a program to print them in reverse order.
        

        string str = "Ben Dover";
        string str2 = (str.Substring(str.IndexOf("D"),5));
        string str3 = (str.Substring(str.IndexOf("B"),4 ));
        Console.WriteLine(str2 +" "+ str3);



        //SUGGESTED
        string STR = "Ben Dover";
        string[] parts = STR.Split(' ');
        string reversedName = parts[1] + " " + parts[0];
        Console.WriteLine(reversedName);
        */






        /*
        Exercise 2: Counting Characters
        Given a string, count how many times the letter 'a' appears in it.
        

        string strA = "Alakazam";
        int count = strA.Count(n => n == 'a'||n == 'A' );
        Console.WriteLine(count);
        */




        /*
        Exercise 3: Palindrome Checker
        Write a method that checks if a given string is a palindrome
        (a word, phrase, or sequence that reads the same backward as forward, e.g., "madam").
        

        
        string pal = Console.ReadLine();
        char[] Pal = pal.ToCharArray();
        Console.WriteLine(Pal);
        Array.Reverse(Pal);
        Console.WriteLine(Pal);
        string pal2 = new string(Pal);
        if (pal == pal2)
        {
            Console.WriteLine("They are palindromes");
        }
        else
        {
            Console.WriteLine("They are not palindromes");
        }


        

        //SUGGESTED
        string pal = Console.ReadLine();
        char[] PalArray = pal.ToCharArray();
        Array.Reverse(PalArray);
        string palReversed = new string(PalArray);

        if (pal.Equals(palReversed, StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("They are palindromes");
        }
        else
        {
            Console.WriteLine("They are not palindromes");
        }

        */





        /*
        Exercise 4: Extracting Substrings
        Given a sentence, extract the first word. Assume words are separated by spaces.
        

        string str = "This is a whole sentence";
        string str2 = str.Substring(0, 4);
        Console.WriteLine(str2);



        //SUGGESTED
        string str = "This is a whole sentence";
        int firstSpaceIndex = str.IndexOf(' ');
        if (firstSpaceIndex != -1) // Check if a space was found
        {
            string firstWord = str.Substring(0, firstSpaceIndex);
            Console.WriteLine(firstWord);
        }
        else
        {
            Console.WriteLine(str); // In case there's only one word, print the entire string
        }
        */






        /*
        Exercise 5: Replacing Substrings
        Given a string, replace all instances of the word "C#" with "CSharp".
        

        string str = "C# is pretty cool.I like C#";
        string str2 = str.Replace("C#", "CSharp");
        Console.WriteLine(str2);
        */




        /*
        Exercise 6: String to Array and Back
        Convert a comma-separated string into an array of strings. 
        Then, convert it back to a string with semicolons separating the items.
        

        string str = "I like games,programming,Ai,music,guitars";
        string[] ArStr = str.Split(',');
        string join = String.Join(";",ArStr);
        Console.WriteLine(join);
        */






        /*
        Exercise 7: Case Conversion
        Given a string, convert it to title case (the first letter of each word is capitalized).
        

        //SUGGESTED
        string str = "I am studying";
        var titleCase = string.Join(" ", str.Split(' ')
                                        .Select(word => word.Length > 0
                                        ? char.ToUpper(word[0]) + word.Substring(1).ToLower()
                                        : word));
        Console.WriteLine(titleCase);
        */





        /*
        Exercise 8: Validating Input
        Write a program that checks if a user input is not empty and does not contain 
        only white spaces.
        

        string str = "This is not null or empty";
        Console.WriteLine(str);
        bool isNull = String.IsNullOrEmpty(str);
        Console.WriteLine(isNull);
        bool isEmpty = String.IsNullOrWhiteSpace(str);
        Console.WriteLine(isEmpty);
        */


        /*
        Exercise 9: Custom Split Function
        Implement your own version of the Split method. Given a string and a delimiter character, 
        return an array of substrings.
        
        
        string str = "This is a very big string and i need to split it";
        char delimiter = ' '; // Splitting by space character
        string[] result = CustomSplit(str, delimiter);

        foreach (var substring in result)
        {
            Console.WriteLine(substring);
        }
        //not something i would think of
        */





        /*
        Exercise 10: Concatenating Names
        Write a program that takes two strings (first name and last name) and
        concatenates them into a full name with a space between them. Make sure
        the first letter of each name is uppercase, and the rest are lowercase,
        regardless of the input case.
        */



        /*
        Bonus Challenge: String Compression
        Implement a string compression function that converts a sequence of characters into a 
        shortened form by replacing consecutive duplicate characters with the character 
        followed by the count of duplicates. For example, "aabcccccaaa" would become "a2b1c5a3". 
        If the "compressed" string would not become smaller than the original string,
        your function should return the original string.
        */


    }
   // not something i would think of
   /*
    static string[] CustomSplit(string input, char delimiter)
    {
        List<string> substrings = new List<string>();
        string currentSubstring = "";

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == delimiter)
            {
                if (!string.IsNullOrEmpty(currentSubstring))
                {
                    substrings.Add(currentSubstring);
                    currentSubstring = ""; // Reset for the next substring
                }
            }
            else
            {
                currentSubstring += input[i];
            }
        }

        // Add the last substring if it's not empty
        if (!string.IsNullOrEmpty(currentSubstring))
        {
            substrings.Add(currentSubstring);
        }

        return substrings.ToArray();
    }
   */
}
