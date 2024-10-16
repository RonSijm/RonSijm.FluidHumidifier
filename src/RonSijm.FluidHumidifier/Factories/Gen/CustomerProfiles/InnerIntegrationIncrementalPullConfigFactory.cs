// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CustomerProfiles;

public class InnerIntegrationIncrementalPullConfigFactory(Action<Humidifier.CustomerProfiles.IntegrationTypes.IncrementalPullConfig> factoryAction = null) : SubResourceFactory<Humidifier.CustomerProfiles.IntegrationTypes.IncrementalPullConfig>
{

    protected override Humidifier.CustomerProfiles.IntegrationTypes.IncrementalPullConfig Create()
    {
        var incrementalPullConfigResult = CreateIncrementalPullConfig();
        factoryAction?.Invoke(incrementalPullConfigResult);

        return incrementalPullConfigResult;
    }

    private Humidifier.CustomerProfiles.IntegrationTypes.IncrementalPullConfig CreateIncrementalPullConfig()
    {
        var incrementalPullConfigResult = new Humidifier.CustomerProfiles.IntegrationTypes.IncrementalPullConfig();

        return incrementalPullConfigResult;
    }

} // End Of Class

public static class InnerIntegrationIncrementalPullConfigFactoryExtensions
{
}
