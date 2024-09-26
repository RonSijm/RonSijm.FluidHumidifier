// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaPackage;

public class PackagingGroupFactory(string resourceName = null, Action<Humidifier.MediaPackage.PackagingGroup> factoryAction = null) : ResourceFactory<Humidifier.MediaPackage.PackagingGroup>(resourceName)
{

    internal InnerPackagingGroupAuthorizationFactory AuthorizationFactory { get; set; }

    internal InnerPackagingGroupLogConfigurationFactory EgressAccessLogsFactory { get; set; }

    protected override Humidifier.MediaPackage.PackagingGroup Create()
    {
        var packagingGroupResult = CreatePackagingGroup();
        factoryAction?.Invoke(packagingGroupResult);

        return packagingGroupResult;
    }

    private Humidifier.MediaPackage.PackagingGroup CreatePackagingGroup()
    {
        var packagingGroupResult = new Humidifier.MediaPackage.PackagingGroup
        {
            GivenName = InputResourceName,
        };

        return packagingGroupResult;
    }
    public override void CreateChildren(Humidifier.MediaPackage.PackagingGroup result)
    {
        base.CreateChildren(result);

        result.Authorization ??= AuthorizationFactory?.Build();
        result.EgressAccessLogs ??= EgressAccessLogsFactory?.Build();
    }

} // End Of Class

public static class PackagingGroupFactoryExtensions
{
    public static CombinedResult<PackagingGroupFactory, InnerPackagingGroupAuthorizationFactory> WithAuthorization(this PackagingGroupFactory parentFactory, Action<Humidifier.MediaPackage.PackagingGroupTypes.Authorization> subFactoryAction = null)
    {
        parentFactory.AuthorizationFactory = new InnerPackagingGroupAuthorizationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AuthorizationFactory);
    }

    public static CombinedResult<PackagingGroupFactory, InnerPackagingGroupLogConfigurationFactory> WithEgressAccessLogs(this PackagingGroupFactory parentFactory, Action<Humidifier.MediaPackage.PackagingGroupTypes.LogConfiguration> subFactoryAction = null)
    {
        parentFactory.EgressAccessLogsFactory = new InnerPackagingGroupLogConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EgressAccessLogsFactory);
    }

    public static CombinedResult<PackagingGroupFactory, T1, InnerPackagingGroupAuthorizationFactory> WithAuthorization<T1>(this CombinedResult<PackagingGroupFactory, T1> combinedResult, Action<Humidifier.MediaPackage.PackagingGroupTypes.Authorization> subFactoryAction = null) => new (combinedResult, combinedResult, WithAuthorization(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PackagingGroupFactory, InnerPackagingGroupAuthorizationFactory> WithAuthorization<T1>(this CombinedResult<T1, PackagingGroupFactory> combinedResult, Action<Humidifier.MediaPackage.PackagingGroupTypes.Authorization> subFactoryAction = null) => new (combinedResult, combinedResult, WithAuthorization(combinedResult.T2, subFactoryAction));
    public static CombinedResult<PackagingGroupFactory, T1, T2, InnerPackagingGroupAuthorizationFactory> WithAuthorization<T1, T2>(this CombinedResult<PackagingGroupFactory, T1, T2> combinedResult, Action<Humidifier.MediaPackage.PackagingGroupTypes.Authorization> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthorization(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PackagingGroupFactory, T2, InnerPackagingGroupAuthorizationFactory> WithAuthorization<T1, T2>(this CombinedResult<T1, PackagingGroupFactory, T2> combinedResult, Action<Humidifier.MediaPackage.PackagingGroupTypes.Authorization> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthorization(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PackagingGroupFactory, InnerPackagingGroupAuthorizationFactory> WithAuthorization<T1, T2>(this CombinedResult<T1, T2, PackagingGroupFactory> combinedResult, Action<Humidifier.MediaPackage.PackagingGroupTypes.Authorization> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthorization(combinedResult.T3, subFactoryAction));
    public static CombinedResult<PackagingGroupFactory, T1, T2, T3, InnerPackagingGroupAuthorizationFactory> WithAuthorization<T1, T2, T3>(this CombinedResult<PackagingGroupFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaPackage.PackagingGroupTypes.Authorization> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorization(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PackagingGroupFactory, T2, T3, InnerPackagingGroupAuthorizationFactory> WithAuthorization<T1, T2, T3>(this CombinedResult<T1, PackagingGroupFactory, T2, T3> combinedResult, Action<Humidifier.MediaPackage.PackagingGroupTypes.Authorization> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorization(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PackagingGroupFactory, T3, InnerPackagingGroupAuthorizationFactory> WithAuthorization<T1, T2, T3>(this CombinedResult<T1, T2, PackagingGroupFactory, T3> combinedResult, Action<Humidifier.MediaPackage.PackagingGroupTypes.Authorization> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorization(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PackagingGroupFactory, InnerPackagingGroupAuthorizationFactory> WithAuthorization<T1, T2, T3>(this CombinedResult<T1, T2, T3, PackagingGroupFactory> combinedResult, Action<Humidifier.MediaPackage.PackagingGroupTypes.Authorization> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorization(combinedResult.T4, subFactoryAction));
    public static CombinedResult<PackagingGroupFactory, T1, T2, T3, T4, InnerPackagingGroupAuthorizationFactory> WithAuthorization<T1, T2, T3, T4>(this CombinedResult<PackagingGroupFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaPackage.PackagingGroupTypes.Authorization> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorization(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PackagingGroupFactory, T2, T3, T4, InnerPackagingGroupAuthorizationFactory> WithAuthorization<T1, T2, T3, T4>(this CombinedResult<T1, PackagingGroupFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaPackage.PackagingGroupTypes.Authorization> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorization(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PackagingGroupFactory, T3, T4, InnerPackagingGroupAuthorizationFactory> WithAuthorization<T1, T2, T3, T4>(this CombinedResult<T1, T2, PackagingGroupFactory, T3, T4> combinedResult, Action<Humidifier.MediaPackage.PackagingGroupTypes.Authorization> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorization(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PackagingGroupFactory, T4, InnerPackagingGroupAuthorizationFactory> WithAuthorization<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, PackagingGroupFactory, T4> combinedResult, Action<Humidifier.MediaPackage.PackagingGroupTypes.Authorization> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorization(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, PackagingGroupFactory, InnerPackagingGroupAuthorizationFactory> WithAuthorization<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, PackagingGroupFactory> combinedResult, Action<Humidifier.MediaPackage.PackagingGroupTypes.Authorization> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorization(combinedResult.T5, subFactoryAction));
    public static CombinedResult<PackagingGroupFactory, T1, InnerPackagingGroupLogConfigurationFactory> WithEgressAccessLogs<T1>(this CombinedResult<PackagingGroupFactory, T1> combinedResult, Action<Humidifier.MediaPackage.PackagingGroupTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEgressAccessLogs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PackagingGroupFactory, InnerPackagingGroupLogConfigurationFactory> WithEgressAccessLogs<T1>(this CombinedResult<T1, PackagingGroupFactory> combinedResult, Action<Humidifier.MediaPackage.PackagingGroupTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEgressAccessLogs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<PackagingGroupFactory, T1, T2, InnerPackagingGroupLogConfigurationFactory> WithEgressAccessLogs<T1, T2>(this CombinedResult<PackagingGroupFactory, T1, T2> combinedResult, Action<Humidifier.MediaPackage.PackagingGroupTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEgressAccessLogs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PackagingGroupFactory, T2, InnerPackagingGroupLogConfigurationFactory> WithEgressAccessLogs<T1, T2>(this CombinedResult<T1, PackagingGroupFactory, T2> combinedResult, Action<Humidifier.MediaPackage.PackagingGroupTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEgressAccessLogs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PackagingGroupFactory, InnerPackagingGroupLogConfigurationFactory> WithEgressAccessLogs<T1, T2>(this CombinedResult<T1, T2, PackagingGroupFactory> combinedResult, Action<Humidifier.MediaPackage.PackagingGroupTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEgressAccessLogs(combinedResult.T3, subFactoryAction));
    public static CombinedResult<PackagingGroupFactory, T1, T2, T3, InnerPackagingGroupLogConfigurationFactory> WithEgressAccessLogs<T1, T2, T3>(this CombinedResult<PackagingGroupFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaPackage.PackagingGroupTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEgressAccessLogs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PackagingGroupFactory, T2, T3, InnerPackagingGroupLogConfigurationFactory> WithEgressAccessLogs<T1, T2, T3>(this CombinedResult<T1, PackagingGroupFactory, T2, T3> combinedResult, Action<Humidifier.MediaPackage.PackagingGroupTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEgressAccessLogs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PackagingGroupFactory, T3, InnerPackagingGroupLogConfigurationFactory> WithEgressAccessLogs<T1, T2, T3>(this CombinedResult<T1, T2, PackagingGroupFactory, T3> combinedResult, Action<Humidifier.MediaPackage.PackagingGroupTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEgressAccessLogs(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PackagingGroupFactory, InnerPackagingGroupLogConfigurationFactory> WithEgressAccessLogs<T1, T2, T3>(this CombinedResult<T1, T2, T3, PackagingGroupFactory> combinedResult, Action<Humidifier.MediaPackage.PackagingGroupTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEgressAccessLogs(combinedResult.T4, subFactoryAction));
    public static CombinedResult<PackagingGroupFactory, T1, T2, T3, T4, InnerPackagingGroupLogConfigurationFactory> WithEgressAccessLogs<T1, T2, T3, T4>(this CombinedResult<PackagingGroupFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaPackage.PackagingGroupTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEgressAccessLogs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PackagingGroupFactory, T2, T3, T4, InnerPackagingGroupLogConfigurationFactory> WithEgressAccessLogs<T1, T2, T3, T4>(this CombinedResult<T1, PackagingGroupFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaPackage.PackagingGroupTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEgressAccessLogs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PackagingGroupFactory, T3, T4, InnerPackagingGroupLogConfigurationFactory> WithEgressAccessLogs<T1, T2, T3, T4>(this CombinedResult<T1, T2, PackagingGroupFactory, T3, T4> combinedResult, Action<Humidifier.MediaPackage.PackagingGroupTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEgressAccessLogs(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PackagingGroupFactory, T4, InnerPackagingGroupLogConfigurationFactory> WithEgressAccessLogs<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, PackagingGroupFactory, T4> combinedResult, Action<Humidifier.MediaPackage.PackagingGroupTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEgressAccessLogs(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, PackagingGroupFactory, InnerPackagingGroupLogConfigurationFactory> WithEgressAccessLogs<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, PackagingGroupFactory> combinedResult, Action<Humidifier.MediaPackage.PackagingGroupTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEgressAccessLogs(combinedResult.T5, subFactoryAction));
}
