namespace FactoryPatternsExE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isValid_1;
            int Input_1;

            do//!=======================//!=======================//!=======================
            {//todo==============================================================
                Console.WriteLine("Enter a Number.");
                isValid_1 = int.TryParse(Console.ReadLine(), out Input_1);
                if (!isValid_1)
                {//?============================= 
                    Console.WriteLine("You didn't type a number, Please try again");
                    isValid_1 = false;
                }//?============================= 
            }//todo==============================================================
            while (!isValid_1);//!=======================//!=======================//!=======================

            var vehicle01 = VechicleFactory.GetVehicles(Input_1);
            vehicle01.Build();


        }
    }
}