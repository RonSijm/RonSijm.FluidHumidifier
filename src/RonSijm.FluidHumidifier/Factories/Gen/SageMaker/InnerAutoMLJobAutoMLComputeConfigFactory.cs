// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerAutoMLJobAutoMLComputeConfigFactory(Action<Humidifier.SageMaker.AutoMLJobTypes.AutoMLComputeConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.AutoMLJobTypes.AutoMLComputeConfig>
{

    internal InnerAutoMLJobEmrServerlessComputeConfigFactory EmrServerlessComputeConfigFactory { get; set; }

    protected override Humidifier.SageMaker.AutoMLJobTypes.AutoMLComputeConfig Create()
    {
        var autoMLComputeConfigResult = CreateAutoMLComputeConfig();
        factoryAction?.Invoke(autoMLComputeConfigResult);

        return autoMLComputeConfigResult;
    }

    private Humidifier.SageMaker.AutoMLJobTypes.AutoMLComputeConfig CreateAutoMLComputeConfig()
    {
        var autoMLComputeConfigResult = new Humidifier.SageMaker.AutoMLJobTypes.AutoMLComputeConfig();

        return autoMLComputeConfigResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.AutoMLJobTypes.AutoMLComputeConfig result)
    {
        base.CreateChildren(result);

        result.EmrServerlessComputeConfig ??= EmrServerlessComputeConfigFactory?.Build();
    }

} // End Of Class

public static class InnerAutoMLJobAutoMLComputeConfigFactoryExtensions
{
    public static CombinedResult<InnerAutoMLJobAutoMLComputeConfigFactory, InnerAutoMLJobEmrServerlessComputeConfigFactory> WithEmrServerlessComputeConfig(this InnerAutoMLJobAutoMLComputeConfigFactory parentFactory, Action<Humidifier.SageMaker.AutoMLJobTypes.EmrServerlessComputeConfig> subFactoryAction = null)
    {
        parentFactory.EmrServerlessComputeConfigFactory = new InnerAutoMLJobEmrServerlessComputeConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EmrServerlessComputeConfigFactory);
    }

    public static CombinedResult<InnerAutoMLJobAutoMLComputeConfigFactory, T1, InnerAutoMLJobEmrServerlessComputeConfigFactory> WithEmrServerlessComputeConfig<T1>(this CombinedResult<InnerAutoMLJobAutoMLComputeConfigFactory, T1> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.EmrServerlessComputeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithEmrServerlessComputeConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAutoMLJobAutoMLComputeConfigFactory, InnerAutoMLJobEmrServerlessComputeConfigFactory> WithEmrServerlessComputeConfig<T1>(this CombinedResult<T1, InnerAutoMLJobAutoMLComputeConfigFactory> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.EmrServerlessComputeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithEmrServerlessComputeConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerAutoMLJobAutoMLComputeConfigFactory, T1, T2, InnerAutoMLJobEmrServerlessComputeConfigFactory> WithEmrServerlessComputeConfig<T1, T2>(this CombinedResult<InnerAutoMLJobAutoMLComputeConfigFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.EmrServerlessComputeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEmrServerlessComputeConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAutoMLJobAutoMLComputeConfigFactory, T2, InnerAutoMLJobEmrServerlessComputeConfigFactory> WithEmrServerlessComputeConfig<T1, T2>(this CombinedResult<T1, InnerAutoMLJobAutoMLComputeConfigFactory, T2> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.EmrServerlessComputeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEmrServerlessComputeConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAutoMLJobAutoMLComputeConfigFactory, InnerAutoMLJobEmrServerlessComputeConfigFactory> WithEmrServerlessComputeConfig<T1, T2>(this CombinedResult<T1, T2, InnerAutoMLJobAutoMLComputeConfigFactory> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.EmrServerlessComputeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEmrServerlessComputeConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerAutoMLJobAutoMLComputeConfigFactory, T1, T2, T3, InnerAutoMLJobEmrServerlessComputeConfigFactory> WithEmrServerlessComputeConfig<T1, T2, T3>(this CombinedResult<InnerAutoMLJobAutoMLComputeConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.EmrServerlessComputeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEmrServerlessComputeConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAutoMLJobAutoMLComputeConfigFactory, T2, T3, InnerAutoMLJobEmrServerlessComputeConfigFactory> WithEmrServerlessComputeConfig<T1, T2, T3>(this CombinedResult<T1, InnerAutoMLJobAutoMLComputeConfigFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.EmrServerlessComputeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEmrServerlessComputeConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAutoMLJobAutoMLComputeConfigFactory, T3, InnerAutoMLJobEmrServerlessComputeConfigFactory> WithEmrServerlessComputeConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerAutoMLJobAutoMLComputeConfigFactory, T3> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.EmrServerlessComputeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEmrServerlessComputeConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAutoMLJobAutoMLComputeConfigFactory, InnerAutoMLJobEmrServerlessComputeConfigFactory> WithEmrServerlessComputeConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAutoMLJobAutoMLComputeConfigFactory> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.EmrServerlessComputeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEmrServerlessComputeConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerAutoMLJobAutoMLComputeConfigFactory, T1, T2, T3, T4, InnerAutoMLJobEmrServerlessComputeConfigFactory> WithEmrServerlessComputeConfig<T1, T2, T3, T4>(this CombinedResult<InnerAutoMLJobAutoMLComputeConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.EmrServerlessComputeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEmrServerlessComputeConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAutoMLJobAutoMLComputeConfigFactory, T2, T3, T4, InnerAutoMLJobEmrServerlessComputeConfigFactory> WithEmrServerlessComputeConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerAutoMLJobAutoMLComputeConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.EmrServerlessComputeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEmrServerlessComputeConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAutoMLJobAutoMLComputeConfigFactory, T3, T4, InnerAutoMLJobEmrServerlessComputeConfigFactory> WithEmrServerlessComputeConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAutoMLJobAutoMLComputeConfigFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.EmrServerlessComputeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEmrServerlessComputeConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAutoMLJobAutoMLComputeConfigFactory, T4, InnerAutoMLJobEmrServerlessComputeConfigFactory> WithEmrServerlessComputeConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAutoMLJobAutoMLComputeConfigFactory, T4> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.EmrServerlessComputeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEmrServerlessComputeConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerAutoMLJobAutoMLComputeConfigFactory, InnerAutoMLJobEmrServerlessComputeConfigFactory> WithEmrServerlessComputeConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAutoMLJobAutoMLComputeConfigFactory> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.EmrServerlessComputeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEmrServerlessComputeConfig(combinedResult.T5, subFactoryAction).T2);
}
