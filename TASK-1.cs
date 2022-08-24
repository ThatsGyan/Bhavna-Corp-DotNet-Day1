using System.Linq.Expressions;
using System.Net.Cache;

namespace TASK_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter your Name : ");
            string Name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Hi ! " + Name);
            Console.WriteLine("Press \"I\" for input your details and Press \"P\"for watching your details"  );

            string input = Console.ReadLine();

            switch (input)
            {
                case I:
                    Console.WriteLine("Enter your Age :");
                    int Age = Console.ReadLine();
                    Console.WriteLine("Enter your Address :");
                    string Address = Console.ReadLine();
                    Console.WriteLine("Enter your Course name :");
                    string CName = Console.ReadLine();
                    Console.WriteLine("Enter your Age Contact Number:");
                    int CNumber = Console.ReadLine();
                    break;
                case P:
                    Console.WriteLine("Your name :" + Name + "\nAge : " + Age + "\nAddress : " + Address + "\nCourse name : " + CName + "\nContact number : " + CNumber);
                default:
                    Console.WriteLine("Your name :" + Name + "\nAge : " + Age + "\nAddress : " + Address + "\nCourse name : " + CName + "\nContact number : " + CNumber);
                    break;
            }







            Console.WriteLine("Hello ..." + Name + "These are your details which are submitted to our organization");

            

            Console.WriteLine("Your name :" +Name+"\nAge : "+Age+"\nAddress : "+Address+"\nCourse name : "+CName+"\nContact number : "+CNumber);
        }
    }
}
