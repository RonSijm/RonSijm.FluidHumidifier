// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerVerifiedAccessInstanceCloudWatchLogsFactory(Action<Humidifier.EC2.VerifiedAccessInstanceTypes.CloudWatchLogs> factoryAction = null) : SubResourceFactory<Humidifier.EC2.VerifiedAccessInstanceTypes.CloudWatchLogs>
{

    protected override Humidifier.EC2.VerifiedAccessInstanceTypes.CloudWatchLogs Create()
    {
        var cloudWatchLogsResult = CreateCloudWatchLogs();
        factoryAction?.Invoke(cloudWatchLogsResult);

        return cloudWatchLogsResult;
    }

    private Humidifier.EC2.VerifiedAccessInstanceTypes.CloudWatchLogs CreateCloudWatchLogs()
    {
        var cloudWatchLogsResult = new Humidifier.EC2.VerifiedAccessInstanceTypes.CloudWatchLogs();

        return cloudWatchLogsResult;
    }

} // End Of Class

public static class InnerVerifiedAccessInstanceCloudWatchLogsFactoryExtensions
{
}
