public class VehiculeIterator : IIterator
{
    private CatalogueIterator _catalogue;
    private int _currentIndex = 0;

    public VehiculeIterator(CatalogueIterator catalogue)
    {
        _catalogue = catalogue;
    }

    public bool HasNext()
    {
        return _currentIndex < _catalogue.Count;
    }

    public object Next()
    {
        if (HasNext())
        {
            var vehicule = _catalogue[_currentIndex];
            _currentIndex++;
            return vehicule;
        }
        else
        {
            return null;
        }
    }
}