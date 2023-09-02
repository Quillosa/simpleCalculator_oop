using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class sub
    {
        private int subdi;

        public void setplus(int var1, int var2)
        {
            subdi = var1 - var2;
        }

        public int getplus()
        {
            return subdi;
        }
    }
}
