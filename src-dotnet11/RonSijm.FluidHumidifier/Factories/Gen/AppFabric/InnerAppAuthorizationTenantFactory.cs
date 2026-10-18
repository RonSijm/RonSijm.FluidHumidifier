// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFabric;

public class InnerAppAuthorizationTenantFactory(Action<Humidifier.AppFabric.AppAuthorizationTypes.Tenant> factoryAction = null) : SubResourceFactory<Humidifier.AppFabric.AppAuthorizationTypes.Tenant>
{

    protected override Humidifier.AppFabric.AppAuthorizationTypes.Tenant Create()
    {
        var tenantResult = CreateTenant();
        factoryAction?.Invoke(tenantResult);

        return tenantResult;
    }

    private Humidifier.AppFabric.AppAuthorizationTypes.Tenant CreateTenant()
    {
        var tenantResult = new Humidifier.AppFabric.AppAuthorizationTypes.Tenant();

        return tenantResult;
    }

} // End Of Class

public static class InnerAppAuthorizationTenantFactoryExtensions
{
}
