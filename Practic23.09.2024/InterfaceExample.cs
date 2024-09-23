using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic23._09._2024
{
    interface ITest
    {
        string Name { get; set; }
        void Method();
    }
    interface ITest2 {
        int Age {  get; set; }
    }
    class InterfaceExample : ITest, ITest2
    {
        private int id;
        public string Name { get; set; }
        public int Age { get; set; } = 3;
        public void Method() {
            Console.WriteLine("Method");
        }
        public void Print()
        {
            Console.WriteLine("Print");
        }
    }
    class InterfaceExample2 : ITest, ITest2
    {
        private int id;
        public string Name { get; set; }
        public int Age { get; set; } = 20;
        public void Method()
        {
            Console.WriteLine("Method2");
        }    
    }
}
