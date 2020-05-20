using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace examination_2
{
    /// <summary>
    /// Class representing the ShapeGenerator
    /// </summary>
    class ShapeGenerator
    {
        /// <summary>
        /// Generates a random double between 2 values
        /// </summary>
        /// <param name="maxValue">A double with a standardvalue of 100</param>
        /// <param name="minValue">A double with a standardvalue of 0.01</param>
        /// <returns>A double</returns>
        static double GenerateDouble(double maxValue = 100, double minValue = 0.01)
        {
            return new Random().NextDouble() * (maxValue - minValue) + minValue;
        }

        /// <summary>
        /// Assigns values to the parameters of the shape
        /// </summary>
        /// <param name="length">The amount of parameters to assign values to</param>
        /// <param name="selectedType">The type of the shape</param>
        /// <returns>An instance of Shape</returns>
        static Shape AssignParameters(int length, Type selectedType)
        {
            if (length == 1)
            {
                return (Shape)Activator.CreateInstance(selectedType, GenerateDouble());
            }
            else if (length == 2)
            {
                return (Shape)Activator.CreateInstance(selectedType, GenerateDouble(), GenerateDouble());
            }
            else
            {
                return (Shape)Activator.CreateInstance(selectedType, GenerateDouble(), GenerateDouble(), GenerateDouble());
            }
        }

        /// <summary>
        /// Generates shapes based on how many the user wants to generate
        /// </summary>
        /// <param name="amount">Represents the amount of shapes to be generated</param>
        public static void GenerateShapes(int amount)
        {
            // Get assembly
            Assembly runningAssembly = Assembly.GetExecutingAssembly();

            // Define type
            Type shapeType = typeof(Shape);

            // Declare list for types
            List<Type> allShapeTypes = new List<Type>();

            // go through all types in our project and locate those who inherit Shape
            foreach (Type type in runningAssembly.GetTypes())
            {
                if (shapeType.IsAssignableFrom(type))
                {
                    string name = type.Name;
                    bool exists = Enum.IsDefined(typeof(ShapeType), name);
                    if (exists)
                    {
                        allShapeTypes.Add(type);
                    }
                }
            }

            // Declare list for shapes
            List<Shape3D> shapeList3D = new List<Shape3D>();
            List<Shape2D> shapeList2D = new List<Shape2D>();

            // Loop amount of shapes to generate
            for (int i = 0; i < amount; i++)
            {
                // Get random index 0-4
                int random = new Random().Next(0, 5);

                // Select type of random index
                Type selectedType = allShapeTypes[random];

                // Get all constructors for type
                ConstructorInfo[] constructors = selectedType.GetConstructors();
                int constructorSelector = 0;

                // Check if multiple constructors exists and pick 1 at random
                if (constructors.Length > 1)
                {
                    constructorSelector = new Random().Next(0, 2);
                }

                // Get number of parameters for selected constructor
                ParameterInfo[] parameters = constructors[constructorSelector].GetParameters();

                // Assign values to parameters and add shape to list
                Shape shape = AssignParameters(parameters.Length, selectedType);

                if (shape.Is3D)
                {
                    shapeList3D.Add((Shape3D)shape);
                }
                else
                {
                    shapeList2D.Add((Shape2D)shape);
                }
            }
            PrintShapes(shapeList2D, shapeList3D);
        }

        /// <summary>
        /// Loops and prints shapes with a formatted string
        /// </summary>
        static void PrintShapes(List<Shape2D> shapeList2D, List<Shape3D> shapeList3D)
        {
            IOrderedEnumerable<Shape2D> query2D =
                from shape in shapeList2D
                orderby shape.ShapeType, shape.Area descending
                select shape;

            IOrderedEnumerable<Shape3D> query3D =
                from shape in shapeList3D
                orderby shape.ShapeType, shape.Volume descending
                select shape;

            Console.WriteLine("2D Shapes:");
            foreach (Shape2D result in query2D)
            {
                Console.WriteLine(result.ToString("R"));
            }
            Console.WriteLine("\r\n" + "3D Shapes:");
            foreach (Shape3D result in query3D)
            {
                Console.WriteLine(result.ToString("R"));
            }

            Console.WriteLine("\r\n" + "Press Enter to return to the Main Menu:");
            Console.ReadKey();
            Console.Clear();
        }
    }
}