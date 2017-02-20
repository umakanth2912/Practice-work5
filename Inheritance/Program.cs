using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Dog
    {
        public string DogName;
        public int DogAge;
        public String DogOwnerName;
        public string DogTagAddress;


    }
    class BullDog : Dog
    {
        public void TagPrint()
        {
            string DogBreed = "BullDog";
            Console.WriteLine("Enter the Dog Name");
            DogName = Console.ReadLine();
            Console.WriteLine("Enter the Owner Name");
            DogOwnerName = Console.ReadLine();
            Console.WriteLine("Enter the Dog's Age");
            DogAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Dog's Address");
            DogTagAddress = Console.ReadLine();

            Console.WriteLine("*********** Your Dog Tag ***********");
            Console.WriteLine("*********** Dog Name:{0} ***********", DogName);
            Console.WriteLine("*********** Dog Age:{0} ***********", DogAge);
            Console.WriteLine("*********** Dog Breed:{0} ***********", DogBreed);
            Console.WriteLine("*********** Dog Owner's Name:{0} ***********", DogOwnerName);
            Console.WriteLine("*********** Dog's Address:{0} ***********", DogTagAddress);

        }
    }
    class Germanshepard : Dog
    {
        public void TagPrint()
        {
            string DogBreed = "Germanshepard";
            Console.WriteLine("Enter the Dog Name");
            DogName = Console.ReadLine();
            Console.WriteLine("Enter the Owner Name");
            DogOwnerName = Console.ReadLine();
            Console.WriteLine("Enter the Dog's Age ");
            DogAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Dog's Address");
            DogTagAddress = Console.ReadLine();

            Console.WriteLine("*********** Your Dog Tag ***********");
            Console.WriteLine("*********** Dog Name:{0} ***********", DogName);
            Console.WriteLine("*********** Dog Age:{0} ***********", DogAge);
            Console.WriteLine("*********** Dog Breed:{0} ***********", DogBreed);
            Console.WriteLine("*********** Dog Owner's Name:{0} ***********", DogOwnerName);
            Console.WriteLine("*********** Dog's Address:{0} ***********", DogTagAddress);

        }
    }
    class Dalmation : Dog
    {
        public void TagPrint()
        {
            string DogBreed = "Dalmation";
            Console.WriteLine("Enter the Dog Name");
            DogName = Console.ReadLine();
            Console.WriteLine("Enter the Owner Name");
            DogOwnerName = Console.ReadLine();
            Console.WriteLine("Enter the Dog's Age");
            DogAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Dog's Address");
            DogTagAddress = Console.ReadLine();

            Console.WriteLine("*********** Your Dog Tag ***********");
            Console.WriteLine("*********** Dog Name:{0} ***********", DogName);
            Console.WriteLine("*********** Dog Age:{0} ***********", DogAge);
            Console.WriteLine("*********** Dog Breed:{0} ***********", DogBreed);
            Console.WriteLine("*********** Dog Owner's Name:{0} ***********", DogOwnerName);
            Console.WriteLine("*********** Dog's Address:{0} ***********", DogTagAddress);

        }
    }

    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Please Choose the Dog Breed : \n 1.German Shepard \n 2.Bull Dog \n 3.Dalmation");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("You have selected German Shepard Dog");
                Germanshepard ger = new Germanshepard();
                ger.TagPrint();
            }
            else if (choice == 2)
            {
                Console.WriteLine("You have selected Bull Dog");
                BullDog bull = new BullDog();
                bull.TagPrint();
            }
            else if (choice == 3)
            {
                Console.WriteLine("You have selected Dalmation Dog");
                Dalmation dal = new Dalmation();
                dal.TagPrint();
            }
            else
            {
                Console.WriteLine("Please enter your choice between 1,2 And 3 \n Thank you");
            }

            Console.ReadLine();





        }
    }
}
