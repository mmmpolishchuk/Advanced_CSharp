
using System;
using System.Collections;
using System.Collections.Generic;

namespace Homework_2
{
    public class NamesList : IEnumerable
    {
        public List<string> names = new List<string>();
        Random rnd = new Random(9);

        public IEnumerator GetEnumerator()
        {
            return names.GetEnumerator();
        }
        public void Add()
        {
            names.Add("Bill");
            names.Add("Peter");
            names.Add("Nick");
            names.Add("Mike");
            names.Add("Rick");
            names.Add("James");
            names.Add("Chris");
            names.Add("Martin");
            names.Add("Bob");
            names.Add("Tim");
        }
        public void Remove()
        {
            names.RemoveAt(rnd.Next(0, 10));
        }
    }
    public class NamesIterator : IEnumerator
    {
        List<string> names;
        int position = -1;
        public NamesIterator(List<string> names)
        {
            this.names = names;
        }
        public object Current
        {
            get
            {
                return names[position];
            }
        }
        public bool MoveNext()
        {
            if (position < names.Count - 1)
            {
                position++;
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Reset()
        {
            position = -1;
        }
    }
    //==================================== Task#2 ==================================
    class Rectangle<T, R>
                       where T : struct
                       where R : Shape
    {
        T sidesQuantity;
        R Shape;
        int side;
        int square;
        public Rectangle(T sides, R Shape, int side)
        {
            this.sidesQuantity = sides;
            this.Shape = Shape;
            this.side = side;
        }
        public R GetR()
        {
            return Shape;
        }
        public T GetT()
        {
            return sidesQuantity;
        }
        public int GetSide()
        {
            return side;
        }
        public void SetSquare()
        {
            square = side * side;
        }
        public int GetSquare()
        {
            return square;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Name of shape: {0};\tSides: {1};\tSquare: {2};\tType of R: {3}", Shape.GetName(), sidesQuantity, square, typeof(Shape).ToString());
        }
    }
    public class Shape
    {
        public string name;
        public Shape(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            NamesList students = new NamesList();
            students.Add();
            Console.WriteLine("List of names:");
            foreach (var student in students)
            {
                Console.WriteLine("\t" + student);
            }

            if (students.names.Count > 5)
            {
                Console.Write("List has more than 5 elements, so u can cross out names. How many names do you want to cross out?  ");
                int removeQuantity = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < removeQuantity; i++)
                {
                    students.Remove();
                }
                Console.WriteLine("Modified List:");
                foreach (var student in students)
                {
                    Console.WriteLine("\t" + student);
                }
            }
            Console.WriteLine("==========================================================================");
            //==================================== Task#2 ==================================
            Shape shape = new Shape("Rectangle");
            Rectangle<int, Shape> rectangle = new Rectangle<int, Shape>(4, shape, 5);
            rectangle.SetSquare();
            rectangle.ShowInfo();
        }
    }
}