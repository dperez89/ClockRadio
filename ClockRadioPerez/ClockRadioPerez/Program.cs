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
            ClockRadio davidsClock = new ClockRadio();
            davidsClock.navigateClockRadioMenu();
            Console.ReadKey();
        }
    }
}
