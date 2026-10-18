// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class ActionConnectorFactory(string resourceName = null, Action<Humidifier.QuickSight.ActionConnector> factoryAction = null) : ResourceFactory<Humidifier.QuickSight.ActionConnector>(resourceName)
{

    internal List<InnerActionConnectorResourcePermissionFactory> PermissionsFactories { get; set; } = [];

    internal InnerActionConnectorAuthConfigFactory AuthenticationConfigFactory { get; set; }

    protected override Humidifier.QuickSight.ActionConnector Create()
    {
        var actionConnectorResult = CreateActionConnector();
        factoryAction?.Invoke(actionConnectorResult);

        return actionConnectorResult;
    }

    private Humidifier.QuickSight.ActionConnector CreateActionConnector()
    {
        var actionConnectorResult = new Humidifier.QuickSight.ActionConnector
        {
            GivenName = InputResourceName,
        };

        return actionConnectorResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.ActionConnector result)
    {
        base.CreateChildren(result);

        result.Permissions = PermissionsFactories.Any() ? PermissionsFactories.Select(x => x.Build()).ToList() : null;
        result.AuthenticationConfig ??= AuthenticationConfigFactory?.Build();
    }

} // End Of Class

public static class ActionConnectorFactoryExtensions
{
    public static CombinedResult<ActionConnectorFactory, InnerActionConnectorResourcePermissionFactory> WithPermissions(this ActionConnectorFactory parentFactory, Action<Humidifier.QuickSight.ActionConnectorTypes.ResourcePermission> subFactoryAction = null)
    {
        var factory = new InnerActionConnectorResourcePermissionFactory(subFactoryAction);
        parentFactory.PermissionsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ActionConnectorFactory, InnerActionConnectorAuthConfigFactory> WithAuthenticationConfig(this ActionConnectorFactory parentFactory, Action<Humidifier.QuickSight.ActionConnectorTypes.AuthConfig> subFactoryAction = null)
    {
        parentFactory.AuthenticationConfigFactory = new InnerActionConnectorAuthConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AuthenticationConfigFactory);
    }

    public static CombinedResult<ActionConnectorFactory, T1, InnerActionConnectorResourcePermissionFactory> WithPermissions<T1>(this CombinedResult<ActionConnectorFactory, T1> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.ResourcePermission> subFactoryAction = null) => new (combinedResult, combinedResult, WithPermissions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ActionConnectorFactory, InnerActionConnectorResourcePermissionFactory> WithPermissions<T1>(this CombinedResult<T1, ActionConnectorFactory> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.ResourcePermission> subFactoryAction = null) => new (combinedResult, combinedResult, WithPermissions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ActionConnectorFactory, T1, T2, InnerActionConnectorResourcePermissionFactory> WithPermissions<T1, T2>(this CombinedResult<ActionConnectorFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.ResourcePermission> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPermissions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ActionConnectorFactory, T2, InnerActionConnectorResourcePermissionFactory> WithPermissions<T1, T2>(this CombinedResult<T1, ActionConnectorFactory, T2> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.ResourcePermission> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPermissions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ActionConnectorFactory, InnerActionConnectorResourcePermissionFactory> WithPermissions<T1, T2>(this CombinedResult<T1, T2, ActionConnectorFactory> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.ResourcePermission> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPermissions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ActionConnectorFactory, T1, T2, T3, InnerActionConnectorResourcePermissionFactory> WithPermissions<T1, T2, T3>(this CombinedResult<ActionConnectorFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.ResourcePermission> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPermissions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ActionConnectorFactory, T2, T3, InnerActionConnectorResourcePermissionFactory> WithPermissions<T1, T2, T3>(this CombinedResult<T1, ActionConnectorFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.ResourcePermission> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPermissions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ActionConnectorFactory, T3, InnerActionConnectorResourcePermissionFactory> WithPermissions<T1, T2, T3>(this CombinedResult<T1, T2, ActionConnectorFactory, T3> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.ResourcePermission> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPermissions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ActionConnectorFactory, InnerActionConnectorResourcePermissionFactory> WithPermissions<T1, T2, T3>(this CombinedResult<T1, T2, T3, ActionConnectorFactory> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.ResourcePermission> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPermissions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ActionConnectorFactory, T1, T2, T3, T4, InnerActionConnectorResourcePermissionFactory> WithPermissions<T1, T2, T3, T4>(this CombinedResult<ActionConnectorFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.ResourcePermission> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPermissions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ActionConnectorFactory, T2, T3, T4, InnerActionConnectorResourcePermissionFactory> WithPermissions<T1, T2, T3, T4>(this CombinedResult<T1, ActionConnectorFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.ResourcePermission> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPermissions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ActionConnectorFactory, T3, T4, InnerActionConnectorResourcePermissionFactory> WithPermissions<T1, T2, T3, T4>(this CombinedResult<T1, T2, ActionConnectorFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.ResourcePermission> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPermissions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ActionConnectorFactory, T4, InnerActionConnectorResourcePermissionFactory> WithPermissions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ActionConnectorFactory, T4> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.ResourcePermission> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPermissions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ActionConnectorFactory, InnerActionConnectorResourcePermissionFactory> WithPermissions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ActionConnectorFactory> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.ResourcePermission> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPermissions(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<ActionConnectorFactory, T1, InnerActionConnectorAuthConfigFactory> WithAuthenticationConfig<T1>(this CombinedResult<ActionConnectorFactory, T1> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.AuthConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithAuthenticationConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ActionConnectorFactory, InnerActionConnectorAuthConfigFactory> WithAuthenticationConfig<T1>(this CombinedResult<T1, ActionConnectorFactory> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.AuthConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithAuthenticationConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ActionConnectorFactory, T1, T2, InnerActionConnectorAuthConfigFactory> WithAuthenticationConfig<T1, T2>(this CombinedResult<ActionConnectorFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.AuthConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthenticationConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ActionConnectorFactory, T2, InnerActionConnectorAuthConfigFactory> WithAuthenticationConfig<T1, T2>(this CombinedResult<T1, ActionConnectorFactory, T2> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.AuthConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthenticationConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ActionConnectorFactory, InnerActionConnectorAuthConfigFactory> WithAuthenticationConfig<T1, T2>(this CombinedResult<T1, T2, ActionConnectorFactory> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.AuthConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthenticationConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ActionConnectorFactory, T1, T2, T3, InnerActionConnectorAuthConfigFactory> WithAuthenticationConfig<T1, T2, T3>(this CombinedResult<ActionConnectorFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.AuthConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthenticationConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ActionConnectorFactory, T2, T3, InnerActionConnectorAuthConfigFactory> WithAuthenticationConfig<T1, T2, T3>(this CombinedResult<T1, ActionConnectorFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.AuthConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthenticationConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ActionConnectorFactory, T3, InnerActionConnectorAuthConfigFactory> WithAuthenticationConfig<T1, T2, T3>(this CombinedResult<T1, T2, ActionConnectorFactory, T3> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.AuthConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthenticationConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ActionConnectorFactory, InnerActionConnectorAuthConfigFactory> WithAuthenticationConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, ActionConnectorFactory> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.AuthConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthenticationConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ActionConnectorFactory, T1, T2, T3, T4, InnerActionConnectorAuthConfigFactory> WithAuthenticationConfig<T1, T2, T3, T4>(this CombinedResult<ActionConnectorFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.AuthConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthenticationConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ActionConnectorFactory, T2, T3, T4, InnerActionConnectorAuthConfigFactory> WithAuthenticationConfig<T1, T2, T3, T4>(this CombinedResult<T1, ActionConnectorFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.AuthConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthenticationConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ActionConnectorFactory, T3, T4, InnerActionConnectorAuthConfigFactory> WithAuthenticationConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, ActionConnectorFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.AuthConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthenticationConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ActionConnectorFactory, T4, InnerActionConnectorAuthConfigFactory> WithAuthenticationConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ActionConnectorFactory, T4> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.AuthConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthenticationConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ActionConnectorFactory, InnerActionConnectorAuthConfigFactory> WithAuthenticationConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ActionConnectorFactory> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.AuthConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthenticationConfig(combinedResult.T5, subFactoryAction).T2);
}
