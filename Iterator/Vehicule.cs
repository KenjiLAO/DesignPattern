public class Vehicule
{
    public string Model { get; set; }
    public string Type { get; set; }

    public Vehicule(string model, string type)
    {
        Model = model;
        Type = type;
    }
}