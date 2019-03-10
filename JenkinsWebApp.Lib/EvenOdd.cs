using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JenkinsWebApp.Lib
{
    public class EvenOdd
    {
        public string GetNumberType(int num)
        {
            if (num%2 == 0)
            {
                return "Even";
            }
            else
            {
                return "Odd";
            }
        }

    }
}
