// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WorkspacesInstances;

public class WorkspaceInstanceFactory(string resourceName = null, Action<Humidifier.WorkspacesInstances.WorkspaceInstance> factoryAction = null) : ResourceFactory<Humidifier.WorkspacesInstances.WorkspaceInstance>(resourceName)
{

    internal InnerWorkspaceInstanceManagedInstanceFactory ManagedInstanceFactory { get; set; }

    protected override Humidifier.WorkspacesInstances.WorkspaceInstance Create()
    {
        var workspaceInstanceResult = CreateWorkspaceInstance();
        factoryAction?.Invoke(workspaceInstanceResult);

        return workspaceInstanceResult;
    }

    private Humidifier.WorkspacesInstances.WorkspaceInstance CreateWorkspaceInstance()
    {
        var workspaceInstanceResult = new Humidifier.WorkspacesInstances.WorkspaceInstance
        {
            GivenName = InputResourceName,
        };

        return workspaceInstanceResult;
    }
    public override void CreateChildren(Humidifier.WorkspacesInstances.WorkspaceInstance result)
    {
        base.CreateChildren(result);

        result.ManagedInstance ??= ManagedInstanceFactory?.Build();
    }

} // End Of Class

public static class WorkspaceInstanceFactoryExtensions
{
    public static CombinedResult<WorkspaceInstanceFactory, InnerWorkspaceInstanceManagedInstanceFactory> WithManagedInstance(this WorkspaceInstanceFactory parentFactory, Action<Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.ManagedInstance> subFactoryAction = null)
    {
        parentFactory.ManagedInstanceFactory = new InnerWorkspaceInstanceManagedInstanceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ManagedInstanceFactory);
    }

    public static CombinedResult<WorkspaceInstanceFactory, T1, InnerWorkspaceInstanceManagedInstanceFactory> WithManagedInstance<T1>(this CombinedResult<WorkspaceInstanceFactory, T1> combinedResult, Action<Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.ManagedInstance> subFactoryAction = null) => new (combinedResult, combinedResult, WithManagedInstance(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WorkspaceInstanceFactory, InnerWorkspaceInstanceManagedInstanceFactory> WithManagedInstance<T1>(this CombinedResult<T1, WorkspaceInstanceFactory> combinedResult, Action<Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.ManagedInstance> subFactoryAction = null) => new (combinedResult, combinedResult, WithManagedInstance(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<WorkspaceInstanceFactory, T1, T2, InnerWorkspaceInstanceManagedInstanceFactory> WithManagedInstance<T1, T2>(this CombinedResult<WorkspaceInstanceFactory, T1, T2> combinedResult, Action<Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.ManagedInstance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithManagedInstance(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WorkspaceInstanceFactory, T2, InnerWorkspaceInstanceManagedInstanceFactory> WithManagedInstance<T1, T2>(this CombinedResult<T1, WorkspaceInstanceFactory, T2> combinedResult, Action<Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.ManagedInstance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithManagedInstance(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, WorkspaceInstanceFactory, InnerWorkspaceInstanceManagedInstanceFactory> WithManagedInstance<T1, T2>(this CombinedResult<T1, T2, WorkspaceInstanceFactory> combinedResult, Action<Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.ManagedInstance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithManagedInstance(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<WorkspaceInstanceFactory, T1, T2, T3, InnerWorkspaceInstanceManagedInstanceFactory> WithManagedInstance<T1, T2, T3>(this CombinedResult<WorkspaceInstanceFactory, T1, T2, T3> combinedResult, Action<Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.ManagedInstance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithManagedInstance(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WorkspaceInstanceFactory, T2, T3, InnerWorkspaceInstanceManagedInstanceFactory> WithManagedInstance<T1, T2, T3>(this CombinedResult<T1, WorkspaceInstanceFactory, T2, T3> combinedResult, Action<Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.ManagedInstance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithManagedInstance(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, WorkspaceInstanceFactory, T3, InnerWorkspaceInstanceManagedInstanceFactory> WithManagedInstance<T1, T2, T3>(this CombinedResult<T1, T2, WorkspaceInstanceFactory, T3> combinedResult, Action<Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.ManagedInstance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithManagedInstance(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, WorkspaceInstanceFactory, InnerWorkspaceInstanceManagedInstanceFactory> WithManagedInstance<T1, T2, T3>(this CombinedResult<T1, T2, T3, WorkspaceInstanceFactory> combinedResult, Action<Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.ManagedInstance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithManagedInstance(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<WorkspaceInstanceFactory, T1, T2, T3, T4, InnerWorkspaceInstanceManagedInstanceFactory> WithManagedInstance<T1, T2, T3, T4>(this CombinedResult<WorkspaceInstanceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.ManagedInstance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithManagedInstance(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WorkspaceInstanceFactory, T2, T3, T4, InnerWorkspaceInstanceManagedInstanceFactory> WithManagedInstance<T1, T2, T3, T4>(this CombinedResult<T1, WorkspaceInstanceFactory, T2, T3, T4> combinedResult, Action<Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.ManagedInstance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithManagedInstance(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, WorkspaceInstanceFactory, T3, T4, InnerWorkspaceInstanceManagedInstanceFactory> WithManagedInstance<T1, T2, T3, T4>(this CombinedResult<T1, T2, WorkspaceInstanceFactory, T3, T4> combinedResult, Action<Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.ManagedInstance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithManagedInstance(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, WorkspaceInstanceFactory, T4, InnerWorkspaceInstanceManagedInstanceFactory> WithManagedInstance<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, WorkspaceInstanceFactory, T4> combinedResult, Action<Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.ManagedInstance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithManagedInstance(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, WorkspaceInstanceFactory, InnerWorkspaceInstanceManagedInstanceFactory> WithManagedInstance<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, WorkspaceInstanceFactory> combinedResult, Action<Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.ManagedInstance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithManagedInstance(combinedResult.T5, subFactoryAction).T2);
}
