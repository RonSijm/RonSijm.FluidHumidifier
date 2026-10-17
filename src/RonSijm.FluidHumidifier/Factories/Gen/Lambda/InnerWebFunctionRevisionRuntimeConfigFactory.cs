// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class InnerWebFunctionRevisionRuntimeConfigFactory(Action<Humidifier.Lambda.WebFunctionRevisionTypes.RuntimeConfig> factoryAction = null) : SubResourceFactory<Humidifier.Lambda.WebFunctionRevisionTypes.RuntimeConfig>
{

    protected override Humidifier.Lambda.WebFunctionRevisionTypes.RuntimeConfig Create()
    {
        var runtimeConfigResult = CreateRuntimeConfig();
        factoryAction?.Invoke(runtimeConfigResult);

        return runtimeConfigResult;
    }

    private Humidifier.Lambda.WebFunctionRevisionTypes.RuntimeConfig CreateRuntimeConfig()
    {
        var runtimeConfigResult = new Humidifier.Lambda.WebFunctionRevisionTypes.RuntimeConfig();

        return runtimeConfigResult;
    }

} // End Of Class

public static class InnerWebFunctionRevisionRuntimeConfigFactoryExtensions
{
}
