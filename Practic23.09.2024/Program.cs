using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Practic23._09._2024
{
    /*    interface InterExample
        {
            string Name { get; }
        }
        class Example1 : InterExample { 
            public string Name { get; set; }
        }
        class Example2 : InterExample {
            public string Name { get; set; }
        }

    */

    class Child : ICloneable
    {
        public string Name { get; set; }
        public int Age {  get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public override string ToString()
        {
            return $"Имя: {Name}, Возраст: {Age}";
        }

    }
    internal class Program
    {
        /*public static void Foo(InterExample ex)
        {
            if (ex is Example1)
                (ex as Example1).Name = "Foo";
            else if (ex is Example2)
                (ex as Example2).Name = "Foo2";
        }*/

        static void Main(string[] args)
        {
            /*Foo(new Example1());
            Foo(new Example2());*/

            /*Auditory auditory = new Auditory();

            foreach (Student student in auditory)
            {
                Console.WriteLine(student);
            }

            auditory.Sort();

            Console.WriteLine();
            foreach (Student student in auditory)
            {
                Console.WriteLine(student);
            }

            auditory.Sort(new DateComparer());

            Console.WriteLine();
            foreach (Student student in auditory)
            {
                Console.WriteLine(student);
            }*/

           /* Student stud1 = new Student
            {
                Name = "Ivan",
                Surname = "Ivanov",
                BirthDate = DateTime.Parse("1992-12-5"),
                StudentCard = new StudentCard
                {
                    Number = 24,
                    Series = "345TT3"
                }
            };

            Student stud2 = (Student)stud1.Clone();

            Console.WriteLine("first child: " + stud1);
            Console.WriteLine("second child: " + stud2);

            Console.WriteLine();

            stud2.StudentCard.Number = 111;

            Console.WriteLine("first child: " + stud1);
            Console.WriteLine("second child: " + stud2);*/

            //IEnumerable - перечислитель, в основном используется
            //для foreach
            //IComparable, IComparer - для сравнения
            //IClonable - для клонирования объекта
        }
    }
}
