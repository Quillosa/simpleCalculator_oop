using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class div
    {
        private int dive;

        public void setplus(int var1, int var2)
        {
            dive = var1 / var2;
        }

        public int getplus()
        {
            return dive;
        }
    }
}
