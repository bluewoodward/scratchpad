using System;

namespace scratchpad
{
    class Blob //Class Declaration
    {
        public int WeightKg = 1;  //Property
        public string Name = "tim"; //Property

        public Blob(string name, int weight) //Constructor (same name as the class and no return type) 
        {
            Name = name;
            WeightKg = weight;
        }

        public void Display() //Method (functions attatched to a class)
        {
            Console.WriteLine($"Hello {Name} with weight {WeightKg}");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Blob blobvar = new Blob("john",2);
            Blob blobvar2 = new Blob("tim",1);
            Blob blobvar3 = new Blob("abraham",3);
            blobvar.Display();
            blobvar2.Display();
            blobvar3.Display();
        }
    }
}
