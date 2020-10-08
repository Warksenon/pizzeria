using System;
using System.IO;

namespace Pizza
{
    public class RecordOfExceptions
    {
        public static void Save(string e,string name)
        {
            try
            {
                using (StreamWriter streamW = new StreamWriter(("Record Of Exceptions.txt"), true))
                {
                    string s = "Data : " + DateTime.Now.ToString()+ "\n" + name + "\n" + e + "\n\n";
                   
                    streamW.WriteLine(s);
                    streamW.Flush();
                }
            }
            catch 
            {
                Console.WriteLine("Eroor save RecordOfExceptions ");
            }
        }
    }
}
