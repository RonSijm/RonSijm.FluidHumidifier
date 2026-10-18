// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.PCAConnectorSCEP;

public class ChallengeFactory(string resourceName = null, Action<Humidifier.PCAConnectorSCEP.Challenge> factoryAction = null) : ResourceFactory<Humidifier.PCAConnectorSCEP.Challenge>(resourceName)
{

    protected override Humidifier.PCAConnectorSCEP.Challenge Create()
    {
        var challengeResult = CreateChallenge();
        factoryAction?.Invoke(challengeResult);

        return challengeResult;
    }

    private Humidifier.PCAConnectorSCEP.Challenge CreateChallenge()
    {
        var challengeResult = new Humidifier.PCAConnectorSCEP.Challenge
        {
            GivenName = InputResourceName,
        };

        return challengeResult;
    }

} // End Of Class

public static class ChallengeFactoryExtensions
{
}
