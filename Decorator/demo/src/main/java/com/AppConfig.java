import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;

@Configuration
public class AppConfig {

    @Bean // retourne un objet qui doit être géré et injecté par le conteneur (Decorator)
    public MonService monService() {
        return new MonService();
    }
}