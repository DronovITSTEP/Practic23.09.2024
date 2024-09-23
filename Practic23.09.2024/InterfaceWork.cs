using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic23._09._2024
{
    class StudentCard
    {
        public int Number { get; set; }
        public string Series { get; set; }
        public override string ToString()
        {
            return $"Студ. билет: {Number} - {Series}";
        }
    }
    class Student : IComparable, ICloneable
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public StudentCard StudentCard { get; set; }

        public override string ToString()
        {
            return $"{Name} {Surname}, Дата рождения: {BirthDate.ToLongDateString()}\n" +
                $"Студ. билет: {StudentCard}";
        }
        public int CompareTo(object obj)
        {
            if (obj is Student)
            {
                return Surname.CompareTo((obj as Student).Surname);
            }

            throw new NotImplementedException();
        }
        public object Clone()
        {
            Student temp = (Student)MemberwiseClone();
            temp.StudentCard = new StudentCard
            {
                Number = temp.StudentCard.Number,
                Series = temp.StudentCard.Series
            };
            return temp;
        }
    }

    class Auditory : IEnumerable
    {
        public Student[] students =
        {
            new Student
            {
                Name = "Ivan",
                Surname = "Ivanov",
                BirthDate = DateTime.Parse("1992-12-5"),
                StudentCard = new StudentCard {
                    Number = 24,
                    Series = "345TT3"
                }
            },
            new Student
            {
                Name = "Petr",
                Surname = "Petrov",
                BirthDate = DateTime.Parse("1990-5-16"),
                StudentCard = new StudentCard {
                    Number = 456,
                    Series = "tt2345"
                }
            },
            new Student
            {
                Name = "Sergey",
                Surname = "Sergeev",
                BirthDate = DateTime.Parse("1992-12-15"),
                StudentCard = new StudentCard {
                    Number = 30,
                    Series = "33wt35"
                }
            },
            new Student
            {
                Name = "Elena",
                Surname = "Elenova",
                BirthDate = DateTime.Now,
                StudentCard = new StudentCard {
                    Number = 79,
                    Series = "234wv"
                }
            }
        };

        public IEnumerator GetEnumerator()
        {
            return students.GetEnumerator();
        }

        public void Sort()
        {
            Array.Sort(students);
        }
        public void Sort(IComparer comparer)
        {
            Array.Sort(students, comparer);
        }
    }
    class DateComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            if (x is Student && y is Student)
            {
                return DateTime.Compare(
                    (x as Student).BirthDate,
                    (y as Student).BirthDate);
            }
            throw new NotImplementedException();
        }
    }
}
