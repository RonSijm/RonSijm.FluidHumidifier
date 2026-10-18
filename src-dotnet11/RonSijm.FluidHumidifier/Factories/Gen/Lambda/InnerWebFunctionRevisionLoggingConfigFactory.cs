// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class InnerWebFunctionRevisionLoggingConfigFactory(Action<Humidifier.Lambda.WebFunctionRevisionTypes.LoggingConfig> factoryAction = null) : SubResourceFactory<Humidifier.Lambda.WebFunctionRevisionTypes.LoggingConfig>
{

    protected override Humidifier.Lambda.WebFunctionRevisionTypes.LoggingConfig Create()
    {
        var loggingConfigResult = CreateLoggingConfig();
        factoryAction?.Invoke(loggingConfigResult);

        return loggingConfigResult;
    }

    private Humidifier.Lambda.WebFunctionRevisionTypes.LoggingConfig CreateLoggingConfig()
    {
        var loggingConfigResult = new Humidifier.Lambda.WebFunctionRevisionTypes.LoggingConfig();

        return loggingConfigResult;
    }

} // End Of Class

public static class InnerWebFunctionRevisionLoggingConfigFactoryExtensions
{
}
