public class Vendeur
{
  protected Constructeur constructeur;

  public Vendeur(Constructeur constructeur)
  {
    this.constructeur = constructeur;
  }

  public Liasse create(string nomClient)
  {
    constructeur.construitBonDeCommande(nomClient);
    constructeur.construitDemandeImmatriculation
      (nomClient);
    Liasse liasse = constructeur.resultat();
    return liasse;
  }
}