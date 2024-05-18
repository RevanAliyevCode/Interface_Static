using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UserTask
{
    public enum RegestrationMonth
    {
        January = 1,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        Novomber,
        December,
    }

    public static class Check
    {
        public static bool CheckPIN(this string value)
        {
            if (value.Length != 7) return false;

            for (int i = 0; i < value.Length; i++)
            {
                if (char.ToUpper(value[i]) != value[i])
                {
                    return false;
                }
            }

            return true;
        }
    }

    public class User
    {
        private string pin;
        public string Name { get; set; }
        public string Surname { get; set; }

        public RegestrationMonth RegestrationMonth { get; set; }
        public string PIN
        {
            get
            {
                return pin;
            }
            set
            {
                if (value.CheckPIN())
                    pin = value;
                else Console.WriteLine("You can not assign this value please write pin with uppercase or make sure length is 7");
            }
        }

        public User(string name, string surname, RegestrationMonth regestrationMonth, string pin)
        {
            Name = name;
            Surname = surname;
            RegestrationMonth = regestrationMonth;
            PIN = pin;
        }

        public void GetDetails()
        {
            Console.WriteLine($"Name: {Name}, Surname: {Surname}, Regestration Month: {RegestrationMonth}, PIN: {PIN}");
        }
    }
}
