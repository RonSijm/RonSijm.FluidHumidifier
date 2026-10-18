// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class InnerDistributionLegacyCustomOriginFactory(Action<Humidifier.CloudFront.DistributionTypes.LegacyCustomOrigin> factoryAction = null) : SubResourceFactory<Humidifier.CloudFront.DistributionTypes.LegacyCustomOrigin>
{

    protected override Humidifier.CloudFront.DistributionTypes.LegacyCustomOrigin Create()
    {
        var legacyCustomOriginResult = CreateLegacyCustomOrigin();
        factoryAction?.Invoke(legacyCustomOriginResult);

        return legacyCustomOriginResult;
    }

    private Humidifier.CloudFront.DistributionTypes.LegacyCustomOrigin CreateLegacyCustomOrigin()
    {
        var legacyCustomOriginResult = new Humidifier.CloudFront.DistributionTypes.LegacyCustomOrigin();

        return legacyCustomOriginResult;
    }

} // End Of Class

public static class InnerDistributionLegacyCustomOriginFactoryExtensions
{
}
