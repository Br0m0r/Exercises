using SuggestedToDo;

namespace Exercise
{
    public class Program
    {
        static void Main(string[] args)
        {
           Book book = new Book("MyFartDiary","SuperiorBenignOverlord",100);
           book.PrintNumPages();
           Console.WriteLine("");
           book.CutPage();
           book.PrintNumPages();
           Console.WriteLine();
           book.CutPage().PrintNumPages();



        }
    }
}