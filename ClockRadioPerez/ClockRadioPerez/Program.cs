using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockRadioPerez
{
    class Program
    {
        static void Main(string[] args)
        {
            ClockRadio davidClockRadio = new ClockRadio();
            string currentTime = davidClockRadio.ViewTime();
            Console.ReadKey();
        }
    }
}
