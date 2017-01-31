using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

// Ilustrerer problemerne omkring tråde og synkronisering, hvis flere tråde arbejder på samme objekt
// Ilustrerer problems of threads and synchronization, if multiple threads working on the same object

namespace Trådeksempel4
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Start");

            Ex4Tråd tk1 = new Ex4Tråd('.', 80);
            Ex4Tråd tk2 = new Ex4Tråd('X', 50);
            Thread t1 = new Thread(tk1.RunThread);
            Thread t1b = new Thread(tk1.RunThread);       // Ny tråd på samme objekt. New thread on the same object
            Thread t2 = new Thread(tk2.RunThread);

            t1.Start();
            t1b.Start();
            t2.Start();
            //                      Thread.Sleep(5);

            t2.Join();
            t1.Join();
            t1b.Join();
            System.Console.WriteLine("\nEnter for Exit");
            System.Console.ReadLine();
            System.Console.WriteLine("EXIT");

        }
    }
}
