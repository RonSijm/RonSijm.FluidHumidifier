// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EFS;

public class InnerAccessPointRootDirectoryFactory(Action<Humidifier.EFS.AccessPointTypes.RootDirectory> factoryAction = null) : SubResourceFactory<Humidifier.EFS.AccessPointTypes.RootDirectory>
{

    internal InnerAccessPointCreationInfoFactory CreationInfoFactory { get; set; }

    protected override Humidifier.EFS.AccessPointTypes.RootDirectory Create()
    {
        var rootDirectoryResult = CreateRootDirectory();
        factoryAction?.Invoke(rootDirectoryResult);

        return rootDirectoryResult;
    }

    private Humidifier.EFS.AccessPointTypes.RootDirectory CreateRootDirectory()
    {
        var rootDirectoryResult = new Humidifier.EFS.AccessPointTypes.RootDirectory();

        return rootDirectoryResult;
    }
    public override void CreateChildren(Humidifier.EFS.AccessPointTypes.RootDirectory result)
    {
        base.CreateChildren(result);

        result.CreationInfo ??= CreationInfoFactory?.Build();
    }

} // End Of Class

public static class InnerAccessPointRootDirectoryFactoryExtensions
{
    public static CombinedResult<InnerAccessPointRootDirectoryFactory, InnerAccessPointCreationInfoFactory> WithCreationInfo(this InnerAccessPointRootDirectoryFactory parentFactory, Action<Humidifier.EFS.AccessPointTypes.CreationInfo> subFactoryAction = null)
    {
        parentFactory.CreationInfoFactory = new InnerAccessPointCreationInfoFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CreationInfoFactory);
    }

    public static CombinedResult<InnerAccessPointRootDirectoryFactory, T1, InnerAccessPointCreationInfoFactory> WithCreationInfo<T1>(this CombinedResult<InnerAccessPointRootDirectoryFactory, T1> combinedResult, Action<Humidifier.EFS.AccessPointTypes.CreationInfo> subFactoryAction = null) => new (combinedResult, combinedResult, WithCreationInfo(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAccessPointRootDirectoryFactory, InnerAccessPointCreationInfoFactory> WithCreationInfo<T1>(this CombinedResult<T1, InnerAccessPointRootDirectoryFactory> combinedResult, Action<Humidifier.EFS.AccessPointTypes.CreationInfo> subFactoryAction = null) => new (combinedResult, combinedResult, WithCreationInfo(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerAccessPointRootDirectoryFactory, T1, T2, InnerAccessPointCreationInfoFactory> WithCreationInfo<T1, T2>(this CombinedResult<InnerAccessPointRootDirectoryFactory, T1, T2> combinedResult, Action<Humidifier.EFS.AccessPointTypes.CreationInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCreationInfo(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAccessPointRootDirectoryFactory, T2, InnerAccessPointCreationInfoFactory> WithCreationInfo<T1, T2>(this CombinedResult<T1, InnerAccessPointRootDirectoryFactory, T2> combinedResult, Action<Humidifier.EFS.AccessPointTypes.CreationInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCreationInfo(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAccessPointRootDirectoryFactory, InnerAccessPointCreationInfoFactory> WithCreationInfo<T1, T2>(this CombinedResult<T1, T2, InnerAccessPointRootDirectoryFactory> combinedResult, Action<Humidifier.EFS.AccessPointTypes.CreationInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCreationInfo(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerAccessPointRootDirectoryFactory, T1, T2, T3, InnerAccessPointCreationInfoFactory> WithCreationInfo<T1, T2, T3>(this CombinedResult<InnerAccessPointRootDirectoryFactory, T1, T2, T3> combinedResult, Action<Humidifier.EFS.AccessPointTypes.CreationInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCreationInfo(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAccessPointRootDirectoryFactory, T2, T3, InnerAccessPointCreationInfoFactory> WithCreationInfo<T1, T2, T3>(this CombinedResult<T1, InnerAccessPointRootDirectoryFactory, T2, T3> combinedResult, Action<Humidifier.EFS.AccessPointTypes.CreationInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCreationInfo(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAccessPointRootDirectoryFactory, T3, InnerAccessPointCreationInfoFactory> WithCreationInfo<T1, T2, T3>(this CombinedResult<T1, T2, InnerAccessPointRootDirectoryFactory, T3> combinedResult, Action<Humidifier.EFS.AccessPointTypes.CreationInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCreationInfo(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAccessPointRootDirectoryFactory, InnerAccessPointCreationInfoFactory> WithCreationInfo<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAccessPointRootDirectoryFactory> combinedResult, Action<Humidifier.EFS.AccessPointTypes.CreationInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCreationInfo(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerAccessPointRootDirectoryFactory, T1, T2, T3, T4, InnerAccessPointCreationInfoFactory> WithCreationInfo<T1, T2, T3, T4>(this CombinedResult<InnerAccessPointRootDirectoryFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EFS.AccessPointTypes.CreationInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCreationInfo(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAccessPointRootDirectoryFactory, T2, T3, T4, InnerAccessPointCreationInfoFactory> WithCreationInfo<T1, T2, T3, T4>(this CombinedResult<T1, InnerAccessPointRootDirectoryFactory, T2, T3, T4> combinedResult, Action<Humidifier.EFS.AccessPointTypes.CreationInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCreationInfo(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAccessPointRootDirectoryFactory, T3, T4, InnerAccessPointCreationInfoFactory> WithCreationInfo<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAccessPointRootDirectoryFactory, T3, T4> combinedResult, Action<Humidifier.EFS.AccessPointTypes.CreationInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCreationInfo(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAccessPointRootDirectoryFactory, T4, InnerAccessPointCreationInfoFactory> WithCreationInfo<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAccessPointRootDirectoryFactory, T4> combinedResult, Action<Humidifier.EFS.AccessPointTypes.CreationInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCreationInfo(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerAccessPointRootDirectoryFactory, InnerAccessPointCreationInfoFactory> WithCreationInfo<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAccessPointRootDirectoryFactory> combinedResult, Action<Humidifier.EFS.AccessPointTypes.CreationInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCreationInfo(combinedResult.T5, subFactoryAction));
}
