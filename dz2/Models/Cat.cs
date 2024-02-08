namespace dz2.Models
{
    public class Cat : IAnimal
    {
        public string Name { get; set; } = "Barsik";
        public string Sound { get; set; } = "Meow";

        public string Speak()
        {
            return "I am a cat " + Name + " and I say " + Sound;
        }
    }
}
