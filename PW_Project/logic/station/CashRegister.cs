using System;
using System.Collections.Generic;
using System.Threading;

namespace PW_Project.logic.station
{
    class CashRegister
    {
        private bool free;
        private readonly Queue<Vehicle> queue;
        private readonly object serviceBox;
        private readonly Semaphore SEM_Queue;

        public bool Free { get => free; set => free = value; }
        public Queue<Vehicle> Queue { get => queue; }

        public CashRegister()
        {
            free = true;
            queue = new Queue<Vehicle>();
            serviceBox = new object();
            SEM_Queue = new Semaphore(4, 4);
        }

        //
        // JOIN TO THE QUEUE
        //
        public void EnterTheQueue(Vehicle vehicle)
        {
            SEM_Queue.WaitOne();
            queue.Enqueue(vehicle);
            while (true)
            {
                Monitor.Enter(serviceBox);

                if (vehicle.Equals(queue.Peek()))
                {
                    break;
                }

                Monitor.Exit(serviceBox);
            }
            ClientService();
        }

        //
        // CLIENT SERVICE
        //
        private void ClientService()
        {
            free = false;
            Thread.Sleep(new Random().Next(5, 15) * 1000);
            queue.Dequeue();
            Monitor.Exit(serviceBox);
            SEM_Queue.Release();
            free = true;
        }
    }
}
