using System.Threading;
using System;
namespace L1pocSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            (new Program(1)).Start();
            (new Program(2)).Start();
           // (new Program(3)).Start();
        }

        void Start()
        {

            Thread t = new Thread(SomeT);
            t.Start();

            (new Thread(StopT)).Start();
        }

        private int nameT;
        public Program(int number)
        {
            nameT = number;
        }
        void SomeT()
        {

            long sum = 0;
            long count = 1;

            do
            {
                sum = sum + 1;
                count = count + 1;


            } while (!isStop);

            Console.WriteLine("Number thread: " + nameT + ", sum = " + sum + ", number of terms: " + count);

        }
        private bool isStop = false;
        public bool IsStop { get => isStop; }
        public void StopT()
        {

            Thread.Sleep(10 * 1000);
            isStop = true;

        }

    }
}
