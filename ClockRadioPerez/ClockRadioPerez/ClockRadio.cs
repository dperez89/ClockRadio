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
        public string userInput;
        public bool isOn;
        public bool isAlarmSet;
        public string alarmStatus;
        public string currentTime;
        public string currentAlarmTime;
        public string currentRadioStation;
        public bool exitIntent;

        public ClockRadio()
        {
            color = "brown";
            isOn = true;
            isAlarmSet = false;
            alarmStatus = "The alarm is off.";
            currentTime = "12:00";
            currentAlarmTime = "12:00";
            currentRadioStation = "93.3";
            exitIntent = false;
        }

        public void navigateClockRadioMenu()
        {
            Console.WriteLine("Clock Radio Status", Environment.NewLine);
            Console.WriteLine("Time: " + currentTime, Environment.NewLine);
            Console.WriteLine("Alarm Time: " + currentAlarmTime, Environment.NewLine);
            Console.WriteLine("Alarm Status: " + alarmStatus, Environment.NewLine);
            Console.WriteLine("Radio Station: " + currentRadioStation, Environment.NewLine);
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Clock Radio Main Menu");
            Console.WriteLine("What would you like to do?", Environment.NewLine);
            Console.WriteLine("1.) Change Time", Environment.NewLine);
            Console.WriteLine("2.) Change Alarm Time", Environment.NewLine);
            Console.WriteLine("3.) Change Radio Station", Environment.NewLine);
            Console.WriteLine("4.) Toggle Alarm On/Off", Environment.NewLine);
            Console.WriteLine("5.) Exit");
            Console.WriteLine(Environment.NewLine);
            userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    changeTime();
                    break;
                case "2":
                    changeAlarmTime();
                    break;
                case "3":
                    changeRadioStation();
                    break;
                case "4":
                    toggleAlarmStatus();
                    break;
                case "5":
                    exitClock();
                    break;
                default:
                    Console.WriteLine("Please try again!");
                    Console.ReadKey();
                    break;
            }
            if (exitIntent == false)
            {
                Console.Clear();
                navigateClockRadioMenu();
            }
            else if (exitIntent == true)
            {

            }
        }

        public string ViewTime()
        {
            Console.WriteLine(currentTime);
            return currentTime;
        }
        public string ViewRadioStation()
        {
            Console.WriteLine(currentRadioStation);
            return currentRadioStation;
        }
        public void ViewAlarmTime()
        {
            if (!isAlarmSet)
            {
                Console.WriteLine("No alarm is currently set");
            }
            else
            {
                Console.WriteLine(currentAlarmTime);

            }
        }
        public void changeTime()
        {
            Console.WriteLine("Please enter a new time for the clock in HH:MM AM/PM format:");
            currentTime = Console.ReadLine();
            Console.WriteLine("The time is now set to " + currentTime);
        }
        public void changeAlarmTime()
        {
            Console.WriteLine("Please enter a new alarm time for the clock in HH:MM AM/PM format:");
            currentAlarmTime = Console.ReadLine();
            Console.WriteLine("The alarm is now set for " + currentAlarmTime);
        }
        public void changeRadioStation()
        {
            Console.WriteLine("Please enter a new radio station in XX.X or XXX.X format:");
            currentRadioStation = Console.ReadLine();
            Console.WriteLine("The radio is now set to " + currentRadioStation);
        }
        public void toggleAlarmStatus()
        {
            if(isAlarmSet == false)
            {
                isAlarmSet = true;
                alarmStatus = "The alarm is on";
                Console.WriteLine("The alarm is now active.");
                Console.ReadKey();
            }
            else
            {
                isAlarmSet = false;
                alarmStatus = "The alarm is off";
                Console.WriteLine("The alarm is now inactive");
                Console.ReadKey();
            }
        }
        public void exitClock()
        {
            exitIntent = true;
            Console.WriteLine("Disengaging program...");
        }
    }
}
