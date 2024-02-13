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
            myDog.Play();
            myDog.Sleep();
            myCat.Sleep();
            myDog.MakeSound();
            myCat.MakeSound();

            Console.WriteLine("=====================================");
            myDog.PrintSummary();
            myCat.PrintSummary();
            Console.WriteLine("=====================================");
        }
    }
}
