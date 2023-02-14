using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class Book
    {
        /*string name { get; set; }
        int year { get; set; }
        string author { get; set; }
        string genre { get; set; }*/

        public string[] ar = new string[1];

        public Book() { }

        public Book(string s)
        {
            ar[0] = s;
        }


        public void Input()
        {
            WriteLine("Введите название книги:");
            ar[ar.Length - 1] = ReadLine();
        }
        public void Print()
        {
            for (int i = 0; i < ar.Length; i++)
            {
                WriteLine($"{ 0,4}", ar[i]);
            }
            WriteLine();
        }
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < ar.Length)
                {
                    return ar[index];
                }
                else
                {
                    throw new Exception("Некорректный индекс! " + index);
                }
            }
            set
            {
                if (index >= 0 && index < ar.Length)
                {
                    ar[index] = value;
                }
                else
                {
                    throw new Exception("Некорректный индекс! " + index);
                }
            }

        }


        class Program
        {
            static void Main(string[] args)
            {
                Book a = new Book("Baki");
                a.Input();
                a.Input();
                WriteLine();
                a.Print();
                Console.WriteLine($"\t{a[0]}");
            }
        }
    }
}


