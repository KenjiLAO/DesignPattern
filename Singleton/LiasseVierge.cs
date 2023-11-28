public class LiasseVierge {
    
    private static LiasseVierge instance = null;

    public LiasseVierge getInstance()
    { 
        if (instance == null)
            {
                instance = new LiasseVierge();
            }
            return instance;
    }
}