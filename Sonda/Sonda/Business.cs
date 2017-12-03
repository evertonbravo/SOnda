using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sonda
{
    public class Business
    {
        public static bool IsPositive(int val)
        {
            bool ispositive = val > 0 ? true : false;
            return ispositive;
        }
    }
}