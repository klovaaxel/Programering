using System;
using System.Collections.Generic;

namespace _4030_intro_arv_animal{
  class Program
  {
    static void Main(string[] args)
    {
        Zoo myZoo = new Zoo();
        myZoo.Act();
    }

  }

  class Cat
  {
    public int age {get;}

    public Cat(int publicAge)
    {
      age = publicAge;
    }

    public void Act()
    {
      for (int i = 0; i < age; i++)
      {
            Console.Write("mjau, ");
      }
    }
  }

  class Dog
  {
    public int age { get;}

    public Dog(int publicAge)
    {
      age = publicAge;
    }

    public void Act()
    {
      for (int i = 0; i < age; i++)
      {
        Console.Write("vov, ");
      }
    }
  }


  class Zoo
  {
    List<Cat> Cats = new List<Cat>();
    List<Dog> Dogs = new List<Dog>();

    public Zoo()
    {
        Cats.Add(new Cat(5));
        Cats.Add(new Cat(2));
        Cats.Add(new Cat(3));

        Dogs.Add(new Dog(2));
        Dogs.Add(new Dog(3));



    }

    public void Act()
    {
        foreach (var cat in Cats) {
            for (int i = 0; i < cat.age; i++)
            {
                Console.Write("mjau, ");
            }
            Console.WriteLine("");
        }
        foreach (var dog in Dogs) {
            for (int i = 0; i < dog.age; i++)
            {
                Console.Write("vov, ");
            }
            Console.WriteLine("");
        }
    }
  }

}
