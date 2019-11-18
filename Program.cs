using System;
//Comment Latest Name and Date
//Khali Tran - 2019-11-13
namespace assignment_four
{
    class Program
    {
        static void Main(string[] args)
        {
            //Global Declarations
            int dayCount;
            string code;
            double totalCost;

            houseKeeping();
            ComputeRate(int dayCount);
            ComputeRate(int dayCount, string code);
            conclude(int dayCount,string code,double totalCost);
        }

        static void houseKeeping(){
            int dayCount;
            Console.WriteLine("Enter how many days the dog will stay");
            dayCount = Convert.ToInt32(Console.ReadLine());
            return dayCount;

            string code;
            Console.WriteLine("Enter add-on code");
            code = Console.ReadLine();
            return code;

        }

        static int ComputeRate(){

        }

        static int ComputeRate(){

        }

        static void conclude(int dayCount,string code, double totalCost){

        }
        
        do
        {
            
        } while (true);

        //Overloaded method with one argument




        //Overloaded method with two arguments
    }
}
