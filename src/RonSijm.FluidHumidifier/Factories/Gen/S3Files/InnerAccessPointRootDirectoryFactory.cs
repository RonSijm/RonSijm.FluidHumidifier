// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3Files;

public class InnerAccessPointRootDirectoryFactory(Action<Humidifier.S3Files.AccessPointTypes.RootDirectory> factoryAction = null) : SubResourceFactory<Humidifier.S3Files.AccessPointTypes.RootDirectory>
{

    internal InnerAccessPointCreationPermissionsFactory CreationPermissionsFactory { get; set; }

    protected override Humidifier.S3Files.AccessPointTypes.RootDirectory Create()
    {
        var rootDirectoryResult = CreateRootDirectory();
        factoryAction?.Invoke(rootDirectoryResult);

        return rootDirectoryResult;
    }

    private Humidifier.S3Files.AccessPointTypes.RootDirectory CreateRootDirectory()
    {
        var rootDirectoryResult = new Humidifier.S3Files.AccessPointTypes.RootDirectory();

        return rootDirectoryResult;
    }
    public override void CreateChildren(Humidifier.S3Files.AccessPointTypes.RootDirectory result)
    {
        base.CreateChildren(result);

        result.CreationPermissions ??= CreationPermissionsFactory?.Build();
    }

} // End Of Class

public static class InnerAccessPointRootDirectoryFactoryExtensions
{
    public static CombinedResult<InnerAccessPointRootDirectoryFactory, InnerAccessPointCreationPermissionsFactory> WithCreationPermissions(this InnerAccessPointRootDirectoryFactory parentFactory, Action<Humidifier.S3Files.AccessPointTypes.CreationPermissions> subFactoryAction = null)
    {
        parentFactory.CreationPermissionsFactory = new InnerAccessPointCreationPermissionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CreationPermissionsFactory);
    }

    public static CombinedResult<InnerAccessPointRootDirectoryFactory, T1, InnerAccessPointCreationPermissionsFactory> WithCreationPermissions<T1>(this CombinedResult<InnerAccessPointRootDirectoryFactory, T1> combinedResult, Action<Humidifier.S3Files.AccessPointTypes.CreationPermissions> subFactoryAction = null) => new (combinedResult, combinedResult, WithCreationPermissions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAccessPointRootDirectoryFactory, InnerAccessPointCreationPermissionsFactory> WithCreationPermissions<T1>(this CombinedResult<T1, InnerAccessPointRootDirectoryFactory> combinedResult, Action<Humidifier.S3Files.AccessPointTypes.CreationPermissions> subFactoryAction = null) => new (combinedResult, combinedResult, WithCreationPermissions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerAccessPointRootDirectoryFactory, T1, T2, InnerAccessPointCreationPermissionsFactory> WithCreationPermissions<T1, T2>(this CombinedResult<InnerAccessPointRootDirectoryFactory, T1, T2> combinedResult, Action<Humidifier.S3Files.AccessPointTypes.CreationPermissions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCreationPermissions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAccessPointRootDirectoryFactory, T2, InnerAccessPointCreationPermissionsFactory> WithCreationPermissions<T1, T2>(this CombinedResult<T1, InnerAccessPointRootDirectoryFactory, T2> combinedResult, Action<Humidifier.S3Files.AccessPointTypes.CreationPermissions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCreationPermissions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAccessPointRootDirectoryFactory, InnerAccessPointCreationPermissionsFactory> WithCreationPermissions<T1, T2>(this CombinedResult<T1, T2, InnerAccessPointRootDirectoryFactory> combinedResult, Action<Humidifier.S3Files.AccessPointTypes.CreationPermissions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCreationPermissions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerAccessPointRootDirectoryFactory, T1, T2, T3, InnerAccessPointCreationPermissionsFactory> WithCreationPermissions<T1, T2, T3>(this CombinedResult<InnerAccessPointRootDirectoryFactory, T1, T2, T3> combinedResult, Action<Humidifier.S3Files.AccessPointTypes.CreationPermissions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCreationPermissions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAccessPointRootDirectoryFactory, T2, T3, InnerAccessPointCreationPermissionsFactory> WithCreationPermissions<T1, T2, T3>(this CombinedResult<T1, InnerAccessPointRootDirectoryFactory, T2, T3> combinedResult, Action<Humidifier.S3Files.AccessPointTypes.CreationPermissions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCreationPermissions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAccessPointRootDirectoryFactory, T3, InnerAccessPointCreationPermissionsFactory> WithCreationPermissions<T1, T2, T3>(this CombinedResult<T1, T2, InnerAccessPointRootDirectoryFactory, T3> combinedResult, Action<Humidifier.S3Files.AccessPointTypes.CreationPermissions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCreationPermissions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAccessPointRootDirectoryFactory, InnerAccessPointCreationPermissionsFactory> WithCreationPermissions<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAccessPointRootDirectoryFactory> combinedResult, Action<Humidifier.S3Files.AccessPointTypes.CreationPermissions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCreationPermissions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerAccessPointRootDirectoryFactory, T1, T2, T3, T4, InnerAccessPointCreationPermissionsFactory> WithCreationPermissions<T1, T2, T3, T4>(this CombinedResult<InnerAccessPointRootDirectoryFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.S3Files.AccessPointTypes.CreationPermissions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCreationPermissions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAccessPointRootDirectoryFactory, T2, T3, T4, InnerAccessPointCreationPermissionsFactory> WithCreationPermissions<T1, T2, T3, T4>(this CombinedResult<T1, InnerAccessPointRootDirectoryFactory, T2, T3, T4> combinedResult, Action<Humidifier.S3Files.AccessPointTypes.CreationPermissions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCreationPermissions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAccessPointRootDirectoryFactory, T3, T4, InnerAccessPointCreationPermissionsFactory> WithCreationPermissions<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAccessPointRootDirectoryFactory, T3, T4> combinedResult, Action<Humidifier.S3Files.AccessPointTypes.CreationPermissions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCreationPermissions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAccessPointRootDirectoryFactory, T4, InnerAccessPointCreationPermissionsFactory> WithCreationPermissions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAccessPointRootDirectoryFactory, T4> combinedResult, Action<Humidifier.S3Files.AccessPointTypes.CreationPermissions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCreationPermissions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerAccessPointRootDirectoryFactory, InnerAccessPointCreationPermissionsFactory> WithCreationPermissions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAccessPointRootDirectoryFactory> combinedResult, Action<Humidifier.S3Files.AccessPointTypes.CreationPermissions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCreationPermissions(combinedResult.T5, subFactoryAction).T2);
}
