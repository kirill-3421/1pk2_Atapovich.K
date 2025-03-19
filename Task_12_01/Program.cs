namespace Task_12_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Моня", 9, "серого");
            cat.GetInfo();
            cat.MakeSound();

            Dog dog = new Dog("Барбос", 5, "бело-чёрного");
            dog.GetInfo();
            dog.MakeSound();
        }
    }
}
