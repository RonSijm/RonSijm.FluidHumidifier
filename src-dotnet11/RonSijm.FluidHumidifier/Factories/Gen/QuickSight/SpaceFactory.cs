// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class SpaceFactory(string resourceName = null, Action<Humidifier.QuickSight.Space> factoryAction = null) : ResourceFactory<Humidifier.QuickSight.Space>(resourceName)
{

    internal List<InnerSpaceResourcePermissionFactory> PermissionsFactories { get; set; } = [];

    internal List<InnerSpaceSpaceResourceFactory> ResourcesFactories { get; set; } = [];

    protected override Humidifier.QuickSight.Space Create()
    {
        var spaceResult = CreateSpace();
        factoryAction?.Invoke(spaceResult);

        return spaceResult;
    }

    private Humidifier.QuickSight.Space CreateSpace()
    {
        var spaceResult = new Humidifier.QuickSight.Space
        {
            GivenName = InputResourceName,
        };

        return spaceResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.Space result)
    {
        base.CreateChildren(result);

        result.Permissions = PermissionsFactories.Any() ? PermissionsFactories.Select(x => x.Build()).ToList() : null;
        result.Resources = ResourcesFactories.Any() ? ResourcesFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class SpaceFactoryExtensions
{
    public static CombinedResult<SpaceFactory, InnerSpaceResourcePermissionFactory> WithPermissions(this SpaceFactory parentFactory, Action<Humidifier.QuickSight.SpaceTypes.ResourcePermission> subFactoryAction = null)
    {
        var factory = new InnerSpaceResourcePermissionFactory(subFactoryAction);
        parentFactory.PermissionsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<SpaceFactory, InnerSpaceSpaceResourceFactory> WithResources(this SpaceFactory parentFactory, Action<Humidifier.QuickSight.SpaceTypes.SpaceResource> subFactoryAction = null)
    {
        var factory = new InnerSpaceSpaceResourceFactory(subFactoryAction);
        parentFactory.ResourcesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<SpaceFactory, T1, InnerSpaceResourcePermissionFactory> WithPermissions<T1>(this CombinedResult<SpaceFactory, T1> combinedResult, Action<Humidifier.QuickSight.SpaceTypes.ResourcePermission> subFactoryAction = null) => new (combinedResult, combinedResult, WithPermissions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SpaceFactory, InnerSpaceResourcePermissionFactory> WithPermissions<T1>(this CombinedResult<T1, SpaceFactory> combinedResult, Action<Humidifier.QuickSight.SpaceTypes.ResourcePermission> subFactoryAction = null) => new (combinedResult, combinedResult, WithPermissions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<SpaceFactory, T1, T2, InnerSpaceResourcePermissionFactory> WithPermissions<T1, T2>(this CombinedResult<SpaceFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.SpaceTypes.ResourcePermission> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPermissions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SpaceFactory, T2, InnerSpaceResourcePermissionFactory> WithPermissions<T1, T2>(this CombinedResult<T1, SpaceFactory, T2> combinedResult, Action<Humidifier.QuickSight.SpaceTypes.ResourcePermission> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPermissions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SpaceFactory, InnerSpaceResourcePermissionFactory> WithPermissions<T1, T2>(this CombinedResult<T1, T2, SpaceFactory> combinedResult, Action<Humidifier.QuickSight.SpaceTypes.ResourcePermission> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPermissions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<SpaceFactory, T1, T2, T3, InnerSpaceResourcePermissionFactory> WithPermissions<T1, T2, T3>(this CombinedResult<SpaceFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.SpaceTypes.ResourcePermission> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPermissions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SpaceFactory, T2, T3, InnerSpaceResourcePermissionFactory> WithPermissions<T1, T2, T3>(this CombinedResult<T1, SpaceFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.SpaceTypes.ResourcePermission> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPermissions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SpaceFactory, T3, InnerSpaceResourcePermissionFactory> WithPermissions<T1, T2, T3>(this CombinedResult<T1, T2, SpaceFactory, T3> combinedResult, Action<Humidifier.QuickSight.SpaceTypes.ResourcePermission> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPermissions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, SpaceFactory, InnerSpaceResourcePermissionFactory> WithPermissions<T1, T2, T3>(this CombinedResult<T1, T2, T3, SpaceFactory> combinedResult, Action<Humidifier.QuickSight.SpaceTypes.ResourcePermission> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPermissions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<SpaceFactory, T1, T2, T3, T4, InnerSpaceResourcePermissionFactory> WithPermissions<T1, T2, T3, T4>(this CombinedResult<SpaceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.SpaceTypes.ResourcePermission> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPermissions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SpaceFactory, T2, T3, T4, InnerSpaceResourcePermissionFactory> WithPermissions<T1, T2, T3, T4>(this CombinedResult<T1, SpaceFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.SpaceTypes.ResourcePermission> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPermissions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SpaceFactory, T3, T4, InnerSpaceResourcePermissionFactory> WithPermissions<T1, T2, T3, T4>(this CombinedResult<T1, T2, SpaceFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.SpaceTypes.ResourcePermission> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPermissions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, SpaceFactory, T4, InnerSpaceResourcePermissionFactory> WithPermissions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SpaceFactory, T4> combinedResult, Action<Humidifier.QuickSight.SpaceTypes.ResourcePermission> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPermissions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, SpaceFactory, InnerSpaceResourcePermissionFactory> WithPermissions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SpaceFactory> combinedResult, Action<Humidifier.QuickSight.SpaceTypes.ResourcePermission> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPermissions(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<SpaceFactory, T1, InnerSpaceSpaceResourceFactory> WithResources<T1>(this CombinedResult<SpaceFactory, T1> combinedResult, Action<Humidifier.QuickSight.SpaceTypes.SpaceResource> subFactoryAction = null) => new (combinedResult, combinedResult, WithResources(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SpaceFactory, InnerSpaceSpaceResourceFactory> WithResources<T1>(this CombinedResult<T1, SpaceFactory> combinedResult, Action<Humidifier.QuickSight.SpaceTypes.SpaceResource> subFactoryAction = null) => new (combinedResult, combinedResult, WithResources(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<SpaceFactory, T1, T2, InnerSpaceSpaceResourceFactory> WithResources<T1, T2>(this CombinedResult<SpaceFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.SpaceTypes.SpaceResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResources(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SpaceFactory, T2, InnerSpaceSpaceResourceFactory> WithResources<T1, T2>(this CombinedResult<T1, SpaceFactory, T2> combinedResult, Action<Humidifier.QuickSight.SpaceTypes.SpaceResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResources(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SpaceFactory, InnerSpaceSpaceResourceFactory> WithResources<T1, T2>(this CombinedResult<T1, T2, SpaceFactory> combinedResult, Action<Humidifier.QuickSight.SpaceTypes.SpaceResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResources(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<SpaceFactory, T1, T2, T3, InnerSpaceSpaceResourceFactory> WithResources<T1, T2, T3>(this CombinedResult<SpaceFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.SpaceTypes.SpaceResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResources(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SpaceFactory, T2, T3, InnerSpaceSpaceResourceFactory> WithResources<T1, T2, T3>(this CombinedResult<T1, SpaceFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.SpaceTypes.SpaceResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResources(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SpaceFactory, T3, InnerSpaceSpaceResourceFactory> WithResources<T1, T2, T3>(this CombinedResult<T1, T2, SpaceFactory, T3> combinedResult, Action<Humidifier.QuickSight.SpaceTypes.SpaceResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResources(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, SpaceFactory, InnerSpaceSpaceResourceFactory> WithResources<T1, T2, T3>(this CombinedResult<T1, T2, T3, SpaceFactory> combinedResult, Action<Humidifier.QuickSight.SpaceTypes.SpaceResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResources(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<SpaceFactory, T1, T2, T3, T4, InnerSpaceSpaceResourceFactory> WithResources<T1, T2, T3, T4>(this CombinedResult<SpaceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.SpaceTypes.SpaceResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResources(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SpaceFactory, T2, T3, T4, InnerSpaceSpaceResourceFactory> WithResources<T1, T2, T3, T4>(this CombinedResult<T1, SpaceFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.SpaceTypes.SpaceResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResources(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SpaceFactory, T3, T4, InnerSpaceSpaceResourceFactory> WithResources<T1, T2, T3, T4>(this CombinedResult<T1, T2, SpaceFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.SpaceTypes.SpaceResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResources(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, SpaceFactory, T4, InnerSpaceSpaceResourceFactory> WithResources<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SpaceFactory, T4> combinedResult, Action<Humidifier.QuickSight.SpaceTypes.SpaceResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResources(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, SpaceFactory, InnerSpaceSpaceResourceFactory> WithResources<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SpaceFactory> combinedResult, Action<Humidifier.QuickSight.SpaceTypes.SpaceResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResources(combinedResult.T5, subFactoryAction).T2);
}
