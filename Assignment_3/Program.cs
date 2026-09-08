namespace Assignment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Question13
            ////Given string title = "Refactoring";, write a switch statement that prints "Great choice!" if the title is "Clean Code",
            ////"Nice pick!" if it's "Refactoring", and "Never heard of it" for anything else.

            //string title = "Refactoring";
            //switch (title)
            //{
            //    case ("Clean Code"):
            //        Console.WriteLine("Great choice!");
            //        break;
            //    case ("Refactoring"):
            //        Console.WriteLine("Nice pick!");
            //        break;
            //    default:
            //        Console.WriteLine("Never heard of it");
            //        break;
            //}

            #endregion



            #region Question14
            ////Given int pages = 464;, use the ternary operator to store "Long Book" or "Short Book"
            ////into a variable sizeLabel (same rule as question 8: long if pages > 300)

            //int pages = 464;
            //string sizeLabel = pages > 300 ? "Long Book" : "Short Book";
            //Console.WriteLine(sizeLabel);

            #endregion


            #region Question15
            ////Given string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };,
            ////use a for loop to print each book with its position number, like 1. Clean Code



            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //for(int i=0; i < books.Length; i++)
            //{
            //    Console.WriteLine($"the index {i+1} is: {books[i]}");
            //}

            #endregion


            #region Question16
            ////Using the same books array, use a while loop to print every book title


            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //int i = 0;
            //while (i < books.Length)
            //{
            //    Console.WriteLine(books[i]);
            //    i++;
            //}

            #endregion


            #region Question17
            ////Write a do-while loop that prints "Checking book..." exactly 3 times.

            //int i = 0;
            //do
            //{
            //    Console.WriteLine("Checking book...");
            //    i++;
            //}
            //while (i < 3);


            #endregion


            #region Question18
            ////Using the same books array, use a foreach loop to print every book title


            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //foreach(string book in books)
            //{
            //    Console.WriteLine(book);
            //}

            #endregion


            #region Question19
            ////Using the same books array, loop through it and print each title,
            ////but stop completely (break) once you reach "Refactoring".


            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //foreach (string book in books)
            //{
            //    if(book == "Refactoring")
            //    {
            //        break;
            //    }
            //    Console.WriteLine(book);
            //}
            #endregion


        }

    }
}
