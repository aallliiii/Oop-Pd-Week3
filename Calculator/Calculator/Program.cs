using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Calculator.BL;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option;
            double value1;
            double value2;
            Console.WriteLine("Press 1 to perform binary calculation");
            Console.WriteLine("Press 2 to perform unary calculation");
            option = int.Parse(Console.ReadLine());
            if (option == 1)
            {
                CalculatorClass c = new CalculatorClass();
                while (true)
                {
                    Console.Clear();
                    double answer;
                    int calculation;
                    Console.WriteLine("Press 1 to create a object of calculator");
                    Console.WriteLine("Press 2 to change the values of attributes");
                    Console.WriteLine("Press 3 to Add");
                    Console.WriteLine("Press 4 to Subtract");
                    Console.WriteLine("Press 5 to Multiply");
                    Console.WriteLine("Press 6 to divide");
                    Console.WriteLine("Press 7 to find mod");
                    calculation = int.Parse(Console.ReadLine());
                    if (calculation == 1)
                    {
                        Console.Write("Enter Value 1: ");
                        value1 = double.Parse(Console.ReadLine());
                        Console.Write("Enter Value 2: ");
                        value2 = double.Parse(Console.ReadLine());
                        c = new CalculatorClass(value1, value2);
                    }
                    else if (calculation == 2)
                    {
                        Console.Write("Enter New Value 1: ");

                        c.value1 = double.Parse(Console.ReadLine());
                        Console.Write("Enter New Value 2: ");
                        c.value2 = double.Parse(Console.ReadLine());
                    }

                    else if (calculation == 3)
                    {
                        answer = c.Add();
                        Console.WriteLine(answer);
                        Console.ReadLine();
                    }
                    else if (calculation == 4)
                    {
                        answer = c.Subtract();
                        Console.WriteLine(answer);
                        Console.ReadLine();
                    }
                    else if (calculation == 5)
                    {
                        answer = c.Multiply();
                        Console.WriteLine(answer);
                        Console.ReadLine();
                    }
                    else if (calculation == 6)
                    {
                        answer = c.Divide();
                        Console.WriteLine(answer);
                        Console.ReadLine();
                    }
                    else if (calculation == 7)
                    {
                        answer = c.Mod();
                        Console.WriteLine(answer);
                        Console.ReadLine();
                    }
                }
            }
            else if (option == 2)
            {
                double answer;
                int option1;
                CalculatorClass i = new CalculatorClass();
                Console.WriteLine("Enter Value: ");
                i.value1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Press 1 to find square root");
                Console.WriteLine("Press 2 to find Exponent");
                Console.WriteLine("Press 3 to find log");
                Console.WriteLine("Press 4 to find sin(value in radians)");
                Console.WriteLine("Press 5 to find cos(value in radians)");
                Console.WriteLine("Press 6 to find tan(value in radians)");
                option1 = int.Parse(Console.ReadLine());
                if (option1 == 1)
                {
                    answer = i.SquareRoot();
                    Console.WriteLine(answer);
                    Console.ReadLine();
                }
                else if (option1 == 2)
                {
                    answer = i.Exponent();
                    Console.WriteLine(answer);
                    Console.ReadLine();
                }
                else if (option1 == 3)
                {

                    answer = i.Log();
                    Console.WriteLine(answer);
                    Console.ReadLine();
                }
                else if (option1 == 4)
                {

                    answer = i.Sin();
                    Console.WriteLine(answer);
                    Console.ReadLine();
                }
                else if (option1 == 5)
                {
                    answer = i.Cos();
                    Console.WriteLine(answer);
                    Console.ReadLine();
                }
                else if (option1 == 6)
                {
                    answer = i.Tan();
                    Console.WriteLine(answer);
                    Console.ReadLine();
                }
            }
            }
        }
    } 

