// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ImageBuilder;

public class LifecycleExecutionFactory(string resourceName = null, Action<Humidifier.ImageBuilder.LifecycleExecution> factoryAction = null) : ResourceFactory<Humidifier.ImageBuilder.LifecycleExecution>(resourceName)
{

    protected override Humidifier.ImageBuilder.LifecycleExecution Create()
    {
        var lifecycleExecutionResult = CreateLifecycleExecution();
        factoryAction?.Invoke(lifecycleExecutionResult);

        return lifecycleExecutionResult;
    }

    private Humidifier.ImageBuilder.LifecycleExecution CreateLifecycleExecution()
    {
        var lifecycleExecutionResult = new Humidifier.ImageBuilder.LifecycleExecution
        {
            GivenName = InputResourceName,
        };

        return lifecycleExecutionResult;
    }

} // End Of Class

public static class LifecycleExecutionFactoryExtensions
{
}
