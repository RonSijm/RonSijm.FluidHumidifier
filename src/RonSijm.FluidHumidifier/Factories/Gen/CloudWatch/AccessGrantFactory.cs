// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudWatch;

public class AccessGrantFactory(string resourceName = null, Action<Humidifier.CloudWatch.AccessGrant> factoryAction = null) : ResourceFactory<Humidifier.CloudWatch.AccessGrant>(resourceName)
{

    internal List<InnerAccessGrantScopedActionsFactory> ScopedActionsFactories { get; set; } = [];

    internal InnerAccessGrantAccessGrantPrincipalFactory PrincipalFactory { get; set; }

    protected override Humidifier.CloudWatch.AccessGrant Create()
    {
        var accessGrantResult = CreateAccessGrant();
        factoryAction?.Invoke(accessGrantResult);

        return accessGrantResult;
    }

    private Humidifier.CloudWatch.AccessGrant CreateAccessGrant()
    {
        var accessGrantResult = new Humidifier.CloudWatch.AccessGrant
        {
            GivenName = InputResourceName,
        };

        return accessGrantResult;
    }
    public override void CreateChildren(Humidifier.CloudWatch.AccessGrant result)
    {
        base.CreateChildren(result);

        result.ScopedActions = ScopedActionsFactories.Any() ? ScopedActionsFactories.Select(x => x.Build()).ToList() : null;
        result.Principal ??= PrincipalFactory?.Build();
    }

} // End Of Class

public static class AccessGrantFactoryExtensions
{
    public static CombinedResult<AccessGrantFactory, InnerAccessGrantScopedActionsFactory> WithScopedActions(this AccessGrantFactory parentFactory, Action<Humidifier.CloudWatch.AccessGrantTypes.ScopedActions> subFactoryAction = null)
    {
        var factory = new InnerAccessGrantScopedActionsFactory(subFactoryAction);
        parentFactory.ScopedActionsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<AccessGrantFactory, InnerAccessGrantAccessGrantPrincipalFactory> WithPrincipal(this AccessGrantFactory parentFactory, Action<Humidifier.CloudWatch.AccessGrantTypes.AccessGrantPrincipal> subFactoryAction = null)
    {
        parentFactory.PrincipalFactory = new InnerAccessGrantAccessGrantPrincipalFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PrincipalFactory);
    }

    public static CombinedResult<AccessGrantFactory, T1, InnerAccessGrantScopedActionsFactory> WithScopedActions<T1>(this CombinedResult<AccessGrantFactory, T1> combinedResult, Action<Humidifier.CloudWatch.AccessGrantTypes.ScopedActions> subFactoryAction = null) => new (combinedResult, combinedResult, WithScopedActions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AccessGrantFactory, InnerAccessGrantScopedActionsFactory> WithScopedActions<T1>(this CombinedResult<T1, AccessGrantFactory> combinedResult, Action<Humidifier.CloudWatch.AccessGrantTypes.ScopedActions> subFactoryAction = null) => new (combinedResult, combinedResult, WithScopedActions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<AccessGrantFactory, T1, T2, InnerAccessGrantScopedActionsFactory> WithScopedActions<T1, T2>(this CombinedResult<AccessGrantFactory, T1, T2> combinedResult, Action<Humidifier.CloudWatch.AccessGrantTypes.ScopedActions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScopedActions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AccessGrantFactory, T2, InnerAccessGrantScopedActionsFactory> WithScopedActions<T1, T2>(this CombinedResult<T1, AccessGrantFactory, T2> combinedResult, Action<Humidifier.CloudWatch.AccessGrantTypes.ScopedActions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScopedActions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AccessGrantFactory, InnerAccessGrantScopedActionsFactory> WithScopedActions<T1, T2>(this CombinedResult<T1, T2, AccessGrantFactory> combinedResult, Action<Humidifier.CloudWatch.AccessGrantTypes.ScopedActions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScopedActions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<AccessGrantFactory, T1, T2, T3, InnerAccessGrantScopedActionsFactory> WithScopedActions<T1, T2, T3>(this CombinedResult<AccessGrantFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudWatch.AccessGrantTypes.ScopedActions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScopedActions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AccessGrantFactory, T2, T3, InnerAccessGrantScopedActionsFactory> WithScopedActions<T1, T2, T3>(this CombinedResult<T1, AccessGrantFactory, T2, T3> combinedResult, Action<Humidifier.CloudWatch.AccessGrantTypes.ScopedActions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScopedActions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AccessGrantFactory, T3, InnerAccessGrantScopedActionsFactory> WithScopedActions<T1, T2, T3>(this CombinedResult<T1, T2, AccessGrantFactory, T3> combinedResult, Action<Humidifier.CloudWatch.AccessGrantTypes.ScopedActions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScopedActions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AccessGrantFactory, InnerAccessGrantScopedActionsFactory> WithScopedActions<T1, T2, T3>(this CombinedResult<T1, T2, T3, AccessGrantFactory> combinedResult, Action<Humidifier.CloudWatch.AccessGrantTypes.ScopedActions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScopedActions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<AccessGrantFactory, T1, T2, T3, T4, InnerAccessGrantScopedActionsFactory> WithScopedActions<T1, T2, T3, T4>(this CombinedResult<AccessGrantFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudWatch.AccessGrantTypes.ScopedActions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScopedActions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AccessGrantFactory, T2, T3, T4, InnerAccessGrantScopedActionsFactory> WithScopedActions<T1, T2, T3, T4>(this CombinedResult<T1, AccessGrantFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudWatch.AccessGrantTypes.ScopedActions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScopedActions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AccessGrantFactory, T3, T4, InnerAccessGrantScopedActionsFactory> WithScopedActions<T1, T2, T3, T4>(this CombinedResult<T1, T2, AccessGrantFactory, T3, T4> combinedResult, Action<Humidifier.CloudWatch.AccessGrantTypes.ScopedActions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScopedActions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AccessGrantFactory, T4, InnerAccessGrantScopedActionsFactory> WithScopedActions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AccessGrantFactory, T4> combinedResult, Action<Humidifier.CloudWatch.AccessGrantTypes.ScopedActions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScopedActions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, AccessGrantFactory, InnerAccessGrantScopedActionsFactory> WithScopedActions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AccessGrantFactory> combinedResult, Action<Humidifier.CloudWatch.AccessGrantTypes.ScopedActions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScopedActions(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<AccessGrantFactory, T1, InnerAccessGrantAccessGrantPrincipalFactory> WithPrincipal<T1>(this CombinedResult<AccessGrantFactory, T1> combinedResult, Action<Humidifier.CloudWatch.AccessGrantTypes.AccessGrantPrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, WithPrincipal(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AccessGrantFactory, InnerAccessGrantAccessGrantPrincipalFactory> WithPrincipal<T1>(this CombinedResult<T1, AccessGrantFactory> combinedResult, Action<Humidifier.CloudWatch.AccessGrantTypes.AccessGrantPrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, WithPrincipal(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<AccessGrantFactory, T1, T2, InnerAccessGrantAccessGrantPrincipalFactory> WithPrincipal<T1, T2>(this CombinedResult<AccessGrantFactory, T1, T2> combinedResult, Action<Humidifier.CloudWatch.AccessGrantTypes.AccessGrantPrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AccessGrantFactory, T2, InnerAccessGrantAccessGrantPrincipalFactory> WithPrincipal<T1, T2>(this CombinedResult<T1, AccessGrantFactory, T2> combinedResult, Action<Humidifier.CloudWatch.AccessGrantTypes.AccessGrantPrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AccessGrantFactory, InnerAccessGrantAccessGrantPrincipalFactory> WithPrincipal<T1, T2>(this CombinedResult<T1, T2, AccessGrantFactory> combinedResult, Action<Humidifier.CloudWatch.AccessGrantTypes.AccessGrantPrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<AccessGrantFactory, T1, T2, T3, InnerAccessGrantAccessGrantPrincipalFactory> WithPrincipal<T1, T2, T3>(this CombinedResult<AccessGrantFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudWatch.AccessGrantTypes.AccessGrantPrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AccessGrantFactory, T2, T3, InnerAccessGrantAccessGrantPrincipalFactory> WithPrincipal<T1, T2, T3>(this CombinedResult<T1, AccessGrantFactory, T2, T3> combinedResult, Action<Humidifier.CloudWatch.AccessGrantTypes.AccessGrantPrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AccessGrantFactory, T3, InnerAccessGrantAccessGrantPrincipalFactory> WithPrincipal<T1, T2, T3>(this CombinedResult<T1, T2, AccessGrantFactory, T3> combinedResult, Action<Humidifier.CloudWatch.AccessGrantTypes.AccessGrantPrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AccessGrantFactory, InnerAccessGrantAccessGrantPrincipalFactory> WithPrincipal<T1, T2, T3>(this CombinedResult<T1, T2, T3, AccessGrantFactory> combinedResult, Action<Humidifier.CloudWatch.AccessGrantTypes.AccessGrantPrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<AccessGrantFactory, T1, T2, T3, T4, InnerAccessGrantAccessGrantPrincipalFactory> WithPrincipal<T1, T2, T3, T4>(this CombinedResult<AccessGrantFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudWatch.AccessGrantTypes.AccessGrantPrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AccessGrantFactory, T2, T3, T4, InnerAccessGrantAccessGrantPrincipalFactory> WithPrincipal<T1, T2, T3, T4>(this CombinedResult<T1, AccessGrantFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudWatch.AccessGrantTypes.AccessGrantPrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AccessGrantFactory, T3, T4, InnerAccessGrantAccessGrantPrincipalFactory> WithPrincipal<T1, T2, T3, T4>(this CombinedResult<T1, T2, AccessGrantFactory, T3, T4> combinedResult, Action<Humidifier.CloudWatch.AccessGrantTypes.AccessGrantPrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AccessGrantFactory, T4, InnerAccessGrantAccessGrantPrincipalFactory> WithPrincipal<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AccessGrantFactory, T4> combinedResult, Action<Humidifier.CloudWatch.AccessGrantTypes.AccessGrantPrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, AccessGrantFactory, InnerAccessGrantAccessGrantPrincipalFactory> WithPrincipal<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AccessGrantFactory> combinedResult, Action<Humidifier.CloudWatch.AccessGrantTypes.AccessGrantPrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T5, subFactoryAction).T2);
}
