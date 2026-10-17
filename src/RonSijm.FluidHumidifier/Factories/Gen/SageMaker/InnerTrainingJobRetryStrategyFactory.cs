// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerTrainingJobRetryStrategyFactory(Action<Humidifier.SageMaker.TrainingJobTypes.RetryStrategy> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.TrainingJobTypes.RetryStrategy>
{

    protected override Humidifier.SageMaker.TrainingJobTypes.RetryStrategy Create()
    {
        var retryStrategyResult = CreateRetryStrategy();
        factoryAction?.Invoke(retryStrategyResult);

        return retryStrategyResult;
    }

    private Humidifier.SageMaker.TrainingJobTypes.RetryStrategy CreateRetryStrategy()
    {
        var retryStrategyResult = new Humidifier.SageMaker.TrainingJobTypes.RetryStrategy();

        return retryStrategyResult;
    }

} // End Of Class

public static class InnerTrainingJobRetryStrategyFactoryExtensions
{
}
