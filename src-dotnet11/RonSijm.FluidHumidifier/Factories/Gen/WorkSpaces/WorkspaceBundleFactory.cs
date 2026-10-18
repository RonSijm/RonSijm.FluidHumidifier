// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WorkSpaces;

public class WorkspaceBundleFactory(string resourceName = null, Action<Humidifier.WorkSpaces.WorkspaceBundle> factoryAction = null) : ResourceFactory<Humidifier.WorkSpaces.WorkspaceBundle>(resourceName)
{

    internal InnerWorkspaceBundleUserStorageFactory UserStorageFactory { get; set; }

    internal InnerWorkspaceBundleComputeTypeFactory ComputeTypeFactory { get; set; }

    internal InnerWorkspaceBundleRootStorageFactory RootStorageFactory { get; set; }

    protected override Humidifier.WorkSpaces.WorkspaceBundle Create()
    {
        var workspaceBundleResult = CreateWorkspaceBundle();
        factoryAction?.Invoke(workspaceBundleResult);

        return workspaceBundleResult;
    }

    private Humidifier.WorkSpaces.WorkspaceBundle CreateWorkspaceBundle()
    {
        var workspaceBundleResult = new Humidifier.WorkSpaces.WorkspaceBundle
        {
            GivenName = InputResourceName,
        };

        return workspaceBundleResult;
    }
    public override void CreateChildren(Humidifier.WorkSpaces.WorkspaceBundle result)
    {
        base.CreateChildren(result);

        result.UserStorage ??= UserStorageFactory?.Build();
        result.ComputeType ??= ComputeTypeFactory?.Build();
        result.RootStorage ??= RootStorageFactory?.Build();
    }

} // End Of Class

public static class WorkspaceBundleFactoryExtensions
{
    public static CombinedResult<WorkspaceBundleFactory, InnerWorkspaceBundleUserStorageFactory> WithUserStorage(this WorkspaceBundleFactory parentFactory, Action<Humidifier.WorkSpaces.WorkspaceBundleTypes.UserStorage> subFactoryAction = null)
    {
        parentFactory.UserStorageFactory = new InnerWorkspaceBundleUserStorageFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.UserStorageFactory);
    }

    public static CombinedResult<WorkspaceBundleFactory, InnerWorkspaceBundleComputeTypeFactory> WithComputeType(this WorkspaceBundleFactory parentFactory, Action<Humidifier.WorkSpaces.WorkspaceBundleTypes.ComputeType> subFactoryAction = null)
    {
        parentFactory.ComputeTypeFactory = new InnerWorkspaceBundleComputeTypeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ComputeTypeFactory);
    }

    public static CombinedResult<WorkspaceBundleFactory, InnerWorkspaceBundleRootStorageFactory> WithRootStorage(this WorkspaceBundleFactory parentFactory, Action<Humidifier.WorkSpaces.WorkspaceBundleTypes.RootStorage> subFactoryAction = null)
    {
        parentFactory.RootStorageFactory = new InnerWorkspaceBundleRootStorageFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RootStorageFactory);
    }

    public static CombinedResult<WorkspaceBundleFactory, T1, InnerWorkspaceBundleUserStorageFactory> WithUserStorage<T1>(this CombinedResult<WorkspaceBundleFactory, T1> combinedResult, Action<Humidifier.WorkSpaces.WorkspaceBundleTypes.UserStorage> subFactoryAction = null) => new (combinedResult, combinedResult, WithUserStorage(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WorkspaceBundleFactory, InnerWorkspaceBundleUserStorageFactory> WithUserStorage<T1>(this CombinedResult<T1, WorkspaceBundleFactory> combinedResult, Action<Humidifier.WorkSpaces.WorkspaceBundleTypes.UserStorage> subFactoryAction = null) => new (combinedResult, combinedResult, WithUserStorage(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<WorkspaceBundleFactory, T1, T2, InnerWorkspaceBundleUserStorageFactory> WithUserStorage<T1, T2>(this CombinedResult<WorkspaceBundleFactory, T1, T2> combinedResult, Action<Humidifier.WorkSpaces.WorkspaceBundleTypes.UserStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUserStorage(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WorkspaceBundleFactory, T2, InnerWorkspaceBundleUserStorageFactory> WithUserStorage<T1, T2>(this CombinedResult<T1, WorkspaceBundleFactory, T2> combinedResult, Action<Humidifier.WorkSpaces.WorkspaceBundleTypes.UserStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUserStorage(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, WorkspaceBundleFactory, InnerWorkspaceBundleUserStorageFactory> WithUserStorage<T1, T2>(this CombinedResult<T1, T2, WorkspaceBundleFactory> combinedResult, Action<Humidifier.WorkSpaces.WorkspaceBundleTypes.UserStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUserStorage(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<WorkspaceBundleFactory, T1, T2, T3, InnerWorkspaceBundleUserStorageFactory> WithUserStorage<T1, T2, T3>(this CombinedResult<WorkspaceBundleFactory, T1, T2, T3> combinedResult, Action<Humidifier.WorkSpaces.WorkspaceBundleTypes.UserStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUserStorage(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WorkspaceBundleFactory, T2, T3, InnerWorkspaceBundleUserStorageFactory> WithUserStorage<T1, T2, T3>(this CombinedResult<T1, WorkspaceBundleFactory, T2, T3> combinedResult, Action<Humidifier.WorkSpaces.WorkspaceBundleTypes.UserStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUserStorage(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, WorkspaceBundleFactory, T3, InnerWorkspaceBundleUserStorageFactory> WithUserStorage<T1, T2, T3>(this CombinedResult<T1, T2, WorkspaceBundleFactory, T3> combinedResult, Action<Humidifier.WorkSpaces.WorkspaceBundleTypes.UserStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUserStorage(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, WorkspaceBundleFactory, InnerWorkspaceBundleUserStorageFactory> WithUserStorage<T1, T2, T3>(this CombinedResult<T1, T2, T3, WorkspaceBundleFactory> combinedResult, Action<Humidifier.WorkSpaces.WorkspaceBundleTypes.UserStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUserStorage(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<WorkspaceBundleFactory, T1, T2, T3, T4, InnerWorkspaceBundleUserStorageFactory> WithUserStorage<T1, T2, T3, T4>(this CombinedResult<WorkspaceBundleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WorkSpaces.WorkspaceBundleTypes.UserStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUserStorage(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WorkspaceBundleFactory, T2, T3, T4, InnerWorkspaceBundleUserStorageFactory> WithUserStorage<T1, T2, T3, T4>(this CombinedResult<T1, WorkspaceBundleFactory, T2, T3, T4> combinedResult, Action<Humidifier.WorkSpaces.WorkspaceBundleTypes.UserStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUserStorage(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, WorkspaceBundleFactory, T3, T4, InnerWorkspaceBundleUserStorageFactory> WithUserStorage<T1, T2, T3, T4>(this CombinedResult<T1, T2, WorkspaceBundleFactory, T3, T4> combinedResult, Action<Humidifier.WorkSpaces.WorkspaceBundleTypes.UserStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUserStorage(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, WorkspaceBundleFactory, T4, InnerWorkspaceBundleUserStorageFactory> WithUserStorage<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, WorkspaceBundleFactory, T4> combinedResult, Action<Humidifier.WorkSpaces.WorkspaceBundleTypes.UserStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUserStorage(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, WorkspaceBundleFactory, InnerWorkspaceBundleUserStorageFactory> WithUserStorage<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, WorkspaceBundleFactory> combinedResult, Action<Humidifier.WorkSpaces.WorkspaceBundleTypes.UserStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUserStorage(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<WorkspaceBundleFactory, T1, InnerWorkspaceBundleComputeTypeFactory> WithComputeType<T1>(this CombinedResult<WorkspaceBundleFactory, T1> combinedResult, Action<Humidifier.WorkSpaces.WorkspaceBundleTypes.ComputeType> subFactoryAction = null) => new (combinedResult, combinedResult, WithComputeType(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WorkspaceBundleFactory, InnerWorkspaceBundleComputeTypeFactory> WithComputeType<T1>(this CombinedResult<T1, WorkspaceBundleFactory> combinedResult, Action<Humidifier.WorkSpaces.WorkspaceBundleTypes.ComputeType> subFactoryAction = null) => new (combinedResult, combinedResult, WithComputeType(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<WorkspaceBundleFactory, T1, T2, InnerWorkspaceBundleComputeTypeFactory> WithComputeType<T1, T2>(this CombinedResult<WorkspaceBundleFactory, T1, T2> combinedResult, Action<Humidifier.WorkSpaces.WorkspaceBundleTypes.ComputeType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithComputeType(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WorkspaceBundleFactory, T2, InnerWorkspaceBundleComputeTypeFactory> WithComputeType<T1, T2>(this CombinedResult<T1, WorkspaceBundleFactory, T2> combinedResult, Action<Humidifier.WorkSpaces.WorkspaceBundleTypes.ComputeType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithComputeType(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, WorkspaceBundleFactory, InnerWorkspaceBundleComputeTypeFactory> WithComputeType<T1, T2>(this CombinedResult<T1, T2, WorkspaceBundleFactory> combinedResult, Action<Humidifier.WorkSpaces.WorkspaceBundleTypes.ComputeType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithComputeType(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<WorkspaceBundleFactory, T1, T2, T3, InnerWorkspaceBundleComputeTypeFactory> WithComputeType<T1, T2, T3>(this CombinedResult<WorkspaceBundleFactory, T1, T2, T3> combinedResult, Action<Humidifier.WorkSpaces.WorkspaceBundleTypes.ComputeType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithComputeType(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WorkspaceBundleFactory, T2, T3, InnerWorkspaceBundleComputeTypeFactory> WithComputeType<T1, T2, T3>(this CombinedResult<T1, WorkspaceBundleFactory, T2, T3> combinedResult, Action<Humidifier.WorkSpaces.WorkspaceBundleTypes.ComputeType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithComputeType(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, WorkspaceBundleFactory, T3, InnerWorkspaceBundleComputeTypeFactory> WithComputeType<T1, T2, T3>(this CombinedResult<T1, T2, WorkspaceBundleFactory, T3> combinedResult, Action<Humidifier.WorkSpaces.WorkspaceBundleTypes.ComputeType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithComputeType(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, WorkspaceBundleFactory, InnerWorkspaceBundleComputeTypeFactory> WithComputeType<T1, T2, T3>(this CombinedResult<T1, T2, T3, WorkspaceBundleFactory> combinedResult, Action<Humidifier.WorkSpaces.WorkspaceBundleTypes.ComputeType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithComputeType(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<WorkspaceBundleFactory, T1, T2, T3, T4, InnerWorkspaceBundleComputeTypeFactory> WithComputeType<T1, T2, T3, T4>(this CombinedResult<WorkspaceBundleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WorkSpaces.WorkspaceBundleTypes.ComputeType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithComputeType(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WorkspaceBundleFactory, T2, T3, T4, InnerWorkspaceBundleComputeTypeFactory> WithComputeType<T1, T2, T3, T4>(this CombinedResult<T1, WorkspaceBundleFactory, T2, T3, T4> combinedResult, Action<Humidifier.WorkSpaces.WorkspaceBundleTypes.ComputeType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithComputeType(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, WorkspaceBundleFactory, T3, T4, InnerWorkspaceBundleComputeTypeFactory> WithComputeType<T1, T2, T3, T4>(this CombinedResult<T1, T2, WorkspaceBundleFactory, T3, T4> combinedResult, Action<Humidifier.WorkSpaces.WorkspaceBundleTypes.ComputeType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithComputeType(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, WorkspaceBundleFactory, T4, InnerWorkspaceBundleComputeTypeFactory> WithComputeType<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, WorkspaceBundleFactory, T4> combinedResult, Action<Humidifier.WorkSpaces.WorkspaceBundleTypes.ComputeType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithComputeType(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, WorkspaceBundleFactory, InnerWorkspaceBundleComputeTypeFactory> WithComputeType<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, WorkspaceBundleFactory> combinedResult, Action<Humidifier.WorkSpaces.WorkspaceBundleTypes.ComputeType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithComputeType(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<WorkspaceBundleFactory, T1, InnerWorkspaceBundleRootStorageFactory> WithRootStorage<T1>(this CombinedResult<WorkspaceBundleFactory, T1> combinedResult, Action<Humidifier.WorkSpaces.WorkspaceBundleTypes.RootStorage> subFactoryAction = null) => new (combinedResult, combinedResult, WithRootStorage(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WorkspaceBundleFactory, InnerWorkspaceBundleRootStorageFactory> WithRootStorage<T1>(this CombinedResult<T1, WorkspaceBundleFactory> combinedResult, Action<Humidifier.WorkSpaces.WorkspaceBundleTypes.RootStorage> subFactoryAction = null) => new (combinedResult, combinedResult, WithRootStorage(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<WorkspaceBundleFactory, T1, T2, InnerWorkspaceBundleRootStorageFactory> WithRootStorage<T1, T2>(this CombinedResult<WorkspaceBundleFactory, T1, T2> combinedResult, Action<Humidifier.WorkSpaces.WorkspaceBundleTypes.RootStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRootStorage(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WorkspaceBundleFactory, T2, InnerWorkspaceBundleRootStorageFactory> WithRootStorage<T1, T2>(this CombinedResult<T1, WorkspaceBundleFactory, T2> combinedResult, Action<Humidifier.WorkSpaces.WorkspaceBundleTypes.RootStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRootStorage(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, WorkspaceBundleFactory, InnerWorkspaceBundleRootStorageFactory> WithRootStorage<T1, T2>(this CombinedResult<T1, T2, WorkspaceBundleFactory> combinedResult, Action<Humidifier.WorkSpaces.WorkspaceBundleTypes.RootStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRootStorage(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<WorkspaceBundleFactory, T1, T2, T3, InnerWorkspaceBundleRootStorageFactory> WithRootStorage<T1, T2, T3>(this CombinedResult<WorkspaceBundleFactory, T1, T2, T3> combinedResult, Action<Humidifier.WorkSpaces.WorkspaceBundleTypes.RootStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRootStorage(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WorkspaceBundleFactory, T2, T3, InnerWorkspaceBundleRootStorageFactory> WithRootStorage<T1, T2, T3>(this CombinedResult<T1, WorkspaceBundleFactory, T2, T3> combinedResult, Action<Humidifier.WorkSpaces.WorkspaceBundleTypes.RootStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRootStorage(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, WorkspaceBundleFactory, T3, InnerWorkspaceBundleRootStorageFactory> WithRootStorage<T1, T2, T3>(this CombinedResult<T1, T2, WorkspaceBundleFactory, T3> combinedResult, Action<Humidifier.WorkSpaces.WorkspaceBundleTypes.RootStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRootStorage(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, WorkspaceBundleFactory, InnerWorkspaceBundleRootStorageFactory> WithRootStorage<T1, T2, T3>(this CombinedResult<T1, T2, T3, WorkspaceBundleFactory> combinedResult, Action<Humidifier.WorkSpaces.WorkspaceBundleTypes.RootStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRootStorage(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<WorkspaceBundleFactory, T1, T2, T3, T4, InnerWorkspaceBundleRootStorageFactory> WithRootStorage<T1, T2, T3, T4>(this CombinedResult<WorkspaceBundleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WorkSpaces.WorkspaceBundleTypes.RootStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRootStorage(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WorkspaceBundleFactory, T2, T3, T4, InnerWorkspaceBundleRootStorageFactory> WithRootStorage<T1, T2, T3, T4>(this CombinedResult<T1, WorkspaceBundleFactory, T2, T3, T4> combinedResult, Action<Humidifier.WorkSpaces.WorkspaceBundleTypes.RootStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRootStorage(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, WorkspaceBundleFactory, T3, T4, InnerWorkspaceBundleRootStorageFactory> WithRootStorage<T1, T2, T3, T4>(this CombinedResult<T1, T2, WorkspaceBundleFactory, T3, T4> combinedResult, Action<Humidifier.WorkSpaces.WorkspaceBundleTypes.RootStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRootStorage(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, WorkspaceBundleFactory, T4, InnerWorkspaceBundleRootStorageFactory> WithRootStorage<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, WorkspaceBundleFactory, T4> combinedResult, Action<Humidifier.WorkSpaces.WorkspaceBundleTypes.RootStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRootStorage(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, WorkspaceBundleFactory, InnerWorkspaceBundleRootStorageFactory> WithRootStorage<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, WorkspaceBundleFactory> combinedResult, Action<Humidifier.WorkSpaces.WorkspaceBundleTypes.RootStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRootStorage(combinedResult.T5, subFactoryAction).T2);
}
