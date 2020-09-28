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
        }
    }
    class Database
    {
        List<Shape3D> shapes = new List<Shape3D>();

        public void Print() 
        {
            foreach (Shape3D shape in shapes) 
            {
                Console.Write(shape.GetType().Name + ", ");
                Console.Write("Area: " + shape.GetArea());
                Console.Write("Volume" + shape.GetVolume());
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
    }

    class Sphere : Shape3D
    {
        private double radius;
        public double GetArea()
        {
            return 4 * Math.PI * radius * radius;
        }
        public double GetVolume()
        {
            return 4 * Math.PI * radius * radius / 3;
        }

        public Sphere(double aRadius) 
        {
            radius = aRadius;
        }
    }

    class Cylinder : Shape3D
    {
        private double radius;
        private double height;

        public double GetArea() 
        {
            return 2 * Math.PI * radius * height + 2 * Math.PI * radius * radius;
        }
        public double GetVolume() 
        {
            return Math.PI * radius * radius * height;
        }
        public Cylinder(double aRadius, double aHeight) 
        {
            radius = aRadius;
            height = aHeight;
        }
    }

    class Cube : Shape3D
    {
        private double length;

        public double GetArea()
        {
            return 6 * length * length;
        }
        public double GetVolume() 
        {
            return length * length * length;
        }
        public Cube(double aLength) 
        {
            length = aLength;
        }
    }
}
