// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelCardTrainingDetailsFactory(Action<Humidifier.SageMaker.ModelCardTypes.TrainingDetails> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelCardTypes.TrainingDetails>
{

    internal InnerModelCardObjectiveFunctionFactory ObjectiveFunctionFactory { get; set; }

    internal InnerModelCardTrainingJobDetailsFactory TrainingJobDetailsFactory { get; set; }

    protected override Humidifier.SageMaker.ModelCardTypes.TrainingDetails Create()
    {
        var trainingDetailsResult = CreateTrainingDetails();
        factoryAction?.Invoke(trainingDetailsResult);

        return trainingDetailsResult;
    }

    private Humidifier.SageMaker.ModelCardTypes.TrainingDetails CreateTrainingDetails()
    {
        var trainingDetailsResult = new Humidifier.SageMaker.ModelCardTypes.TrainingDetails();

        return trainingDetailsResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.ModelCardTypes.TrainingDetails result)
    {
        base.CreateChildren(result);

        result.ObjectiveFunction ??= ObjectiveFunctionFactory?.Build();
        result.TrainingJobDetails ??= TrainingJobDetailsFactory?.Build();
    }

} // End Of Class

public static class InnerModelCardTrainingDetailsFactoryExtensions
{
    public static CombinedResult<InnerModelCardTrainingDetailsFactory, InnerModelCardObjectiveFunctionFactory> WithObjectiveFunction(this InnerModelCardTrainingDetailsFactory parentFactory, Action<Humidifier.SageMaker.ModelCardTypes.ObjectiveFunction> subFactoryAction = null)
    {
        parentFactory.ObjectiveFunctionFactory = new InnerModelCardObjectiveFunctionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ObjectiveFunctionFactory);
    }

    public static CombinedResult<InnerModelCardTrainingDetailsFactory, InnerModelCardTrainingJobDetailsFactory> WithTrainingJobDetails(this InnerModelCardTrainingDetailsFactory parentFactory, Action<Humidifier.SageMaker.ModelCardTypes.TrainingJobDetails> subFactoryAction = null)
    {
        parentFactory.TrainingJobDetailsFactory = new InnerModelCardTrainingJobDetailsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TrainingJobDetailsFactory);
    }

    public static CombinedResult<InnerModelCardTrainingDetailsFactory, T1, InnerModelCardObjectiveFunctionFactory> WithObjectiveFunction<T1>(this CombinedResult<InnerModelCardTrainingDetailsFactory, T1> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.ObjectiveFunction> subFactoryAction = null) => new (combinedResult, combinedResult, WithObjectiveFunction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelCardTrainingDetailsFactory, InnerModelCardObjectiveFunctionFactory> WithObjectiveFunction<T1>(this CombinedResult<T1, InnerModelCardTrainingDetailsFactory> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.ObjectiveFunction> subFactoryAction = null) => new (combinedResult, combinedResult, WithObjectiveFunction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerModelCardTrainingDetailsFactory, T1, T2, InnerModelCardObjectiveFunctionFactory> WithObjectiveFunction<T1, T2>(this CombinedResult<InnerModelCardTrainingDetailsFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.ObjectiveFunction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithObjectiveFunction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelCardTrainingDetailsFactory, T2, InnerModelCardObjectiveFunctionFactory> WithObjectiveFunction<T1, T2>(this CombinedResult<T1, InnerModelCardTrainingDetailsFactory, T2> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.ObjectiveFunction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithObjectiveFunction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelCardTrainingDetailsFactory, InnerModelCardObjectiveFunctionFactory> WithObjectiveFunction<T1, T2>(this CombinedResult<T1, T2, InnerModelCardTrainingDetailsFactory> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.ObjectiveFunction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithObjectiveFunction(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerModelCardTrainingDetailsFactory, T1, T2, T3, InnerModelCardObjectiveFunctionFactory> WithObjectiveFunction<T1, T2, T3>(this CombinedResult<InnerModelCardTrainingDetailsFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.ObjectiveFunction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithObjectiveFunction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelCardTrainingDetailsFactory, T2, T3, InnerModelCardObjectiveFunctionFactory> WithObjectiveFunction<T1, T2, T3>(this CombinedResult<T1, InnerModelCardTrainingDetailsFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.ObjectiveFunction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithObjectiveFunction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelCardTrainingDetailsFactory, T3, InnerModelCardObjectiveFunctionFactory> WithObjectiveFunction<T1, T2, T3>(this CombinedResult<T1, T2, InnerModelCardTrainingDetailsFactory, T3> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.ObjectiveFunction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithObjectiveFunction(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerModelCardTrainingDetailsFactory, InnerModelCardObjectiveFunctionFactory> WithObjectiveFunction<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerModelCardTrainingDetailsFactory> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.ObjectiveFunction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithObjectiveFunction(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerModelCardTrainingDetailsFactory, T1, T2, T3, T4, InnerModelCardObjectiveFunctionFactory> WithObjectiveFunction<T1, T2, T3, T4>(this CombinedResult<InnerModelCardTrainingDetailsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.ObjectiveFunction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithObjectiveFunction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelCardTrainingDetailsFactory, T2, T3, T4, InnerModelCardObjectiveFunctionFactory> WithObjectiveFunction<T1, T2, T3, T4>(this CombinedResult<T1, InnerModelCardTrainingDetailsFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.ObjectiveFunction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithObjectiveFunction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelCardTrainingDetailsFactory, T3, T4, InnerModelCardObjectiveFunctionFactory> WithObjectiveFunction<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerModelCardTrainingDetailsFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.ObjectiveFunction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithObjectiveFunction(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerModelCardTrainingDetailsFactory, T4, InnerModelCardObjectiveFunctionFactory> WithObjectiveFunction<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerModelCardTrainingDetailsFactory, T4> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.ObjectiveFunction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithObjectiveFunction(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerModelCardTrainingDetailsFactory, InnerModelCardObjectiveFunctionFactory> WithObjectiveFunction<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerModelCardTrainingDetailsFactory> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.ObjectiveFunction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithObjectiveFunction(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerModelCardTrainingDetailsFactory, T1, InnerModelCardTrainingJobDetailsFactory> WithTrainingJobDetails<T1>(this CombinedResult<InnerModelCardTrainingDetailsFactory, T1> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.TrainingJobDetails> subFactoryAction = null) => new (combinedResult, combinedResult, WithTrainingJobDetails(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelCardTrainingDetailsFactory, InnerModelCardTrainingJobDetailsFactory> WithTrainingJobDetails<T1>(this CombinedResult<T1, InnerModelCardTrainingDetailsFactory> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.TrainingJobDetails> subFactoryAction = null) => new (combinedResult, combinedResult, WithTrainingJobDetails(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerModelCardTrainingDetailsFactory, T1, T2, InnerModelCardTrainingJobDetailsFactory> WithTrainingJobDetails<T1, T2>(this CombinedResult<InnerModelCardTrainingDetailsFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.TrainingJobDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTrainingJobDetails(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelCardTrainingDetailsFactory, T2, InnerModelCardTrainingJobDetailsFactory> WithTrainingJobDetails<T1, T2>(this CombinedResult<T1, InnerModelCardTrainingDetailsFactory, T2> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.TrainingJobDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTrainingJobDetails(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelCardTrainingDetailsFactory, InnerModelCardTrainingJobDetailsFactory> WithTrainingJobDetails<T1, T2>(this CombinedResult<T1, T2, InnerModelCardTrainingDetailsFactory> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.TrainingJobDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTrainingJobDetails(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerModelCardTrainingDetailsFactory, T1, T2, T3, InnerModelCardTrainingJobDetailsFactory> WithTrainingJobDetails<T1, T2, T3>(this CombinedResult<InnerModelCardTrainingDetailsFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.TrainingJobDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTrainingJobDetails(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelCardTrainingDetailsFactory, T2, T3, InnerModelCardTrainingJobDetailsFactory> WithTrainingJobDetails<T1, T2, T3>(this CombinedResult<T1, InnerModelCardTrainingDetailsFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.TrainingJobDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTrainingJobDetails(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelCardTrainingDetailsFactory, T3, InnerModelCardTrainingJobDetailsFactory> WithTrainingJobDetails<T1, T2, T3>(this CombinedResult<T1, T2, InnerModelCardTrainingDetailsFactory, T3> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.TrainingJobDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTrainingJobDetails(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerModelCardTrainingDetailsFactory, InnerModelCardTrainingJobDetailsFactory> WithTrainingJobDetails<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerModelCardTrainingDetailsFactory> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.TrainingJobDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTrainingJobDetails(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerModelCardTrainingDetailsFactory, T1, T2, T3, T4, InnerModelCardTrainingJobDetailsFactory> WithTrainingJobDetails<T1, T2, T3, T4>(this CombinedResult<InnerModelCardTrainingDetailsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.TrainingJobDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTrainingJobDetails(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelCardTrainingDetailsFactory, T2, T3, T4, InnerModelCardTrainingJobDetailsFactory> WithTrainingJobDetails<T1, T2, T3, T4>(this CombinedResult<T1, InnerModelCardTrainingDetailsFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.TrainingJobDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTrainingJobDetails(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelCardTrainingDetailsFactory, T3, T4, InnerModelCardTrainingJobDetailsFactory> WithTrainingJobDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerModelCardTrainingDetailsFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.TrainingJobDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTrainingJobDetails(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerModelCardTrainingDetailsFactory, T4, InnerModelCardTrainingJobDetailsFactory> WithTrainingJobDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerModelCardTrainingDetailsFactory, T4> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.TrainingJobDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTrainingJobDetails(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerModelCardTrainingDetailsFactory, InnerModelCardTrainingJobDetailsFactory> WithTrainingJobDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerModelCardTrainingDetailsFactory> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.TrainingJobDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTrainingJobDetails(combinedResult.T5, subFactoryAction));
}
