// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class AIWorkloadConfigFactory(string resourceName = null, Action<Humidifier.SageMaker.AIWorkloadConfig> factoryAction = null) : ResourceFactory<Humidifier.SageMaker.AIWorkloadConfig>(resourceName)
{

    internal InnerAIWorkloadConfigAIDatasetConfigFactory DatasetConfigFactory { get; set; }

    internal InnerAIWorkloadConfigAIWorkloadConfigsFactory AIWorkloadConfigsFactory { get; set; }

    protected override Humidifier.SageMaker.AIWorkloadConfig Create()
    {
        var aIWorkloadConfigResult = CreateAIWorkloadConfig();
        factoryAction?.Invoke(aIWorkloadConfigResult);

        return aIWorkloadConfigResult;
    }

    private Humidifier.SageMaker.AIWorkloadConfig CreateAIWorkloadConfig()
    {
        var aIWorkloadConfigResult = new Humidifier.SageMaker.AIWorkloadConfig
        {
            GivenName = InputResourceName,
        };

        return aIWorkloadConfigResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.AIWorkloadConfig result)
    {
        base.CreateChildren(result);

        result.DatasetConfig ??= DatasetConfigFactory?.Build();
        result.AIWorkloadConfigs ??= AIWorkloadConfigsFactory?.Build();
    }

} // End Of Class

public static class AIWorkloadConfigFactoryExtensions
{
    public static CombinedResult<AIWorkloadConfigFactory, InnerAIWorkloadConfigAIDatasetConfigFactory> WithDatasetConfig(this AIWorkloadConfigFactory parentFactory, Action<Humidifier.SageMaker.AIWorkloadConfigTypes.AIDatasetConfig> subFactoryAction = null)
    {
        parentFactory.DatasetConfigFactory = new InnerAIWorkloadConfigAIDatasetConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DatasetConfigFactory);
    }

    public static CombinedResult<AIWorkloadConfigFactory, InnerAIWorkloadConfigAIWorkloadConfigsFactory> WithAIWorkloadConfigs(this AIWorkloadConfigFactory parentFactory, Action<Humidifier.SageMaker.AIWorkloadConfigTypes.AIWorkloadConfigs> subFactoryAction = null)
    {
        parentFactory.AIWorkloadConfigsFactory = new InnerAIWorkloadConfigAIWorkloadConfigsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AIWorkloadConfigsFactory);
    }

    public static CombinedResult<AIWorkloadConfigFactory, T1, InnerAIWorkloadConfigAIDatasetConfigFactory> WithDatasetConfig<T1>(this CombinedResult<AIWorkloadConfigFactory, T1> combinedResult, Action<Humidifier.SageMaker.AIWorkloadConfigTypes.AIDatasetConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithDatasetConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AIWorkloadConfigFactory, InnerAIWorkloadConfigAIDatasetConfigFactory> WithDatasetConfig<T1>(this CombinedResult<T1, AIWorkloadConfigFactory> combinedResult, Action<Humidifier.SageMaker.AIWorkloadConfigTypes.AIDatasetConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithDatasetConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<AIWorkloadConfigFactory, T1, T2, InnerAIWorkloadConfigAIDatasetConfigFactory> WithDatasetConfig<T1, T2>(this CombinedResult<AIWorkloadConfigFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.AIWorkloadConfigTypes.AIDatasetConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDatasetConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AIWorkloadConfigFactory, T2, InnerAIWorkloadConfigAIDatasetConfigFactory> WithDatasetConfig<T1, T2>(this CombinedResult<T1, AIWorkloadConfigFactory, T2> combinedResult, Action<Humidifier.SageMaker.AIWorkloadConfigTypes.AIDatasetConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDatasetConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AIWorkloadConfigFactory, InnerAIWorkloadConfigAIDatasetConfigFactory> WithDatasetConfig<T1, T2>(this CombinedResult<T1, T2, AIWorkloadConfigFactory> combinedResult, Action<Humidifier.SageMaker.AIWorkloadConfigTypes.AIDatasetConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDatasetConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<AIWorkloadConfigFactory, T1, T2, T3, InnerAIWorkloadConfigAIDatasetConfigFactory> WithDatasetConfig<T1, T2, T3>(this CombinedResult<AIWorkloadConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.AIWorkloadConfigTypes.AIDatasetConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AIWorkloadConfigFactory, T2, T3, InnerAIWorkloadConfigAIDatasetConfigFactory> WithDatasetConfig<T1, T2, T3>(this CombinedResult<T1, AIWorkloadConfigFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.AIWorkloadConfigTypes.AIDatasetConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AIWorkloadConfigFactory, T3, InnerAIWorkloadConfigAIDatasetConfigFactory> WithDatasetConfig<T1, T2, T3>(this CombinedResult<T1, T2, AIWorkloadConfigFactory, T3> combinedResult, Action<Humidifier.SageMaker.AIWorkloadConfigTypes.AIDatasetConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AIWorkloadConfigFactory, InnerAIWorkloadConfigAIDatasetConfigFactory> WithDatasetConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, AIWorkloadConfigFactory> combinedResult, Action<Humidifier.SageMaker.AIWorkloadConfigTypes.AIDatasetConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<AIWorkloadConfigFactory, T1, T2, T3, T4, InnerAIWorkloadConfigAIDatasetConfigFactory> WithDatasetConfig<T1, T2, T3, T4>(this CombinedResult<AIWorkloadConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.AIWorkloadConfigTypes.AIDatasetConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AIWorkloadConfigFactory, T2, T3, T4, InnerAIWorkloadConfigAIDatasetConfigFactory> WithDatasetConfig<T1, T2, T3, T4>(this CombinedResult<T1, AIWorkloadConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.AIWorkloadConfigTypes.AIDatasetConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AIWorkloadConfigFactory, T3, T4, InnerAIWorkloadConfigAIDatasetConfigFactory> WithDatasetConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, AIWorkloadConfigFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.AIWorkloadConfigTypes.AIDatasetConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AIWorkloadConfigFactory, T4, InnerAIWorkloadConfigAIDatasetConfigFactory> WithDatasetConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AIWorkloadConfigFactory, T4> combinedResult, Action<Humidifier.SageMaker.AIWorkloadConfigTypes.AIDatasetConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, AIWorkloadConfigFactory, InnerAIWorkloadConfigAIDatasetConfigFactory> WithDatasetConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AIWorkloadConfigFactory> combinedResult, Action<Humidifier.SageMaker.AIWorkloadConfigTypes.AIDatasetConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetConfig(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<AIWorkloadConfigFactory, T1, InnerAIWorkloadConfigAIWorkloadConfigsFactory> WithAIWorkloadConfigs<T1>(this CombinedResult<AIWorkloadConfigFactory, T1> combinedResult, Action<Humidifier.SageMaker.AIWorkloadConfigTypes.AIWorkloadConfigs> subFactoryAction = null) => new (combinedResult, combinedResult, WithAIWorkloadConfigs(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AIWorkloadConfigFactory, InnerAIWorkloadConfigAIWorkloadConfigsFactory> WithAIWorkloadConfigs<T1>(this CombinedResult<T1, AIWorkloadConfigFactory> combinedResult, Action<Humidifier.SageMaker.AIWorkloadConfigTypes.AIWorkloadConfigs> subFactoryAction = null) => new (combinedResult, combinedResult, WithAIWorkloadConfigs(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<AIWorkloadConfigFactory, T1, T2, InnerAIWorkloadConfigAIWorkloadConfigsFactory> WithAIWorkloadConfigs<T1, T2>(this CombinedResult<AIWorkloadConfigFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.AIWorkloadConfigTypes.AIWorkloadConfigs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAIWorkloadConfigs(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AIWorkloadConfigFactory, T2, InnerAIWorkloadConfigAIWorkloadConfigsFactory> WithAIWorkloadConfigs<T1, T2>(this CombinedResult<T1, AIWorkloadConfigFactory, T2> combinedResult, Action<Humidifier.SageMaker.AIWorkloadConfigTypes.AIWorkloadConfigs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAIWorkloadConfigs(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AIWorkloadConfigFactory, InnerAIWorkloadConfigAIWorkloadConfigsFactory> WithAIWorkloadConfigs<T1, T2>(this CombinedResult<T1, T2, AIWorkloadConfigFactory> combinedResult, Action<Humidifier.SageMaker.AIWorkloadConfigTypes.AIWorkloadConfigs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAIWorkloadConfigs(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<AIWorkloadConfigFactory, T1, T2, T3, InnerAIWorkloadConfigAIWorkloadConfigsFactory> WithAIWorkloadConfigs<T1, T2, T3>(this CombinedResult<AIWorkloadConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.AIWorkloadConfigTypes.AIWorkloadConfigs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAIWorkloadConfigs(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AIWorkloadConfigFactory, T2, T3, InnerAIWorkloadConfigAIWorkloadConfigsFactory> WithAIWorkloadConfigs<T1, T2, T3>(this CombinedResult<T1, AIWorkloadConfigFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.AIWorkloadConfigTypes.AIWorkloadConfigs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAIWorkloadConfigs(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AIWorkloadConfigFactory, T3, InnerAIWorkloadConfigAIWorkloadConfigsFactory> WithAIWorkloadConfigs<T1, T2, T3>(this CombinedResult<T1, T2, AIWorkloadConfigFactory, T3> combinedResult, Action<Humidifier.SageMaker.AIWorkloadConfigTypes.AIWorkloadConfigs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAIWorkloadConfigs(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AIWorkloadConfigFactory, InnerAIWorkloadConfigAIWorkloadConfigsFactory> WithAIWorkloadConfigs<T1, T2, T3>(this CombinedResult<T1, T2, T3, AIWorkloadConfigFactory> combinedResult, Action<Humidifier.SageMaker.AIWorkloadConfigTypes.AIWorkloadConfigs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAIWorkloadConfigs(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<AIWorkloadConfigFactory, T1, T2, T3, T4, InnerAIWorkloadConfigAIWorkloadConfigsFactory> WithAIWorkloadConfigs<T1, T2, T3, T4>(this CombinedResult<AIWorkloadConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.AIWorkloadConfigTypes.AIWorkloadConfigs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAIWorkloadConfigs(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AIWorkloadConfigFactory, T2, T3, T4, InnerAIWorkloadConfigAIWorkloadConfigsFactory> WithAIWorkloadConfigs<T1, T2, T3, T4>(this CombinedResult<T1, AIWorkloadConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.AIWorkloadConfigTypes.AIWorkloadConfigs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAIWorkloadConfigs(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AIWorkloadConfigFactory, T3, T4, InnerAIWorkloadConfigAIWorkloadConfigsFactory> WithAIWorkloadConfigs<T1, T2, T3, T4>(this CombinedResult<T1, T2, AIWorkloadConfigFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.AIWorkloadConfigTypes.AIWorkloadConfigs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAIWorkloadConfigs(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AIWorkloadConfigFactory, T4, InnerAIWorkloadConfigAIWorkloadConfigsFactory> WithAIWorkloadConfigs<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AIWorkloadConfigFactory, T4> combinedResult, Action<Humidifier.SageMaker.AIWorkloadConfigTypes.AIWorkloadConfigs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAIWorkloadConfigs(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, AIWorkloadConfigFactory, InnerAIWorkloadConfigAIWorkloadConfigsFactory> WithAIWorkloadConfigs<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AIWorkloadConfigFactory> combinedResult, Action<Humidifier.SageMaker.AIWorkloadConfigTypes.AIWorkloadConfigs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAIWorkloadConfigs(combinedResult.T5, subFactoryAction).T2);
}
