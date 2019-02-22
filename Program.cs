using System;

namespace ba_db_edit_dotnet
{
    class Program
    {
        static void Main(string[] args)
        {

            SQL c1 = new SQL();
            DirectoryReader directoryreader = new DirectoryReader();


            Console.WriteLine($"Hello World! {c1.MessageToReturn()}");
            directoryreader.Writelinesfromfile();
        }



       
    }
}