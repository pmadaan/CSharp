using System;
using System.Collections.Generic;

namespace StacksQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            //QueueViaStacksTest();
            //SortStackTest();
            AnimalShelterTest();
        }

        private static void AnimalShelterTest()
        {
            AnimalShelter shelter = new AnimalShelter();
            shelter.AddAnimal(new Dog("a"));
            shelter.AddAnimal(new Cat("b"));
            shelter.AddAnimal(new Dog("c"));
            shelter.AddAnimal(new Dog("d"));
            shelter.AddAnimal(new Cat("e"));

            Console.WriteLine(shelter.DequeueAny().name);
            Console.WriteLine(shelter.DequeueDog().name);
            Console.WriteLine(shelter.DequeueCat().name);
            Console.WriteLine(shelter.DequeueDog().name);

        }

        private static void SortStackTest()
        {
            Stack<int> s = new Stack<int>();
            s.Push(7);
            s.Push(10);
            s.Push(5);
            s.Push(8);
            s.Push(12);
            s.Push(3);
            s.Push(1);

            SortStack.sort(s);

            while (s.Count > 0)
                Console.Write(s.Pop() + "\t");
        }

        private static void QueueViaStacksTest()
        {
            QueueUsingStacks qs = new QueueUsingStacks();
            qs.queue(1);
            qs.queue(2);
            qs.queue(3);
            qs.queue(4);
            qs.queue(5);

            Console.WriteLine("size: " + qs.size());

            Console.WriteLine("dequeue: " + qs.dequeue());
            Console.WriteLine("dequeue: " + qs.dequeue());

            Console.WriteLine("size: " + qs.size());
        }
    }
}
