using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sonda
{
    public class Helper
    {
        public static bool IsNumeric(string val)
        {

            bool isnumeric = false;
            char[] datachars = val.ToCharArray();

            foreach (var datachar in datachars)
                isnumeric = char.IsDigit(datachar) ? true : isnumeric;


            return isnumeric;
        }
        public static bool IsPositive(int val)
        {
            bool ispositive = val > 0 ? true : false;
            return ispositive;
        }


    }
}