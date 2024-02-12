namespace OOP_Challenge
{
    public class Dog : VirtualPet
    {
        public Dog(string name, int age) : base(name, age)
        {
            
        }

        public override void Play()
        {
            SetHappinessLevel(HappinessLevel + 20);
            SetEnergyLevel(EnergyLevel - 25);
            Console.WriteLine($"{Name} is playing.");
            PrintSummary();
        }
        public void Bark()
        {
            SetHappinessLevel(HappinessLevel + 5);
            SetEnergyLevel(EnergyLevel - 5);
            Console.WriteLine($"{Name} is barking.");
            PrintSummary();
        }

        
        public override void PrintSummary()
        {
            Console.WriteLine($"Dog: {Name}, Age: {Age}, Happiness Level: {HappinessLevel}, Energy Level: {EnergyLevel}.");
        }
        
    }
}