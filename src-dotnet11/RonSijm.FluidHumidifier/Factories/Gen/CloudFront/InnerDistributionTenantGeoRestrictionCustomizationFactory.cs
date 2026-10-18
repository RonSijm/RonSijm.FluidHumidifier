// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class InnerDistributionTenantGeoRestrictionCustomizationFactory(Action<Humidifier.CloudFront.DistributionTenantTypes.GeoRestrictionCustomization> factoryAction = null) : SubResourceFactory<Humidifier.CloudFront.DistributionTenantTypes.GeoRestrictionCustomization>
{

    protected override Humidifier.CloudFront.DistributionTenantTypes.GeoRestrictionCustomization Create()
    {
        var geoRestrictionCustomizationResult = CreateGeoRestrictionCustomization();
        factoryAction?.Invoke(geoRestrictionCustomizationResult);

        return geoRestrictionCustomizationResult;
    }

    private Humidifier.CloudFront.DistributionTenantTypes.GeoRestrictionCustomization CreateGeoRestrictionCustomization()
    {
        var geoRestrictionCustomizationResult = new Humidifier.CloudFront.DistributionTenantTypes.GeoRestrictionCustomization();

        return geoRestrictionCustomizationResult;
    }

} // End Of Class

public static class InnerDistributionTenantGeoRestrictionCustomizationFactoryExtensions
{
}
