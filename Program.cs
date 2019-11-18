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
            int EXIT = -1;//sentinel value
            double totalCost;
            dayCount = houseKeeping();
            while(dayCount != EXIT){
                code = getCode();
                totalCost = ComputeRate(code, dayCount);
                Conclude(dayCount, code, totalCost);
                dayCount = primer();
            }



        }

        static double ComputeRate(int dayCount, string code){
            if code = ("A"){
                totalCost = dayCount * 169; 
            }
            else{
                totalCost = dayCount * 112;
            }

            return TotalCost;
        }

        static int houseKeeping(){
            int dayCount;
            Console.WriteLine("Enter how many days the dog will stay");
            dayCount = Convert.ToInt32(Console.ReadLine());
            return dayCount;
        }

        static string getCode(){
            string code;
            Console.WriteLine("Enter add-on code");
            code = Console.ReadLine();
            return code;
        }

        static int primer()
        {
            int dayCount;
            Console.WriteLine("to enter another dog, enter number of days or enter -1 to exit");
            dayCount = Convert.ToInt32(Console.ReadLine());
            return dayCount;

        }

        static void Conclude(int dayCount, string code, double totalCost){

            Console.WriteLine($"Number of days: {dayCount} \nCode: {code}\nTotal Cost: {totalCost}");
        }
    }
}
