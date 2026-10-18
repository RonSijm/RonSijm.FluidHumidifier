// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class InnerEventSourceMappingProvisionedPollerConfigFactory(Action<Humidifier.Lambda.EventSourceMappingTypes.ProvisionedPollerConfig> factoryAction = null) : SubResourceFactory<Humidifier.Lambda.EventSourceMappingTypes.ProvisionedPollerConfig>
{

    protected override Humidifier.Lambda.EventSourceMappingTypes.ProvisionedPollerConfig Create()
    {
        var provisionedPollerConfigResult = CreateProvisionedPollerConfig();
        factoryAction?.Invoke(provisionedPollerConfigResult);

        return provisionedPollerConfigResult;
    }

    private Humidifier.Lambda.EventSourceMappingTypes.ProvisionedPollerConfig CreateProvisionedPollerConfig()
    {
        var provisionedPollerConfigResult = new Humidifier.Lambda.EventSourceMappingTypes.ProvisionedPollerConfig();

        return provisionedPollerConfigResult;
    }

} // End Of Class

public static class InnerEventSourceMappingProvisionedPollerConfigFactoryExtensions
{
}
