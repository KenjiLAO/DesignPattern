public abstract class Constructeur
{
  protected Liasse liasse;

  public abstract void construitBonDeCommande(string
    nomClient);

  public abstract void construitDemandeImmatriculation
    (string nomDemandeur);

  public Liasse resultat()
  {
    return liasse;
  }
}