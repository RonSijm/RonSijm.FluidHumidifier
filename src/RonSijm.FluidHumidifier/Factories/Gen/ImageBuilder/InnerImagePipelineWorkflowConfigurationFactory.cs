// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ImageBuilder;

public class InnerImagePipelineWorkflowConfigurationFactory(Action<Humidifier.ImageBuilder.ImagePipelineTypes.WorkflowConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ImageBuilder.ImagePipelineTypes.WorkflowConfiguration>
{

    protected override Humidifier.ImageBuilder.ImagePipelineTypes.WorkflowConfiguration Create()
    {
        var workflowConfigurationResult = CreateWorkflowConfiguration();
        factoryAction?.Invoke(workflowConfigurationResult);

        return workflowConfigurationResult;
    }

    private Humidifier.ImageBuilder.ImagePipelineTypes.WorkflowConfiguration CreateWorkflowConfiguration()
    {
        var workflowConfigurationResult = new Humidifier.ImageBuilder.ImagePipelineTypes.WorkflowConfiguration();

        return workflowConfigurationResult;
    }

} // End Of Class

public static class InnerImagePipelineWorkflowConfigurationFactoryExtensions
{
}
