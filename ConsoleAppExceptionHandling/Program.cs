using System;
using System.IO;

namespace ConsoleAppExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader smrd=null;
            try
            {
              smrd = new StreamReader(@"D:/test.txt");
                smrd.ReadToEnd();
            }    
            catch(FileNotFoundException fn)
            {
                Console.WriteLine("File {0} not found.",fn.FileName);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception occured {0}",ex.Message);
                Console.WriteLine();
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                if(smrd != null)
                {                    
                    smrd.Close();
                }
            }
        }
    }
}
