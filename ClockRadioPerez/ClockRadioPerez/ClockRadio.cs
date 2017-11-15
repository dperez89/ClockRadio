using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockRadioPerez
{
    public class ClockRadio
    {
        public string color;
        public bool isOn;
        public string currentTime;
        public string currentAlarmTime;

        public ClockRadio()
        {
            color = "brown";
            isOn = true;
            currentTime = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();
            currentAlarmTime = "12:00";
        }

        public string ViewTime()
        {
            Console.WriteLine(currentTime);
            return currentTime;
        }
        //member methods
    }
}
