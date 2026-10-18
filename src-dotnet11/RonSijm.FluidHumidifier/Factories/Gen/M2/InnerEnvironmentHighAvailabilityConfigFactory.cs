// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.M2;

public class InnerEnvironmentHighAvailabilityConfigFactory(Action<Humidifier.M2.EnvironmentTypes.HighAvailabilityConfig> factoryAction = null) : SubResourceFactory<Humidifier.M2.EnvironmentTypes.HighAvailabilityConfig>
{

    protected override Humidifier.M2.EnvironmentTypes.HighAvailabilityConfig Create()
    {
        var highAvailabilityConfigResult = CreateHighAvailabilityConfig();
        factoryAction?.Invoke(highAvailabilityConfigResult);

        return highAvailabilityConfigResult;
    }

    private Humidifier.M2.EnvironmentTypes.HighAvailabilityConfig CreateHighAvailabilityConfig()
    {
        var highAvailabilityConfigResult = new Humidifier.M2.EnvironmentTypes.HighAvailabilityConfig();

        return highAvailabilityConfigResult;
    }

} // End Of Class

public static class InnerEnvironmentHighAvailabilityConfigFactoryExtensions
{
}
