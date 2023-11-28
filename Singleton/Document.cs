public class Document{
    static void Main(string[] args)
  {
    LiasseVierge document = LiasseVierge.getInstance();
    document.nomDoc = "Vente";
    document.dateDoc = "12/12/2012";
    affiche();
  }

  public static void affiche()
  {
    LiasseVierge document = LiasseVierge.getInstance();
    document.afficheDoc();
  }
}