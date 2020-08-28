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
          Uppgift_3A();
          Uppgift_3B();
          Uppgift_3C();
          Uppgift_4A();
          Uppgift_4B();
          Uppgift_4C();
          Uppgift_5();
          Uppgift_6();
          Uppgift_7A();
          Uppgift_8A();
          Uppgift_8B();
          Uppgift_9A();
          Uppgift_9B12();
          Uppgift_9B3();
          Uppgift_10A();


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
          Console.WriteLine("");

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
        Console.WriteLine("");

      }

      static void Uppgift_3A(){
        int numloop1 = 1;
        while(numloop1 < 6){
          Console.WriteLine(numloop1);
          numloop1 += 1;
        }
        Console.WriteLine("");

      }

      static void Uppgift_3B(){
        int numloop2 = 5;
        while(numloop2 < 21){
          Console.WriteLine(numloop2);
          numloop2 += 3;
        }
        Console.WriteLine("");
      }

      static void Uppgift_3C(){
        int numloop3 = 10;
        while(numloop3 > -1){
          Console.Write(numloop3 + ", ");
          numloop3 -= 1;
        }
        Console.WriteLine("");
      }

      static void Uppgift_4A(){
        for (int i = 0; i < 6; i++)
        {
          Console.Write(i + ", ");
        }
        Console.WriteLine("");
      }

      static void Uppgift_4B(){
        for (int i = 5; i < 21; i += 3)
        {
          Console.Write(i + ", ");
        }
        Console.WriteLine("");
      }

      static void Uppgift_4C(){
        for (int i = 10; i > -1; i--)
        {
          Console.Write(i + ", ");
        }
        Console.WriteLine("");
      }

      static void Uppgift_5(){
        Console.WriteLine("Gissa numret: ");
        String sGues = Console.ReadLine();
        double dGues = Convert.ToDouble(sGues);

        while (dGues != 15)
        {
          Console.WriteLine("Fel, Gissa igen: ");
          sGues = Console.ReadLine();
          dGues = Convert.ToDouble(sGues);
        }
        Console.WriteLine("du gissade rätt");
        Console.WriteLine("");

      }

      static void Uppgift_6(){

      }

      static void Uppgift_7A(){
        int[] array1 = {1, 5, 7, 9, 11, 13};
        Console.WriteLine("");

      }

      static void Uppgift_8A(){
        int[] array1 = {1, 5, 7, 9, 11, 13};
        foreach (var item in array1)
        {
          Console.Write(item + ", ");
          Console.WriteLine("");

        }
      }
       static void Uppgift_8B(){
        int[] array1 = {1, 5, 7, 9, 11, 13};
        foreach (var item in array1)
        {
          Console.Write((item + 1) + ", ");
          Console.WriteLine("");

        }
      }
      static void Uppgift_9A(){
        Console.WriteLine("Välkommen Agent X. Ditt uppdrag är ...");
        Console.WriteLine("");

      }

      static void Uppgift_9B12(){
        Console.WriteLine("Enter Number one: ");
        String sNum1 = Console.ReadLine();
        double dNum1 = Convert.ToDouble(sNum1);
        Console.WriteLine("Enter Number two: ");
        String sNum2 = Console.ReadLine();
        double dNum2 = Convert.ToDouble(sNum2);

        Console.WriteLine("The sum is: " + addera(dNum1, dNum2));
      }

      private static double addera(double num1, double num2){
        return (num1 + num2);
      }

      static void Uppgift_9B3(){
        Console.WriteLine("Enter Number one: ");
        String sNum1 = Console.ReadLine();
        double dNum1 = Convert.ToDouble(sNum1);
        Console.WriteLine("Enter Number two: ");
        String sNum2 = Console.ReadLine();
        double dNum2 = Convert.ToDouble(sNum2);
        Console.WriteLine("Enter Number three: ");
        String sNum3 = Console.ReadLine();
        double dNum3 = Convert.ToDouble(sNum3);

        Console.WriteLine("The sum is: " + addera2(dNum1, dNum2, dNum3));
      }
      private static double addera2(double num3, double num4, double num5){
        return (num3 + num4 + num5);
      }

      static void Uppgift_10A(){
        String[] products = new string[50];

        Console.WriteLine("Enter shopping artciles and when done enter 'done'");
        Console.WriteLine("(max 50 items)");

        String product = Console.ReadLine();
        for (int i = 0; product != "done"; i++)
        {
          products[i] = product;
          Console.WriteLine("Enter shopping artciles and when done enter 'done'");
          product = Console.ReadLine();
        }
        
        Console.WriteLine("");
        Console.WriteLine("--- Shopping List ---");
        foreach (var item in products)
        {
          if (item != null)
          {
            Console.WriteLine(item);
          }
        }
      
        
      }
    }
}
