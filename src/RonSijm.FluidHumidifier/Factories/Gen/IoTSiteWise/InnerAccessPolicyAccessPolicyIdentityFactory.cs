// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTSiteWise;

public class InnerAccessPolicyAccessPolicyIdentityFactory(Action<Humidifier.IoTSiteWise.AccessPolicyTypes.AccessPolicyIdentity> factoryAction = null) : SubResourceFactory<Humidifier.IoTSiteWise.AccessPolicyTypes.AccessPolicyIdentity>
{

    internal InnerAccessPolicyUserFactory UserFactory { get; set; }

    internal InnerAccessPolicyIamUserFactory IamUserFactory { get; set; }

    internal InnerAccessPolicyIamRoleFactory IamRoleFactory { get; set; }

    protected override Humidifier.IoTSiteWise.AccessPolicyTypes.AccessPolicyIdentity Create()
    {
        var accessPolicyIdentityResult = CreateAccessPolicyIdentity();
        factoryAction?.Invoke(accessPolicyIdentityResult);

        return accessPolicyIdentityResult;
    }

    private Humidifier.IoTSiteWise.AccessPolicyTypes.AccessPolicyIdentity CreateAccessPolicyIdentity()
    {
        var accessPolicyIdentityResult = new Humidifier.IoTSiteWise.AccessPolicyTypes.AccessPolicyIdentity();

        return accessPolicyIdentityResult;
    }
    public override void CreateChildren(Humidifier.IoTSiteWise.AccessPolicyTypes.AccessPolicyIdentity result)
    {
        base.CreateChildren(result);

        result.User ??= UserFactory?.Build();
        result.IamUser ??= IamUserFactory?.Build();
        result.IamRole ??= IamRoleFactory?.Build();
    }

} // End Of Class

public static class InnerAccessPolicyAccessPolicyIdentityFactoryExtensions
{
    public static CombinedResult<InnerAccessPolicyAccessPolicyIdentityFactory, InnerAccessPolicyUserFactory> WithUser(this InnerAccessPolicyAccessPolicyIdentityFactory parentFactory, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.User> subFactoryAction = null)
    {
        parentFactory.UserFactory = new InnerAccessPolicyUserFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.UserFactory);
    }

    public static CombinedResult<InnerAccessPolicyAccessPolicyIdentityFactory, InnerAccessPolicyIamUserFactory> WithIamUser(this InnerAccessPolicyAccessPolicyIdentityFactory parentFactory, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.IamUser> subFactoryAction = null)
    {
        parentFactory.IamUserFactory = new InnerAccessPolicyIamUserFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.IamUserFactory);
    }

    public static CombinedResult<InnerAccessPolicyAccessPolicyIdentityFactory, InnerAccessPolicyIamRoleFactory> WithIamRole(this InnerAccessPolicyAccessPolicyIdentityFactory parentFactory, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.IamRole> subFactoryAction = null)
    {
        parentFactory.IamRoleFactory = new InnerAccessPolicyIamRoleFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.IamRoleFactory);
    }

    public static CombinedResult<InnerAccessPolicyAccessPolicyIdentityFactory, T1, InnerAccessPolicyUserFactory> WithUser<T1>(this CombinedResult<InnerAccessPolicyAccessPolicyIdentityFactory, T1> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.User> subFactoryAction = null) => new (combinedResult, combinedResult, WithUser(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAccessPolicyAccessPolicyIdentityFactory, InnerAccessPolicyUserFactory> WithUser<T1>(this CombinedResult<T1, InnerAccessPolicyAccessPolicyIdentityFactory> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.User> subFactoryAction = null) => new (combinedResult, combinedResult, WithUser(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerAccessPolicyAccessPolicyIdentityFactory, T1, T2, InnerAccessPolicyUserFactory> WithUser<T1, T2>(this CombinedResult<InnerAccessPolicyAccessPolicyIdentityFactory, T1, T2> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.User> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUser(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAccessPolicyAccessPolicyIdentityFactory, T2, InnerAccessPolicyUserFactory> WithUser<T1, T2>(this CombinedResult<T1, InnerAccessPolicyAccessPolicyIdentityFactory, T2> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.User> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUser(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAccessPolicyAccessPolicyIdentityFactory, InnerAccessPolicyUserFactory> WithUser<T1, T2>(this CombinedResult<T1, T2, InnerAccessPolicyAccessPolicyIdentityFactory> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.User> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUser(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerAccessPolicyAccessPolicyIdentityFactory, T1, T2, T3, InnerAccessPolicyUserFactory> WithUser<T1, T2, T3>(this CombinedResult<InnerAccessPolicyAccessPolicyIdentityFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.User> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUser(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAccessPolicyAccessPolicyIdentityFactory, T2, T3, InnerAccessPolicyUserFactory> WithUser<T1, T2, T3>(this CombinedResult<T1, InnerAccessPolicyAccessPolicyIdentityFactory, T2, T3> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.User> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUser(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAccessPolicyAccessPolicyIdentityFactory, T3, InnerAccessPolicyUserFactory> WithUser<T1, T2, T3>(this CombinedResult<T1, T2, InnerAccessPolicyAccessPolicyIdentityFactory, T3> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.User> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUser(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAccessPolicyAccessPolicyIdentityFactory, InnerAccessPolicyUserFactory> WithUser<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAccessPolicyAccessPolicyIdentityFactory> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.User> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUser(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerAccessPolicyAccessPolicyIdentityFactory, T1, T2, T3, T4, InnerAccessPolicyUserFactory> WithUser<T1, T2, T3, T4>(this CombinedResult<InnerAccessPolicyAccessPolicyIdentityFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.User> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUser(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAccessPolicyAccessPolicyIdentityFactory, T2, T3, T4, InnerAccessPolicyUserFactory> WithUser<T1, T2, T3, T4>(this CombinedResult<T1, InnerAccessPolicyAccessPolicyIdentityFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.User> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUser(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAccessPolicyAccessPolicyIdentityFactory, T3, T4, InnerAccessPolicyUserFactory> WithUser<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAccessPolicyAccessPolicyIdentityFactory, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.User> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUser(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAccessPolicyAccessPolicyIdentityFactory, T4, InnerAccessPolicyUserFactory> WithUser<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAccessPolicyAccessPolicyIdentityFactory, T4> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.User> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUser(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerAccessPolicyAccessPolicyIdentityFactory, InnerAccessPolicyUserFactory> WithUser<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAccessPolicyAccessPolicyIdentityFactory> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.User> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUser(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerAccessPolicyAccessPolicyIdentityFactory, T1, InnerAccessPolicyIamUserFactory> WithIamUser<T1>(this CombinedResult<InnerAccessPolicyAccessPolicyIdentityFactory, T1> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.IamUser> subFactoryAction = null) => new (combinedResult, combinedResult, WithIamUser(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAccessPolicyAccessPolicyIdentityFactory, InnerAccessPolicyIamUserFactory> WithIamUser<T1>(this CombinedResult<T1, InnerAccessPolicyAccessPolicyIdentityFactory> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.IamUser> subFactoryAction = null) => new (combinedResult, combinedResult, WithIamUser(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerAccessPolicyAccessPolicyIdentityFactory, T1, T2, InnerAccessPolicyIamUserFactory> WithIamUser<T1, T2>(this CombinedResult<InnerAccessPolicyAccessPolicyIdentityFactory, T1, T2> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.IamUser> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIamUser(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAccessPolicyAccessPolicyIdentityFactory, T2, InnerAccessPolicyIamUserFactory> WithIamUser<T1, T2>(this CombinedResult<T1, InnerAccessPolicyAccessPolicyIdentityFactory, T2> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.IamUser> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIamUser(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAccessPolicyAccessPolicyIdentityFactory, InnerAccessPolicyIamUserFactory> WithIamUser<T1, T2>(this CombinedResult<T1, T2, InnerAccessPolicyAccessPolicyIdentityFactory> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.IamUser> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIamUser(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerAccessPolicyAccessPolicyIdentityFactory, T1, T2, T3, InnerAccessPolicyIamUserFactory> WithIamUser<T1, T2, T3>(this CombinedResult<InnerAccessPolicyAccessPolicyIdentityFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.IamUser> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIamUser(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAccessPolicyAccessPolicyIdentityFactory, T2, T3, InnerAccessPolicyIamUserFactory> WithIamUser<T1, T2, T3>(this CombinedResult<T1, InnerAccessPolicyAccessPolicyIdentityFactory, T2, T3> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.IamUser> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIamUser(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAccessPolicyAccessPolicyIdentityFactory, T3, InnerAccessPolicyIamUserFactory> WithIamUser<T1, T2, T3>(this CombinedResult<T1, T2, InnerAccessPolicyAccessPolicyIdentityFactory, T3> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.IamUser> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIamUser(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAccessPolicyAccessPolicyIdentityFactory, InnerAccessPolicyIamUserFactory> WithIamUser<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAccessPolicyAccessPolicyIdentityFactory> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.IamUser> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIamUser(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerAccessPolicyAccessPolicyIdentityFactory, T1, T2, T3, T4, InnerAccessPolicyIamUserFactory> WithIamUser<T1, T2, T3, T4>(this CombinedResult<InnerAccessPolicyAccessPolicyIdentityFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.IamUser> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIamUser(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAccessPolicyAccessPolicyIdentityFactory, T2, T3, T4, InnerAccessPolicyIamUserFactory> WithIamUser<T1, T2, T3, T4>(this CombinedResult<T1, InnerAccessPolicyAccessPolicyIdentityFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.IamUser> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIamUser(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAccessPolicyAccessPolicyIdentityFactory, T3, T4, InnerAccessPolicyIamUserFactory> WithIamUser<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAccessPolicyAccessPolicyIdentityFactory, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.IamUser> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIamUser(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAccessPolicyAccessPolicyIdentityFactory, T4, InnerAccessPolicyIamUserFactory> WithIamUser<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAccessPolicyAccessPolicyIdentityFactory, T4> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.IamUser> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIamUser(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerAccessPolicyAccessPolicyIdentityFactory, InnerAccessPolicyIamUserFactory> WithIamUser<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAccessPolicyAccessPolicyIdentityFactory> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.IamUser> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIamUser(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerAccessPolicyAccessPolicyIdentityFactory, T1, InnerAccessPolicyIamRoleFactory> WithIamRole<T1>(this CombinedResult<InnerAccessPolicyAccessPolicyIdentityFactory, T1> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.IamRole> subFactoryAction = null) => new (combinedResult, combinedResult, WithIamRole(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAccessPolicyAccessPolicyIdentityFactory, InnerAccessPolicyIamRoleFactory> WithIamRole<T1>(this CombinedResult<T1, InnerAccessPolicyAccessPolicyIdentityFactory> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.IamRole> subFactoryAction = null) => new (combinedResult, combinedResult, WithIamRole(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerAccessPolicyAccessPolicyIdentityFactory, T1, T2, InnerAccessPolicyIamRoleFactory> WithIamRole<T1, T2>(this CombinedResult<InnerAccessPolicyAccessPolicyIdentityFactory, T1, T2> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.IamRole> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIamRole(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAccessPolicyAccessPolicyIdentityFactory, T2, InnerAccessPolicyIamRoleFactory> WithIamRole<T1, T2>(this CombinedResult<T1, InnerAccessPolicyAccessPolicyIdentityFactory, T2> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.IamRole> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIamRole(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAccessPolicyAccessPolicyIdentityFactory, InnerAccessPolicyIamRoleFactory> WithIamRole<T1, T2>(this CombinedResult<T1, T2, InnerAccessPolicyAccessPolicyIdentityFactory> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.IamRole> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIamRole(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerAccessPolicyAccessPolicyIdentityFactory, T1, T2, T3, InnerAccessPolicyIamRoleFactory> WithIamRole<T1, T2, T3>(this CombinedResult<InnerAccessPolicyAccessPolicyIdentityFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.IamRole> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIamRole(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAccessPolicyAccessPolicyIdentityFactory, T2, T3, InnerAccessPolicyIamRoleFactory> WithIamRole<T1, T2, T3>(this CombinedResult<T1, InnerAccessPolicyAccessPolicyIdentityFactory, T2, T3> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.IamRole> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIamRole(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAccessPolicyAccessPolicyIdentityFactory, T3, InnerAccessPolicyIamRoleFactory> WithIamRole<T1, T2, T3>(this CombinedResult<T1, T2, InnerAccessPolicyAccessPolicyIdentityFactory, T3> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.IamRole> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIamRole(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAccessPolicyAccessPolicyIdentityFactory, InnerAccessPolicyIamRoleFactory> WithIamRole<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAccessPolicyAccessPolicyIdentityFactory> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.IamRole> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIamRole(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerAccessPolicyAccessPolicyIdentityFactory, T1, T2, T3, T4, InnerAccessPolicyIamRoleFactory> WithIamRole<T1, T2, T3, T4>(this CombinedResult<InnerAccessPolicyAccessPolicyIdentityFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.IamRole> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIamRole(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAccessPolicyAccessPolicyIdentityFactory, T2, T3, T4, InnerAccessPolicyIamRoleFactory> WithIamRole<T1, T2, T3, T4>(this CombinedResult<T1, InnerAccessPolicyAccessPolicyIdentityFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.IamRole> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIamRole(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAccessPolicyAccessPolicyIdentityFactory, T3, T4, InnerAccessPolicyIamRoleFactory> WithIamRole<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAccessPolicyAccessPolicyIdentityFactory, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.IamRole> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIamRole(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAccessPolicyAccessPolicyIdentityFactory, T4, InnerAccessPolicyIamRoleFactory> WithIamRole<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAccessPolicyAccessPolicyIdentityFactory, T4> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.IamRole> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIamRole(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerAccessPolicyAccessPolicyIdentityFactory, InnerAccessPolicyIamRoleFactory> WithIamRole<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAccessPolicyAccessPolicyIdentityFactory> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.IamRole> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIamRole(combinedResult.T5, subFactoryAction));
}
