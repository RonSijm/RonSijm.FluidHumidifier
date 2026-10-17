// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ResilienceHubV2;

public class UserJourneyFactory(string resourceName = null, Action<Humidifier.ResilienceHubV2.UserJourney> factoryAction = null) : ResourceFactory<Humidifier.ResilienceHubV2.UserJourney>(resourceName)
{

    protected override Humidifier.ResilienceHubV2.UserJourney Create()
    {
        var userJourneyResult = CreateUserJourney();
        factoryAction?.Invoke(userJourneyResult);

        return userJourneyResult;
    }

    private Humidifier.ResilienceHubV2.UserJourney CreateUserJourney()
    {
        var userJourneyResult = new Humidifier.ResilienceHubV2.UserJourney
        {
            GivenName = InputResourceName,
        };

        return userJourneyResult;
    }

} // End Of Class

public static class UserJourneyFactoryExtensions
{
}
