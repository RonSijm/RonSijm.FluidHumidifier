// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class InnerFunctionTracingConfigFactory(Action<Humidifier.Lambda.FunctionTypes.TracingConfig> factoryAction = null) : SubResourceFactory<Humidifier.Lambda.FunctionTypes.TracingConfig>
{

    protected override Humidifier.Lambda.FunctionTypes.TracingConfig Create()
    {
        var tracingConfigResult = CreateTracingConfig();
        factoryAction?.Invoke(tracingConfigResult);

        return tracingConfigResult;
    }

    private Humidifier.Lambda.FunctionTypes.TracingConfig CreateTracingConfig()
    {
        var tracingConfigResult = new Humidifier.Lambda.FunctionTypes.TracingConfig();

        return tracingConfigResult;
    }

} // End Of Class

public static class InnerFunctionTracingConfigFactoryExtensions
{
}
