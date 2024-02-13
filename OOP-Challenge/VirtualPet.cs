namespace OOP_Challenge
{
    public class VirtualPet
    {
        private readonly string name;
        private readonly int age;
        private int happinessLevel;
        private int energyLevel;

        public VirtualPet(string name, int age)
        {
            this.name = name;
            this.age = age;
            happinessLevel = 50; 
            energyLevel = 50;
        }

        public string Name
        {
            get { return name; }
        }

        public int Age
        {
            get { return age; }
        }

        public int HappinessLevel
        {
            get { return happinessLevel; }
        }

        public int EnergyLevel
        {
            get { return energyLevel; }
        }

        public void SetHappinessLevel(int happinessLevel)
        {
            this.happinessLevel = happinessLevel;
        }

        public void SetEnergyLevel(int energyLevel)
        {
            this.energyLevel = energyLevel;
        }

        public void Feed()
        {
            happinessLevel += 10;
            energyLevel += 50;
            Console.WriteLine($"{name} is eating.");
            PrintSummary();
        }

        public virtual void Play()
        {
            happinessLevel += 15;
            energyLevel -= 20;
            Console.WriteLine($"{name} is playing.");
            PrintSummary();
        }

        public void Sleep()
        {
            happinessLevel += 5;
            energyLevel += 10;
            Console.WriteLine($"{name} is sleeping.");
            PrintSummary();
        }

        public virtual void PrintSummary()
        {
            Console.WriteLine($"Name: {name}, Age: {age}, Happiness Level: {happinessLevel}, Energy Level: {energyLevel}.");
        }

        public virtual void MakeSound()
        {
            happinessLevel += 5;
            energyLevel -= 5;
            Console.WriteLine($"{name} is making a sound.");
            PrintSummary();
        }
        


    }
}