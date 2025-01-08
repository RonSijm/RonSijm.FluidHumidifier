// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class FolderFactory(string resourceName = null, Action<Humidifier.QuickSight.Folder> factoryAction = null) : ResourceFactory<Humidifier.QuickSight.Folder>(resourceName)
{

    internal List<InnerFolderResourcePermissionFactory> PermissionsFactories { get; set; } = [];

    protected override Humidifier.QuickSight.Folder Create()
    {
        var folderResult = CreateFolder();
        factoryAction?.Invoke(folderResult);

        return folderResult;
    }

    private Humidifier.QuickSight.Folder CreateFolder()
    {
        var folderResult = new Humidifier.QuickSight.Folder
        {
            GivenName = InputResourceName,
        };

        return folderResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.Folder result)
    {
        base.CreateChildren(result);

        result.Permissions = PermissionsFactories.Any() ? PermissionsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class FolderFactoryExtensions
{
    public static CombinedResult<FolderFactory, InnerFolderResourcePermissionFactory> WithPermissions(this FolderFactory parentFactory, Action<Humidifier.QuickSight.FolderTypes.ResourcePermission> subFactoryAction = null)
    {
        var factory = new InnerFolderResourcePermissionFactory(subFactoryAction);
        parentFactory.PermissionsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<FolderFactory, T1, InnerFolderResourcePermissionFactory> WithPermissions<T1>(this CombinedResult<FolderFactory, T1> combinedResult, Action<Humidifier.QuickSight.FolderTypes.ResourcePermission> subFactoryAction = null) => new (combinedResult, combinedResult, WithPermissions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FolderFactory, InnerFolderResourcePermissionFactory> WithPermissions<T1>(this CombinedResult<T1, FolderFactory> combinedResult, Action<Humidifier.QuickSight.FolderTypes.ResourcePermission> subFactoryAction = null) => new (combinedResult, combinedResult, WithPermissions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<FolderFactory, T1, T2, InnerFolderResourcePermissionFactory> WithPermissions<T1, T2>(this CombinedResult<FolderFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.FolderTypes.ResourcePermission> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPermissions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FolderFactory, T2, InnerFolderResourcePermissionFactory> WithPermissions<T1, T2>(this CombinedResult<T1, FolderFactory, T2> combinedResult, Action<Humidifier.QuickSight.FolderTypes.ResourcePermission> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPermissions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FolderFactory, InnerFolderResourcePermissionFactory> WithPermissions<T1, T2>(this CombinedResult<T1, T2, FolderFactory> combinedResult, Action<Humidifier.QuickSight.FolderTypes.ResourcePermission> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPermissions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<FolderFactory, T1, T2, T3, InnerFolderResourcePermissionFactory> WithPermissions<T1, T2, T3>(this CombinedResult<FolderFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.FolderTypes.ResourcePermission> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPermissions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FolderFactory, T2, T3, InnerFolderResourcePermissionFactory> WithPermissions<T1, T2, T3>(this CombinedResult<T1, FolderFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.FolderTypes.ResourcePermission> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPermissions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FolderFactory, T3, InnerFolderResourcePermissionFactory> WithPermissions<T1, T2, T3>(this CombinedResult<T1, T2, FolderFactory, T3> combinedResult, Action<Humidifier.QuickSight.FolderTypes.ResourcePermission> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPermissions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FolderFactory, InnerFolderResourcePermissionFactory> WithPermissions<T1, T2, T3>(this CombinedResult<T1, T2, T3, FolderFactory> combinedResult, Action<Humidifier.QuickSight.FolderTypes.ResourcePermission> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPermissions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<FolderFactory, T1, T2, T3, T4, InnerFolderResourcePermissionFactory> WithPermissions<T1, T2, T3, T4>(this CombinedResult<FolderFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.FolderTypes.ResourcePermission> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPermissions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FolderFactory, T2, T3, T4, InnerFolderResourcePermissionFactory> WithPermissions<T1, T2, T3, T4>(this CombinedResult<T1, FolderFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.FolderTypes.ResourcePermission> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPermissions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FolderFactory, T3, T4, InnerFolderResourcePermissionFactory> WithPermissions<T1, T2, T3, T4>(this CombinedResult<T1, T2, FolderFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.FolderTypes.ResourcePermission> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPermissions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FolderFactory, T4, InnerFolderResourcePermissionFactory> WithPermissions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, FolderFactory, T4> combinedResult, Action<Humidifier.QuickSight.FolderTypes.ResourcePermission> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPermissions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, FolderFactory, InnerFolderResourcePermissionFactory> WithPermissions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, FolderFactory> combinedResult, Action<Humidifier.QuickSight.FolderTypes.ResourcePermission> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPermissions(combinedResult.T5, subFactoryAction));
}
