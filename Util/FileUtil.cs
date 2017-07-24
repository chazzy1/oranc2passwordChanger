using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


namespace MainForm.Util
{
    class FileUtil
    {
        public static string[] ParseDataLineByDelimiter(string dataLine)
        {
            string delimiter = ",";

            string[] dataColumns = Regex.Split(dataLine, delimiter);
            return dataColumns;

        }

        public static void DeleteFile(string filename)
        {
            System.IO.File.Delete(filename);
        }


    }
}
