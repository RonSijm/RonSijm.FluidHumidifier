// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pipes;

public class InnerPipeBatchRetryStrategyFactory(Action<Humidifier.Pipes.PipeTypes.BatchRetryStrategy> factoryAction = null) : SubResourceFactory<Humidifier.Pipes.PipeTypes.BatchRetryStrategy>
{

    protected override Humidifier.Pipes.PipeTypes.BatchRetryStrategy Create()
    {
        var batchRetryStrategyResult = CreateBatchRetryStrategy();
        factoryAction?.Invoke(batchRetryStrategyResult);

        return batchRetryStrategyResult;
    }

    private Humidifier.Pipes.PipeTypes.BatchRetryStrategy CreateBatchRetryStrategy()
    {
        var batchRetryStrategyResult = new Humidifier.Pipes.PipeTypes.BatchRetryStrategy();

        return batchRetryStrategyResult;
    }

} // End Of Class

public static class InnerPipeBatchRetryStrategyFactoryExtensions
{
}
