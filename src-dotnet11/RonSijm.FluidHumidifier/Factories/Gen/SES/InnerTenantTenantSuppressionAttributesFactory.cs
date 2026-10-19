// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SES;

public class InnerTenantTenantSuppressionAttributesFactory(Action<Humidifier.SES.TenantTypes.TenantSuppressionAttributes> factoryAction = null) : SubResourceFactory<Humidifier.SES.TenantTypes.TenantSuppressionAttributes>
{

    protected override Humidifier.SES.TenantTypes.TenantSuppressionAttributes Create()
    {
        var tenantSuppressionAttributesResult = CreateTenantSuppressionAttributes();
        factoryAction?.Invoke(tenantSuppressionAttributesResult);

        return tenantSuppressionAttributesResult;
    }

    private Humidifier.SES.TenantTypes.TenantSuppressionAttributes CreateTenantSuppressionAttributes()
    {
        var tenantSuppressionAttributesResult = new Humidifier.SES.TenantTypes.TenantSuppressionAttributes();

        return tenantSuppressionAttributesResult;
    }

} // End Of Class

public static class InnerTenantTenantSuppressionAttributesFactoryExtensions
{
}
