// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class InnerStreamingDistributionLoggingFactory(Action<Humidifier.CloudFront.StreamingDistributionTypes.Logging> factoryAction = null) : SubResourceFactory<Humidifier.CloudFront.StreamingDistributionTypes.Logging>
{

    protected override Humidifier.CloudFront.StreamingDistributionTypes.Logging Create()
    {
        var loggingResult = CreateLogging();
        factoryAction?.Invoke(loggingResult);

        return loggingResult;
    }

    private Humidifier.CloudFront.StreamingDistributionTypes.Logging CreateLogging()
    {
        var loggingResult = new Humidifier.CloudFront.StreamingDistributionTypes.Logging();

        return loggingResult;
    }

} // End Of Class

public static class InnerStreamingDistributionLoggingFactoryExtensions
{
}
