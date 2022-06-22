using System;
using System.Threading;

namespace PW_Project.logic
{
    static class ThreadController
    {
        private static int threadCount;
        private static Thread[] threads;

        public static object Entrance;
        public static object GasBox;
        public static object GasExit;
        public static object Exit;

        public static Semaphore[] SEM_StationQueue;
        public static Semaphore SEM_GasBoxes;


        static ThreadController()
        {
            threadCount = 0;
            threads = new Thread[0];

            Entrance = new object();
            GasBox = new object();
            GasExit = new object();
            Exit = new object();

            SEM_StationQueue = new Semaphore[SequenceController.QueuePoints.Length];
            for(int i = 0; i < SEM_StationQueue.Length; i++)
            {
                SEM_StationQueue[i] = new Semaphore(1, 1);
            }

            SEM_GasBoxes = new Semaphore(16, 16);
        }

        //
        // START
        //
        private static void CreateThreads()
        {
            threads = new Thread[threadCount];
            for(int i = 0; i < threadCount; i++)
            {
                threads[i] = new Thread(SequenceController.ThreadMainSequence)
                {
                    IsBackground = true,
                    Name = string.Format("client_{0}", i)
                };
            }
        }

        public static void Start(int thCount)
        {
            threadCount = thCount;
            CreateThreads();
            foreach (Thread thread in threads)
            {
                thread.Start();
            }
        }

        //
        // ACTIVE THREADS COUNTER
        //
        public static int GetActiveThreadsCount()
        {
            int count = 0;
            for(int i = 0; i < threads.Length; i++)
            {
                if(threads[i] != null && threads[i].IsAlive)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
