namespace dz2.Models
{
    public interface IAnimal
    {
        string Name { get; set; }
        string Sound { get; set; }
        string Speak();
    }
}
