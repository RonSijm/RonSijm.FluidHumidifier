// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFormation;

public class InnerHookVersionLoggingConfigFactory(Action<Humidifier.CloudFormation.HookVersionTypes.LoggingConfig> factoryAction = null) : SubResourceFactory<Humidifier.CloudFormation.HookVersionTypes.LoggingConfig>
{

    protected override Humidifier.CloudFormation.HookVersionTypes.LoggingConfig Create()
    {
        var loggingConfigResult = CreateLoggingConfig();
        factoryAction?.Invoke(loggingConfigResult);

        return loggingConfigResult;
    }

    private Humidifier.CloudFormation.HookVersionTypes.LoggingConfig CreateLoggingConfig()
    {
        var loggingConfigResult = new Humidifier.CloudFormation.HookVersionTypes.LoggingConfig();

        return loggingConfigResult;
    }

} // End Of Class

public static class InnerHookVersionLoggingConfigFactoryExtensions
{
}
