using System;
namespace C_Sharp_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string UserAnswer;
            char Operation;
            do
            {
                Console.WriteLine("Please Enter Your Number");
                float Number1 = Convert.ToSingle(Console.ReadLine());
                float Result = Number1;
                do
                {

                    Console.WriteLine("Please Enter Your Operation : + , - , * , /");
                    Operation = char.Parse(Console.ReadLine());

                    float Number;
                    switch (Operation)
                    {

                        case '+':
                            Console.WriteLine("Please Enter Your Number");
                            Number = Convert.ToSingle(Console.ReadLine());
                            Result += Number;
                            break;

                        case '-':
                            Console.WriteLine("Please Enter Your Number");
                            Number = Convert.ToSingle(Console.ReadLine());
                            Result -= Number;
                            break;

                        case '*':
                            Console.WriteLine("Please Enter Your Number");
                            Number = Convert.ToSingle(Console.ReadLine());
                            Result *= Number;
                            break;

                        case '/':
                            do
                            {
                                Console.WriteLine("Please Enter Your Number");
                                Number = Convert.ToSingle(Console.ReadLine());
                                if (Number != 0)
                                {
                                    Result /= Number;
                                }
                                else
                                {
                                    Console.WriteLine("Cannot divide by zero");
                                }
                            } while (Number == 0);
                            break;

                        case '=':
                            Console.WriteLine("Result = {0}", Result);
                            break;

                        default:
                            Console.WriteLine("Uncorrected Opertion {0}", Operation);
                            break;
                    }
                } while (Operation == '+' || Operation == '-' || Operation == '*' || Operation == '/' || Operation != '=');

                do
                {
                    Console.WriteLine("Do You Want Try Again ?? YES or NO");
                    UserAnswer = Console.ReadLine().ToUpper();

                } while (UserAnswer != "YES" && UserAnswer != "NO");

                Console.Clear();

            } while (UserAnswer == "YES");

            Console.Clear();
            Console.WriteLine("Welcom, Byee Byee");
        }
    }
}
