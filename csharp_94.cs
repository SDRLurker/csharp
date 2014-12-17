using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Globalization;

namespace ConsoleApplication1
{
    class Test
    {
        public static void DisplayTemperature(DateTime date, double temp)
        {
            string output;
            output = string.Format("Temperature at {0:t} on {0:d} : {1:N2}", date, temp);
            Console.WriteLine(output);
            output = string.Format("Temperature at {0:t} on {0:MM/dd/yyyy} : {1:N2}", date, temp);
            Console.WriteLine(output);

        }
        public static void Main()        
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            DisplayTemperature(DateTime.Now, 4.567);            
        }

    }
}
