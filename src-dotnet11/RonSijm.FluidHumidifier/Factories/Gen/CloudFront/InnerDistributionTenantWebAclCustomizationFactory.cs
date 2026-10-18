// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class InnerDistributionTenantWebAclCustomizationFactory(Action<Humidifier.CloudFront.DistributionTenantTypes.WebAclCustomization> factoryAction = null) : SubResourceFactory<Humidifier.CloudFront.DistributionTenantTypes.WebAclCustomization>
{

    protected override Humidifier.CloudFront.DistributionTenantTypes.WebAclCustomization Create()
    {
        var webAclCustomizationResult = CreateWebAclCustomization();
        factoryAction?.Invoke(webAclCustomizationResult);

        return webAclCustomizationResult;
    }

    private Humidifier.CloudFront.DistributionTenantTypes.WebAclCustomization CreateWebAclCustomization()
    {
        var webAclCustomizationResult = new Humidifier.CloudFront.DistributionTenantTypes.WebAclCustomization();

        return webAclCustomizationResult;
    }

} // End Of Class

public static class InnerDistributionTenantWebAclCustomizationFactoryExtensions
{
}
