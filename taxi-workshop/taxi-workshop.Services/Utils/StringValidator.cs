using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taxi_workshop.Services.Utils
{
    public static class StringValidator
    {
        public static int ValidNumber(string number, int range)
        {
            int num = 0;
            bool isNumber = int.TryParse(number, out num);
            if (!isNumber)
                return -1;
            if (num <= 0 || num > range) 
                return -1;
            return num;
        }

        public static bool ValidateUsername(string username) =>
            username.Length >= 5;

        public static bool ValidatePassword(string password)
        {
            if(password.Length < 6)
                return false;
            bool isNum = false;
            foreach(char c in password)
            {
                isNum = int.TryParse(c.ToString(), out int num);
                if(isNum) return true;
            }
            return false;
        }
    }
}
