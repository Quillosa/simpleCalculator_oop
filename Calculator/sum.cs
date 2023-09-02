using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class sum
    {
        private int plus;

        public void setplus(int var1, int var2)
        {
            plus = var1 + var2;
        }

        public int getplus()
        {
            return plus; 
        }
    }
}
