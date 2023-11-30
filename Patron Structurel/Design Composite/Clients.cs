public class Clients {
    public void ClientCode(LaoIndustries leaf)
        {
            Console.WriteLine($"Resultats: {leaf.Operation()}\n");
        }

        public void ClientCode2(LaoIndustries component1, LaoIndustries component2)
        {
            if (component1.IsComposite())
            {
                component1.Add(component2);
            }
            
            Console.WriteLine($"Resultats: {component1.Operation()}");
        }
}