using System;

namespace Hello_World
{
    class Program
    {
    static void Main(string[] args)
      {
          // kör koden för uppgift 1A
          Uppgift_1A();

          // kör koden för uppgift 1B
          Uppgift_1B();
          Uppgift_1C();
          Uppgift_1D();
          Uppgift_2A();
          Uppgift_2B();
      }

      static void Uppgift_1A()
      {
        Console.WriteLine("Vad heter du?");
        String namn = Console.ReadLine();
        Console.WriteLine("Välkommen " + namn + "!");
        Console.WriteLine("");
      }

      static void Uppgift_1B()
      {
        double bredd = 9.6;
        double höjd = 5.4;
        double area = (bredd * höjd) / 2;

        Console.WriteLine("bredd" + bredd);
        Console.WriteLine("Höjd" + höjd);
        Console.WriteLine("Area" + area);
        Console.WriteLine("");

      }

      static void Uppgift_1C() {
        Console.WriteLine("beräkna area triangel");
        Console.WriteLine("Bredd: ");
        String bredd = Console.ReadLine();
        double dBredd = Convert.ToDouble(bredd);
        Console.WriteLine("Höjd");
        String höjd = Console.ReadLine();
        double dHöjd = Convert.ToDouble(höjd);
        double area = (dBredd * dHöjd) / 2;
        Console.WriteLine("triangle arean är " + area);
        Console.WriteLine("");
      }

      static void Uppgift_1D() {
          Console.WriteLine("Summan av två tal");
          Console.WriteLine("skriv första talet: ");
          String tal1 = Console.ReadLine();
          double dTal1 = Convert.ToDouble(tal1);
          Console.WriteLine("skriv andra talet: ");
          String tal2 = Console.ReadLine();
          double dTal2 = Convert.ToDouble(tal2);

          Console.WriteLine("Summan av de två talen är :" + (dTal1 + dTal2));
          Console.WriteLine("");
        
      }
      static void Uppgift_2A(){
          Console.WriteLine("Skriv ut gissa mitt favorittal.");
          String favorittal = Console.ReadLine();
          double dFavorittal = Convert.ToDouble(favorittal);

          if (dFavorittal == 3) {
              Console.WriteLine("Du gissde rätt");
          }
          else{
              Console.WriteLine("Du gissde fel");
          }

      }
      static void Uppgift_2B(){
        Random randomGenerator = new Random();
        int tärning1 = randomGenerator.Next(1, 7);
        Console.WriteLine("första tärningen blev " + tärning1);
        int tärning2 = randomGenerator.Next(1, 7);
        Console.WriteLine("adnra tärningen blev " + tärning2);

        if (tärning1 == tärning2){
            Console.WriteLine("Vinst!!");
        }
        else{
            Console.WriteLine("Förlust!!");
        }

      }
    }
}
