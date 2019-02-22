using System;
using System.Collections.Generic;
using System.IO;

namespace ba_db_edit_dotnet
{
    ///<summary>
    ///* Function: Function to Read csv files
    ///* @author: Sena.kim
    ///* @parameter: string DirectoryAboveTheFile, string folderFormat (report : "yyyyMMdd" or AIDATA :  "yyyy-MM-dd")
    ///* @return: string DateFolderLocation 
    ///</summary>
    public class DirectoryReader
    {
        public void Writelinesfromfile()
        {
            var lines = ReadFrom("samples\\?Ç¨?ö©?ûê_[?òÅ?óÖ?ã§].xlsx");
            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }
        }

        static IEnumerable<string> ReadFrom(string file)
        {
            string line;
            using (var reader = File.OpenText(file))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    yield return line;
                }
            }
        }


    }
}