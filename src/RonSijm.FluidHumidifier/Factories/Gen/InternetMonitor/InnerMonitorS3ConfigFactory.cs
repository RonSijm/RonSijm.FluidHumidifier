// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.InternetMonitor;

public class InnerMonitorS3ConfigFactory(Action<Humidifier.InternetMonitor.MonitorTypes.S3Config> factoryAction = null) : SubResourceFactory<Humidifier.InternetMonitor.MonitorTypes.S3Config>
{

    protected override Humidifier.InternetMonitor.MonitorTypes.S3Config Create()
    {
        var s3ConfigResult = CreateS3Config();
        factoryAction?.Invoke(s3ConfigResult);

        return s3ConfigResult;
    }

    private Humidifier.InternetMonitor.MonitorTypes.S3Config CreateS3Config()
    {
        var s3ConfigResult = new Humidifier.InternetMonitor.MonitorTypes.S3Config();

        return s3ConfigResult;
    }

} // End Of Class

public static class InnerMonitorS3ConfigFactoryExtensions
{
}
