public class LiasseVierge {
    
    public string nomDoc {get; set;}
    public string dateDoc {get; set;}
    private static LiasseVierge instance = null;

    private LiasseVierge() {}

    public static LiasseVierge getInstance()
    { 
        if (instance == null)
            {
                instance = new LiasseVierge();
            }
            return instance;
    }

    public void afficheDoc()
  {
    Console.WriteLine("Nom du document : " + nomDoc);
    Console.WriteLine("Date du document : " + dateDoc);
  }
}