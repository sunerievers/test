using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestConsole
{
    public class Extra2
    {
        public static void Hello()
        {
            Console.WriteLine("Hello World!");
        }

        public int GetNumber()
        {
            var a = 1;
            var b = 2;
            var c = 3;
            var d = a * b * c;

            for (int i = 0; i < 10; ++i)
            {
                d = -d;
            }

            switch(d)
            {
                case 0:
                    return 0;

                case 1:
                    return 1;

                case 2:
                    return 2;

                default:
                    return -1;
            }
        }
        public int GetNumber2()
        {
            var a = 1; var b = 2; var c = 3; var d = a * b * c;

            for (int i = 0; i < 10; ++i)
                d = -d;

            switch (d)
            {
                case 0: return 0;

                case 1: return 1;

                case 2: return 2;

                default: return -1;
            }
        }
    }
}
