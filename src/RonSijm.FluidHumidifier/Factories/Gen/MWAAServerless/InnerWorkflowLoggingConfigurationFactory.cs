// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MWAAServerless;

public class InnerWorkflowLoggingConfigurationFactory(Action<Humidifier.MWAAServerless.WorkflowTypes.LoggingConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MWAAServerless.WorkflowTypes.LoggingConfiguration>
{

    protected override Humidifier.MWAAServerless.WorkflowTypes.LoggingConfiguration Create()
    {
        var loggingConfigurationResult = CreateLoggingConfiguration();
        factoryAction?.Invoke(loggingConfigurationResult);

        return loggingConfigurationResult;
    }

    private Humidifier.MWAAServerless.WorkflowTypes.LoggingConfiguration CreateLoggingConfiguration()
    {
        var loggingConfigurationResult = new Humidifier.MWAAServerless.WorkflowTypes.LoggingConfiguration();

        return loggingConfigurationResult;
    }

} // End Of Class

public static class InnerWorkflowLoggingConfigurationFactoryExtensions
{
}
