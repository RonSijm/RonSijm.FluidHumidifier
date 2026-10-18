// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class InnerDistributionGeoRestrictionFactory(Action<Humidifier.CloudFront.DistributionTypes.GeoRestriction> factoryAction = null) : SubResourceFactory<Humidifier.CloudFront.DistributionTypes.GeoRestriction>
{

    protected override Humidifier.CloudFront.DistributionTypes.GeoRestriction Create()
    {
        var geoRestrictionResult = CreateGeoRestriction();
        factoryAction?.Invoke(geoRestrictionResult);

        return geoRestrictionResult;
    }

    private Humidifier.CloudFront.DistributionTypes.GeoRestriction CreateGeoRestriction()
    {
        var geoRestrictionResult = new Humidifier.CloudFront.DistributionTypes.GeoRestriction();

        return geoRestrictionResult;
    }

} // End Of Class

public static class InnerDistributionGeoRestrictionFactoryExtensions
{
}
