// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class AlgorithmFactory(string resourceName = null, Action<Humidifier.SageMaker.Algorithm> factoryAction = null) : ResourceFactory<Humidifier.SageMaker.Algorithm>(resourceName)
{

    internal InnerAlgorithmInferenceSpecificationFactory InferenceSpecificationFactory { get; set; }

    internal InnerAlgorithmTrainingSpecificationFactory TrainingSpecificationFactory { get; set; }

    protected override Humidifier.SageMaker.Algorithm Create()
    {
        var algorithmResult = CreateAlgorithm();
        factoryAction?.Invoke(algorithmResult);

        return algorithmResult;
    }

    private Humidifier.SageMaker.Algorithm CreateAlgorithm()
    {
        var algorithmResult = new Humidifier.SageMaker.Algorithm
        {
            GivenName = InputResourceName,
        };

        return algorithmResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.Algorithm result)
    {
        base.CreateChildren(result);

        result.InferenceSpecification ??= InferenceSpecificationFactory?.Build();
        result.TrainingSpecification ??= TrainingSpecificationFactory?.Build();
    }

} // End Of Class

public static class AlgorithmFactoryExtensions
{
    public static CombinedResult<AlgorithmFactory, InnerAlgorithmInferenceSpecificationFactory> WithInferenceSpecification(this AlgorithmFactory parentFactory, Action<Humidifier.SageMaker.AlgorithmTypes.InferenceSpecification> subFactoryAction = null)
    {
        parentFactory.InferenceSpecificationFactory = new InnerAlgorithmInferenceSpecificationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.InferenceSpecificationFactory);
    }

    public static CombinedResult<AlgorithmFactory, InnerAlgorithmTrainingSpecificationFactory> WithTrainingSpecification(this AlgorithmFactory parentFactory, Action<Humidifier.SageMaker.AlgorithmTypes.TrainingSpecification> subFactoryAction = null)
    {
        parentFactory.TrainingSpecificationFactory = new InnerAlgorithmTrainingSpecificationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TrainingSpecificationFactory);
    }

    public static CombinedResult<AlgorithmFactory, T1, InnerAlgorithmInferenceSpecificationFactory> WithInferenceSpecification<T1>(this CombinedResult<AlgorithmFactory, T1> combinedResult, Action<Humidifier.SageMaker.AlgorithmTypes.InferenceSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, WithInferenceSpecification(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AlgorithmFactory, InnerAlgorithmInferenceSpecificationFactory> WithInferenceSpecification<T1>(this CombinedResult<T1, AlgorithmFactory> combinedResult, Action<Humidifier.SageMaker.AlgorithmTypes.InferenceSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, WithInferenceSpecification(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<AlgorithmFactory, T1, T2, InnerAlgorithmInferenceSpecificationFactory> WithInferenceSpecification<T1, T2>(this CombinedResult<AlgorithmFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.AlgorithmTypes.InferenceSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInferenceSpecification(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AlgorithmFactory, T2, InnerAlgorithmInferenceSpecificationFactory> WithInferenceSpecification<T1, T2>(this CombinedResult<T1, AlgorithmFactory, T2> combinedResult, Action<Humidifier.SageMaker.AlgorithmTypes.InferenceSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInferenceSpecification(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AlgorithmFactory, InnerAlgorithmInferenceSpecificationFactory> WithInferenceSpecification<T1, T2>(this CombinedResult<T1, T2, AlgorithmFactory> combinedResult, Action<Humidifier.SageMaker.AlgorithmTypes.InferenceSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInferenceSpecification(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<AlgorithmFactory, T1, T2, T3, InnerAlgorithmInferenceSpecificationFactory> WithInferenceSpecification<T1, T2, T3>(this CombinedResult<AlgorithmFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.AlgorithmTypes.InferenceSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInferenceSpecification(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AlgorithmFactory, T2, T3, InnerAlgorithmInferenceSpecificationFactory> WithInferenceSpecification<T1, T2, T3>(this CombinedResult<T1, AlgorithmFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.AlgorithmTypes.InferenceSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInferenceSpecification(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AlgorithmFactory, T3, InnerAlgorithmInferenceSpecificationFactory> WithInferenceSpecification<T1, T2, T3>(this CombinedResult<T1, T2, AlgorithmFactory, T3> combinedResult, Action<Humidifier.SageMaker.AlgorithmTypes.InferenceSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInferenceSpecification(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AlgorithmFactory, InnerAlgorithmInferenceSpecificationFactory> WithInferenceSpecification<T1, T2, T3>(this CombinedResult<T1, T2, T3, AlgorithmFactory> combinedResult, Action<Humidifier.SageMaker.AlgorithmTypes.InferenceSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInferenceSpecification(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<AlgorithmFactory, T1, T2, T3, T4, InnerAlgorithmInferenceSpecificationFactory> WithInferenceSpecification<T1, T2, T3, T4>(this CombinedResult<AlgorithmFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.AlgorithmTypes.InferenceSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInferenceSpecification(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AlgorithmFactory, T2, T3, T4, InnerAlgorithmInferenceSpecificationFactory> WithInferenceSpecification<T1, T2, T3, T4>(this CombinedResult<T1, AlgorithmFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.AlgorithmTypes.InferenceSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInferenceSpecification(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AlgorithmFactory, T3, T4, InnerAlgorithmInferenceSpecificationFactory> WithInferenceSpecification<T1, T2, T3, T4>(this CombinedResult<T1, T2, AlgorithmFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.AlgorithmTypes.InferenceSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInferenceSpecification(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AlgorithmFactory, T4, InnerAlgorithmInferenceSpecificationFactory> WithInferenceSpecification<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AlgorithmFactory, T4> combinedResult, Action<Humidifier.SageMaker.AlgorithmTypes.InferenceSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInferenceSpecification(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, AlgorithmFactory, InnerAlgorithmInferenceSpecificationFactory> WithInferenceSpecification<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AlgorithmFactory> combinedResult, Action<Humidifier.SageMaker.AlgorithmTypes.InferenceSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInferenceSpecification(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<AlgorithmFactory, T1, InnerAlgorithmTrainingSpecificationFactory> WithTrainingSpecification<T1>(this CombinedResult<AlgorithmFactory, T1> combinedResult, Action<Humidifier.SageMaker.AlgorithmTypes.TrainingSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, WithTrainingSpecification(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AlgorithmFactory, InnerAlgorithmTrainingSpecificationFactory> WithTrainingSpecification<T1>(this CombinedResult<T1, AlgorithmFactory> combinedResult, Action<Humidifier.SageMaker.AlgorithmTypes.TrainingSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, WithTrainingSpecification(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<AlgorithmFactory, T1, T2, InnerAlgorithmTrainingSpecificationFactory> WithTrainingSpecification<T1, T2>(this CombinedResult<AlgorithmFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.AlgorithmTypes.TrainingSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTrainingSpecification(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AlgorithmFactory, T2, InnerAlgorithmTrainingSpecificationFactory> WithTrainingSpecification<T1, T2>(this CombinedResult<T1, AlgorithmFactory, T2> combinedResult, Action<Humidifier.SageMaker.AlgorithmTypes.TrainingSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTrainingSpecification(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AlgorithmFactory, InnerAlgorithmTrainingSpecificationFactory> WithTrainingSpecification<T1, T2>(this CombinedResult<T1, T2, AlgorithmFactory> combinedResult, Action<Humidifier.SageMaker.AlgorithmTypes.TrainingSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTrainingSpecification(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<AlgorithmFactory, T1, T2, T3, InnerAlgorithmTrainingSpecificationFactory> WithTrainingSpecification<T1, T2, T3>(this CombinedResult<AlgorithmFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.AlgorithmTypes.TrainingSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTrainingSpecification(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AlgorithmFactory, T2, T3, InnerAlgorithmTrainingSpecificationFactory> WithTrainingSpecification<T1, T2, T3>(this CombinedResult<T1, AlgorithmFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.AlgorithmTypes.TrainingSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTrainingSpecification(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AlgorithmFactory, T3, InnerAlgorithmTrainingSpecificationFactory> WithTrainingSpecification<T1, T2, T3>(this CombinedResult<T1, T2, AlgorithmFactory, T3> combinedResult, Action<Humidifier.SageMaker.AlgorithmTypes.TrainingSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTrainingSpecification(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AlgorithmFactory, InnerAlgorithmTrainingSpecificationFactory> WithTrainingSpecification<T1, T2, T3>(this CombinedResult<T1, T2, T3, AlgorithmFactory> combinedResult, Action<Humidifier.SageMaker.AlgorithmTypes.TrainingSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTrainingSpecification(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<AlgorithmFactory, T1, T2, T3, T4, InnerAlgorithmTrainingSpecificationFactory> WithTrainingSpecification<T1, T2, T3, T4>(this CombinedResult<AlgorithmFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.AlgorithmTypes.TrainingSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTrainingSpecification(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AlgorithmFactory, T2, T3, T4, InnerAlgorithmTrainingSpecificationFactory> WithTrainingSpecification<T1, T2, T3, T4>(this CombinedResult<T1, AlgorithmFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.AlgorithmTypes.TrainingSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTrainingSpecification(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AlgorithmFactory, T3, T4, InnerAlgorithmTrainingSpecificationFactory> WithTrainingSpecification<T1, T2, T3, T4>(this CombinedResult<T1, T2, AlgorithmFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.AlgorithmTypes.TrainingSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTrainingSpecification(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AlgorithmFactory, T4, InnerAlgorithmTrainingSpecificationFactory> WithTrainingSpecification<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AlgorithmFactory, T4> combinedResult, Action<Humidifier.SageMaker.AlgorithmTypes.TrainingSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTrainingSpecification(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, AlgorithmFactory, InnerAlgorithmTrainingSpecificationFactory> WithTrainingSpecification<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AlgorithmFactory> combinedResult, Action<Humidifier.SageMaker.AlgorithmTypes.TrainingSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTrainingSpecification(combinedResult.T5, subFactoryAction).T2);
}
