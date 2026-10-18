// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFabric;

public class AppAuthorizationFactory(string resourceName = null, Action<Humidifier.AppFabric.AppAuthorization> factoryAction = null) : ResourceFactory<Humidifier.AppFabric.AppAuthorization>(resourceName)
{

    internal InnerAppAuthorizationCredentialFactory CredentialFactory { get; set; }

    internal InnerAppAuthorizationTenantFactory TenantFactory { get; set; }

    protected override Humidifier.AppFabric.AppAuthorization Create()
    {
        var appAuthorizationResult = CreateAppAuthorization();
        factoryAction?.Invoke(appAuthorizationResult);

        return appAuthorizationResult;
    }

    private Humidifier.AppFabric.AppAuthorization CreateAppAuthorization()
    {
        var appAuthorizationResult = new Humidifier.AppFabric.AppAuthorization
        {
            GivenName = InputResourceName,
        };

        return appAuthorizationResult;
    }
    public override void CreateChildren(Humidifier.AppFabric.AppAuthorization result)
    {
        base.CreateChildren(result);

        result.Credential ??= CredentialFactory?.Build();
        result.Tenant ??= TenantFactory?.Build();
    }

} // End Of Class

public static class AppAuthorizationFactoryExtensions
{
    public static CombinedResult<AppAuthorizationFactory, InnerAppAuthorizationCredentialFactory> WithCredential(this AppAuthorizationFactory parentFactory, Action<Humidifier.AppFabric.AppAuthorizationTypes.Credential> subFactoryAction = null)
    {
        parentFactory.CredentialFactory = new InnerAppAuthorizationCredentialFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CredentialFactory);
    }

    public static CombinedResult<AppAuthorizationFactory, InnerAppAuthorizationTenantFactory> WithTenant(this AppAuthorizationFactory parentFactory, Action<Humidifier.AppFabric.AppAuthorizationTypes.Tenant> subFactoryAction = null)
    {
        parentFactory.TenantFactory = new InnerAppAuthorizationTenantFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TenantFactory);
    }

    public static CombinedResult<AppAuthorizationFactory, T1, InnerAppAuthorizationCredentialFactory> WithCredential<T1>(this CombinedResult<AppAuthorizationFactory, T1> combinedResult, Action<Humidifier.AppFabric.AppAuthorizationTypes.Credential> subFactoryAction = null) => new (combinedResult, combinedResult, WithCredential(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AppAuthorizationFactory, InnerAppAuthorizationCredentialFactory> WithCredential<T1>(this CombinedResult<T1, AppAuthorizationFactory> combinedResult, Action<Humidifier.AppFabric.AppAuthorizationTypes.Credential> subFactoryAction = null) => new (combinedResult, combinedResult, WithCredential(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<AppAuthorizationFactory, T1, T2, InnerAppAuthorizationCredentialFactory> WithCredential<T1, T2>(this CombinedResult<AppAuthorizationFactory, T1, T2> combinedResult, Action<Humidifier.AppFabric.AppAuthorizationTypes.Credential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCredential(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AppAuthorizationFactory, T2, InnerAppAuthorizationCredentialFactory> WithCredential<T1, T2>(this CombinedResult<T1, AppAuthorizationFactory, T2> combinedResult, Action<Humidifier.AppFabric.AppAuthorizationTypes.Credential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCredential(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AppAuthorizationFactory, InnerAppAuthorizationCredentialFactory> WithCredential<T1, T2>(this CombinedResult<T1, T2, AppAuthorizationFactory> combinedResult, Action<Humidifier.AppFabric.AppAuthorizationTypes.Credential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCredential(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<AppAuthorizationFactory, T1, T2, T3, InnerAppAuthorizationCredentialFactory> WithCredential<T1, T2, T3>(this CombinedResult<AppAuthorizationFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppFabric.AppAuthorizationTypes.Credential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCredential(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AppAuthorizationFactory, T2, T3, InnerAppAuthorizationCredentialFactory> WithCredential<T1, T2, T3>(this CombinedResult<T1, AppAuthorizationFactory, T2, T3> combinedResult, Action<Humidifier.AppFabric.AppAuthorizationTypes.Credential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCredential(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AppAuthorizationFactory, T3, InnerAppAuthorizationCredentialFactory> WithCredential<T1, T2, T3>(this CombinedResult<T1, T2, AppAuthorizationFactory, T3> combinedResult, Action<Humidifier.AppFabric.AppAuthorizationTypes.Credential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCredential(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AppAuthorizationFactory, InnerAppAuthorizationCredentialFactory> WithCredential<T1, T2, T3>(this CombinedResult<T1, T2, T3, AppAuthorizationFactory> combinedResult, Action<Humidifier.AppFabric.AppAuthorizationTypes.Credential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCredential(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<AppAuthorizationFactory, T1, T2, T3, T4, InnerAppAuthorizationCredentialFactory> WithCredential<T1, T2, T3, T4>(this CombinedResult<AppAuthorizationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppFabric.AppAuthorizationTypes.Credential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCredential(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AppAuthorizationFactory, T2, T3, T4, InnerAppAuthorizationCredentialFactory> WithCredential<T1, T2, T3, T4>(this CombinedResult<T1, AppAuthorizationFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppFabric.AppAuthorizationTypes.Credential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCredential(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AppAuthorizationFactory, T3, T4, InnerAppAuthorizationCredentialFactory> WithCredential<T1, T2, T3, T4>(this CombinedResult<T1, T2, AppAuthorizationFactory, T3, T4> combinedResult, Action<Humidifier.AppFabric.AppAuthorizationTypes.Credential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCredential(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AppAuthorizationFactory, T4, InnerAppAuthorizationCredentialFactory> WithCredential<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AppAuthorizationFactory, T4> combinedResult, Action<Humidifier.AppFabric.AppAuthorizationTypes.Credential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCredential(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, AppAuthorizationFactory, InnerAppAuthorizationCredentialFactory> WithCredential<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AppAuthorizationFactory> combinedResult, Action<Humidifier.AppFabric.AppAuthorizationTypes.Credential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCredential(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<AppAuthorizationFactory, T1, InnerAppAuthorizationTenantFactory> WithTenant<T1>(this CombinedResult<AppAuthorizationFactory, T1> combinedResult, Action<Humidifier.AppFabric.AppAuthorizationTypes.Tenant> subFactoryAction = null) => new (combinedResult, combinedResult, WithTenant(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AppAuthorizationFactory, InnerAppAuthorizationTenantFactory> WithTenant<T1>(this CombinedResult<T1, AppAuthorizationFactory> combinedResult, Action<Humidifier.AppFabric.AppAuthorizationTypes.Tenant> subFactoryAction = null) => new (combinedResult, combinedResult, WithTenant(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<AppAuthorizationFactory, T1, T2, InnerAppAuthorizationTenantFactory> WithTenant<T1, T2>(this CombinedResult<AppAuthorizationFactory, T1, T2> combinedResult, Action<Humidifier.AppFabric.AppAuthorizationTypes.Tenant> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTenant(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AppAuthorizationFactory, T2, InnerAppAuthorizationTenantFactory> WithTenant<T1, T2>(this CombinedResult<T1, AppAuthorizationFactory, T2> combinedResult, Action<Humidifier.AppFabric.AppAuthorizationTypes.Tenant> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTenant(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AppAuthorizationFactory, InnerAppAuthorizationTenantFactory> WithTenant<T1, T2>(this CombinedResult<T1, T2, AppAuthorizationFactory> combinedResult, Action<Humidifier.AppFabric.AppAuthorizationTypes.Tenant> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTenant(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<AppAuthorizationFactory, T1, T2, T3, InnerAppAuthorizationTenantFactory> WithTenant<T1, T2, T3>(this CombinedResult<AppAuthorizationFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppFabric.AppAuthorizationTypes.Tenant> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTenant(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AppAuthorizationFactory, T2, T3, InnerAppAuthorizationTenantFactory> WithTenant<T1, T2, T3>(this CombinedResult<T1, AppAuthorizationFactory, T2, T3> combinedResult, Action<Humidifier.AppFabric.AppAuthorizationTypes.Tenant> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTenant(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AppAuthorizationFactory, T3, InnerAppAuthorizationTenantFactory> WithTenant<T1, T2, T3>(this CombinedResult<T1, T2, AppAuthorizationFactory, T3> combinedResult, Action<Humidifier.AppFabric.AppAuthorizationTypes.Tenant> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTenant(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AppAuthorizationFactory, InnerAppAuthorizationTenantFactory> WithTenant<T1, T2, T3>(this CombinedResult<T1, T2, T3, AppAuthorizationFactory> combinedResult, Action<Humidifier.AppFabric.AppAuthorizationTypes.Tenant> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTenant(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<AppAuthorizationFactory, T1, T2, T3, T4, InnerAppAuthorizationTenantFactory> WithTenant<T1, T2, T3, T4>(this CombinedResult<AppAuthorizationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppFabric.AppAuthorizationTypes.Tenant> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTenant(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AppAuthorizationFactory, T2, T3, T4, InnerAppAuthorizationTenantFactory> WithTenant<T1, T2, T3, T4>(this CombinedResult<T1, AppAuthorizationFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppFabric.AppAuthorizationTypes.Tenant> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTenant(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AppAuthorizationFactory, T3, T4, InnerAppAuthorizationTenantFactory> WithTenant<T1, T2, T3, T4>(this CombinedResult<T1, T2, AppAuthorizationFactory, T3, T4> combinedResult, Action<Humidifier.AppFabric.AppAuthorizationTypes.Tenant> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTenant(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AppAuthorizationFactory, T4, InnerAppAuthorizationTenantFactory> WithTenant<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AppAuthorizationFactory, T4> combinedResult, Action<Humidifier.AppFabric.AppAuthorizationTypes.Tenant> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTenant(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, AppAuthorizationFactory, InnerAppAuthorizationTenantFactory> WithTenant<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AppAuthorizationFactory> combinedResult, Action<Humidifier.AppFabric.AppAuthorizationTypes.Tenant> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTenant(combinedResult.T5, subFactoryAction).T2);
}
