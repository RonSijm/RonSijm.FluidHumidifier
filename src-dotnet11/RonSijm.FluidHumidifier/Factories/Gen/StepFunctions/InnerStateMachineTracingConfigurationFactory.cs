// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.StepFunctions;

public class InnerStateMachineTracingConfigurationFactory(Action<Humidifier.StepFunctions.StateMachineTypes.TracingConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.StepFunctions.StateMachineTypes.TracingConfiguration>
{

    protected override Humidifier.StepFunctions.StateMachineTypes.TracingConfiguration Create()
    {
        var tracingConfigurationResult = CreateTracingConfiguration();
        factoryAction?.Invoke(tracingConfigurationResult);

        return tracingConfigurationResult;
    }

    private Humidifier.StepFunctions.StateMachineTypes.TracingConfiguration CreateTracingConfiguration()
    {
        var tracingConfigurationResult = new Humidifier.StepFunctions.StateMachineTypes.TracingConfiguration();

        return tracingConfigurationResult;
    }

} // End Of Class

public static class InnerStateMachineTracingConfigurationFactoryExtensions
{
}
