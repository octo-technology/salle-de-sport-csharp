namespace Tests;

[TestClass]
public class AbonnementTest
{
    [TestMethod]
    public void DoitSouscrireUnAbonnementEtEnvoyerUnMail()
    {
        // GIVEN
        Boolean estEtudiant = false;
        String formuleId = "aaa-bbb";
        String email = "test@test.com";
        String dateDeDebutDAbonnement = "2023-02-02";
        AbonnementRepository abonnementRepository = new AbonnementRepository();
        SouscrireAbonnementCommandHandler souscrireAbonnementCommandHandler = new SouscrireAbonnementCommandHandler(abonnementRepository)
        souscrireAbonnementCommandHandler.handle(formuleId, email, dateDeDebutDAbonnement, estEtudiant);

        // WHEN
        Abonnement abonnementSouscrit = Abonnement.Souscrire();

        // THEN
        Assert.AreEqual(abonnementSouscrit.AbonnementId.Value, "id");

    }
}

class AbonnementRepository {

}

class SouscrireAbonnementCommandHandler {
    public SouscrireAbonnementCommandHandler(AbonnementRepository abonnementRepository) {

    }

    public void handle(String formuleId, String email, String dateDeDebutDAbonnement, Boolean estEtudiant) {

    }
}