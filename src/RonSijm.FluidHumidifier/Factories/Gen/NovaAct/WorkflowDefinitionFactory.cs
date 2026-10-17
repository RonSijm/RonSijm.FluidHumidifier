// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NovaAct;

public class WorkflowDefinitionFactory(string resourceName = null, Action<Humidifier.NovaAct.WorkflowDefinition> factoryAction = null) : ResourceFactory<Humidifier.NovaAct.WorkflowDefinition>(resourceName)
{

    internal InnerWorkflowDefinitionWorkflowExportConfigFactory ExportConfigFactory { get; set; }

    protected override Humidifier.NovaAct.WorkflowDefinition Create()
    {
        var workflowDefinitionResult = CreateWorkflowDefinition();
        factoryAction?.Invoke(workflowDefinitionResult);

        return workflowDefinitionResult;
    }

    private Humidifier.NovaAct.WorkflowDefinition CreateWorkflowDefinition()
    {
        var workflowDefinitionResult = new Humidifier.NovaAct.WorkflowDefinition
        {
            GivenName = InputResourceName,
        };

        return workflowDefinitionResult;
    }
    public override void CreateChildren(Humidifier.NovaAct.WorkflowDefinition result)
    {
        base.CreateChildren(result);

        result.ExportConfig ??= ExportConfigFactory?.Build();
    }

} // End Of Class

public static class WorkflowDefinitionFactoryExtensions
{
    public static CombinedResult<WorkflowDefinitionFactory, InnerWorkflowDefinitionWorkflowExportConfigFactory> WithExportConfig(this WorkflowDefinitionFactory parentFactory, Action<Humidifier.NovaAct.WorkflowDefinitionTypes.WorkflowExportConfig> subFactoryAction = null)
    {
        parentFactory.ExportConfigFactory = new InnerWorkflowDefinitionWorkflowExportConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ExportConfigFactory);
    }

    public static CombinedResult<WorkflowDefinitionFactory, T1, InnerWorkflowDefinitionWorkflowExportConfigFactory> WithExportConfig<T1>(this CombinedResult<WorkflowDefinitionFactory, T1> combinedResult, Action<Humidifier.NovaAct.WorkflowDefinitionTypes.WorkflowExportConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithExportConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WorkflowDefinitionFactory, InnerWorkflowDefinitionWorkflowExportConfigFactory> WithExportConfig<T1>(this CombinedResult<T1, WorkflowDefinitionFactory> combinedResult, Action<Humidifier.NovaAct.WorkflowDefinitionTypes.WorkflowExportConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithExportConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<WorkflowDefinitionFactory, T1, T2, InnerWorkflowDefinitionWorkflowExportConfigFactory> WithExportConfig<T1, T2>(this CombinedResult<WorkflowDefinitionFactory, T1, T2> combinedResult, Action<Humidifier.NovaAct.WorkflowDefinitionTypes.WorkflowExportConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExportConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WorkflowDefinitionFactory, T2, InnerWorkflowDefinitionWorkflowExportConfigFactory> WithExportConfig<T1, T2>(this CombinedResult<T1, WorkflowDefinitionFactory, T2> combinedResult, Action<Humidifier.NovaAct.WorkflowDefinitionTypes.WorkflowExportConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExportConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, WorkflowDefinitionFactory, InnerWorkflowDefinitionWorkflowExportConfigFactory> WithExportConfig<T1, T2>(this CombinedResult<T1, T2, WorkflowDefinitionFactory> combinedResult, Action<Humidifier.NovaAct.WorkflowDefinitionTypes.WorkflowExportConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExportConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<WorkflowDefinitionFactory, T1, T2, T3, InnerWorkflowDefinitionWorkflowExportConfigFactory> WithExportConfig<T1, T2, T3>(this CombinedResult<WorkflowDefinitionFactory, T1, T2, T3> combinedResult, Action<Humidifier.NovaAct.WorkflowDefinitionTypes.WorkflowExportConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExportConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WorkflowDefinitionFactory, T2, T3, InnerWorkflowDefinitionWorkflowExportConfigFactory> WithExportConfig<T1, T2, T3>(this CombinedResult<T1, WorkflowDefinitionFactory, T2, T3> combinedResult, Action<Humidifier.NovaAct.WorkflowDefinitionTypes.WorkflowExportConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExportConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, WorkflowDefinitionFactory, T3, InnerWorkflowDefinitionWorkflowExportConfigFactory> WithExportConfig<T1, T2, T3>(this CombinedResult<T1, T2, WorkflowDefinitionFactory, T3> combinedResult, Action<Humidifier.NovaAct.WorkflowDefinitionTypes.WorkflowExportConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExportConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, WorkflowDefinitionFactory, InnerWorkflowDefinitionWorkflowExportConfigFactory> WithExportConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, WorkflowDefinitionFactory> combinedResult, Action<Humidifier.NovaAct.WorkflowDefinitionTypes.WorkflowExportConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExportConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<WorkflowDefinitionFactory, T1, T2, T3, T4, InnerWorkflowDefinitionWorkflowExportConfigFactory> WithExportConfig<T1, T2, T3, T4>(this CombinedResult<WorkflowDefinitionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.NovaAct.WorkflowDefinitionTypes.WorkflowExportConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExportConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WorkflowDefinitionFactory, T2, T3, T4, InnerWorkflowDefinitionWorkflowExportConfigFactory> WithExportConfig<T1, T2, T3, T4>(this CombinedResult<T1, WorkflowDefinitionFactory, T2, T3, T4> combinedResult, Action<Humidifier.NovaAct.WorkflowDefinitionTypes.WorkflowExportConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExportConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, WorkflowDefinitionFactory, T3, T4, InnerWorkflowDefinitionWorkflowExportConfigFactory> WithExportConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, WorkflowDefinitionFactory, T3, T4> combinedResult, Action<Humidifier.NovaAct.WorkflowDefinitionTypes.WorkflowExportConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExportConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, WorkflowDefinitionFactory, T4, InnerWorkflowDefinitionWorkflowExportConfigFactory> WithExportConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, WorkflowDefinitionFactory, T4> combinedResult, Action<Humidifier.NovaAct.WorkflowDefinitionTypes.WorkflowExportConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExportConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, WorkflowDefinitionFactory, InnerWorkflowDefinitionWorkflowExportConfigFactory> WithExportConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, WorkflowDefinitionFactory> combinedResult, Action<Humidifier.NovaAct.WorkflowDefinitionTypes.WorkflowExportConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExportConfig(combinedResult.T5, subFactoryAction).T2);
}
