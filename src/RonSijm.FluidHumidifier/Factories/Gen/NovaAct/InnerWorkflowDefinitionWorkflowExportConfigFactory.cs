// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NovaAct;

public class InnerWorkflowDefinitionWorkflowExportConfigFactory(Action<Humidifier.NovaAct.WorkflowDefinitionTypes.WorkflowExportConfig> factoryAction = null) : SubResourceFactory<Humidifier.NovaAct.WorkflowDefinitionTypes.WorkflowExportConfig>
{

    protected override Humidifier.NovaAct.WorkflowDefinitionTypes.WorkflowExportConfig Create()
    {
        var workflowExportConfigResult = CreateWorkflowExportConfig();
        factoryAction?.Invoke(workflowExportConfigResult);

        return workflowExportConfigResult;
    }

    private Humidifier.NovaAct.WorkflowDefinitionTypes.WorkflowExportConfig CreateWorkflowExportConfig()
    {
        var workflowExportConfigResult = new Humidifier.NovaAct.WorkflowDefinitionTypes.WorkflowExportConfig();

        return workflowExportConfigResult;
    }

} // End Of Class

public static class InnerWorkflowDefinitionWorkflowExportConfigFactoryExtensions
{
}
