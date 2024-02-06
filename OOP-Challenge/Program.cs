namespace OOP_Challenge
{
    class Program
    {
        static void Main()
        {
            Dog myDog = new("Dogy", 3);
            Cat myCat = new("Oyen", 2);

            myDog.Feed();
            myCat.Play();
            myDog.Sleep();

            Console.WriteLine($"My dog's name is {myDog.Name} and it's {myDog.Age} years old. Happiness level: {myDog.HappinessLevel}" +
                              $" Energy level: {myDog.EnergyLevel}");
            Console.WriteLine($"My cat's name is {myCat.Name} and it's {myCat.Age} years old. Happiness level: {myCat.HappinessLevel}" +
                                $" Energy level: {myCat.EnergyLevel}");
        }
    }
}
