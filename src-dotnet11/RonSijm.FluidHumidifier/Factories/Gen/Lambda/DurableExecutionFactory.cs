// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class DurableExecutionFactory(string resourceName = null, Action<Humidifier.Lambda.DurableExecution> factoryAction = null) : ResourceFactory<Humidifier.Lambda.DurableExecution>(resourceName)
{

    protected override Humidifier.Lambda.DurableExecution Create()
    {
        var durableExecutionResult = CreateDurableExecution();
        factoryAction?.Invoke(durableExecutionResult);

        return durableExecutionResult;
    }

    private Humidifier.Lambda.DurableExecution CreateDurableExecution()
    {
        var durableExecutionResult = new Humidifier.Lambda.DurableExecution
        {
            GivenName = InputResourceName,
        };

        return durableExecutionResult;
    }

} // End Of Class

public static class DurableExecutionFactoryExtensions
{
}
