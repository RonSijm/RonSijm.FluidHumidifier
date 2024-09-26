// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ImageBuilder;

public class InnerImageWorkflowConfigurationFactory(Action<Humidifier.ImageBuilder.ImageTypes.WorkflowConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ImageBuilder.ImageTypes.WorkflowConfiguration>
{

    protected override Humidifier.ImageBuilder.ImageTypes.WorkflowConfiguration Create()
    {
        var workflowConfigurationResult = CreateWorkflowConfiguration();
        factoryAction?.Invoke(workflowConfigurationResult);

        return workflowConfigurationResult;
    }

    private Humidifier.ImageBuilder.ImageTypes.WorkflowConfiguration CreateWorkflowConfiguration()
    {
        var workflowConfigurationResult = new Humidifier.ImageBuilder.ImageTypes.WorkflowConfiguration();

        return workflowConfigurationResult;
    }

} // End Of Class

public static class InnerImageWorkflowConfigurationFactoryExtensions
{
}
