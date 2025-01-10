using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_OOP04.Third_Project
{
    internal class Duration
    {
        public int Hours { get;  set; }
        public int Minutes { get;  set; }
        public int Seconds { get; set; }

        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
            Time();
        }

        public Duration(int totalSeconds)
        {
            Hours = totalSeconds / 3600;
            Minutes = (totalSeconds % 3600) / 60;
            Seconds = totalSeconds % 60;
        }
        public override string ToString()
        {
            if (Hours > 0)
                return $"Hours: {Hours}, Minutes: {Minutes}, Seconds: {Seconds}";
            else if (Minutes > 0)
                return $"Minutes: {Minutes}, Seconds: {Seconds}";
            else
                return $"Seconds: {Seconds}";
        }
        public override bool Equals(object obj)
        {
            if (obj is Duration other)
            {
                return Hours == other.Hours && Minutes == other.Minutes && Seconds == other.Seconds;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Hours, Minutes, Seconds);
        }

        private void Time()
        {
            if (Seconds >= 60)
            {
                Minutes += Seconds / 60;
                Seconds %= 60;
            }
            if (Minutes >= 60)
            {
                Hours += Minutes / 60;
                Minutes %= 60;
            }
        }
    }
}
