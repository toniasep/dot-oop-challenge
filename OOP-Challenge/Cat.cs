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
            Console.WriteLine($"{Name} is playing. Happiness level increased to {HappinessLevel}. Energy level decreased to {EnergyLevel}.");
        }
        public void Meow()
        {
            SetHappinessLevel(HappinessLevel + 5);
            SetEnergyLevel(EnergyLevel - 5);
            Console.WriteLine($"{Name} is meowing. Happiness level increased to {HappinessLevel}. Energy level decreased to {EnergyLevel}.");
        }

    }
}