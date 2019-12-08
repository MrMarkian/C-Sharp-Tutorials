using System;

namespace CustomException
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Car myCar = new Car("Audi", 90);

            try { myCar.Accelerate(50); }
            catch (CarIsDeadException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.CauseOfError);
                Console.WriteLine(e.errorTimeStamp);
                Console.WriteLine(e.StackTrace);

            }

        }
    }
}
