// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTSiteWise;

public class AccessPolicyFactory(string resourceName = null, Action<Humidifier.IoTSiteWise.AccessPolicy> factoryAction = null) : ResourceFactory<Humidifier.IoTSiteWise.AccessPolicy>(resourceName)
{

    internal InnerAccessPolicyAccessPolicyResourceFactory AccessPolicyResourceFactory { get; set; }

    internal InnerAccessPolicyAccessPolicyIdentityFactory AccessPolicyIdentityFactory { get; set; }

    protected override Humidifier.IoTSiteWise.AccessPolicy Create()
    {
        var accessPolicyResult = CreateAccessPolicy();
        factoryAction?.Invoke(accessPolicyResult);

        return accessPolicyResult;
    }

    private Humidifier.IoTSiteWise.AccessPolicy CreateAccessPolicy()
    {
        var accessPolicyResult = new Humidifier.IoTSiteWise.AccessPolicy
        {
            GivenName = InputResourceName,
        };

        return accessPolicyResult;
    }
    public override void CreateChildren(Humidifier.IoTSiteWise.AccessPolicy result)
    {
        base.CreateChildren(result);

        result.AccessPolicyResource ??= AccessPolicyResourceFactory?.Build();
        result.AccessPolicyIdentity ??= AccessPolicyIdentityFactory?.Build();
    }

} // End Of Class

public static class AccessPolicyFactoryExtensions
{
    public static CombinedResult<AccessPolicyFactory, InnerAccessPolicyAccessPolicyResourceFactory> WithAccessPolicyResource(this AccessPolicyFactory parentFactory, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.AccessPolicyResource> subFactoryAction = null)
    {
        parentFactory.AccessPolicyResourceFactory = new InnerAccessPolicyAccessPolicyResourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AccessPolicyResourceFactory);
    }

    public static CombinedResult<AccessPolicyFactory, InnerAccessPolicyAccessPolicyIdentityFactory> WithAccessPolicyIdentity(this AccessPolicyFactory parentFactory, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.AccessPolicyIdentity> subFactoryAction = null)
    {
        parentFactory.AccessPolicyIdentityFactory = new InnerAccessPolicyAccessPolicyIdentityFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AccessPolicyIdentityFactory);
    }

    public static CombinedResult<AccessPolicyFactory, T1, InnerAccessPolicyAccessPolicyResourceFactory> WithAccessPolicyResource<T1>(this CombinedResult<AccessPolicyFactory, T1> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.AccessPolicyResource> subFactoryAction = null) => new (combinedResult, combinedResult, WithAccessPolicyResource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AccessPolicyFactory, InnerAccessPolicyAccessPolicyResourceFactory> WithAccessPolicyResource<T1>(this CombinedResult<T1, AccessPolicyFactory> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.AccessPolicyResource> subFactoryAction = null) => new (combinedResult, combinedResult, WithAccessPolicyResource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<AccessPolicyFactory, T1, T2, InnerAccessPolicyAccessPolicyResourceFactory> WithAccessPolicyResource<T1, T2>(this CombinedResult<AccessPolicyFactory, T1, T2> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.AccessPolicyResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAccessPolicyResource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AccessPolicyFactory, T2, InnerAccessPolicyAccessPolicyResourceFactory> WithAccessPolicyResource<T1, T2>(this CombinedResult<T1, AccessPolicyFactory, T2> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.AccessPolicyResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAccessPolicyResource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AccessPolicyFactory, InnerAccessPolicyAccessPolicyResourceFactory> WithAccessPolicyResource<T1, T2>(this CombinedResult<T1, T2, AccessPolicyFactory> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.AccessPolicyResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAccessPolicyResource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<AccessPolicyFactory, T1, T2, T3, InnerAccessPolicyAccessPolicyResourceFactory> WithAccessPolicyResource<T1, T2, T3>(this CombinedResult<AccessPolicyFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.AccessPolicyResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccessPolicyResource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AccessPolicyFactory, T2, T3, InnerAccessPolicyAccessPolicyResourceFactory> WithAccessPolicyResource<T1, T2, T3>(this CombinedResult<T1, AccessPolicyFactory, T2, T3> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.AccessPolicyResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccessPolicyResource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AccessPolicyFactory, T3, InnerAccessPolicyAccessPolicyResourceFactory> WithAccessPolicyResource<T1, T2, T3>(this CombinedResult<T1, T2, AccessPolicyFactory, T3> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.AccessPolicyResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccessPolicyResource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AccessPolicyFactory, InnerAccessPolicyAccessPolicyResourceFactory> WithAccessPolicyResource<T1, T2, T3>(this CombinedResult<T1, T2, T3, AccessPolicyFactory> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.AccessPolicyResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccessPolicyResource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<AccessPolicyFactory, T1, T2, T3, T4, InnerAccessPolicyAccessPolicyResourceFactory> WithAccessPolicyResource<T1, T2, T3, T4>(this CombinedResult<AccessPolicyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.AccessPolicyResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessPolicyResource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AccessPolicyFactory, T2, T3, T4, InnerAccessPolicyAccessPolicyResourceFactory> WithAccessPolicyResource<T1, T2, T3, T4>(this CombinedResult<T1, AccessPolicyFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.AccessPolicyResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessPolicyResource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AccessPolicyFactory, T3, T4, InnerAccessPolicyAccessPolicyResourceFactory> WithAccessPolicyResource<T1, T2, T3, T4>(this CombinedResult<T1, T2, AccessPolicyFactory, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.AccessPolicyResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessPolicyResource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AccessPolicyFactory, T4, InnerAccessPolicyAccessPolicyResourceFactory> WithAccessPolicyResource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AccessPolicyFactory, T4> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.AccessPolicyResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessPolicyResource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, AccessPolicyFactory, InnerAccessPolicyAccessPolicyResourceFactory> WithAccessPolicyResource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AccessPolicyFactory> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.AccessPolicyResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessPolicyResource(combinedResult.T5, subFactoryAction));
    public static CombinedResult<AccessPolicyFactory, T1, InnerAccessPolicyAccessPolicyIdentityFactory> WithAccessPolicyIdentity<T1>(this CombinedResult<AccessPolicyFactory, T1> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.AccessPolicyIdentity> subFactoryAction = null) => new (combinedResult, combinedResult, WithAccessPolicyIdentity(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AccessPolicyFactory, InnerAccessPolicyAccessPolicyIdentityFactory> WithAccessPolicyIdentity<T1>(this CombinedResult<T1, AccessPolicyFactory> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.AccessPolicyIdentity> subFactoryAction = null) => new (combinedResult, combinedResult, WithAccessPolicyIdentity(combinedResult.T2, subFactoryAction));
    public static CombinedResult<AccessPolicyFactory, T1, T2, InnerAccessPolicyAccessPolicyIdentityFactory> WithAccessPolicyIdentity<T1, T2>(this CombinedResult<AccessPolicyFactory, T1, T2> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.AccessPolicyIdentity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAccessPolicyIdentity(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AccessPolicyFactory, T2, InnerAccessPolicyAccessPolicyIdentityFactory> WithAccessPolicyIdentity<T1, T2>(this CombinedResult<T1, AccessPolicyFactory, T2> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.AccessPolicyIdentity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAccessPolicyIdentity(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AccessPolicyFactory, InnerAccessPolicyAccessPolicyIdentityFactory> WithAccessPolicyIdentity<T1, T2>(this CombinedResult<T1, T2, AccessPolicyFactory> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.AccessPolicyIdentity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAccessPolicyIdentity(combinedResult.T3, subFactoryAction));
    public static CombinedResult<AccessPolicyFactory, T1, T2, T3, InnerAccessPolicyAccessPolicyIdentityFactory> WithAccessPolicyIdentity<T1, T2, T3>(this CombinedResult<AccessPolicyFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.AccessPolicyIdentity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccessPolicyIdentity(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AccessPolicyFactory, T2, T3, InnerAccessPolicyAccessPolicyIdentityFactory> WithAccessPolicyIdentity<T1, T2, T3>(this CombinedResult<T1, AccessPolicyFactory, T2, T3> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.AccessPolicyIdentity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccessPolicyIdentity(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AccessPolicyFactory, T3, InnerAccessPolicyAccessPolicyIdentityFactory> WithAccessPolicyIdentity<T1, T2, T3>(this CombinedResult<T1, T2, AccessPolicyFactory, T3> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.AccessPolicyIdentity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccessPolicyIdentity(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AccessPolicyFactory, InnerAccessPolicyAccessPolicyIdentityFactory> WithAccessPolicyIdentity<T1, T2, T3>(this CombinedResult<T1, T2, T3, AccessPolicyFactory> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.AccessPolicyIdentity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccessPolicyIdentity(combinedResult.T4, subFactoryAction));
    public static CombinedResult<AccessPolicyFactory, T1, T2, T3, T4, InnerAccessPolicyAccessPolicyIdentityFactory> WithAccessPolicyIdentity<T1, T2, T3, T4>(this CombinedResult<AccessPolicyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.AccessPolicyIdentity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessPolicyIdentity(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AccessPolicyFactory, T2, T3, T4, InnerAccessPolicyAccessPolicyIdentityFactory> WithAccessPolicyIdentity<T1, T2, T3, T4>(this CombinedResult<T1, AccessPolicyFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.AccessPolicyIdentity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessPolicyIdentity(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AccessPolicyFactory, T3, T4, InnerAccessPolicyAccessPolicyIdentityFactory> WithAccessPolicyIdentity<T1, T2, T3, T4>(this CombinedResult<T1, T2, AccessPolicyFactory, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.AccessPolicyIdentity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessPolicyIdentity(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AccessPolicyFactory, T4, InnerAccessPolicyAccessPolicyIdentityFactory> WithAccessPolicyIdentity<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AccessPolicyFactory, T4> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.AccessPolicyIdentity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessPolicyIdentity(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, AccessPolicyFactory, InnerAccessPolicyAccessPolicyIdentityFactory> WithAccessPolicyIdentity<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AccessPolicyFactory> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.AccessPolicyIdentity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessPolicyIdentity(combinedResult.T5, subFactoryAction));
}
