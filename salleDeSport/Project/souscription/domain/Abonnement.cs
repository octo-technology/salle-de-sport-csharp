public class Abonnement {
    public AbonnementId AbonnementId { get; private set; }
    public FormuleChoisie FormuleChoisie { get; set; }

    private Abonnement(
        String intituléFormuleChoisie,
        String prixDeBaseFormuleChoisie,
        String duréeFormuleChoisie ,
        String email,
        Boolean isEtudiant,
        IRandomUUIDGenerator randomUUIDGenerator)
    {
        this.AbonnementId = new AbonnementId(randomUUIDGenerator.generateId());
    }

    public static Abonnement Souscrire(
        String intituléFormuleChoisie,
        String prixDeBaseFormuleChoisie,
        String duréeFormuleChoisie ,
        String email,
        Boolean isEtudiant,
        IRandomUUIDGenerator randomUUIDGenerator) {
        Abonnement abonnementSouscrit = new Abonnement(
            intituléFormuleChoisie,
            prixDeBaseFormuleChoisie,
            duréeFormuleChoisie,
            email,
            true,
            randomUUIDGenerator
        );
        return abonnementSouscrit;
    }

}