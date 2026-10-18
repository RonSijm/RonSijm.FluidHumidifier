// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerTrainingJobAlgorithmSpecificationFactory(Action<Humidifier.SageMaker.TrainingJobTypes.AlgorithmSpecification> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.TrainingJobTypes.AlgorithmSpecification>
{

    internal InnerTrainingJobTrainingImageConfigFactory TrainingImageConfigFactory { get; set; }

    protected override Humidifier.SageMaker.TrainingJobTypes.AlgorithmSpecification Create()
    {
        var algorithmSpecificationResult = CreateAlgorithmSpecification();
        factoryAction?.Invoke(algorithmSpecificationResult);

        return algorithmSpecificationResult;
    }

    private Humidifier.SageMaker.TrainingJobTypes.AlgorithmSpecification CreateAlgorithmSpecification()
    {
        var algorithmSpecificationResult = new Humidifier.SageMaker.TrainingJobTypes.AlgorithmSpecification();

        return algorithmSpecificationResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.TrainingJobTypes.AlgorithmSpecification result)
    {
        base.CreateChildren(result);

        result.TrainingImageConfig ??= TrainingImageConfigFactory?.Build();
    }

} // End Of Class

public static class InnerTrainingJobAlgorithmSpecificationFactoryExtensions
{
    public static CombinedResult<InnerTrainingJobAlgorithmSpecificationFactory, InnerTrainingJobTrainingImageConfigFactory> WithTrainingImageConfig(this InnerTrainingJobAlgorithmSpecificationFactory parentFactory, Action<Humidifier.SageMaker.TrainingJobTypes.TrainingImageConfig> subFactoryAction = null)
    {
        parentFactory.TrainingImageConfigFactory = new InnerTrainingJobTrainingImageConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TrainingImageConfigFactory);
    }

    public static CombinedResult<InnerTrainingJobAlgorithmSpecificationFactory, T1, InnerTrainingJobTrainingImageConfigFactory> WithTrainingImageConfig<T1>(this CombinedResult<InnerTrainingJobAlgorithmSpecificationFactory, T1> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.TrainingImageConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithTrainingImageConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTrainingJobAlgorithmSpecificationFactory, InnerTrainingJobTrainingImageConfigFactory> WithTrainingImageConfig<T1>(this CombinedResult<T1, InnerTrainingJobAlgorithmSpecificationFactory> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.TrainingImageConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithTrainingImageConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerTrainingJobAlgorithmSpecificationFactory, T1, T2, InnerTrainingJobTrainingImageConfigFactory> WithTrainingImageConfig<T1, T2>(this CombinedResult<InnerTrainingJobAlgorithmSpecificationFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.TrainingImageConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTrainingImageConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTrainingJobAlgorithmSpecificationFactory, T2, InnerTrainingJobTrainingImageConfigFactory> WithTrainingImageConfig<T1, T2>(this CombinedResult<T1, InnerTrainingJobAlgorithmSpecificationFactory, T2> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.TrainingImageConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTrainingImageConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTrainingJobAlgorithmSpecificationFactory, InnerTrainingJobTrainingImageConfigFactory> WithTrainingImageConfig<T1, T2>(this CombinedResult<T1, T2, InnerTrainingJobAlgorithmSpecificationFactory> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.TrainingImageConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTrainingImageConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerTrainingJobAlgorithmSpecificationFactory, T1, T2, T3, InnerTrainingJobTrainingImageConfigFactory> WithTrainingImageConfig<T1, T2, T3>(this CombinedResult<InnerTrainingJobAlgorithmSpecificationFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.TrainingImageConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTrainingImageConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTrainingJobAlgorithmSpecificationFactory, T2, T3, InnerTrainingJobTrainingImageConfigFactory> WithTrainingImageConfig<T1, T2, T3>(this CombinedResult<T1, InnerTrainingJobAlgorithmSpecificationFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.TrainingImageConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTrainingImageConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTrainingJobAlgorithmSpecificationFactory, T3, InnerTrainingJobTrainingImageConfigFactory> WithTrainingImageConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerTrainingJobAlgorithmSpecificationFactory, T3> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.TrainingImageConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTrainingImageConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerTrainingJobAlgorithmSpecificationFactory, InnerTrainingJobTrainingImageConfigFactory> WithTrainingImageConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTrainingJobAlgorithmSpecificationFactory> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.TrainingImageConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTrainingImageConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerTrainingJobAlgorithmSpecificationFactory, T1, T2, T3, T4, InnerTrainingJobTrainingImageConfigFactory> WithTrainingImageConfig<T1, T2, T3, T4>(this CombinedResult<InnerTrainingJobAlgorithmSpecificationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.TrainingImageConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTrainingImageConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTrainingJobAlgorithmSpecificationFactory, T2, T3, T4, InnerTrainingJobTrainingImageConfigFactory> WithTrainingImageConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerTrainingJobAlgorithmSpecificationFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.TrainingImageConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTrainingImageConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTrainingJobAlgorithmSpecificationFactory, T3, T4, InnerTrainingJobTrainingImageConfigFactory> WithTrainingImageConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTrainingJobAlgorithmSpecificationFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.TrainingImageConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTrainingImageConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerTrainingJobAlgorithmSpecificationFactory, T4, InnerTrainingJobTrainingImageConfigFactory> WithTrainingImageConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTrainingJobAlgorithmSpecificationFactory, T4> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.TrainingImageConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTrainingImageConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerTrainingJobAlgorithmSpecificationFactory, InnerTrainingJobTrainingImageConfigFactory> WithTrainingImageConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTrainingJobAlgorithmSpecificationFactory> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.TrainingImageConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTrainingImageConfig(combinedResult.T5, subFactoryAction).T2);
}
