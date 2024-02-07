namespace OOP_Challenge
{
    public class Dog : VirtualPet
    {
        public Dog(string name, int age) : base(name, age)
        {
            
        }

        public void Bark()
        {
            SetHappinessLevel(HappinessLevel + 5);
            SetEnergyLevel(EnergyLevel - 5);
            Console.WriteLine($"{Name} is barking. Happiness level increased to {HappinessLevel}. Energy level decreased to {EnergyLevel}.");
        }
        
    }
}