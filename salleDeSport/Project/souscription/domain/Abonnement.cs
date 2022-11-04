public class Abonnement {
    public AbonnementId abonnementId { get; private set; }
    public FormuleChoisie formuleChoisie { get; set; }

    private Abonnement(
        String intituléFormuleChoisie,
        String prixDeBaseFormuleChoisie,
        String duréeFormuleChoisie ,
        String email,
        Boolean isEtudiant,
        IRandomUUIDGenerator randomUUIDGenerator)
    {
        this.abonnementId = new AbonnementId(randomUUIDGenerator.generateId());
    }

    public static Abonnement souscrire(
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