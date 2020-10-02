using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace _4060
{
    class Program
    {

        static void Main(string[] args) 
        {
            Database myDatabase = new Database();
            myDatabase.AddShape3D(new Sphere(4));
            myDatabase.AddShape3D(new Cylinder(4, 6.0));
            myDatabase.AddShape3D(new Cube(3.0));
            myDatabase.Print();
        }
    }
    class Database
    {
        List<Shape3D> shapes = new List<Shape3D>();

        public void Print() 
        {
            foreach (Shape3D shape in shapes) 
            {
                Console.WriteLine(shape.GetType().Name);
                shape.PrintProprietary();
                Console.WriteLine("Area: " + shape.GetArea());
                Console.WriteLine("Volume: " + shape.GetVolume());
                Console.WriteLine("");
            }
        }

        public void AddShape3D(Shape3D shape) 
        {
            shapes.Add(shape);
        }
    }

    interface Shape3D
    {
        double GetArea();
        double GetVolume();
        void PrintProprietary();
    }

    class Sphere : Shape3D
    {
        private double radius;
        public Sphere(double aRadius)
        {
            radius = aRadius;
        }
        public double GetArea()
        {
            return 4 * Math.PI * radius * radius;
        }
        public double GetVolume()
        {
            return (4d / 3d) * Math.PI * (radius * radius * radius);
        }

        public void PrintProprietary() 
        {
            Console.WriteLine("Radius: " + radius);
        }
    }

    class Cylinder : Shape3D
    {
        private double radius;
        private double height;
        public Cylinder(double aRadius, double aHeight)
        {
            radius = aRadius;
            height = aHeight;
        }
        public double GetArea() 
        {
            return 2 * Math.PI * radius * height + 2 * Math.PI * radius * radius;
        }
        public double GetVolume() 
        {
            return Math.PI * radius * radius * height;
        }
        public void PrintProprietary()
        {
            Console.WriteLine("Radius: " + radius);
            Console.WriteLine("Height: " + height);
        }
    }

    class Cube : Shape3D
    {
        private double length;
        public Cube(double aLength)
        {
            length = aLength;
        }
        public double GetArea()
        {
            return 6 * length * length;
        }
        public double GetVolume() 
        {
            return length * length * length;
        }
        public void PrintProprietary()
        {
            Console.WriteLine("length of side: " + length);
        }
    }
}
