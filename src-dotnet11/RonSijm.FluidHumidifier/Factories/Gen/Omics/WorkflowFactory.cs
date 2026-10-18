// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Omics;

public class WorkflowFactory(string resourceName = null, Action<Humidifier.Omics.Workflow> factoryAction = null) : ResourceFactory<Humidifier.Omics.Workflow>(resourceName)
{

    internal InnerWorkflowContainerRegistryMapFactory ContainerRegistryMapFactory { get; set; }

    internal InnerWorkflowDefinitionRepositoryFactory DefinitionRepositoryFactory { get; set; }

    protected override Humidifier.Omics.Workflow Create()
    {
        var workflowResult = CreateWorkflow();
        factoryAction?.Invoke(workflowResult);

        return workflowResult;
    }

    private Humidifier.Omics.Workflow CreateWorkflow()
    {
        var workflowResult = new Humidifier.Omics.Workflow
        {
            GivenName = InputResourceName,
        };

        return workflowResult;
    }
    public override void CreateChildren(Humidifier.Omics.Workflow result)
    {
        base.CreateChildren(result);

        result.ContainerRegistryMap ??= ContainerRegistryMapFactory?.Build();
        result.DefinitionRepository ??= DefinitionRepositoryFactory?.Build();
    }

} // End Of Class

public static class WorkflowFactoryExtensions
{
    public static CombinedResult<WorkflowFactory, InnerWorkflowContainerRegistryMapFactory> WithContainerRegistryMap(this WorkflowFactory parentFactory, Action<Humidifier.Omics.WorkflowTypes.ContainerRegistryMap> subFactoryAction = null)
    {
        parentFactory.ContainerRegistryMapFactory = new InnerWorkflowContainerRegistryMapFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ContainerRegistryMapFactory);
    }

    public static CombinedResult<WorkflowFactory, InnerWorkflowDefinitionRepositoryFactory> WithDefinitionRepository(this WorkflowFactory parentFactory, Action<Humidifier.Omics.WorkflowTypes.DefinitionRepository> subFactoryAction = null)
    {
        parentFactory.DefinitionRepositoryFactory = new InnerWorkflowDefinitionRepositoryFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DefinitionRepositoryFactory);
    }

    public static CombinedResult<WorkflowFactory, T1, InnerWorkflowContainerRegistryMapFactory> WithContainerRegistryMap<T1>(this CombinedResult<WorkflowFactory, T1> combinedResult, Action<Humidifier.Omics.WorkflowTypes.ContainerRegistryMap> subFactoryAction = null) => new (combinedResult, combinedResult, WithContainerRegistryMap(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WorkflowFactory, InnerWorkflowContainerRegistryMapFactory> WithContainerRegistryMap<T1>(this CombinedResult<T1, WorkflowFactory> combinedResult, Action<Humidifier.Omics.WorkflowTypes.ContainerRegistryMap> subFactoryAction = null) => new (combinedResult, combinedResult, WithContainerRegistryMap(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<WorkflowFactory, T1, T2, InnerWorkflowContainerRegistryMapFactory> WithContainerRegistryMap<T1, T2>(this CombinedResult<WorkflowFactory, T1, T2> combinedResult, Action<Humidifier.Omics.WorkflowTypes.ContainerRegistryMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContainerRegistryMap(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WorkflowFactory, T2, InnerWorkflowContainerRegistryMapFactory> WithContainerRegistryMap<T1, T2>(this CombinedResult<T1, WorkflowFactory, T2> combinedResult, Action<Humidifier.Omics.WorkflowTypes.ContainerRegistryMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContainerRegistryMap(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, WorkflowFactory, InnerWorkflowContainerRegistryMapFactory> WithContainerRegistryMap<T1, T2>(this CombinedResult<T1, T2, WorkflowFactory> combinedResult, Action<Humidifier.Omics.WorkflowTypes.ContainerRegistryMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContainerRegistryMap(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<WorkflowFactory, T1, T2, T3, InnerWorkflowContainerRegistryMapFactory> WithContainerRegistryMap<T1, T2, T3>(this CombinedResult<WorkflowFactory, T1, T2, T3> combinedResult, Action<Humidifier.Omics.WorkflowTypes.ContainerRegistryMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContainerRegistryMap(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WorkflowFactory, T2, T3, InnerWorkflowContainerRegistryMapFactory> WithContainerRegistryMap<T1, T2, T3>(this CombinedResult<T1, WorkflowFactory, T2, T3> combinedResult, Action<Humidifier.Omics.WorkflowTypes.ContainerRegistryMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContainerRegistryMap(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, WorkflowFactory, T3, InnerWorkflowContainerRegistryMapFactory> WithContainerRegistryMap<T1, T2, T3>(this CombinedResult<T1, T2, WorkflowFactory, T3> combinedResult, Action<Humidifier.Omics.WorkflowTypes.ContainerRegistryMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContainerRegistryMap(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, WorkflowFactory, InnerWorkflowContainerRegistryMapFactory> WithContainerRegistryMap<T1, T2, T3>(this CombinedResult<T1, T2, T3, WorkflowFactory> combinedResult, Action<Humidifier.Omics.WorkflowTypes.ContainerRegistryMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContainerRegistryMap(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<WorkflowFactory, T1, T2, T3, T4, InnerWorkflowContainerRegistryMapFactory> WithContainerRegistryMap<T1, T2, T3, T4>(this CombinedResult<WorkflowFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Omics.WorkflowTypes.ContainerRegistryMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContainerRegistryMap(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WorkflowFactory, T2, T3, T4, InnerWorkflowContainerRegistryMapFactory> WithContainerRegistryMap<T1, T2, T3, T4>(this CombinedResult<T1, WorkflowFactory, T2, T3, T4> combinedResult, Action<Humidifier.Omics.WorkflowTypes.ContainerRegistryMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContainerRegistryMap(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, WorkflowFactory, T3, T4, InnerWorkflowContainerRegistryMapFactory> WithContainerRegistryMap<T1, T2, T3, T4>(this CombinedResult<T1, T2, WorkflowFactory, T3, T4> combinedResult, Action<Humidifier.Omics.WorkflowTypes.ContainerRegistryMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContainerRegistryMap(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, WorkflowFactory, T4, InnerWorkflowContainerRegistryMapFactory> WithContainerRegistryMap<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, WorkflowFactory, T4> combinedResult, Action<Humidifier.Omics.WorkflowTypes.ContainerRegistryMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContainerRegistryMap(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, WorkflowFactory, InnerWorkflowContainerRegistryMapFactory> WithContainerRegistryMap<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, WorkflowFactory> combinedResult, Action<Humidifier.Omics.WorkflowTypes.ContainerRegistryMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContainerRegistryMap(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<WorkflowFactory, T1, InnerWorkflowDefinitionRepositoryFactory> WithDefinitionRepository<T1>(this CombinedResult<WorkflowFactory, T1> combinedResult, Action<Humidifier.Omics.WorkflowTypes.DefinitionRepository> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefinitionRepository(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WorkflowFactory, InnerWorkflowDefinitionRepositoryFactory> WithDefinitionRepository<T1>(this CombinedResult<T1, WorkflowFactory> combinedResult, Action<Humidifier.Omics.WorkflowTypes.DefinitionRepository> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefinitionRepository(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<WorkflowFactory, T1, T2, InnerWorkflowDefinitionRepositoryFactory> WithDefinitionRepository<T1, T2>(this CombinedResult<WorkflowFactory, T1, T2> combinedResult, Action<Humidifier.Omics.WorkflowTypes.DefinitionRepository> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefinitionRepository(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WorkflowFactory, T2, InnerWorkflowDefinitionRepositoryFactory> WithDefinitionRepository<T1, T2>(this CombinedResult<T1, WorkflowFactory, T2> combinedResult, Action<Humidifier.Omics.WorkflowTypes.DefinitionRepository> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefinitionRepository(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, WorkflowFactory, InnerWorkflowDefinitionRepositoryFactory> WithDefinitionRepository<T1, T2>(this CombinedResult<T1, T2, WorkflowFactory> combinedResult, Action<Humidifier.Omics.WorkflowTypes.DefinitionRepository> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefinitionRepository(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<WorkflowFactory, T1, T2, T3, InnerWorkflowDefinitionRepositoryFactory> WithDefinitionRepository<T1, T2, T3>(this CombinedResult<WorkflowFactory, T1, T2, T3> combinedResult, Action<Humidifier.Omics.WorkflowTypes.DefinitionRepository> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefinitionRepository(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WorkflowFactory, T2, T3, InnerWorkflowDefinitionRepositoryFactory> WithDefinitionRepository<T1, T2, T3>(this CombinedResult<T1, WorkflowFactory, T2, T3> combinedResult, Action<Humidifier.Omics.WorkflowTypes.DefinitionRepository> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefinitionRepository(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, WorkflowFactory, T3, InnerWorkflowDefinitionRepositoryFactory> WithDefinitionRepository<T1, T2, T3>(this CombinedResult<T1, T2, WorkflowFactory, T3> combinedResult, Action<Humidifier.Omics.WorkflowTypes.DefinitionRepository> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefinitionRepository(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, WorkflowFactory, InnerWorkflowDefinitionRepositoryFactory> WithDefinitionRepository<T1, T2, T3>(this CombinedResult<T1, T2, T3, WorkflowFactory> combinedResult, Action<Humidifier.Omics.WorkflowTypes.DefinitionRepository> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefinitionRepository(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<WorkflowFactory, T1, T2, T3, T4, InnerWorkflowDefinitionRepositoryFactory> WithDefinitionRepository<T1, T2, T3, T4>(this CombinedResult<WorkflowFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Omics.WorkflowTypes.DefinitionRepository> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefinitionRepository(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WorkflowFactory, T2, T3, T4, InnerWorkflowDefinitionRepositoryFactory> WithDefinitionRepository<T1, T2, T3, T4>(this CombinedResult<T1, WorkflowFactory, T2, T3, T4> combinedResult, Action<Humidifier.Omics.WorkflowTypes.DefinitionRepository> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefinitionRepository(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, WorkflowFactory, T3, T4, InnerWorkflowDefinitionRepositoryFactory> WithDefinitionRepository<T1, T2, T3, T4>(this CombinedResult<T1, T2, WorkflowFactory, T3, T4> combinedResult, Action<Humidifier.Omics.WorkflowTypes.DefinitionRepository> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefinitionRepository(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, WorkflowFactory, T4, InnerWorkflowDefinitionRepositoryFactory> WithDefinitionRepository<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, WorkflowFactory, T4> combinedResult, Action<Humidifier.Omics.WorkflowTypes.DefinitionRepository> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefinitionRepository(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, WorkflowFactory, InnerWorkflowDefinitionRepositoryFactory> WithDefinitionRepository<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, WorkflowFactory> combinedResult, Action<Humidifier.Omics.WorkflowTypes.DefinitionRepository> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefinitionRepository(combinedResult.T5, subFactoryAction).T2);
}
