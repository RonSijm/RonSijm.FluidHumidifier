// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerTrainingJobTrainingImageConfigFactory(Action<Humidifier.SageMaker.TrainingJobTypes.TrainingImageConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.TrainingJobTypes.TrainingImageConfig>
{

    internal InnerTrainingJobTrainingRepositoryAuthConfigFactory TrainingRepositoryAuthConfigFactory { get; set; }

    protected override Humidifier.SageMaker.TrainingJobTypes.TrainingImageConfig Create()
    {
        var trainingImageConfigResult = CreateTrainingImageConfig();
        factoryAction?.Invoke(trainingImageConfigResult);

        return trainingImageConfigResult;
    }

    private Humidifier.SageMaker.TrainingJobTypes.TrainingImageConfig CreateTrainingImageConfig()
    {
        var trainingImageConfigResult = new Humidifier.SageMaker.TrainingJobTypes.TrainingImageConfig();

        return trainingImageConfigResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.TrainingJobTypes.TrainingImageConfig result)
    {
        base.CreateChildren(result);

        result.TrainingRepositoryAuthConfig ??= TrainingRepositoryAuthConfigFactory?.Build();
    }

} // End Of Class

public static class InnerTrainingJobTrainingImageConfigFactoryExtensions
{
    public static CombinedResult<InnerTrainingJobTrainingImageConfigFactory, InnerTrainingJobTrainingRepositoryAuthConfigFactory> WithTrainingRepositoryAuthConfig(this InnerTrainingJobTrainingImageConfigFactory parentFactory, Action<Humidifier.SageMaker.TrainingJobTypes.TrainingRepositoryAuthConfig> subFactoryAction = null)
    {
        parentFactory.TrainingRepositoryAuthConfigFactory = new InnerTrainingJobTrainingRepositoryAuthConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TrainingRepositoryAuthConfigFactory);
    }

    public static CombinedResult<InnerTrainingJobTrainingImageConfigFactory, T1, InnerTrainingJobTrainingRepositoryAuthConfigFactory> WithTrainingRepositoryAuthConfig<T1>(this CombinedResult<InnerTrainingJobTrainingImageConfigFactory, T1> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.TrainingRepositoryAuthConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithTrainingRepositoryAuthConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTrainingJobTrainingImageConfigFactory, InnerTrainingJobTrainingRepositoryAuthConfigFactory> WithTrainingRepositoryAuthConfig<T1>(this CombinedResult<T1, InnerTrainingJobTrainingImageConfigFactory> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.TrainingRepositoryAuthConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithTrainingRepositoryAuthConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerTrainingJobTrainingImageConfigFactory, T1, T2, InnerTrainingJobTrainingRepositoryAuthConfigFactory> WithTrainingRepositoryAuthConfig<T1, T2>(this CombinedResult<InnerTrainingJobTrainingImageConfigFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.TrainingRepositoryAuthConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTrainingRepositoryAuthConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTrainingJobTrainingImageConfigFactory, T2, InnerTrainingJobTrainingRepositoryAuthConfigFactory> WithTrainingRepositoryAuthConfig<T1, T2>(this CombinedResult<T1, InnerTrainingJobTrainingImageConfigFactory, T2> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.TrainingRepositoryAuthConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTrainingRepositoryAuthConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTrainingJobTrainingImageConfigFactory, InnerTrainingJobTrainingRepositoryAuthConfigFactory> WithTrainingRepositoryAuthConfig<T1, T2>(this CombinedResult<T1, T2, InnerTrainingJobTrainingImageConfigFactory> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.TrainingRepositoryAuthConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTrainingRepositoryAuthConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerTrainingJobTrainingImageConfigFactory, T1, T2, T3, InnerTrainingJobTrainingRepositoryAuthConfigFactory> WithTrainingRepositoryAuthConfig<T1, T2, T3>(this CombinedResult<InnerTrainingJobTrainingImageConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.TrainingRepositoryAuthConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTrainingRepositoryAuthConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTrainingJobTrainingImageConfigFactory, T2, T3, InnerTrainingJobTrainingRepositoryAuthConfigFactory> WithTrainingRepositoryAuthConfig<T1, T2, T3>(this CombinedResult<T1, InnerTrainingJobTrainingImageConfigFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.TrainingRepositoryAuthConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTrainingRepositoryAuthConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTrainingJobTrainingImageConfigFactory, T3, InnerTrainingJobTrainingRepositoryAuthConfigFactory> WithTrainingRepositoryAuthConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerTrainingJobTrainingImageConfigFactory, T3> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.TrainingRepositoryAuthConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTrainingRepositoryAuthConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerTrainingJobTrainingImageConfigFactory, InnerTrainingJobTrainingRepositoryAuthConfigFactory> WithTrainingRepositoryAuthConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTrainingJobTrainingImageConfigFactory> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.TrainingRepositoryAuthConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTrainingRepositoryAuthConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerTrainingJobTrainingImageConfigFactory, T1, T2, T3, T4, InnerTrainingJobTrainingRepositoryAuthConfigFactory> WithTrainingRepositoryAuthConfig<T1, T2, T3, T4>(this CombinedResult<InnerTrainingJobTrainingImageConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.TrainingRepositoryAuthConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTrainingRepositoryAuthConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTrainingJobTrainingImageConfigFactory, T2, T3, T4, InnerTrainingJobTrainingRepositoryAuthConfigFactory> WithTrainingRepositoryAuthConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerTrainingJobTrainingImageConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.TrainingRepositoryAuthConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTrainingRepositoryAuthConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTrainingJobTrainingImageConfigFactory, T3, T4, InnerTrainingJobTrainingRepositoryAuthConfigFactory> WithTrainingRepositoryAuthConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTrainingJobTrainingImageConfigFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.TrainingRepositoryAuthConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTrainingRepositoryAuthConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerTrainingJobTrainingImageConfigFactory, T4, InnerTrainingJobTrainingRepositoryAuthConfigFactory> WithTrainingRepositoryAuthConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTrainingJobTrainingImageConfigFactory, T4> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.TrainingRepositoryAuthConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTrainingRepositoryAuthConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerTrainingJobTrainingImageConfigFactory, InnerTrainingJobTrainingRepositoryAuthConfigFactory> WithTrainingRepositoryAuthConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTrainingJobTrainingImageConfigFactory> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.TrainingRepositoryAuthConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTrainingRepositoryAuthConfig(combinedResult.T5, subFactoryAction).T2);
}
