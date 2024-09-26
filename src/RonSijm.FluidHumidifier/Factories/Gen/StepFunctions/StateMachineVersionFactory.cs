// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.StepFunctions;

public class StateMachineVersionFactory(string resourceName = null, Action<Humidifier.StepFunctions.StateMachineVersion> factoryAction = null) : ResourceFactory<Humidifier.StepFunctions.StateMachineVersion>(resourceName)
{

    protected override Humidifier.StepFunctions.StateMachineVersion Create()
    {
        var stateMachineVersionResult = CreateStateMachineVersion();
        factoryAction?.Invoke(stateMachineVersionResult);

        return stateMachineVersionResult;
    }

    private Humidifier.StepFunctions.StateMachineVersion CreateStateMachineVersion()
    {
        var stateMachineVersionResult = new Humidifier.StepFunctions.StateMachineVersion
        {
            GivenName = InputResourceName,
        };

        return stateMachineVersionResult;
    }

} // End Of Class

public static class StateMachineVersionFactoryExtensions
{
}
