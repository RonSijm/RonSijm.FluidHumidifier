// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class InnerWebFunctionEndpointThrottleConfigFactory(Action<Humidifier.Lambda.WebFunctionEndpointTypes.ThrottleConfig> factoryAction = null) : SubResourceFactory<Humidifier.Lambda.WebFunctionEndpointTypes.ThrottleConfig>
{

    protected override Humidifier.Lambda.WebFunctionEndpointTypes.ThrottleConfig Create()
    {
        var throttleConfigResult = CreateThrottleConfig();
        factoryAction?.Invoke(throttleConfigResult);

        return throttleConfigResult;
    }

    private Humidifier.Lambda.WebFunctionEndpointTypes.ThrottleConfig CreateThrottleConfig()
    {
        var throttleConfigResult = new Humidifier.Lambda.WebFunctionEndpointTypes.ThrottleConfig();

        return throttleConfigResult;
    }

} // End Of Class

public static class InnerWebFunctionEndpointThrottleConfigFactoryExtensions
{
}
