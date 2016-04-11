using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write the string");
            MessageBoxOutput.Message(Console.ReadLine());
            Console.WriteLine("Create and testing class MyList");
            MyList _myList = new MyList(10);

            Console.WriteLine("Add 3 objects in _myList");
            _myList.Add ("string1");
            _myList.Add(6);
            _myList.Add(9.9);
            _myList.Print();

            WriteTestName("Count");
            Console.WriteLine("_myList.Count - {0}", _myList.Count);

            WriteTestName("CopyTo");
            object[] _array=new object[3];
            _myList.CopyTo(_array, 0);
            foreach (object i in _array)
            {
                Console.WriteLine(i);
            }

            WriteTestName("Clear");
            _myList.Clear();
            _myList.Print();

            Console.WriteLine("Add 3 new objects in _myList");
            _myList.Add("string2");
            _myList.Add(6.6f);
            _myList.Add(9);
            _myList.Print();

            WriteTestName("Indexer");
            Console.WriteLine("_myList[0] - {0}", _myList[0]);
            _myList[3] = "string3";
            _myList.Print();

            WriteTestName("Contains");

            Console.WriteLine("Is 'string6' contains in myList - {0}", _myList.Contains("string6"));
            Console.WriteLine("Is 'string3' contains in myList - {0}", _myList.Contains("string3"));

            WriteTestName("IndexOf");
            Console.WriteLine("IndexOf string2 - {0}", _myList.IndexOf("string2"));


            WriteTestName("Insert");
            _myList.Insert(2, "string4");
            _myList.Print();


            Console.ReadLine();
        }

        static void WriteTestName(string test)
        {
            Console.WriteLine("Test function  " + test);
            Console.WriteLine();
        }
    }

    class MessageBoxOutput
    {
        static public void Message(string str)
        {
            MessageBox.Show(str);
        }
    }
}
