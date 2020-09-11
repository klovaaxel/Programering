using System;
using System.Collections.Generic;

namespace _4030_intro_arv_animal{
  class Program
  {
    static void Main(string[] args)
    {
      Cat minKatt = new Cat(5);
      minKatt.Act();
    }

  }

  class Cat
  {
    private int age {get;}

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
    private int age {get;}

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
    private Object cats;
    private Object dogs;

    public Zoo()
    {
      
    }  
  }   
}
