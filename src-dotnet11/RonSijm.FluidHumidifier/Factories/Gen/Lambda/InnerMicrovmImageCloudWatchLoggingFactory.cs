// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class InnerMicrovmImageCloudWatchLoggingFactory(Action<Humidifier.Lambda.MicrovmImageTypes.CloudWatchLogging> factoryAction = null) : SubResourceFactory<Humidifier.Lambda.MicrovmImageTypes.CloudWatchLogging>
{

    protected override Humidifier.Lambda.MicrovmImageTypes.CloudWatchLogging Create()
    {
        var cloudWatchLoggingResult = CreateCloudWatchLogging();
        factoryAction?.Invoke(cloudWatchLoggingResult);

        return cloudWatchLoggingResult;
    }

    private Humidifier.Lambda.MicrovmImageTypes.CloudWatchLogging CreateCloudWatchLogging()
    {
        var cloudWatchLoggingResult = new Humidifier.Lambda.MicrovmImageTypes.CloudWatchLogging();

        return cloudWatchLoggingResult;
    }

} // End Of Class

public static class InnerMicrovmImageCloudWatchLoggingFactoryExtensions
{
}
