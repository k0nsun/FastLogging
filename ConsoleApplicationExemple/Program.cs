using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FastLogging;

namespace ConsoleApplicationExemple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");
            try
            {
                Log.Info("Application Start");
            }
            catch
            {
                Console.WriteLine("App.config need to be updated");
            }
            

            Log.Info("My second log");

#if DEBUG
            Log.Info("it's debug mode !");
#endif
            try
            {
                var result = 2 + 2;
                var impoossible  = result / 0;             
            }
            catch(ArithmeticException ex)
            {
                new ExceptionLog(string.Format("Arythmetic exception - {0}", ex.Message), ex.InnerException);
            }

            Console.WriteLine("End - press any key for exit");
            Console.ReadKey();
        }
    }
}
