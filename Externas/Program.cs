using System;

namespace Externas
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Projeto
                Console.ReadLine();
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
}
