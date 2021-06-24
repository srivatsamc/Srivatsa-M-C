using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class ArgumentTest
    {
        public void Test() { } //public void Test(A this){   }

        public void NewTest(int x, int y) { } // public void Test(A this,int x,int y){}
        public static void OldTest() { } // 0
    }
}
