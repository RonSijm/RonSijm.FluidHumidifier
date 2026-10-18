// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class InnerDistributionTenantConfigFactory(Action<Humidifier.CloudFront.DistributionTypes.TenantConfig> factoryAction = null) : SubResourceFactory<Humidifier.CloudFront.DistributionTypes.TenantConfig>
{

    protected override Humidifier.CloudFront.DistributionTypes.TenantConfig Create()
    {
        var tenantConfigResult = CreateTenantConfig();
        factoryAction?.Invoke(tenantConfigResult);

        return tenantConfigResult;
    }

    private Humidifier.CloudFront.DistributionTypes.TenantConfig CreateTenantConfig()
    {
        var tenantConfigResult = new Humidifier.CloudFront.DistributionTypes.TenantConfig();

        return tenantConfigResult;
    }

} // End Of Class

public static class InnerDistributionTenantConfigFactoryExtensions
{
}
