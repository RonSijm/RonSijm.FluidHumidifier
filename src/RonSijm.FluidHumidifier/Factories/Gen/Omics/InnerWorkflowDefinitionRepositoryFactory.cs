// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Omics;

public class InnerWorkflowDefinitionRepositoryFactory(Action<Humidifier.Omics.WorkflowTypes.DefinitionRepository> factoryAction = null) : SubResourceFactory<Humidifier.Omics.WorkflowTypes.DefinitionRepository>
{

    internal InnerWorkflowSourceReferenceFactory sourceReferenceFactory { get; set; }

    protected override Humidifier.Omics.WorkflowTypes.DefinitionRepository Create()
    {
        var definitionRepositoryResult = CreateDefinitionRepository();
        factoryAction?.Invoke(definitionRepositoryResult);

        return definitionRepositoryResult;
    }

    private Humidifier.Omics.WorkflowTypes.DefinitionRepository CreateDefinitionRepository()
    {
        var definitionRepositoryResult = new Humidifier.Omics.WorkflowTypes.DefinitionRepository();

        return definitionRepositoryResult;
    }
    public override void CreateChildren(Humidifier.Omics.WorkflowTypes.DefinitionRepository result)
    {
        base.CreateChildren(result);

        result.sourceReference ??= sourceReferenceFactory?.Build();
    }

} // End Of Class

public static class InnerWorkflowDefinitionRepositoryFactoryExtensions
{
    public static CombinedResult<InnerWorkflowDefinitionRepositoryFactory, InnerWorkflowSourceReferenceFactory> WithsourceReference(this InnerWorkflowDefinitionRepositoryFactory parentFactory, Action<Humidifier.Omics.WorkflowTypes.SourceReference> subFactoryAction = null)
    {
        parentFactory.sourceReferenceFactory = new InnerWorkflowSourceReferenceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.sourceReferenceFactory);
    }

    public static CombinedResult<InnerWorkflowDefinitionRepositoryFactory, T1, InnerWorkflowSourceReferenceFactory> WithsourceReference<T1>(this CombinedResult<InnerWorkflowDefinitionRepositoryFactory, T1> combinedResult, Action<Humidifier.Omics.WorkflowTypes.SourceReference> subFactoryAction = null) => new (combinedResult, combinedResult, WithsourceReference(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerWorkflowDefinitionRepositoryFactory, InnerWorkflowSourceReferenceFactory> WithsourceReference<T1>(this CombinedResult<T1, InnerWorkflowDefinitionRepositoryFactory> combinedResult, Action<Humidifier.Omics.WorkflowTypes.SourceReference> subFactoryAction = null) => new (combinedResult, combinedResult, WithsourceReference(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerWorkflowDefinitionRepositoryFactory, T1, T2, InnerWorkflowSourceReferenceFactory> WithsourceReference<T1, T2>(this CombinedResult<InnerWorkflowDefinitionRepositoryFactory, T1, T2> combinedResult, Action<Humidifier.Omics.WorkflowTypes.SourceReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithsourceReference(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerWorkflowDefinitionRepositoryFactory, T2, InnerWorkflowSourceReferenceFactory> WithsourceReference<T1, T2>(this CombinedResult<T1, InnerWorkflowDefinitionRepositoryFactory, T2> combinedResult, Action<Humidifier.Omics.WorkflowTypes.SourceReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithsourceReference(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerWorkflowDefinitionRepositoryFactory, InnerWorkflowSourceReferenceFactory> WithsourceReference<T1, T2>(this CombinedResult<T1, T2, InnerWorkflowDefinitionRepositoryFactory> combinedResult, Action<Humidifier.Omics.WorkflowTypes.SourceReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithsourceReference(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerWorkflowDefinitionRepositoryFactory, T1, T2, T3, InnerWorkflowSourceReferenceFactory> WithsourceReference<T1, T2, T3>(this CombinedResult<InnerWorkflowDefinitionRepositoryFactory, T1, T2, T3> combinedResult, Action<Humidifier.Omics.WorkflowTypes.SourceReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithsourceReference(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerWorkflowDefinitionRepositoryFactory, T2, T3, InnerWorkflowSourceReferenceFactory> WithsourceReference<T1, T2, T3>(this CombinedResult<T1, InnerWorkflowDefinitionRepositoryFactory, T2, T3> combinedResult, Action<Humidifier.Omics.WorkflowTypes.SourceReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithsourceReference(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerWorkflowDefinitionRepositoryFactory, T3, InnerWorkflowSourceReferenceFactory> WithsourceReference<T1, T2, T3>(this CombinedResult<T1, T2, InnerWorkflowDefinitionRepositoryFactory, T3> combinedResult, Action<Humidifier.Omics.WorkflowTypes.SourceReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithsourceReference(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerWorkflowDefinitionRepositoryFactory, InnerWorkflowSourceReferenceFactory> WithsourceReference<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerWorkflowDefinitionRepositoryFactory> combinedResult, Action<Humidifier.Omics.WorkflowTypes.SourceReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithsourceReference(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerWorkflowDefinitionRepositoryFactory, T1, T2, T3, T4, InnerWorkflowSourceReferenceFactory> WithsourceReference<T1, T2, T3, T4>(this CombinedResult<InnerWorkflowDefinitionRepositoryFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Omics.WorkflowTypes.SourceReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithsourceReference(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerWorkflowDefinitionRepositoryFactory, T2, T3, T4, InnerWorkflowSourceReferenceFactory> WithsourceReference<T1, T2, T3, T4>(this CombinedResult<T1, InnerWorkflowDefinitionRepositoryFactory, T2, T3, T4> combinedResult, Action<Humidifier.Omics.WorkflowTypes.SourceReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithsourceReference(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerWorkflowDefinitionRepositoryFactory, T3, T4, InnerWorkflowSourceReferenceFactory> WithsourceReference<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerWorkflowDefinitionRepositoryFactory, T3, T4> combinedResult, Action<Humidifier.Omics.WorkflowTypes.SourceReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithsourceReference(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerWorkflowDefinitionRepositoryFactory, T4, InnerWorkflowSourceReferenceFactory> WithsourceReference<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerWorkflowDefinitionRepositoryFactory, T4> combinedResult, Action<Humidifier.Omics.WorkflowTypes.SourceReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithsourceReference(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerWorkflowDefinitionRepositoryFactory, InnerWorkflowSourceReferenceFactory> WithsourceReference<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerWorkflowDefinitionRepositoryFactory> combinedResult, Action<Humidifier.Omics.WorkflowTypes.SourceReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithsourceReference(combinedResult.T5, subFactoryAction).T2);
}
