// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaTailor;

public class InnerFunctionConcurrentExecutorConfigurationFactory(Action<Humidifier.MediaTailor.FunctionTypes.ConcurrentExecutorConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaTailor.FunctionTypes.ConcurrentExecutorConfiguration>
{

    protected override Humidifier.MediaTailor.FunctionTypes.ConcurrentExecutorConfiguration Create()
    {
        var concurrentExecutorConfigurationResult = CreateConcurrentExecutorConfiguration();
        factoryAction?.Invoke(concurrentExecutorConfigurationResult);

        return concurrentExecutorConfigurationResult;
    }

    private Humidifier.MediaTailor.FunctionTypes.ConcurrentExecutorConfiguration CreateConcurrentExecutorConfiguration()
    {
        var concurrentExecutorConfigurationResult = new Humidifier.MediaTailor.FunctionTypes.ConcurrentExecutorConfiguration();

        return concurrentExecutorConfigurationResult;
    }

} // End Of Class

public static class InnerFunctionConcurrentExecutorConfigurationFactoryExtensions
{
}
