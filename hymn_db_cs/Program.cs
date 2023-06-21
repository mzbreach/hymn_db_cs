using System;


namespace HymnDbCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        private int testFunction1(int alfalfa)
        {
            if(alfalfa <= 0)
            {
                return -1;
            }
            else
            {
                return alfalfa;
            }
        }

    }
}