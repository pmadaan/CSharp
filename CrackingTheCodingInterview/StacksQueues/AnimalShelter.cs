using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace StacksQueues
{
    class AnimalShelter
    {
        Queue<Dog> dogs;
        Queue<Cat> cats;
        private int order { get; set; }

        public AnimalShelter()
        {
            dogs = new Queue<Dog>();
            cats = new Queue<Cat>();

            order = 0;
        }

        public void AddAnimal(Animal animal)
        {
            animal.order = order;
            order++;

            if (animal is Dog) dogs.Enqueue((Dog)animal);
            else if (animal is Cat) cats.Enqueue((Cat)animal);
        }

        public Animal DequeueAny()
        {
            if (dogs.Count == 0) return cats.Dequeue();
            if (cats.Count == 0) return dogs.Dequeue();

            Dog d = dogs.Peek();
            Cat c = cats.Peek();

            if (d.isOlder(c)) return dogs.Dequeue();
            else return cats.Dequeue();
        }

        public Dog DequeueDog()
        {
            return dogs.Dequeue();
        }

        public Cat DequeueCat()
        {
            return cats.Dequeue();
        }
    }

    abstract class Animal
    {
        internal string name { get; }
        internal int order { get; set; }

        public Animal(string n)
        {
            name = n;
        }

        public bool isOlder(Animal a)
        {
            return this.order < a.order;
        }
    }

    class Dog : Animal
    {
        public Dog(string n) : base(n)
        { }
    }

    class Cat : Animal
    {
        public Cat(string n) : base(n)
        { }
    }
}
