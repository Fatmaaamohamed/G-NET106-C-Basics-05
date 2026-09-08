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
        }
    }
}
