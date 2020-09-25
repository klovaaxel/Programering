using System;
using System.Collections.Generic;
using System.Dynamic;

namespace _4040
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

    class Sak {
        protected String name;
        protected String author;

        public String GetName() 
        {
            return name;
        }

        public virtual void Print() 
        { 

        }
   
    }

    class Cd : Sak
    {
        private String Artist;
        public Cd(String aName, String aAuthor) 
        {
            name = aName;
            Artist = aAuthor;
        }
        public override void Print()
        {
            Console.Write("Artist: " + Artist + ", ");
        }

    }

    class Dvd : Sak
    {
        private String Regissor;

        public Dvd(String aName, String aAuthor)
        {
            name = aName;
            Regissor = aAuthor;
        }
        public override void Print()
        {
            Console.Write("Regissor: " + Regissor + ", ");
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
            foreach (var item in saker) {

                Console.Write(item.GetType().Name + ", ");
                Console.Write("Name: " + item.GetName() + ", ");
                item.Print();
                Console.WriteLine();
            }
        }
    }
}
