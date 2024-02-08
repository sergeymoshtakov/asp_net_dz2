using dz2.Models;

namespace dz2.Services
{
    public class AnimalService
    {
        private readonly IAnimal _animal;

        public AnimalService(IAnimal animal)
        {
            _animal = animal;
        }

        public void DisplayAnimalDetails()
        {
            Console.WriteLine(_animal.Speak());
        }
    }
}
