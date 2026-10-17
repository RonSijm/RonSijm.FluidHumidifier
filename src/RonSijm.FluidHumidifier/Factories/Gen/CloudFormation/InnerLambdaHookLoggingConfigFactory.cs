// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFormation;

public class InnerLambdaHookLoggingConfigFactory(Action<Humidifier.CloudFormation.LambdaHookTypes.LoggingConfig> factoryAction = null) : SubResourceFactory<Humidifier.CloudFormation.LambdaHookTypes.LoggingConfig>
{

    protected override Humidifier.CloudFormation.LambdaHookTypes.LoggingConfig Create()
    {
        var loggingConfigResult = CreateLoggingConfig();
        factoryAction?.Invoke(loggingConfigResult);

        return loggingConfigResult;
    }

    private Humidifier.CloudFormation.LambdaHookTypes.LoggingConfig CreateLoggingConfig()
    {
        var loggingConfigResult = new Humidifier.CloudFormation.LambdaHookTypes.LoggingConfig();

        return loggingConfigResult;
    }

} // End Of Class

public static class InnerLambdaHookLoggingConfigFactoryExtensions
{
}
