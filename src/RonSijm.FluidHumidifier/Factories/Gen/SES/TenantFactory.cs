// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SES;

public class TenantFactory(string resourceName = null, Action<Humidifier.SES.Tenant> factoryAction = null) : ResourceFactory<Humidifier.SES.Tenant>(resourceName)
{

    internal List<InnerTenantResourceAssociationFactory> ResourceAssociationsFactories { get; set; } = [];

    protected override Humidifier.SES.Tenant Create()
    {
        var tenantResult = CreateTenant();
        factoryAction?.Invoke(tenantResult);

        return tenantResult;
    }

    private Humidifier.SES.Tenant CreateTenant()
    {
        var tenantResult = new Humidifier.SES.Tenant
        {
            GivenName = InputResourceName,
        };

        return tenantResult;
    }
    public override void CreateChildren(Humidifier.SES.Tenant result)
    {
        base.CreateChildren(result);

        result.ResourceAssociations = ResourceAssociationsFactories.Any() ? ResourceAssociationsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class TenantFactoryExtensions
{
    public static CombinedResult<TenantFactory, InnerTenantResourceAssociationFactory> WithResourceAssociations(this TenantFactory parentFactory, Action<Humidifier.SES.TenantTypes.ResourceAssociation> subFactoryAction = null)
    {
        var factory = new InnerTenantResourceAssociationFactory(subFactoryAction);
        parentFactory.ResourceAssociationsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<TenantFactory, T1, InnerTenantResourceAssociationFactory> WithResourceAssociations<T1>(this CombinedResult<TenantFactory, T1> combinedResult, Action<Humidifier.SES.TenantTypes.ResourceAssociation> subFactoryAction = null) => new (combinedResult, combinedResult, WithResourceAssociations(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TenantFactory, InnerTenantResourceAssociationFactory> WithResourceAssociations<T1>(this CombinedResult<T1, TenantFactory> combinedResult, Action<Humidifier.SES.TenantTypes.ResourceAssociation> subFactoryAction = null) => new (combinedResult, combinedResult, WithResourceAssociations(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<TenantFactory, T1, T2, InnerTenantResourceAssociationFactory> WithResourceAssociations<T1, T2>(this CombinedResult<TenantFactory, T1, T2> combinedResult, Action<Humidifier.SES.TenantTypes.ResourceAssociation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceAssociations(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TenantFactory, T2, InnerTenantResourceAssociationFactory> WithResourceAssociations<T1, T2>(this CombinedResult<T1, TenantFactory, T2> combinedResult, Action<Humidifier.SES.TenantTypes.ResourceAssociation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceAssociations(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TenantFactory, InnerTenantResourceAssociationFactory> WithResourceAssociations<T1, T2>(this CombinedResult<T1, T2, TenantFactory> combinedResult, Action<Humidifier.SES.TenantTypes.ResourceAssociation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceAssociations(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<TenantFactory, T1, T2, T3, InnerTenantResourceAssociationFactory> WithResourceAssociations<T1, T2, T3>(this CombinedResult<TenantFactory, T1, T2, T3> combinedResult, Action<Humidifier.SES.TenantTypes.ResourceAssociation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceAssociations(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TenantFactory, T2, T3, InnerTenantResourceAssociationFactory> WithResourceAssociations<T1, T2, T3>(this CombinedResult<T1, TenantFactory, T2, T3> combinedResult, Action<Humidifier.SES.TenantTypes.ResourceAssociation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceAssociations(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TenantFactory, T3, InnerTenantResourceAssociationFactory> WithResourceAssociations<T1, T2, T3>(this CombinedResult<T1, T2, TenantFactory, T3> combinedResult, Action<Humidifier.SES.TenantTypes.ResourceAssociation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceAssociations(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, TenantFactory, InnerTenantResourceAssociationFactory> WithResourceAssociations<T1, T2, T3>(this CombinedResult<T1, T2, T3, TenantFactory> combinedResult, Action<Humidifier.SES.TenantTypes.ResourceAssociation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceAssociations(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<TenantFactory, T1, T2, T3, T4, InnerTenantResourceAssociationFactory> WithResourceAssociations<T1, T2, T3, T4>(this CombinedResult<TenantFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SES.TenantTypes.ResourceAssociation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceAssociations(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TenantFactory, T2, T3, T4, InnerTenantResourceAssociationFactory> WithResourceAssociations<T1, T2, T3, T4>(this CombinedResult<T1, TenantFactory, T2, T3, T4> combinedResult, Action<Humidifier.SES.TenantTypes.ResourceAssociation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceAssociations(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TenantFactory, T3, T4, InnerTenantResourceAssociationFactory> WithResourceAssociations<T1, T2, T3, T4>(this CombinedResult<T1, T2, TenantFactory, T3, T4> combinedResult, Action<Humidifier.SES.TenantTypes.ResourceAssociation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceAssociations(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, TenantFactory, T4, InnerTenantResourceAssociationFactory> WithResourceAssociations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TenantFactory, T4> combinedResult, Action<Humidifier.SES.TenantTypes.ResourceAssociation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceAssociations(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, TenantFactory, InnerTenantResourceAssociationFactory> WithResourceAssociations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TenantFactory> combinedResult, Action<Humidifier.SES.TenantTypes.ResourceAssociation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceAssociations(combinedResult.T5, subFactoryAction).T2);
}
