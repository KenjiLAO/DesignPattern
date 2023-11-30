public abstract class LaoIndustries {
    public LaoIndustries laoIndustries;
    public string nom = "Lao Industries";
    public int voiture = 3;

    public abstract string Operation();

        public virtual void Add(LaoIndustries component)
        {
            throw new NotImplementedException();
        }

        public virtual bool IsComposite()
        {
            return true;
        }
}