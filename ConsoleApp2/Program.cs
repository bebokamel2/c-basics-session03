using System.Text;

namespace ConsoleApp2
{
    internal class Program
    {

        static void PrintFirstBook(params string[] books)
        {
            if (books == null ) return;
        }
        static void Main(string[] args)
        {
            // q1
            string? name = "clean code";
            string? upperTitle = name.ToUpper();
            Console.WriteLine($" name is {name.ToUpper()} and the title is {upperTitle}");

            // Q2
            string anthorName = "clean code ";
            string anthorName2 = "clean code ";
            Console.WriteLine(anthorName.Equals(anthorName2));

            // Q3
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("book list");
            stringBuilder.AppendLine("-Updated");
            Console.WriteLine($"{stringBuilder}");

            //Q4
            stringBuilder.Replace("book list","library");

            //Q5
            string title = "clean code";
            int pages = 464;
            Console.WriteLine("the title is " + title + "and pages are " + pages);

            // Q6
            Console.WriteLine($"the title is {title} and pages are {pages}");

            //Q7
            if (pages >= 300)
                Console.WriteLine("long book");
            else
                Console.WriteLine("short book");

            //Q8
            bool isAvailable = true;
            if (isAvailable && pages>= 300 )
                Console.WriteLine("you can borrow this book");


            // Q9
            
            switch (title)
            {
                case "clean code": 
                Console.WriteLine("Great choise");
                     break;
                case "Refactoring":
                Console.WriteLine("nice pick");
                    break;

               default : Console.WriteLine("never heard of it");
                   break;
            }

            // Q10

            string sizeLabel = pages > 300 ? "Long Book" : "Short Book";
            Console.WriteLine(sizeLabel);

            // Q11
            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            for(int t = 0; t < books.Length; t++)
            {
                Console.WriteLine(books[t]);
                
            }
            int i = 0;
            while (i <books.Length)
            {
                Console.WriteLine(books[i]);
                i++;
            }

            do
            {
                Console.WriteLine(books[i]);
                i++;
            }
            while (i < books.Length);

            foreach(string book in books)
            {
                Console.WriteLine(book);
            }

            for (int t = 0; t < books.Length; t++)
            {
                Console.WriteLine(books[t]);
                if(books[t] == "Refactoring")
                {
                    break;
                }


            }
            for (int t = 0; t < books.Length; t++)
            {
                Console.WriteLine(books[t]);
                if (books[t] == "The Pragmatic Programmer")
                {
                    continue;
                }

                 
            }
            PrintFirstBook(books[0]);
            
            
            // sorry here i made all questions in the same Q11 because its all realted together


            

        }
    }
}
