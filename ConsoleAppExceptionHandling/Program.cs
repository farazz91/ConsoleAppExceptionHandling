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
                try
                {
                    int fn = 10, sn = 0;
                   int res = fn / sn;
            }
                catch (Exception ex)
                {
                    string filepath = @"test.txt";
                    if (File.Exists(filepath))
                    {
                        smrd = new StreamReader(filepath);
                        smrd.ReadToEnd();
                    }
                    else
                    {
                        throw new FileNotFoundException(filepath + " not found.", ex);
                    }

                }
                //catch(FileNotFoundException fn)
                //{
                //    Console.WriteLine("File {0} not found.",fn.FileName);
                //}
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Exception occured {0}",ex.Message);
                //Console.WriteLine();
                //Console.WriteLine(ex.StackTrace);
                //Inne exception handling
                Console.WriteLine("Current Exception: {0}", ex.GetType().Name);
                if (ex.InnerException != null)
                {
                    Console.WriteLine("Inner Exception: {0}", ex.InnerException.GetType().Name);
                }
            }
            finally
            {
                if (smrd != null)
                {
                    smrd.Close();
                }
            }
        }
    }
}
