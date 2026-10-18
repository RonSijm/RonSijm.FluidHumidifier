// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class InnerDistributionLoggingFactory(Action<Humidifier.CloudFront.DistributionTypes.Logging> factoryAction = null) : SubResourceFactory<Humidifier.CloudFront.DistributionTypes.Logging>
{

    protected override Humidifier.CloudFront.DistributionTypes.Logging Create()
    {
        var loggingResult = CreateLogging();
        factoryAction?.Invoke(loggingResult);

        return loggingResult;
    }

    private Humidifier.CloudFront.DistributionTypes.Logging CreateLogging()
    {
        var loggingResult = new Humidifier.CloudFront.DistributionTypes.Logging();

        return loggingResult;
    }

} // End Of Class

public static class InnerDistributionLoggingFactoryExtensions
{
}
