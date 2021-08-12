using System;

namespace Figures
{
    class Program
    {
        static void Main(string[] args)
        {

            bool restart = true;
            while (restart == true)
            {
                try
                {            
                    


                        Console.WriteLine("\nWhat operation do you want to perform\n");
                        Console.WriteLine("1.Calculate the area");
                        Console.WriteLine("2.calculat the perimeter");
                        Double operation = Convert.ToDouble(Console.ReadLine());
                        if (operation == 1 || operation == 2)
                        {
                            Console.WriteLine("Area of which shape you want to calculate:");
                            Console.WriteLine("1.Square");
                            Console.WriteLine("2.Rectangle");
                            Console.WriteLine("3.Triangle");
                            int figure = Convert.ToInt16(Console.ReadLine());
                            if (operation == 1)
                            {
                                switch (figure)
                                {

                                    case 1:
                                        Console.WriteLine("\nArea of square\n");
                                        Console.WriteLine("Enter the length of the side");
                                        double sideSquare = Convert.ToInt32(Console.ReadLine());
                                        if (sideSquare == 0)
                                        {
                                        DoesNotExist();
                                        }
                                        else
                                        {
                                            double resultSquare = Math.Pow(sideSquare, 2);
                                            Console.WriteLine($"The area of ​​your square is: {resultSquare}cm²");
                                        }
                                        break;

                                    case 2:
                                        Console.WriteLine("\nArea of rectangle\n");
                                        Console.WriteLine("Enter the length of the first side: ");
                                        double sideRectangle01 = Convert.ToDouble(Console.ReadLine());
                                        Console.WriteLine("Enter the length of the other side: ");
                                        double sideRectangle02 = Convert.ToDouble(Console.ReadLine());
                                        if (sideRectangle01 == 0 || sideRectangle02 == 0)
                                        {
                                        DoesNotExist();
                                        }
                                        else
                                        {
                                            double resultRectangle = sideRectangle01 * sideRectangle02;
                                            Console.WriteLine($"The area of ​​your rectangle is: {resultRectangle}cm²");
                                        }
                                        break;

                                    case 3:
                                        Console.WriteLine("\nArea of triangle\n");
                                        Console.WriteLine("Enter the base: ");
                                        double baseTriangle = Convert.ToDouble(Console.ReadLine());
                                        Console.WriteLine("Enter the height: ");
                                        double heightTriangle = Convert.ToDouble(Console.ReadLine());
                                        if (baseTriangle == 0 || heightTriangle == 0)
                                        {
                                        DoesNotExist();
                                        }
                                        else
                                        {
                                            double resultTriangle = (baseTriangle / 2) * heightTriangle;
                                            Console.WriteLine($"The area of your triangle is: {resultTriangle}cm²");
                                        }
                                        break;
                                    default:
                                    Error(ref restart);
                                    break;
                                }
                            }
                            else if (operation == 2)
                            {
                                switch (figure)
                                {
                                    case 1:
                                        Console.WriteLine("\nPerimeter of square\n");
                                        Console.WriteLine("Enter the length of the side");
                                        double sideSquare = Convert.ToInt32(Console.ReadLine());
                                        if (sideSquare == 0)
                                        {
                                        DoesNotExist();
                                        }
                                        else
                                        {
                                            double resultSquare = sideSquare * 4;
                                            Console.WriteLine("Perimeter of square is: " + resultSquare);
                                        }
                                        break;

                                    case 2:
                                        Console.WriteLine("\nPerimeter of rectangle\n");
                                        Console.WriteLine("Enter the length of the first side: ");
                                        double sideRectangle01 = Convert.ToDouble(Console.ReadLine());
                                        Console.WriteLine("Enter the length of the other side: ");
                                        double sideRectangle02 = Convert.ToDouble(Console.ReadLine());
                                        if (sideRectangle01 == 0 || sideRectangle02 == 0)
                                        {
                                        DoesNotExist();
                                        }
                                        else
                                        {
                                            double resultRectangle = sideRectangle01 * 2 + sideRectangle02 * 2;
                                            Console.WriteLine("Perimeter of rectangle is: " + resultRectangle);
                                        }
                                        break;
                                    case 3:
                                        Console.WriteLine("\nPerimeter of triangle\n");
                                        Console.WriteLine("Enter the length of the first side: ");
                                        double sideTriangle01 = Convert.ToDouble(Console.ReadLine());
                                        Console.WriteLine("Enter the length of the second side: ");
                                        double sideTriangle02 = Convert.ToDouble(Console.ReadLine());
                                        Console.WriteLine("Enter the length of the third side: ");
                                        double sideTriangle03 = Convert.ToDouble(Console.ReadLine());
                                        if (sideTriangle01 == 0 || sideTriangle02 == 0 || sideTriangle03 == 0)
                                        {
                                        DoesNotExist();
                                        }
                                        else
                                        {
                                            double resultTriangle = sideTriangle01 + sideTriangle02 + sideTriangle03;
                                            Console.WriteLine("Perimeter of triangle is: " + resultTriangle);
                                        }
                                        break;

                                    default:
                                    Error(ref restart);
                                    break;
                                }

                                
                            }
                        repeat(out restart);
                    }
                        else
                        {
                        Error(ref restart);
                    }
                }
                catch (Exception)
                {
                    Error(ref restart);
                }

            }

        }

        static void Error(ref bool restart)
        {
            restart = true;
            try
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid option");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("\n Do you want to try again?");
                Console.WriteLine("1.Yes");
                Console.WriteLine("2.No");
                Double powtorka = Convert.ToDouble(Console.ReadLine());
                if (powtorka == 1)
                {             
                    Console.Clear();
                }
                else if (powtorka == 2)
                {
                    restart = false;
                   
                }
                else
                {
                    Error(ref restart);
                }
            }
            catch (Exception)
            {
                Error(ref restart);
            }
        }
        static void repeat(out bool restart)
        {
            restart = true;
            try
            {
                Console.WriteLine("\nDo you want to try again?");
                Console.WriteLine("1.Yes");
                Console.WriteLine("2.No");
                Double repeat = Convert.ToDouble(Console.ReadLine());
                if (repeat == 1)
                {
                    Console.Clear();
                    
                }
                else if (repeat == 2)
                {
                    restart = false;
                    
                }
                else
                {
                    Error(ref restart);
                }
            }
            catch (Exception)
            {
                Error(ref restart);
            }
        }
        static void DoesNotExist()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" \nThe figure does not exist\n");
            Console.ForegroundColor = ConsoleColor.Gray;

        }


    }
}









