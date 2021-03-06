using System;

namespace examination_2
{
    /// <summary>
    /// Class representing the Menu
    /// </summary>
    class Menu
    {
        /// <summary>
        /// Main Menu
        /// </summary>
        /// <returns>Returns true or false</returns>
        public static bool MainMenu()
        {
            while (true)
            {
                Console.WriteLine("Choose what to do:");
                Console.WriteLine("1) Generate shapes");
                Console.WriteLine("0) Exit");
                Console.Write("\r\nSelect an option: ");

                try
                {
                    switch (Console.ReadLine())
                    {
                        case "1":
                            Console.Clear();
                            ShapesMenu();
                            break;
                        case "0":
                            return false;
                        default:
                            throw new ArgumentException("Invalid Input");
                    }
                }
                catch (Exception error)
                {
                    Console.Clear();
                    Console.WriteLine(error.Message + "\r\n");
                }

            }
        }

        /// <summary>
        /// The Menu for picking how many shapes to generate
        /// </summary>
        static void ShapesMenu()
        {
            int total;

            while (true)
            {
                Console.WriteLine("Choose how many shapes to generate: (1-50)");
                Console.Write("Amount: ");
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
                    Console.WriteLine(error.Message + "\r\n");
                }

            }
            Console.Clear();
            Console.WriteLine(total);
            ShapeGenerator.GenerateShapes(total);
        }
    }
}