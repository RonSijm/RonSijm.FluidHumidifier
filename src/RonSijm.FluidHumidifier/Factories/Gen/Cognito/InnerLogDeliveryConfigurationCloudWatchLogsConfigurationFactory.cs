// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cognito;

public class InnerLogDeliveryConfigurationCloudWatchLogsConfigurationFactory(Action<Humidifier.Cognito.LogDeliveryConfigurationTypes.CloudWatchLogsConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Cognito.LogDeliveryConfigurationTypes.CloudWatchLogsConfiguration>
{

    protected override Humidifier.Cognito.LogDeliveryConfigurationTypes.CloudWatchLogsConfiguration Create()
    {
        var cloudWatchLogsConfigurationResult = CreateCloudWatchLogsConfiguration();
        factoryAction?.Invoke(cloudWatchLogsConfigurationResult);

        return cloudWatchLogsConfigurationResult;
    }

    private Humidifier.Cognito.LogDeliveryConfigurationTypes.CloudWatchLogsConfiguration CreateCloudWatchLogsConfiguration()
    {
        var cloudWatchLogsConfigurationResult = new Humidifier.Cognito.LogDeliveryConfigurationTypes.CloudWatchLogsConfiguration();

        return cloudWatchLogsConfigurationResult;
    }

} // End Of Class

public static class InnerLogDeliveryConfigurationCloudWatchLogsConfigurationFactoryExtensions
{
}
