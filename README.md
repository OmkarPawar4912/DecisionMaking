# DecisionMaking
```
using System;

namespace DecisionMaking
{
    class Program
    {
        static void Main(string[] args)
        {
            Mark mark = new Mark();
            Console.Write("Enter Total Student :  ");
            string userInput = Console.ReadLine();
            int total;
            if (int.TryParse(userInput, out total))
            {
                Console.WriteLine("=======================================================================");
                for (int i = 0; i < total; i++)
                {
                    mark.GetName();
                    mark.GetToal();
                    mark.GetMark();
                }
            }
            else
            {
                Console.WriteLine("Not a valid number, try again.");
                Console.Beep();
            }
            Console.Read();
        }
    }
    class Student
    {
        public string Name { get; set; }
        public void GetName()
        {
            Console.Write("Enter Student Name  :  ");
            Name = Console.ReadLine();
        }
        
    }
    class Mark : Student
    {
        public int Php { get; set; }
        public int Java { get; set; }
        public int C { get; set; }
        public int Total { get; set; }
        public int Avarage { get; set; }      
        public void GetToal()
        {
            Random random = new Random();
            Php = random.Next(1, 100);
            Java = random.Next(1, 100);
            C = random.Next(1, 50);
            Total = Php + Java + C;
            Avarage = Total / 3;
        }
        public int GetMark()
        {
            Console.WriteLine("Subject      : C#        Java         PHP ");
            Console.WriteLine("Mark         : {0}        {1}            {2} ", Php, Java, C);
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("Total        : {0}       Avarage      : {1}", Total, Avarage);
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("Result       : {0} ", (Avarage >= 35) ? "Pass" : "Fail");
            Console.WriteLine("=======================================================================");
            return 1;
        }
    }
}
