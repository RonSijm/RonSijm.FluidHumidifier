// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class InnerEventSourceMappingScalingConfigFactory(Action<Humidifier.Lambda.EventSourceMappingTypes.ScalingConfig> factoryAction = null) : SubResourceFactory<Humidifier.Lambda.EventSourceMappingTypes.ScalingConfig>
{

    protected override Humidifier.Lambda.EventSourceMappingTypes.ScalingConfig Create()
    {
        var scalingConfigResult = CreateScalingConfig();
        factoryAction?.Invoke(scalingConfigResult);

        return scalingConfigResult;
    }

    private Humidifier.Lambda.EventSourceMappingTypes.ScalingConfig CreateScalingConfig()
    {
        var scalingConfigResult = new Humidifier.Lambda.EventSourceMappingTypes.ScalingConfig();

        return scalingConfigResult;
    }

} // End Of Class

public static class InnerEventSourceMappingScalingConfigFactoryExtensions
{
}
