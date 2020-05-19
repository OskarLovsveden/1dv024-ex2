using System;
using System.Collections.Generic;
using System.Reflection;

namespace examination_2
{
    class Application
    {
        public static void Run()
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose what to do:");
            Console.WriteLine("1) Generate shapes");
            Console.WriteLine("0) Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    // Generate Shapes
                    Console.Clear();
                    ShapesMenu();
                    return true;
                case "0":
                    // Exit Program
                    return false;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid Input. Press Enter to go back to the main menu");
                    Console.ReadKey();
                    return true;
            }
        }

        public static void ShapesMenu()
        {
            int total;

            while (true)
            {
                Console.WriteLine("Choose how many shapes to generate: (1-50)");
                try
                {
                    if (!int.TryParse(Console.ReadLine(), out total))
                    {
                        throw new ArgumentException("Invalid Input");
                    }
                    else if (total < 1 || total > 50)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    else
                    {
                        break;
                    }
                }
                catch (Exception error)
                {
                    Console.Clear();
                    Console.WriteLine(error.Message);
                }

            }
            Console.Clear();
            GenerateShapes(total);
        }

        public static Shape AssignParameters(int length, Type selectedType)
        {
            if (length == 1)
            {
                return (Shape)Activator.CreateInstance(selectedType, 1);
            }
            else if (length == 2)
            {
                return (Shape)Activator.CreateInstance(selectedType, 1, 2);
            }
            else
            {
                return (Shape)Activator.CreateInstance(selectedType, 1, 2, 3);
            }
        }

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
            List<Shape> shapeList = new List<Shape>();

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
                shapeList.Add(AssignParameters(parameters.Length, selectedType));
            }

            // Loop List and render based of is3D
            foreach (Shape shape in shapeList)
            {
                Console.WriteLine(shape.ToString("R"));
                Console.WriteLine("-------------");

            }
            // 2D sort by area
            // 3D sort by volume
            Console.ReadKey();
        }
    }
}
