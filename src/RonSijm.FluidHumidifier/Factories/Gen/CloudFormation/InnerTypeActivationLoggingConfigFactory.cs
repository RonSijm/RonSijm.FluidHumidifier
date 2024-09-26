// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFormation;

public class InnerTypeActivationLoggingConfigFactory(Action<Humidifier.CloudFormation.TypeActivationTypes.LoggingConfig> factoryAction = null) : SubResourceFactory<Humidifier.CloudFormation.TypeActivationTypes.LoggingConfig>
{

    protected override Humidifier.CloudFormation.TypeActivationTypes.LoggingConfig Create()
    {
        var loggingConfigResult = CreateLoggingConfig();
        factoryAction?.Invoke(loggingConfigResult);

        return loggingConfigResult;
    }

    private Humidifier.CloudFormation.TypeActivationTypes.LoggingConfig CreateLoggingConfig()
    {
        var loggingConfigResult = new Humidifier.CloudFormation.TypeActivationTypes.LoggingConfig();

        return loggingConfigResult;
    }

} // End Of Class

public static class InnerTypeActivationLoggingConfigFactoryExtensions
{
}
