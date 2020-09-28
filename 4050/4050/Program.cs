using System;
using System.Collections.Generic;
using System.Dynamic;

namespace _4050
{
    class Program
    {
        static void Main(string[] args)
        {
            Database myData = new Database();
            myData.Add(new Cd("Hello", "Joakim"));
            myData.Add(new Dvd("olleH", "Anton"));
            myData.Add(new Book("Hej", "Anton och Joakim"));

            myData.PrintDatabase();
        }
    }

    abstract class Sak
    {
        protected String name;

        public String GetName()
        {
            return name;
        }

        public abstract void Print();

    }

    class Cd : Sak
    {
        private String artist;
        public Cd(String aName, String aAuthor)
        {
            name = aName;
            artist = aAuthor;
        }
        public override void Print()
        {
            Console.Write("Artist: " + artist + ", ");
        }

    }

    class Dvd : Sak
    {
        private String regissor;

        public Dvd(String aName, String aAuthor)
        {
            name = aName;
            regissor = aAuthor;
        }
        public override void Print()
        {
            Console.Write("Regissor: " + regissor + ", ");
        }
    }

    class Book : Sak
    {
        private String forfattare;
        public Book(String aName, String aAuthor)
        {
            name = aName;
            forfattare = aAuthor;
        }
        public override void Print()
        {
            Console.Write("Forfattare: " + forfattare + ", ");
        }
    }

    class Database
    {
        private List<Sak> saker = new List<Sak>();

        public void Add(Sak aThing)
        {
            saker.Add(aThing);
        }

        public void PrintDatabase()
        {
            foreach (var item in saker)
            {

                Console.Write(item.GetType().Name + ", ");
                Console.Write("Name: " + item.GetName() + ", ");
                item.Print();
                Console.WriteLine();
            }
        }
    }
}