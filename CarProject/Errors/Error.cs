using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject.Errors
{
    class Error
    {
        public static String[] errors = { "" };
        public static void getErrors()
        {
            foreach(string error in errors)
            {
                Console.WriteLine(error);
            }
        }
        public static void Set(string error)
        {
            errors.SetValue(error, error.Length + 1);
        }
    }
}
