using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelPrj
{
   public class TestClass:ITestInterface
    {

        public int Sum (int a , int b)
        {
            return a + b;

        }


        public int Multiple(int a, int b)
        {
            return a * b;

        }

        public string Name()
        {
            return "Anton";
        }

        public string Name2()
        {
            return "afafafa";
        }
    }
}
