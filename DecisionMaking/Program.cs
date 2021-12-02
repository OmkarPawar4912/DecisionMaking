using System;

namespace DecisionMaking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Total Student :  ");
            try
            {
                int total = Int32.Parse(Console.ReadLine());
                int pass = 0;
                int fail = 0;
                for (int i = 0; i < total; i++)
                {
                    Console.Write("Enter Student Name  :  ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Student Name : {0}", name);
                    Random random = new Random();
                    random.Next(1, 100);
                    int c = random.Next(1, 100);
                    int java = random.Next(1, 100);
                    int php = random.Next(1, 100);
                    Console.WriteLine("Subject      : C#        Java         PHP ");
                    Console.WriteLine("Mark         : {0}        {1}          {2} ", php, java, c);
                    int avarage = (c + java + php) / 3;
                    Console.WriteLine("Avarage      : {0} ", avarage);
                    string result = "Fail";
                    if (avarage <= 35)
                    {
                        result = "Pass";
                        pass = pass + 1;
                    }
                    if (result == "Fail")
                    {
                        fail = fail + 1;
                    }

                    Console.WriteLine("-----------------------------------------------------");
                    Console.WriteLine("Result       : {0}", result);
                    Console.WriteLine("-----------------------------------------------------");
                }
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine("Total Student : {0}   Total Pass : {1}  Total Fail : {2}", total, pass, fail);
                Console.WriteLine("-----------------------------------------------------");
            }
            catch(FormatException)
            {
                Console.Write("Enter number only");
            }
            Console.Read();
        }
    }

}