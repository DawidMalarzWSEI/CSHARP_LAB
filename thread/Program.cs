using System;
using System.Threading;

namespace thread
{
    internal class Program
    {
        private static volatile bool looped = true;
        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }
        static void Main(string[] args)
        {
            int counter = 0;
            Thread thread1 = new Thread(() =>
            {
                for (int i = 1; looped; i+=4)
                {
                    if (IsPrime(i))
                        ++counter;
                }
            });
            Thread thread2 = new Thread(() =>
            {

                for (int i = 1; looped; i += 3)
                {
                    if (IsPrime(i))
                        ++counter;
                }
            });
            Thread thread3 = new Thread(() =>
            {
                for (int i = 1; looped; i += 2)
                {
                    if (IsPrime(i))
                        ++counter;
                }
            });
            Thread thread4 = new Thread(() =>
            {

                for (int i = 1; looped; i += 1)
                {
                    if (IsPrime(i))
                        ++counter;
                }
            });


            thread1.Start();
            thread2.Start();
            thread3.Start();
            thread4.Start();

            Thread.Sleep(10 * 1000);  // sleeps main thread for 1 seconds
            looped = false;      // false value breaks loop in the created thread

            thread1.Join();       // sleeps main thread until created thread is not terminated
            thread2.Join();
            thread3.Join();
            thread4.Join();
            Console.WriteLine("Stopped");
            Console.WriteLine(counter);
        }
    }
}
