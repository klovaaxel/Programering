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
        protected String type;

        public String GetName() 
        {
            return name;
        }
        public String GetAuthor() 
        {
            return author;
        }
        public String ReturnType()
        {
            return type;
        }
    }

    class Cd : Sak
    {
        public Cd(String aName, String aAuthor) 
        {
            name = aName;
            author = aAuthor;
            type = "CD";
        }
    }

    class Dvd : Sak
    {
        public Dvd(String aName, String aAuthor)
        {
            name = aName;
            author = aAuthor;
            type = "DVD";
        }
    }

    class Book : Sak
    {
        public Book(String aName, String aAuthor)
        {
            name = aName;
            author = aAuthor;
            type = "Book";
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
                
                Console.Write(item.ReturnType() + ", ");
                Console.Write("Name: " + item.GetName() + ", ");
                Console.Write("Author: " + item.GetAuthor() + ".");
                Console.WriteLine();
            }
        }
    }
}
