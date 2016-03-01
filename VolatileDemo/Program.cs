namespace VolatileDemo
{
   using System;
   using System.Threading;

   class Program
   {
      static void Main()
      {
         // var loop = new BoolHolder { _isOn = true };
         bool loop = true;

         new Thread(() =>
                    {
                       Console.WriteLine("Loop started...");
                       while (loop){}
                       Console.WriteLine("Loop stopped...");
                    }).Start();

         Console.ReadKey();
         loop = false;
         Console.WriteLine("Flag is now FALSE");

         Console.ReadKey();
      }
   }
}