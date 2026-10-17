// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Omics;

public class WorkflowVersionFactory(string resourceName = null, Action<Humidifier.Omics.WorkflowVersion> factoryAction = null) : ResourceFactory<Humidifier.Omics.WorkflowVersion>(resourceName)
{

    internal InnerWorkflowVersionContainerRegistryMapFactory ContainerRegistryMapFactory { get; set; }

    internal InnerWorkflowVersionDefinitionRepositoryFactory DefinitionRepositoryFactory { get; set; }

    protected override Humidifier.Omics.WorkflowVersion Create()
    {
        var workflowVersionResult = CreateWorkflowVersion();
        factoryAction?.Invoke(workflowVersionResult);

        return workflowVersionResult;
    }

    private Humidifier.Omics.WorkflowVersion CreateWorkflowVersion()
    {
        var workflowVersionResult = new Humidifier.Omics.WorkflowVersion
        {
            GivenName = InputResourceName,
        };

        return workflowVersionResult;
    }
    public override void CreateChildren(Humidifier.Omics.WorkflowVersion result)
    {
        base.CreateChildren(result);

        result.ContainerRegistryMap ??= ContainerRegistryMapFactory?.Build();
        result.DefinitionRepository ??= DefinitionRepositoryFactory?.Build();
    }

} // End Of Class

public static class WorkflowVersionFactoryExtensions
{
    public static CombinedResult<WorkflowVersionFactory, InnerWorkflowVersionContainerRegistryMapFactory> WithContainerRegistryMap(this WorkflowVersionFactory parentFactory, Action<Humidifier.Omics.WorkflowVersionTypes.ContainerRegistryMap> subFactoryAction = null)
    {
        parentFactory.ContainerRegistryMapFactory = new InnerWorkflowVersionContainerRegistryMapFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ContainerRegistryMapFactory);
    }

    public static CombinedResult<WorkflowVersionFactory, InnerWorkflowVersionDefinitionRepositoryFactory> WithDefinitionRepository(this WorkflowVersionFactory parentFactory, Action<Humidifier.Omics.WorkflowVersionTypes.DefinitionRepository> subFactoryAction = null)
    {
        parentFactory.DefinitionRepositoryFactory = new InnerWorkflowVersionDefinitionRepositoryFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DefinitionRepositoryFactory);
    }

    public static CombinedResult<WorkflowVersionFactory, T1, InnerWorkflowVersionContainerRegistryMapFactory> WithContainerRegistryMap<T1>(this CombinedResult<WorkflowVersionFactory, T1> combinedResult, Action<Humidifier.Omics.WorkflowVersionTypes.ContainerRegistryMap> subFactoryAction = null) => new (combinedResult, combinedResult, WithContainerRegistryMap(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WorkflowVersionFactory, InnerWorkflowVersionContainerRegistryMapFactory> WithContainerRegistryMap<T1>(this CombinedResult<T1, WorkflowVersionFactory> combinedResult, Action<Humidifier.Omics.WorkflowVersionTypes.ContainerRegistryMap> subFactoryAction = null) => new (combinedResult, combinedResult, WithContainerRegistryMap(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<WorkflowVersionFactory, T1, T2, InnerWorkflowVersionContainerRegistryMapFactory> WithContainerRegistryMap<T1, T2>(this CombinedResult<WorkflowVersionFactory, T1, T2> combinedResult, Action<Humidifier.Omics.WorkflowVersionTypes.ContainerRegistryMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContainerRegistryMap(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WorkflowVersionFactory, T2, InnerWorkflowVersionContainerRegistryMapFactory> WithContainerRegistryMap<T1, T2>(this CombinedResult<T1, WorkflowVersionFactory, T2> combinedResult, Action<Humidifier.Omics.WorkflowVersionTypes.ContainerRegistryMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContainerRegistryMap(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, WorkflowVersionFactory, InnerWorkflowVersionContainerRegistryMapFactory> WithContainerRegistryMap<T1, T2>(this CombinedResult<T1, T2, WorkflowVersionFactory> combinedResult, Action<Humidifier.Omics.WorkflowVersionTypes.ContainerRegistryMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContainerRegistryMap(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<WorkflowVersionFactory, T1, T2, T3, InnerWorkflowVersionContainerRegistryMapFactory> WithContainerRegistryMap<T1, T2, T3>(this CombinedResult<WorkflowVersionFactory, T1, T2, T3> combinedResult, Action<Humidifier.Omics.WorkflowVersionTypes.ContainerRegistryMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContainerRegistryMap(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WorkflowVersionFactory, T2, T3, InnerWorkflowVersionContainerRegistryMapFactory> WithContainerRegistryMap<T1, T2, T3>(this CombinedResult<T1, WorkflowVersionFactory, T2, T3> combinedResult, Action<Humidifier.Omics.WorkflowVersionTypes.ContainerRegistryMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContainerRegistryMap(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, WorkflowVersionFactory, T3, InnerWorkflowVersionContainerRegistryMapFactory> WithContainerRegistryMap<T1, T2, T3>(this CombinedResult<T1, T2, WorkflowVersionFactory, T3> combinedResult, Action<Humidifier.Omics.WorkflowVersionTypes.ContainerRegistryMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContainerRegistryMap(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, WorkflowVersionFactory, InnerWorkflowVersionContainerRegistryMapFactory> WithContainerRegistryMap<T1, T2, T3>(this CombinedResult<T1, T2, T3, WorkflowVersionFactory> combinedResult, Action<Humidifier.Omics.WorkflowVersionTypes.ContainerRegistryMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContainerRegistryMap(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<WorkflowVersionFactory, T1, T2, T3, T4, InnerWorkflowVersionContainerRegistryMapFactory> WithContainerRegistryMap<T1, T2, T3, T4>(this CombinedResult<WorkflowVersionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Omics.WorkflowVersionTypes.ContainerRegistryMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContainerRegistryMap(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WorkflowVersionFactory, T2, T3, T4, InnerWorkflowVersionContainerRegistryMapFactory> WithContainerRegistryMap<T1, T2, T3, T4>(this CombinedResult<T1, WorkflowVersionFactory, T2, T3, T4> combinedResult, Action<Humidifier.Omics.WorkflowVersionTypes.ContainerRegistryMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContainerRegistryMap(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, WorkflowVersionFactory, T3, T4, InnerWorkflowVersionContainerRegistryMapFactory> WithContainerRegistryMap<T1, T2, T3, T4>(this CombinedResult<T1, T2, WorkflowVersionFactory, T3, T4> combinedResult, Action<Humidifier.Omics.WorkflowVersionTypes.ContainerRegistryMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContainerRegistryMap(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, WorkflowVersionFactory, T4, InnerWorkflowVersionContainerRegistryMapFactory> WithContainerRegistryMap<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, WorkflowVersionFactory, T4> combinedResult, Action<Humidifier.Omics.WorkflowVersionTypes.ContainerRegistryMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContainerRegistryMap(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, WorkflowVersionFactory, InnerWorkflowVersionContainerRegistryMapFactory> WithContainerRegistryMap<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, WorkflowVersionFactory> combinedResult, Action<Humidifier.Omics.WorkflowVersionTypes.ContainerRegistryMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContainerRegistryMap(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<WorkflowVersionFactory, T1, InnerWorkflowVersionDefinitionRepositoryFactory> WithDefinitionRepository<T1>(this CombinedResult<WorkflowVersionFactory, T1> combinedResult, Action<Humidifier.Omics.WorkflowVersionTypes.DefinitionRepository> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefinitionRepository(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WorkflowVersionFactory, InnerWorkflowVersionDefinitionRepositoryFactory> WithDefinitionRepository<T1>(this CombinedResult<T1, WorkflowVersionFactory> combinedResult, Action<Humidifier.Omics.WorkflowVersionTypes.DefinitionRepository> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefinitionRepository(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<WorkflowVersionFactory, T1, T2, InnerWorkflowVersionDefinitionRepositoryFactory> WithDefinitionRepository<T1, T2>(this CombinedResult<WorkflowVersionFactory, T1, T2> combinedResult, Action<Humidifier.Omics.WorkflowVersionTypes.DefinitionRepository> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefinitionRepository(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WorkflowVersionFactory, T2, InnerWorkflowVersionDefinitionRepositoryFactory> WithDefinitionRepository<T1, T2>(this CombinedResult<T1, WorkflowVersionFactory, T2> combinedResult, Action<Humidifier.Omics.WorkflowVersionTypes.DefinitionRepository> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefinitionRepository(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, WorkflowVersionFactory, InnerWorkflowVersionDefinitionRepositoryFactory> WithDefinitionRepository<T1, T2>(this CombinedResult<T1, T2, WorkflowVersionFactory> combinedResult, Action<Humidifier.Omics.WorkflowVersionTypes.DefinitionRepository> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefinitionRepository(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<WorkflowVersionFactory, T1, T2, T3, InnerWorkflowVersionDefinitionRepositoryFactory> WithDefinitionRepository<T1, T2, T3>(this CombinedResult<WorkflowVersionFactory, T1, T2, T3> combinedResult, Action<Humidifier.Omics.WorkflowVersionTypes.DefinitionRepository> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefinitionRepository(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WorkflowVersionFactory, T2, T3, InnerWorkflowVersionDefinitionRepositoryFactory> WithDefinitionRepository<T1, T2, T3>(this CombinedResult<T1, WorkflowVersionFactory, T2, T3> combinedResult, Action<Humidifier.Omics.WorkflowVersionTypes.DefinitionRepository> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefinitionRepository(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, WorkflowVersionFactory, T3, InnerWorkflowVersionDefinitionRepositoryFactory> WithDefinitionRepository<T1, T2, T3>(this CombinedResult<T1, T2, WorkflowVersionFactory, T3> combinedResult, Action<Humidifier.Omics.WorkflowVersionTypes.DefinitionRepository> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefinitionRepository(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, WorkflowVersionFactory, InnerWorkflowVersionDefinitionRepositoryFactory> WithDefinitionRepository<T1, T2, T3>(this CombinedResult<T1, T2, T3, WorkflowVersionFactory> combinedResult, Action<Humidifier.Omics.WorkflowVersionTypes.DefinitionRepository> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefinitionRepository(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<WorkflowVersionFactory, T1, T2, T3, T4, InnerWorkflowVersionDefinitionRepositoryFactory> WithDefinitionRepository<T1, T2, T3, T4>(this CombinedResult<WorkflowVersionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Omics.WorkflowVersionTypes.DefinitionRepository> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefinitionRepository(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WorkflowVersionFactory, T2, T3, T4, InnerWorkflowVersionDefinitionRepositoryFactory> WithDefinitionRepository<T1, T2, T3, T4>(this CombinedResult<T1, WorkflowVersionFactory, T2, T3, T4> combinedResult, Action<Humidifier.Omics.WorkflowVersionTypes.DefinitionRepository> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefinitionRepository(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, WorkflowVersionFactory, T3, T4, InnerWorkflowVersionDefinitionRepositoryFactory> WithDefinitionRepository<T1, T2, T3, T4>(this CombinedResult<T1, T2, WorkflowVersionFactory, T3, T4> combinedResult, Action<Humidifier.Omics.WorkflowVersionTypes.DefinitionRepository> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefinitionRepository(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, WorkflowVersionFactory, T4, InnerWorkflowVersionDefinitionRepositoryFactory> WithDefinitionRepository<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, WorkflowVersionFactory, T4> combinedResult, Action<Humidifier.Omics.WorkflowVersionTypes.DefinitionRepository> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefinitionRepository(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, WorkflowVersionFactory, InnerWorkflowVersionDefinitionRepositoryFactory> WithDefinitionRepository<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, WorkflowVersionFactory> combinedResult, Action<Humidifier.Omics.WorkflowVersionTypes.DefinitionRepository> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefinitionRepository(combinedResult.T5, subFactoryAction).T2);
}
