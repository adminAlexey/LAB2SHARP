class Animals
{
    public string name { get; set; }

    public void GetInfo()
    {
        Console.WriteLine($"Имя: {name}");
    }
   virtual public void Voice()
    {
      
    }
}
    class Mammals : Animals
    {
        
    }

    class Dog : Mammals
    {
        public string breed { get; set; }
        override public void Voice()
        {
            Console.WriteLine("звуки2"); //перегрузка
        }
    }

    class horse : Mammals
    {

    }

    class Fish : Animals
    {

    }

    class Insects : Animals
    {
        public bool fly;
    }

    class Spider : Insects
    {
        public int legs;
        public void Legs()
        {
            Console.WriteLine($"конечностей у паука: {legs}");
        }
    }

    class Crocodile : Animals
    {
        public string kind { get; set; }
    }

    class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Dog dog = new Dog();
            dog.name = "Rex";
            dog.breed = "Spitz";
            dog.GetInfo();
            Console.WriteLine("Порода: " + dog.breed);
            Console.WriteLine();

            Spider spider = new Spider();
            spider.name = "Tarantula";
            spider.legs = 8;
            spider.GetInfo();
            spider.Legs();

            Crocodile croc = new Crocodile();
            croc.name = "Croc";
            croc.kind = "Alligator";

            dog.Voice();
        }
    }