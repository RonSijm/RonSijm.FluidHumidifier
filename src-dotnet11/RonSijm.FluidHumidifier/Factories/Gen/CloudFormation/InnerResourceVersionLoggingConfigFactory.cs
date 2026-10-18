// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFormation;

public class InnerResourceVersionLoggingConfigFactory(Action<Humidifier.CloudFormation.ResourceVersionTypes.LoggingConfig> factoryAction = null) : SubResourceFactory<Humidifier.CloudFormation.ResourceVersionTypes.LoggingConfig>
{

    protected override Humidifier.CloudFormation.ResourceVersionTypes.LoggingConfig Create()
    {
        var loggingConfigResult = CreateLoggingConfig();
        factoryAction?.Invoke(loggingConfigResult);

        return loggingConfigResult;
    }

    private Humidifier.CloudFormation.ResourceVersionTypes.LoggingConfig CreateLoggingConfig()
    {
        var loggingConfigResult = new Humidifier.CloudFormation.ResourceVersionTypes.LoggingConfig();

        return loggingConfigResult;
    }

} // End Of Class

public static class InnerResourceVersionLoggingConfigFactoryExtensions
{
}
