using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A19_GenericDelegates
{
    delegate T Operation<T>(T n1, T n2);
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
                Console.WriteLine("\n*******************************");
                Console.WriteLine("Generic Delegates ");
                Operation<int> addDel = Add;
                Operation<int> subtractDel = Subtract;
                Operation<int> multiplyDel = Multiply;
                Operation<int> divideDel = Divide;
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
                            result = addDel(fn, sn);
                            Console.WriteLine("Result = " + result);
                            break;
                        }
                    case 2:
                        {
                            result = subtractDel(fn, sn);
                            Console.WriteLine("Result = " + result);
                            break;
                        }
                    case 3:
                        {
                            result = multiplyDel(fn, sn);
                            Console.WriteLine("Result = " + result);
                            break;
                        }
                    case 4:
                        {
                            result = divideDel(fn, sn);
                            Console.WriteLine("Result = " + result);
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
