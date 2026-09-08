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
            book.password = "secret";
            //it gives Compile error bc Password is inaccessible due to protection level because the acces modifier private makes the field only accessible at its scope (class)
            #endregion
        }
    }
}
