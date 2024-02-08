namespace dz2.Models
{
    public class Dog : IAnimal
    {
        public string Name { get; set; } = "Bobik";
        public string Sound { get; set; } = "Woof";

        public string Speak()
        {
            return "I am a dog " + Name + " and I say " + Sound;
        }
    }
}
