// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.XRay;

public class InnerTransactionSearchConfigCloudWatchLogsConfigurationFactory(Action<Humidifier.XRay.TransactionSearchConfigTypes.CloudWatchLogsConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.XRay.TransactionSearchConfigTypes.CloudWatchLogsConfiguration>
{

    protected override Humidifier.XRay.TransactionSearchConfigTypes.CloudWatchLogsConfiguration Create()
    {
        var cloudWatchLogsConfigurationResult = CreateCloudWatchLogsConfiguration();
        factoryAction?.Invoke(cloudWatchLogsConfigurationResult);

        return cloudWatchLogsConfigurationResult;
    }

    private Humidifier.XRay.TransactionSearchConfigTypes.CloudWatchLogsConfiguration CreateCloudWatchLogsConfiguration()
    {
        var cloudWatchLogsConfigurationResult = new Humidifier.XRay.TransactionSearchConfigTypes.CloudWatchLogsConfiguration();

        return cloudWatchLogsConfigurationResult;
    }

} // End Of Class

public static class InnerTransactionSearchConfigCloudWatchLogsConfigurationFactoryExtensions
{
}
