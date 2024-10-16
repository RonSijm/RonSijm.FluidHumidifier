// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Batch;

public class InnerJobDefinitionRetryStrategyFactory(Action<Humidifier.Batch.JobDefinitionTypes.RetryStrategy> factoryAction = null) : SubResourceFactory<Humidifier.Batch.JobDefinitionTypes.RetryStrategy>
{

    protected override Humidifier.Batch.JobDefinitionTypes.RetryStrategy Create()
    {
        var retryStrategyResult = CreateRetryStrategy();
        factoryAction?.Invoke(retryStrategyResult);

        return retryStrategyResult;
    }

    private Humidifier.Batch.JobDefinitionTypes.RetryStrategy CreateRetryStrategy()
    {
        var retryStrategyResult = new Humidifier.Batch.JobDefinitionTypes.RetryStrategy();

        return retryStrategyResult;
    }

} // End Of Class

public static class InnerJobDefinitionRetryStrategyFactoryExtensions
{
}
