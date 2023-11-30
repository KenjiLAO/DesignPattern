public class CheckParking {
    static void Main(string[] args)
        {
            Clients client = new Clients();
            Parking parking = new Parking();
            client.ClientCode(parking);
            
            LaoSubIndustries tree = new LaoSubIndustries();
            LaoSubIndustries branch1 = new LaoSubIndustries();
            tree.Add(new Parking());
            branch1.Add(new Parking());
            LaoSubIndustries branch2 = new LaoSubIndustries();
            branch2.Add(new Parking());
            tree.Add(branch1);
            tree.Add(branch2);
            client.ClientCode(tree);
            client.ClientCode2(tree, parking);
        }
}