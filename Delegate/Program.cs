using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate void Func(string str);

    class MyClass
    {
        public void Space(string str)
        {
            char[] array = str.ToCharArray();
            string space = "";
            for (int i = 0; i < array.Length; i++)
            {
                space += array[i] + "_";
            }
            Console.WriteLine(space);

        }
        public void Reverse(string str)
        {
            char[] array = str.ToCharArray();
            string reverse = "";
            for (int i = array.Length - 1; i >= 0; i--)
            {
                reverse += array[i];
            }
            Console.WriteLine(reverse);
        }

    }

    class Run
    {
        public void runFunc(Func func, string str)
        {
            func.Invoke(str);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string");
            var str = Console.ReadLine();
            MyClass cls = new MyClass();

            Func funcDell = cls.Space;
            funcDell += cls.Reverse;

            Run run = new Run();
            run.runFunc(funcDell, str);
        }
    }
}
