using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Assignment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //    last part of  assignment 3
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


            #region Question20
            ////Using the same books array, print every title except "The Pragmatic Programmer"
            ////(skip it with continue, don't stop the loop).


            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //foreach (string book in books) { 
            //    if(book == "The Pragmatic Programmer")
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(book);
            //}

            #endregion


            #region Question21
            ////Write a method PrintFirstBook() that prints the first book in the books array. If the array is empty,
            ////use return to exit the method early instead of printing anything.


            //static void PrintFirstBook(string[] books)
            //{
            //    if (books.Length == 0)
            //    {
            //        return;
            //    }
            //    Console.WriteLine(books[0]);
            //}

            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //PrintFirstBook(books);

            #endregion


            //   **********   Assignment 4   String Questions:


            #region Question1
            ////1-Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle.
            ////Print both title and upperTitle to show that title did not change.


            //string title = "clean code";
            //string upperTitle = title.ToUpper();
            //Console.WriteLine(title);
            //Console.WriteLine(upperTitle);

            #endregion


            #region Question2
            ////2-Declare two separate string variables, both set to the literal "Clean Code". 
            ////Use ReferenceEquals() to check if they point to the same object in memory.


            //string str1 = "Clean Code";
            //string str2 = "Clean Code";
            //Console.WriteLine(object.ReferenceEquals(str1, str2));

            #endregion


            #region Question3
            ////3-Create a StringBuilder, Append() the text "Book List",
            ////then Append() " - Updated" onto the same object. Print the final result. 

            //StringBuilder sb = new StringBuilder();
            //sb.Append("Book List");
            //sb.Append(" - Updated"); 
            //Console.WriteLine(sb);

            #endregion


            #region Question4
            ////4-Using the StringBuilder from the question above,
            ////use Replace() to change "Book List" into "Library". Print the result.

            //StringBuilder sb = new StringBuilder();
            //sb.Append("Book List");
            //sb.Replace("Book List", "Library");
            //Console.WriteLine(sb);

            #endregion


            #region Question5
            ////5-Given string title = "Clean Code"; and int pages = 464;,
            ////build the sentence "Book: Clean Code, Pages: 464" using the + operator. 

            //string title = "Clean Code";
            //int pages = 464;
            //string sentence = "Book: " + title + ", Pages: " + pages;
            //Console.WriteLine(sentence);
            
            #endregion
        }

    }
}
