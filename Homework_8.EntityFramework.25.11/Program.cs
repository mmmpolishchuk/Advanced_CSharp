namespace Homework_8.EntityFramework._25._11
{
    class Program
    {
        static void Main(string[] args)
        {
            var bookShelfContext = new BookShelfService();
            //bookShelfContext.AddSomeCharacters();
            bookShelfContext.GetCharactersFromDb();
           
            
        }
    }
}
