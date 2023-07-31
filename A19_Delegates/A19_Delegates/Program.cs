using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A19_Delegates
{
    public delegate int ArithmeticOperation(int n1, int n2);
    internal class Program
    {
        public static int Add(int n1, int n2)
        {
            return n1 + n2;
        }
        public static int Subtract(int n1, int n2)
        {
            return n1 - n2;
        }
        public static int Multiply(int n1, int n2)
        {
            return n1 * n2;
        }
        public static int Divide(int n1, int n2)
        {
            return n1 / n2;
        }
        static void Main(string[] args)
        {
            try
            {
            again:
                Console.WriteLine("\n********************************");
                Console.WriteLine("Delegates");
                int fn, sn, result;
                Console.WriteLine("Enter first Number: ");
                fn = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second Number: ");
                sn = int.Parse(Console.ReadLine());

                Console.WriteLine("1.Addition \n2.Subtraction \n3.Multiplication \n4.Division");
                Console.WriteLine("Choose an Arithmetic Operation to perform");
                int ch = int.Parse(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        {
                            ArithmeticOperation obj = new ArithmeticOperation(Add);
                            result = obj(fn, sn);
                            Console.WriteLine($"Addition of {fn} and {sn} = " + result);
                            break;
                        }
                    case 2:
                        {
                            ArithmeticOperation obj = new ArithmeticOperation(Subtract);
                            result = obj(fn, sn);
                            Console.WriteLine($"Subtraction of {fn} and {sn} = " + result);
                            break;
                        }
                    case 3:
                        {
                            ArithmeticOperation obj = new ArithmeticOperation(Multiply);
                            result = obj(fn, sn);
                            Console.WriteLine($"Multiplication of {fn} and {sn} = " + result);
                            break;
                        }
                    case 4:
                        {
                            ArithmeticOperation obj = new ArithmeticOperation(Divide);
                            result = obj(fn, sn);
                            Console.WriteLine($"Division of {fn} and {sn} = " + result);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid Choice!!");
                            break;
                        }
                }
                Console.WriteLine("Do you want to continue y/n ?");
                char op = Console.ReadKey().KeyChar;
                if (op == 'y')
                {
                    goto again;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Error!! "+e.Message);
            }
            finally
            {
                
                Console.ReadKey();
            }
        }
    }
}
