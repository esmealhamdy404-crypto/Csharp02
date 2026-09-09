namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //#region 1st quetion
            //string title = "clean code";
            //string UpperTitle = title.ToUpper();
            //Console.WriteLine($"title after upper = {UpperTitle}");
            //Console.WriteLine($"title before = {title}");
            //#endregion
            //#region 2nd question
            //string variable1 = "clean code";
            //string variable2 = "clean code";
            //Console.WriteLine(variable1.Equals(variable2));
            //#endregion

            //#region 3rd question the first in assignment 1
            //Book book1 = new Book();
            //book1.Title = "atomic habbit"; 
            //book1.pages =300;
            //Console.WriteLine($"title of book =  {book1.Title} ,num of pages = {book1.pages}");

            //#endregion

            // #region 4rd question the first in assignment 1

            // Book book1 = new Book();
            // book1.Title = "atomic habbit";
            // book1.pages = 300;
            ////Console.WriteLine($"title of book =  {book1.Title} ,num of pages = {book1.pages}");
            //Console.WriteLine(book1.ToString());
            // Console.WriteLine(book1.Equals(book1));
            // Console.WriteLine(book1.GetHashCode());
            // Console.WriteLine(book1.GetType());
            // #endregion
            try
            {
                int x = 1;
                int y = 0;
                int z = x/y;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("can not divide by zero");
            }
            finally
            {
                Console.WriteLine("DONE");
            }


















        }
    }
}
