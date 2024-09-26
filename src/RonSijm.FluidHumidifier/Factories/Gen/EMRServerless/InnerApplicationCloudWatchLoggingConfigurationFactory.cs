// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMRServerless;

public class InnerApplicationCloudWatchLoggingConfigurationFactory(Action<Humidifier.EMRServerless.ApplicationTypes.CloudWatchLoggingConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.EMRServerless.ApplicationTypes.CloudWatchLoggingConfiguration>
{

    protected override Humidifier.EMRServerless.ApplicationTypes.CloudWatchLoggingConfiguration Create()
    {
        var cloudWatchLoggingConfigurationResult = CreateCloudWatchLoggingConfiguration();
        factoryAction?.Invoke(cloudWatchLoggingConfigurationResult);

        return cloudWatchLoggingConfigurationResult;
    }

    private Humidifier.EMRServerless.ApplicationTypes.CloudWatchLoggingConfiguration CreateCloudWatchLoggingConfiguration()
    {
        var cloudWatchLoggingConfigurationResult = new Humidifier.EMRServerless.ApplicationTypes.CloudWatchLoggingConfiguration();

        return cloudWatchLoggingConfigurationResult;
    }

} // End Of Class

public static class InnerApplicationCloudWatchLoggingConfigurationFactoryExtensions
{
}
