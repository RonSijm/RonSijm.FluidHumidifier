// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class InnerWebFunctionEndpointScalingConfigFactory(Action<Humidifier.Lambda.WebFunctionEndpointTypes.ScalingConfig> factoryAction = null) : SubResourceFactory<Humidifier.Lambda.WebFunctionEndpointTypes.ScalingConfig>
{

    protected override Humidifier.Lambda.WebFunctionEndpointTypes.ScalingConfig Create()
    {
        var scalingConfigResult = CreateScalingConfig();
        factoryAction?.Invoke(scalingConfigResult);

        return scalingConfigResult;
    }

    private Humidifier.Lambda.WebFunctionEndpointTypes.ScalingConfig CreateScalingConfig()
    {
        var scalingConfigResult = new Humidifier.Lambda.WebFunctionEndpointTypes.ScalingConfig();

        return scalingConfigResult;
    }

} // End Of Class

public static class InnerWebFunctionEndpointScalingConfigFactoryExtensions
{
}
