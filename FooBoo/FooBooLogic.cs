using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FooBoo
{
    public class FooBooLogic
    {
        public string Analyze(int number)
        {
            string result = "";
            if (number % 3 == 0)
            {
                result += "Foo";
            }

            if (number % 5 == 0)
            {
                result += "Boo";
            }

            if (result.Length == 0)
            {
                result = "No!";
            }

            return result;
        }
    }
}
