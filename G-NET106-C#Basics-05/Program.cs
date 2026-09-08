using System.Collections.Specialized;

namespace G_NET106_C_Basics_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            /*Add a private string password = "secret"; field to a Book class. Try to print it from Main
            (outside the class). What happens, and why?*/

            Book book = new Book();
            // book.password = "secret";
            //it gives Compile error bc Password is inaccessible due to protection level because the acces modifier private makes the field only accessible at its scope (class)
            #endregion

            #region Question02
            /*Add an internal int copiesInStock = 5; field to Book. Print it from Main. Does it compile?
             Why?*/
            Console.WriteLine($"Number of Copies in The Stock:  {book.copiesInStock}");
            // It compiles bc the access modifier internal allows to use the field only in the same file and program and class book are in the same file
            #endregion

            #region Question03
            /*Add a public string Title; field to Book. Set it and print it from Main.*/

            Console.WriteLine($"Enter Book Title: ");
            book.Title = Console.ReadLine();
            Console.WriteLine($"Book Title: {book.Title}");

            #endregion

            #region Question04
            /*Declare an enum Genre { Fiction, NonFiction, Science }. Add a Genre property to Book,
            assign it Genre.Science, and print it.*/

            book.genre = Genre.Science;

            Console.WriteLine($"Book Genre: {book.genre}");

            #endregion

            #region Question05
            /*Using the Genre enum above, print the underlying int value of
            Genre.Fiction, Genre.NonFiction, and Genre.Science by casting each to int.*/

            Console.WriteLine($"Genre.Fiction underlying value: {(int)Genre.Fiction}");
            Console.WriteLine($"Genre.NonFiction underlying value: {(int)Genre.NonFiction}");
            Console.WriteLine($"Genre.Science underlying value: {(int)Genre.Science}");
            #endregion

            #region Question06
            /*Given int genreNumber = 1;, cast it into a Genre value and print the result.*/
            int genreNumber = 1;
            if (Enum.IsDefined(typeof(Genre), genreNumber))
            {
                Genre genre = (Genre)genreNumber;

                Console.WriteLine($"Genre: {genre}");
            }
            else
            {
                Console.WriteLine($"Value {genreNumber} is not a valid Genre.");
            }


            #endregion

            #region Question07
            /*Given Genre genre = Genre.Fiction;, convert it into a string using ToString() and print it.*/

            Genre genree = Genre.Fiction;

            string genreee = genree.ToString();

            Console.WriteLine($" Genre: {genreee} ");
            #endregion

            #region Question08

            /*Given string genreText = "Science";, convert it into a Genre value using Enum.Parse() and
            print the result.*/

            string genreText = "Science";
            Genre gen = Enum.Parse<Genre>(genreText);

            Console.WriteLine( $"Genre Number: {gen}");
            #endregion

        }

    }
}
