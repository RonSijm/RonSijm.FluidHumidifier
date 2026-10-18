// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaTailor;

public class InnerFunctionSequentialExecutorConfigurationFactory(Action<Humidifier.MediaTailor.FunctionTypes.SequentialExecutorConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaTailor.FunctionTypes.SequentialExecutorConfiguration>
{

    protected override Humidifier.MediaTailor.FunctionTypes.SequentialExecutorConfiguration Create()
    {
        var sequentialExecutorConfigurationResult = CreateSequentialExecutorConfiguration();
        factoryAction?.Invoke(sequentialExecutorConfigurationResult);

        return sequentialExecutorConfigurationResult;
    }

    private Humidifier.MediaTailor.FunctionTypes.SequentialExecutorConfiguration CreateSequentialExecutorConfiguration()
    {
        var sequentialExecutorConfigurationResult = new Humidifier.MediaTailor.FunctionTypes.SequentialExecutorConfiguration();

        return sequentialExecutorConfigurationResult;
    }

} // End Of Class

public static class InnerFunctionSequentialExecutorConfigurationFactoryExtensions
{
}
