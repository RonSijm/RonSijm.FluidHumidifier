// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class InnerEventSourceMappingLoggingConfigFactory(Action<Humidifier.Lambda.EventSourceMappingTypes.LoggingConfig> factoryAction = null) : SubResourceFactory<Humidifier.Lambda.EventSourceMappingTypes.LoggingConfig>
{

    protected override Humidifier.Lambda.EventSourceMappingTypes.LoggingConfig Create()
    {
        var loggingConfigResult = CreateLoggingConfig();
        factoryAction?.Invoke(loggingConfigResult);

        return loggingConfigResult;
    }

    private Humidifier.Lambda.EventSourceMappingTypes.LoggingConfig CreateLoggingConfig()
    {
        var loggingConfigResult = new Humidifier.Lambda.EventSourceMappingTypes.LoggingConfig();

        return loggingConfigResult;
    }

} // End Of Class

public static class InnerEventSourceMappingLoggingConfigFactoryExtensions
{
}
