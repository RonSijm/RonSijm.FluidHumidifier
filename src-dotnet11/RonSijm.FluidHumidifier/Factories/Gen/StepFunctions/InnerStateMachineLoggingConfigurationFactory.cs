// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.StepFunctions;

public class InnerStateMachineLoggingConfigurationFactory(Action<Humidifier.StepFunctions.StateMachineTypes.LoggingConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.StepFunctions.StateMachineTypes.LoggingConfiguration>
{

    protected override Humidifier.StepFunctions.StateMachineTypes.LoggingConfiguration Create()
    {
        var loggingConfigurationResult = CreateLoggingConfiguration();
        factoryAction?.Invoke(loggingConfigurationResult);

        return loggingConfigurationResult;
    }

    private Humidifier.StepFunctions.StateMachineTypes.LoggingConfiguration CreateLoggingConfiguration()
    {
        var loggingConfigurationResult = new Humidifier.StepFunctions.StateMachineTypes.LoggingConfiguration();

        return loggingConfigurationResult;
    }

} // End Of Class

public static class InnerStateMachineLoggingConfigurationFactoryExtensions
{
}
