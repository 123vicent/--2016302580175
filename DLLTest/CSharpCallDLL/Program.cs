using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using CSharpCreateDLL;

namespace CSharpCallDLL
{
    class Program
    {
        [DllImport(@"C:\Users\99459\source\repos\DLLTest\Release\CreateDLL.dll", EntryPoint = "test01", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = false, CallingConvention = CallingConvention.StdCall)]

        extern static int test01(int a, int b, int c);

        [DllImport(@"C:\Users\99459\source\repos\DLLTest\Release\CreateDLL.dll", EntryPoint = "test02", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = false, CallingConvention = CallingConvention.StdCall)]

        extern static int test02(int a, int b);


        static void Main(string[] args)
        {
            int r1 = test01(1, 2, 3);
            int r2 = test02(5, 2);

            Class1 c = new Class1();
            int r3 = c.test03(1, 2);
            int r4 = c.test04(1, 2, 3);


            Console.WriteLine("test01:" + r1.ToString());
            Console.WriteLine("test02:" + r2.ToString());
            Console.WriteLine("test03:" + r3.ToString());
            Console.WriteLine("test04:" + r4.ToString());
            Console.ReadKey();//等待键盘输入，退出程序。否则命令窗口会一闪而过
        }
    }
}
