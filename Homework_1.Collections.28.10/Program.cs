using Collections;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{//================================== Task #1.Start =======================================
    class MyArrayList
    {
        public static void ShowMyArrayList()
        {
            ArrayList faculties = new ArrayList();          // ArrayList

            faculties.Add("Faculty MKT");
            faculties.Add("Faculty ХБТ");
            faculties.Add("Faculty ФIМ");

            foreach (var faculty in faculties)              // оператор цикла foreach
            {
                Console.WriteLine(faculty);
            }

            Console.WriteLine();

            for (int i = 0; i < faculties.Count; i++)             // оператор цикла for
            {
                Console.WriteLine(faculties[i]);
            }

        }
    }
    class MyHashTable                               // HashTable
    {
        public static void ShowHashValues()
        {
            Hashtable countries = new Hashtable();
            countries.Add("1", "Bulgaria");
            countries.Add("2", "Slovakia");
            countries.Add("3", "Poland");

            foreach (var value in countries.Values)               // оператор цикла forech
            {
                Console.WriteLine(value);
            }
            Console.WriteLine();
            //for (int i = 0; i < countries.Values.Count; i++)           // оператор цикла for не працює?
            //{
            //    Console.WriteLine(countries[i]);
            //}

        }
        public static void ShowHashKeys()
        {
            Hashtable countries = new Hashtable();
            countries.Add("1", "Bulgaria");
            countries.Add("2", "Slovakia");
            countries.Add("3", "Poland");

            foreach (var keys in countries.Keys)                  // оператор цикла forech
            {
                Console.WriteLine(keys);
            }
            Console.WriteLine();
            //for (int i = 0; i < countries.Keys.Count; i++)      // знову не працює...
            //{
            //    Console.WriteLine(countries[i]);
            //}
        }

        public static void GetValueByKey()
        {
            Hashtable countries = new Hashtable();
            countries.Add("1", "Bulgaria");
            countries.Add("2", "Slovakia");
            countries.Add("3", "Poland");
            Console.WriteLine(countries["3"]);
            Console.WriteLine();
        }
        public static void ConstructorInitialisation()
        {
            Hashtable countries = new Hashtable { { "1", "Bulgaria" }, { "2", "Slovakia" }, { "3", "Poland" } };

            foreach (DictionaryEntry country in countries)
            {
                Console.WriteLine($"Key:{country.Key}  \tValue:{country.Value}");
            }
        }
    }
    class MyQueue
    {
        public static void ShowMyQueue()
        {
            Queue names = new Queue();

            names.Enqueue("Nazarii");
            names.Enqueue("Misha");
            names.Enqueue("Ruslan");

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();
        }
        public static void Dequeue()
        {
            Queue names = new Queue();

            names.Enqueue("Nazarii");
            names.Enqueue("Misha");
            names.Enqueue("Ruslan");

            names.Dequeue();

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();
        }
        public static void Peek()
        {
            Queue names = new Queue();

            names.Enqueue("Nazarii");
            names.Enqueue("Misha");
            names.Enqueue("Ruslan");

            names.Peek();

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();
        }
    }
    class MyStack
    {
        public static void PushMyStack()
        {
            Stack cities = new Stack();

            cities.Push("Kyiv");
            cities.Push("Lviv");
            cities.Push("Dnipro");

            //for (int i = 0; i < cities.Count; i++)
            //{
            //    Console.WriteLine(cities[i]);                //  ???

            //}
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
            Console.WriteLine();
        }
        public static void PopMyStack()
        {
            Stack cities = new Stack();

            cities.Push("Kyiv");
            cities.Push("Lviv");
            cities.Push("Dnipro");

            cities.Pop();

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
        }
    }
    class MyDictionary
    {
        public static void ShowMyDictionary()
        {
            Dictionary<char, string> streets = new Dictionary<char, string>();

            streets.Add('e', "Entusiastiv street");
            streets.Add('l', "Leipzigska street");
            streets.Add('m', "Mashynobudivna street");

            foreach (var street in streets)
            {
                Console.WriteLine($"Key: {street.Key} \tValue: {street.Value}");
            }
            Console.WriteLine();
        }
        public static void ShowStackKeys()
        {
            Dictionary<char, string> streets = new Dictionary<char, string>();

            streets.Add('e', "Entusiastiv street");
            streets.Add('l', "Leipzigska street");
            streets.Add('m', "Mashynobudivna street");

            foreach (var keys in streets.Keys)
            {
                Console.WriteLine(keys);
            }
        }
    }
    class MyList
    {
        public static void ShowMyList()
        {
            List<string> trees = new List<string>();

            trees.Add("apple tree");
            trees.Add("pear tree");
            trees.Add("oak");

            foreach (var tree in trees)                   //оператор цикла foreach
            {
                Console.WriteLine(tree);
            }
            Console.WriteLine();
            for (int i = 0; i < trees.Count; i++)         //оператор цикла for
            {
                Console.WriteLine(trees[i]);
            }
        }
    }
    class MyLinkedList
    {
        public static void ShowMyLinkedList()
        {
            LinkedList<string> months = new LinkedList<string>();

            months.AddFirst("January");
            months.AddAfter(months.Last, "February");
            months.AddAfter(months.Last, "March");
            months.AddAfter(months.Last, "April");
            months.AddAfter(months.Last, "May");
            months.AddAfter(months.Last, "June");
            LinkedListNode<string> currentMonth = months.First;
            while (currentMonth != null)
            {
                Console.WriteLine(currentMonth.Value);
                currentMonth = currentMonth.Next;
            }

            Console.WriteLine();

            //months.AddFirst("January");
            //months.AddAfter(months.Last, "February");
            //months.AddAfter(months.Last, "April");
            //months.AddBefore(months.Last, "March");
            //months.AddAfter(months.Last, "May");
            //months.AddAfter(months.Last, "June");
            //currentMonth = months.First;
            //while (currentMonth != null)
            //{
            //    Console.WriteLine(currentMonth.Value);
            //    currentMonth = currentMonth.Next;
            //}

            //Console.WriteLine();

            //months.AddLast("January");
            //months.AddLast("February");
            //months.AddLast("April");
            //months.AddLast("March");
            //months.AddLast("May");
            //months.AddLast("June");
            //currentMonth = months.First;
            //while (currentMonth != null)
            //{
            //    Console.WriteLine(currentMonth.Value);
            //    currentMonth = currentMonth.Next;
            //}
        }
        public static void Remove()
        {
            LinkedList<string> months = new LinkedList<string>();

            months.AddFirst("January");
            months.AddAfter(months.Last, "February");
            months.AddAfter(months.Last, "March");
            months.AddAfter(months.Last, "April");
            months.AddAfter(months.Last, "May");
            months.AddAfter(months.Last, "June");

            months.Remove(months.Last);
            months.RemoveFirst();
            months.RemoveLast();

            LinkedListNode<string> currentMonth = months.First;
            while (currentMonth != null)
            {
                Console.WriteLine(currentMonth.Value);
                currentMonth = currentMonth.Next;
            }

            Console.WriteLine();
        }
    }
    //================================== Task #1.Finish =======================================



    //================================== Task #2.Start =======================================
    interface IKey
    {
        string Name { get; set; }
    }
    interface IValue
    {
        string Name { get; set; }
    }
    class EngWord : IKey
    {
        public EngWord(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
    }
    class UkrWord : IValue
    {
        public UkrWord(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
    }






    interface IKeySecond
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
    interface IValueSecond
    {
        public string Status { get; set; }
        public int Sallary { get; set; }
    }
    class Person : IKeySecond
    {
        public Person(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
    class Data : IValueSecond
    {
        public Data(string status, int sallary)
        {
            Sallary = sallary;
            Status = status;
        }
        public string Status { get; set; }
        public int Sallary { get; set; }
    }
}
//================================== Task #2.Finish =======================================

//================================== Task #3.Start ========================================

class LinkedList
{
    public static void Show()
    {
        LinkedList<string> microsoft = new LinkedList<string>();

        microsoft.AddFirst("Word");
        microsoft.AddLast("Excel");
        microsoft.AddLast("OneNote");
        microsoft.AddLast("PowerPoint");
        microsoft.AddLast("OutLook");
        microsoft.AddLast("Access");
        microsoft.AddLast("Publisher");
        microsoft.AddLast("Edge");
        microsoft.AddLast("OneDrive");
        microsoft.AddLast("Calendar");

        LinkedListNode<string> currentNode = microsoft.First;

        while (currentNode != null)
        {
            Console.WriteLine(currentNode.Value);
            currentNode = currentNode.Next;
        }

        Console.WriteLine("\nModified LinkedList:");

        currentNode = microsoft.First;
        while (currentNode != null)
        {
            string remove = "OutLook";
            if (currentNode.Value == remove)
            {
                currentNode = currentNode.Next;
                microsoft.Remove(currentNode.Previous);
            }
            else
            {
                Console.WriteLine(currentNode.Value);
                currentNode = currentNode.Next;
            }
        }
    }
}
//================================== Task #3.Finish =======================================
class Program
{
    static void Main(string[] args)
    {
        Dictionary<IKey, IValue> translator = new Dictionary<IKey, IValue>();
        EngWord FirstEng = new EngWord("Developer");
        UkrWord FirstUkr = new UkrWord("Pозробник");

        EngWord SecondEng = new EngWord("Nature");
        UkrWord SecondUkr = new UkrWord("Природа");

        EngWord ThirdEng = new EngWord("Saturday");
        UkrWord ThirdUkr = new UkrWord("Субота");

        EngWord FourthEng = new EngWord("Holiday");
        UkrWord FourthUkr = new UkrWord("Вiдпустка");

        EngWord FifththEng = new EngWord("Styding");
        UkrWord FifthUkr = new UkrWord("Навчання");

        translator.Add(FirstEng, FirstUkr);
        translator.Add(SecondEng, SecondUkr);
        translator.Add(ThirdEng, ThirdUkr);
        translator.Add(FourthEng, FourthUkr);
        translator.Add(FifththEng, FifthUkr);
        foreach (KeyValuePair<IKey, IValue> word in translator)
        {
            Console.WriteLine("English: {0} ---->  Ukrainian: {1}", word.Key.Name, word.Value.Name);
        }



        Console.WriteLine();



        Dictionary<IKeySecond, IValueSecond> personInfo = new Dictionary<IKeySecond, IValueSecond>();
        Person FirstP = new Person("Max", "Kovalchuk");
        Data FirstD = new Data("Student", 1400);

        Person SecondP = new Person("Dima", "Kovalenko");
        Data SecondD = new Data("Employee", 19000);

        Person ThirdP = new Person("Nazar", "Petrenko");
        Data ThirdD = new Data("Employee", 23000);

        Person FourthP = new Person("Andrii", "Kyrylyuk");
        Data FourthD = new Data("Student", 1400);

        Person FifthP = new Person("Roman", "Shpak");
        Data FifthD = new Data("Employee", 14000);
        personInfo.Add(FirstP, FirstD);
        personInfo.Add(SecondP, SecondD);
        personInfo.Add(ThirdP, ThirdD);
        personInfo.Add(FourthP, FourthD);
        personInfo.Add(FifthP, FifthD);

        foreach (KeyValuePair<IKeySecond, IValueSecond> person in personInfo)
        {
            Console.WriteLine("Person:{0} {1}\t\tStatus:{2}\t\tSallary:{3} ", person.Key.Name, person.Key.Surname, person.Value.Status, person.Value.Sallary);
        }





        Console.WriteLine("\nOriginal LinkedList:");
        LinkedList.Show();
        Console.WriteLine();

        //MyArrayList.ShowMyArrayList();                                                      
        //Console.WriteLine("==========================");
        //MyHashTable.ShowHashValues();
        //MyHashTable.ShowHashKeys();
        //MyHashTable.GetValueByKey();
        //MyHashTable.ConstructorInitialisation();
        //Console.WriteLine("==========================");
        //MyQueue.ShowMyQueue();
        //MyQueue.Dequeue();
        //MyQueue.Peek();
        //Console.WriteLine("==========================");
        //MyStack.PushMyStack();
        //MyStack.PopMyStack();
        //Console.WriteLine("==========================");
        //MyDictionary.ShowMyDictionary();
        //MyDictionary.ShowStackKeys();
        //Console.WriteLine("==========================");
        //MyList.ShowMyList();
        //Console.WriteLine("==========================");
        //MyLinkedList.ShowMyLinkedList();
        //MyLinkedList.Remove();


    }
}
