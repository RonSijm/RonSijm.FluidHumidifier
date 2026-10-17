// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerHyperParameterTuningJobRetryStrategyFactory(Action<Humidifier.SageMaker.HyperParameterTuningJobTypes.RetryStrategy> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.HyperParameterTuningJobTypes.RetryStrategy>
{

    protected override Humidifier.SageMaker.HyperParameterTuningJobTypes.RetryStrategy Create()
    {
        var retryStrategyResult = CreateRetryStrategy();
        factoryAction?.Invoke(retryStrategyResult);

        return retryStrategyResult;
    }

    private Humidifier.SageMaker.HyperParameterTuningJobTypes.RetryStrategy CreateRetryStrategy()
    {
        var retryStrategyResult = new Humidifier.SageMaker.HyperParameterTuningJobTypes.RetryStrategy();

        return retryStrategyResult;
    }

} // End Of Class

public static class InnerHyperParameterTuningJobRetryStrategyFactoryExtensions
{
}
