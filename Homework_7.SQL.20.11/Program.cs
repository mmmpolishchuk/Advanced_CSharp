using TryToConnectToMyDB;

namespace Homework_7.SQL._20._11
{
    class Program
    {
        static void Main(string[] args)
        {
            //SQLClass.MyUpdate();
            SQL_Connection.CreateMyTable();
            InsertInTable.MovieInserting();
            SelectTable.ShowMovies();

        }
    }
}
