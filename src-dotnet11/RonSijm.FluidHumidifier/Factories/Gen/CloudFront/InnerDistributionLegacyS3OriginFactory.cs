// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class InnerDistributionLegacyS3OriginFactory(Action<Humidifier.CloudFront.DistributionTypes.LegacyS3Origin> factoryAction = null) : SubResourceFactory<Humidifier.CloudFront.DistributionTypes.LegacyS3Origin>
{

    protected override Humidifier.CloudFront.DistributionTypes.LegacyS3Origin Create()
    {
        var legacyS3OriginResult = CreateLegacyS3Origin();
        factoryAction?.Invoke(legacyS3OriginResult);

        return legacyS3OriginResult;
    }

    private Humidifier.CloudFront.DistributionTypes.LegacyS3Origin CreateLegacyS3Origin()
    {
        var legacyS3OriginResult = new Humidifier.CloudFront.DistributionTypes.LegacyS3Origin();

        return legacyS3OriginResult;
    }

} // End Of Class

public static class InnerDistributionLegacyS3OriginFactoryExtensions
{
}
