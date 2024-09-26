// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelCardTrainingJobDetailsFactory(Action<Humidifier.SageMaker.ModelCardTypes.TrainingJobDetails> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelCardTypes.TrainingJobDetails>
{

    internal InnerModelCardTrainingEnvironmentFactory TrainingEnvironmentFactory { get; set; }

    protected override Humidifier.SageMaker.ModelCardTypes.TrainingJobDetails Create()
    {
        var trainingJobDetailsResult = CreateTrainingJobDetails();
        factoryAction?.Invoke(trainingJobDetailsResult);

        return trainingJobDetailsResult;
    }

    private Humidifier.SageMaker.ModelCardTypes.TrainingJobDetails CreateTrainingJobDetails()
    {
        var trainingJobDetailsResult = new Humidifier.SageMaker.ModelCardTypes.TrainingJobDetails();

        return trainingJobDetailsResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.ModelCardTypes.TrainingJobDetails result)
    {
        base.CreateChildren(result);

        result.TrainingEnvironment ??= TrainingEnvironmentFactory?.Build();
    }

} // End Of Class

public static class InnerModelCardTrainingJobDetailsFactoryExtensions
{
    public static CombinedResult<InnerModelCardTrainingJobDetailsFactory, InnerModelCardTrainingEnvironmentFactory> WithTrainingEnvironment(this InnerModelCardTrainingJobDetailsFactory parentFactory, Action<Humidifier.SageMaker.ModelCardTypes.TrainingEnvironment> subFactoryAction = null)
    {
        parentFactory.TrainingEnvironmentFactory = new InnerModelCardTrainingEnvironmentFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TrainingEnvironmentFactory);
    }

    public static CombinedResult<InnerModelCardTrainingJobDetailsFactory, T1, InnerModelCardTrainingEnvironmentFactory> WithTrainingEnvironment<T1>(this CombinedResult<InnerModelCardTrainingJobDetailsFactory, T1> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.TrainingEnvironment> subFactoryAction = null) => new (combinedResult, combinedResult, WithTrainingEnvironment(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelCardTrainingJobDetailsFactory, InnerModelCardTrainingEnvironmentFactory> WithTrainingEnvironment<T1>(this CombinedResult<T1, InnerModelCardTrainingJobDetailsFactory> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.TrainingEnvironment> subFactoryAction = null) => new (combinedResult, combinedResult, WithTrainingEnvironment(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerModelCardTrainingJobDetailsFactory, T1, T2, InnerModelCardTrainingEnvironmentFactory> WithTrainingEnvironment<T1, T2>(this CombinedResult<InnerModelCardTrainingJobDetailsFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.TrainingEnvironment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTrainingEnvironment(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelCardTrainingJobDetailsFactory, T2, InnerModelCardTrainingEnvironmentFactory> WithTrainingEnvironment<T1, T2>(this CombinedResult<T1, InnerModelCardTrainingJobDetailsFactory, T2> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.TrainingEnvironment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTrainingEnvironment(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelCardTrainingJobDetailsFactory, InnerModelCardTrainingEnvironmentFactory> WithTrainingEnvironment<T1, T2>(this CombinedResult<T1, T2, InnerModelCardTrainingJobDetailsFactory> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.TrainingEnvironment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTrainingEnvironment(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerModelCardTrainingJobDetailsFactory, T1, T2, T3, InnerModelCardTrainingEnvironmentFactory> WithTrainingEnvironment<T1, T2, T3>(this CombinedResult<InnerModelCardTrainingJobDetailsFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.TrainingEnvironment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTrainingEnvironment(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelCardTrainingJobDetailsFactory, T2, T3, InnerModelCardTrainingEnvironmentFactory> WithTrainingEnvironment<T1, T2, T3>(this CombinedResult<T1, InnerModelCardTrainingJobDetailsFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.TrainingEnvironment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTrainingEnvironment(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelCardTrainingJobDetailsFactory, T3, InnerModelCardTrainingEnvironmentFactory> WithTrainingEnvironment<T1, T2, T3>(this CombinedResult<T1, T2, InnerModelCardTrainingJobDetailsFactory, T3> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.TrainingEnvironment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTrainingEnvironment(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerModelCardTrainingJobDetailsFactory, InnerModelCardTrainingEnvironmentFactory> WithTrainingEnvironment<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerModelCardTrainingJobDetailsFactory> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.TrainingEnvironment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTrainingEnvironment(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerModelCardTrainingJobDetailsFactory, T1, T2, T3, T4, InnerModelCardTrainingEnvironmentFactory> WithTrainingEnvironment<T1, T2, T3, T4>(this CombinedResult<InnerModelCardTrainingJobDetailsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.TrainingEnvironment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTrainingEnvironment(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelCardTrainingJobDetailsFactory, T2, T3, T4, InnerModelCardTrainingEnvironmentFactory> WithTrainingEnvironment<T1, T2, T3, T4>(this CombinedResult<T1, InnerModelCardTrainingJobDetailsFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.TrainingEnvironment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTrainingEnvironment(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelCardTrainingJobDetailsFactory, T3, T4, InnerModelCardTrainingEnvironmentFactory> WithTrainingEnvironment<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerModelCardTrainingJobDetailsFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.TrainingEnvironment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTrainingEnvironment(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerModelCardTrainingJobDetailsFactory, T4, InnerModelCardTrainingEnvironmentFactory> WithTrainingEnvironment<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerModelCardTrainingJobDetailsFactory, T4> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.TrainingEnvironment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTrainingEnvironment(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerModelCardTrainingJobDetailsFactory, InnerModelCardTrainingEnvironmentFactory> WithTrainingEnvironment<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerModelCardTrainingJobDetailsFactory> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.TrainingEnvironment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTrainingEnvironment(combinedResult.T5, subFactoryAction));
}
