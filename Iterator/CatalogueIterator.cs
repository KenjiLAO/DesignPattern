using System.Collections;

public class CatalogueIterator : IAggregate
{
    private ArrayList _vehicules = new ArrayList();

    public void AddVehicule(Vehicule vehicule)
    {
        _vehicules.Add(vehicule);
    }

    public int Count
    {
        get { return _vehicules.Count; }
    }

    public object this[int index]
    {
        get { return _vehicules[index]; }
    }

    public IIterator CreateIterator()
    {
        return new VehiculeIterator(this);
    }
}