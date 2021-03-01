using System;
using System.Collections.Generic;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Beast!")
                {
                    break;
                }

                string[] secondLine = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                try
                {
                    animals = GetAnimal(animals, secondLine, input);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
                animal.ProduceSound();
            }


        }

        public static List<Animal> GetAnimal(List<Animal> animals, string[] secondInput, string type)
        {

            if (type != "Dog" && type != "Frog" && type != "Cat" && type != "Tomcat" && type != "Kitten")
            {
                throw new ArgumentException("Invalid input!");
            }


            string name = secondInput[0];
            int age = int.Parse(secondInput[1]);
            string gender = secondInput[2];

            if (type == "Dog")
            {
                Dog dog = new Dog(name, age, gender);
                animals.Add(dog);
            }

            else if (type == "Frog")
            {
                Frog frog = new Frog(name, age, gender);
                animals.Add(frog);
            }

            else if (type == "Cat")
            {
                Cat cat = new Cat(name, age, gender);
                animals.Add(cat);

            }



            else if (type == "Tomcat")
            {
                Tomcat tomcat = new Tomcat(name, age);
                animals.Add(tomcat);
            }


            else if (type == "Kitten")
            {
                Kitten kitten = new Kitten(name, age);
                animals.Add(kitten);
            }







            return animals;

        }

    }
}
