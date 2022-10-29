using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
   public class Calculation
    {
         private int a, b;
        public Calculation(int a,int  b)
        {
            this.a=a;
            this.b=b;
        }
        public int Exectute(string CalSymbol)
        {
            int Result = 0;
            switch(CalSymbol)
            {
                case"+":
                    Result = a + b;
                    break;
                case "-":
                    Result = a -b;
                    break;
                case "*":
                    Result = a * b;
                    break;
                case "/":
                    Result = a / b;
                    break;

            }
            return Result;
        }
    }
}
