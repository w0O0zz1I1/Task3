using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class Autorization
    {
        private const string LOGIN = "admin";
        private const string PASSWORD = "admin";
        public static Boolean loginMethod(String login)
        {
            Boolean result = false;
            if (login.Equals(LOGIN))
            {
                result = true;
            }
           else { result = false; }
            return result;
        }
        public static Boolean passwordMethod(String password)
        {
            Boolean result = false;
            if (password.Equals(PASSWORD))
            {
                result = true;
            }
            else { result = false; }
            return result;
        }

    }
}
