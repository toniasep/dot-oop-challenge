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
            Console.WriteLine($"{name} has been fed. Happiness level increased to {happinessLevel}. Energy level increased to {energyLevel}.");
        }

        public void Play()
        {
            happinessLevel += 15;
            energyLevel -= 20;
            Console.WriteLine($"{name} is playing. Happiness level increased to {happinessLevel}. Energy level decreased to {energyLevel}.");
        }

        public void Sleep()
        {
            happinessLevel += 5;
            energyLevel += 10;
            Console.WriteLine($"{name} is sleeping. Happiness level increased to {happinessLevel}. Energy level increased to {energyLevel}.");
        }
        


    }
}