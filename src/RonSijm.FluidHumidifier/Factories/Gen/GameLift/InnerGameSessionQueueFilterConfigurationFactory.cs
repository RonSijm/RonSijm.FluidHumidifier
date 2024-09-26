// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GameLift;

public class InnerGameSessionQueueFilterConfigurationFactory(Action<Humidifier.GameLift.GameSessionQueueTypes.FilterConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.GameLift.GameSessionQueueTypes.FilterConfiguration>
{

    protected override Humidifier.GameLift.GameSessionQueueTypes.FilterConfiguration Create()
    {
        var filterConfigurationResult = CreateFilterConfiguration();
        factoryAction?.Invoke(filterConfigurationResult);

        return filterConfigurationResult;
    }

    private Humidifier.GameLift.GameSessionQueueTypes.FilterConfiguration CreateFilterConfiguration()
    {
        var filterConfigurationResult = new Humidifier.GameLift.GameSessionQueueTypes.FilterConfiguration();

        return filterConfigurationResult;
    }

} // End Of Class

public static class InnerGameSessionQueueFilterConfigurationFactoryExtensions
{
}
