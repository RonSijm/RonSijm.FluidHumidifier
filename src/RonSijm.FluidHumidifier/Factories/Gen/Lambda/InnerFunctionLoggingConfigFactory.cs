// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class InnerFunctionLoggingConfigFactory(Action<Humidifier.Lambda.FunctionTypes.LoggingConfig> factoryAction = null) : SubResourceFactory<Humidifier.Lambda.FunctionTypes.LoggingConfig>
{

    protected override Humidifier.Lambda.FunctionTypes.LoggingConfig Create()
    {
        var loggingConfigResult = CreateLoggingConfig();
        factoryAction?.Invoke(loggingConfigResult);

        return loggingConfigResult;
    }

    private Humidifier.Lambda.FunctionTypes.LoggingConfig CreateLoggingConfig()
    {
        var loggingConfigResult = new Humidifier.Lambda.FunctionTypes.LoggingConfig();

        return loggingConfigResult;
    }

} // End Of Class

public static class InnerFunctionLoggingConfigFactoryExtensions
{
}
