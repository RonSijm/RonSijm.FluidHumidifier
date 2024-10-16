// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkFirewall;

public class InnerLoggingConfigurationLogDestinationConfigFactory(Action<Humidifier.NetworkFirewall.LoggingConfigurationTypes.LogDestinationConfig> factoryAction = null) : SubResourceFactory<Humidifier.NetworkFirewall.LoggingConfigurationTypes.LogDestinationConfig>
{

    protected override Humidifier.NetworkFirewall.LoggingConfigurationTypes.LogDestinationConfig Create()
    {
        var logDestinationConfigResult = CreateLogDestinationConfig();
        factoryAction?.Invoke(logDestinationConfigResult);

        return logDestinationConfigResult;
    }

    private Humidifier.NetworkFirewall.LoggingConfigurationTypes.LogDestinationConfig CreateLogDestinationConfig()
    {
        var logDestinationConfigResult = new Humidifier.NetworkFirewall.LoggingConfigurationTypes.LogDestinationConfig();

        return logDestinationConfigResult;
    }

} // End Of Class

public static class InnerLoggingConfigurationLogDestinationConfigFactoryExtensions
{
}
