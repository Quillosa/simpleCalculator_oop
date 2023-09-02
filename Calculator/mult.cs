using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class mult
    {
        private int multip;

        public void setplus(int var1, int var2)
        {
            multip = var1 * var2;
        }

        public int getplus()
        {
            return multip;
        }
    }
}
