using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuggestedToDo
{
    internal class Book
    {
        private string title  { get; set; }
        private string author { get; set; }
        private int pages  { get; set; }
        public Book(string title, string author, int pages)
        {
            this.title = title;
            this.author = author;
            this.pages = pages; 
        }

        public void PrintNumPages()
        {
            Console.WriteLine($"The book currently has : {pages} pages");
        }

        public Book CutPage()
        {
            pages -= 1;
            return this;
        }

    }
}
