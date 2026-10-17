// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.States;

public class ExecutionFactory(string resourceName = null, Action<Humidifier.States.Execution> factoryAction = null) : ResourceFactory<Humidifier.States.Execution>(resourceName)
{

    protected override Humidifier.States.Execution Create()
    {
        var executionResult = CreateExecution();
        factoryAction?.Invoke(executionResult);

        return executionResult;
    }

    private Humidifier.States.Execution CreateExecution()
    {
        var executionResult = new Humidifier.States.Execution
        {
            GivenName = InputResourceName,
        };

        return executionResult;
    }

} // End Of Class

public static class ExecutionFactoryExtensions
{
}
