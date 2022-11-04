namespace Tests;

[TestClass]
public class AbonnementTest
{
    [TestMethod]
    public void DoitSouscrireUnAbonnementEtEnvoyerUnMail()
    {
        // GIVEN
        AbonnementId abonnementId = new AbonnementId("abonnementId");

        // WHEN
        Abonnement abonnementSouscrit = Abonnement.Souscrire("","", "", "", true, new RandomUUIDGeneratorForTest());

        // THEN
        Assert.AreEqual(abonnementSouscrit.AbonnementId.Value, "id");

    }
}

class RandomUUIDGeneratorForTest : IRandomUUIDGenerator {
    string IRandomUUIDGenerator.generateId() {
        return "id";
    }
}