// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Omics;

public class InnerWorkflowVersionDefinitionRepositoryFactory(Action<Humidifier.Omics.WorkflowVersionTypes.DefinitionRepository> factoryAction = null) : SubResourceFactory<Humidifier.Omics.WorkflowVersionTypes.DefinitionRepository>
{

    internal InnerWorkflowVersionSourceReferenceFactory sourceReferenceFactory { get; set; }

    protected override Humidifier.Omics.WorkflowVersionTypes.DefinitionRepository Create()
    {
        var definitionRepositoryResult = CreateDefinitionRepository();
        factoryAction?.Invoke(definitionRepositoryResult);

        return definitionRepositoryResult;
    }

    private Humidifier.Omics.WorkflowVersionTypes.DefinitionRepository CreateDefinitionRepository()
    {
        var definitionRepositoryResult = new Humidifier.Omics.WorkflowVersionTypes.DefinitionRepository();

        return definitionRepositoryResult;
    }
    public override void CreateChildren(Humidifier.Omics.WorkflowVersionTypes.DefinitionRepository result)
    {
        base.CreateChildren(result);

        result.sourceReference ??= sourceReferenceFactory?.Build();
    }

} // End Of Class

public static class InnerWorkflowVersionDefinitionRepositoryFactoryExtensions
{
    public static CombinedResult<InnerWorkflowVersionDefinitionRepositoryFactory, InnerWorkflowVersionSourceReferenceFactory> WithsourceReference(this InnerWorkflowVersionDefinitionRepositoryFactory parentFactory, Action<Humidifier.Omics.WorkflowVersionTypes.SourceReference> subFactoryAction = null)
    {
        parentFactory.sourceReferenceFactory = new InnerWorkflowVersionSourceReferenceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.sourceReferenceFactory);
    }

    public static CombinedResult<InnerWorkflowVersionDefinitionRepositoryFactory, T1, InnerWorkflowVersionSourceReferenceFactory> WithsourceReference<T1>(this CombinedResult<InnerWorkflowVersionDefinitionRepositoryFactory, T1> combinedResult, Action<Humidifier.Omics.WorkflowVersionTypes.SourceReference> subFactoryAction = null) => new (combinedResult, combinedResult, WithsourceReference(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerWorkflowVersionDefinitionRepositoryFactory, InnerWorkflowVersionSourceReferenceFactory> WithsourceReference<T1>(this CombinedResult<T1, InnerWorkflowVersionDefinitionRepositoryFactory> combinedResult, Action<Humidifier.Omics.WorkflowVersionTypes.SourceReference> subFactoryAction = null) => new (combinedResult, combinedResult, WithsourceReference(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerWorkflowVersionDefinitionRepositoryFactory, T1, T2, InnerWorkflowVersionSourceReferenceFactory> WithsourceReference<T1, T2>(this CombinedResult<InnerWorkflowVersionDefinitionRepositoryFactory, T1, T2> combinedResult, Action<Humidifier.Omics.WorkflowVersionTypes.SourceReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithsourceReference(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerWorkflowVersionDefinitionRepositoryFactory, T2, InnerWorkflowVersionSourceReferenceFactory> WithsourceReference<T1, T2>(this CombinedResult<T1, InnerWorkflowVersionDefinitionRepositoryFactory, T2> combinedResult, Action<Humidifier.Omics.WorkflowVersionTypes.SourceReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithsourceReference(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerWorkflowVersionDefinitionRepositoryFactory, InnerWorkflowVersionSourceReferenceFactory> WithsourceReference<T1, T2>(this CombinedResult<T1, T2, InnerWorkflowVersionDefinitionRepositoryFactory> combinedResult, Action<Humidifier.Omics.WorkflowVersionTypes.SourceReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithsourceReference(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerWorkflowVersionDefinitionRepositoryFactory, T1, T2, T3, InnerWorkflowVersionSourceReferenceFactory> WithsourceReference<T1, T2, T3>(this CombinedResult<InnerWorkflowVersionDefinitionRepositoryFactory, T1, T2, T3> combinedResult, Action<Humidifier.Omics.WorkflowVersionTypes.SourceReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithsourceReference(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerWorkflowVersionDefinitionRepositoryFactory, T2, T3, InnerWorkflowVersionSourceReferenceFactory> WithsourceReference<T1, T2, T3>(this CombinedResult<T1, InnerWorkflowVersionDefinitionRepositoryFactory, T2, T3> combinedResult, Action<Humidifier.Omics.WorkflowVersionTypes.SourceReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithsourceReference(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerWorkflowVersionDefinitionRepositoryFactory, T3, InnerWorkflowVersionSourceReferenceFactory> WithsourceReference<T1, T2, T3>(this CombinedResult<T1, T2, InnerWorkflowVersionDefinitionRepositoryFactory, T3> combinedResult, Action<Humidifier.Omics.WorkflowVersionTypes.SourceReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithsourceReference(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerWorkflowVersionDefinitionRepositoryFactory, InnerWorkflowVersionSourceReferenceFactory> WithsourceReference<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerWorkflowVersionDefinitionRepositoryFactory> combinedResult, Action<Humidifier.Omics.WorkflowVersionTypes.SourceReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithsourceReference(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerWorkflowVersionDefinitionRepositoryFactory, T1, T2, T3, T4, InnerWorkflowVersionSourceReferenceFactory> WithsourceReference<T1, T2, T3, T4>(this CombinedResult<InnerWorkflowVersionDefinitionRepositoryFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Omics.WorkflowVersionTypes.SourceReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithsourceReference(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerWorkflowVersionDefinitionRepositoryFactory, T2, T3, T4, InnerWorkflowVersionSourceReferenceFactory> WithsourceReference<T1, T2, T3, T4>(this CombinedResult<T1, InnerWorkflowVersionDefinitionRepositoryFactory, T2, T3, T4> combinedResult, Action<Humidifier.Omics.WorkflowVersionTypes.SourceReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithsourceReference(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerWorkflowVersionDefinitionRepositoryFactory, T3, T4, InnerWorkflowVersionSourceReferenceFactory> WithsourceReference<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerWorkflowVersionDefinitionRepositoryFactory, T3, T4> combinedResult, Action<Humidifier.Omics.WorkflowVersionTypes.SourceReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithsourceReference(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerWorkflowVersionDefinitionRepositoryFactory, T4, InnerWorkflowVersionSourceReferenceFactory> WithsourceReference<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerWorkflowVersionDefinitionRepositoryFactory, T4> combinedResult, Action<Humidifier.Omics.WorkflowVersionTypes.SourceReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithsourceReference(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerWorkflowVersionDefinitionRepositoryFactory, InnerWorkflowVersionSourceReferenceFactory> WithsourceReference<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerWorkflowVersionDefinitionRepositoryFactory> combinedResult, Action<Humidifier.Omics.WorkflowVersionTypes.SourceReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithsourceReference(combinedResult.T5, subFactoryAction).T2);
}
