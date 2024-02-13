namespace OOP_Challenge
{
    public class Cat : VirtualPet
    {
        public Cat(string name, int age) : base(name, age)
        {
            
        }
        
        public override void Play()
        {
            SetHappinessLevel(HappinessLevel + 10);
            SetEnergyLevel(EnergyLevel - 15);
            Console.WriteLine($"{Name} is playing.");
            PrintSummary();
        }
        
        public override void MakeSound()
        {
            SetHappinessLevel(HappinessLevel + 5);
            SetEnergyLevel(EnergyLevel - 5);
            Console.WriteLine($"{Name} is meowing.");
            PrintSummary();
        }

        public override void PrintSummary()
        {
            Console.WriteLine($"Cat: {Name}, Age: {Age}, Happiness Level: {HappinessLevel}, Energy Level: {EnergyLevel}.");
        }

    }
}