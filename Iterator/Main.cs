CatalogueIterator catalogue = new CatalogueIterator();
catalogue.AddVehicule(new Vehicule("Sedan1", "Sedan"));
catalogue.AddVehicule(new Vehicule("SUV1", "SUV"));
catalogue.AddVehicule(new Vehicule("Truck1", "Truck"));

IIterator iterator = catalogue.CreateIterator();

while (iterator.HasNext())
{
    Vehicule vehicule = (Vehicule)iterator.Next();
    Console.WriteLine($"Model: {vehicule.Model}, Type: {vehicule.Type}");
}