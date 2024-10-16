// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Omics;

public class SequenceStoreFactory(string resourceName = null, Action<Humidifier.Omics.SequenceStore> factoryAction = null) : ResourceFactory<Humidifier.Omics.SequenceStore>(resourceName)
{

    internal InnerSequenceStoreSseConfigFactory SseConfigFactory { get; set; }

    protected override Humidifier.Omics.SequenceStore Create()
    {
        var sequenceStoreResult = CreateSequenceStore();
        factoryAction?.Invoke(sequenceStoreResult);

        return sequenceStoreResult;
    }

    private Humidifier.Omics.SequenceStore CreateSequenceStore()
    {
        var sequenceStoreResult = new Humidifier.Omics.SequenceStore
        {
            GivenName = InputResourceName,
        };

        return sequenceStoreResult;
    }
    public override void CreateChildren(Humidifier.Omics.SequenceStore result)
    {
        base.CreateChildren(result);

        result.SseConfig ??= SseConfigFactory?.Build();
    }

} // End Of Class

public static class SequenceStoreFactoryExtensions
{
    public static CombinedResult<SequenceStoreFactory, InnerSequenceStoreSseConfigFactory> WithSseConfig(this SequenceStoreFactory parentFactory, Action<Humidifier.Omics.SequenceStoreTypes.SseConfig> subFactoryAction = null)
    {
        parentFactory.SseConfigFactory = new InnerSequenceStoreSseConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SseConfigFactory);
    }

    public static CombinedResult<SequenceStoreFactory, T1, InnerSequenceStoreSseConfigFactory> WithSseConfig<T1>(this CombinedResult<SequenceStoreFactory, T1> combinedResult, Action<Humidifier.Omics.SequenceStoreTypes.SseConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithSseConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SequenceStoreFactory, InnerSequenceStoreSseConfigFactory> WithSseConfig<T1>(this CombinedResult<T1, SequenceStoreFactory> combinedResult, Action<Humidifier.Omics.SequenceStoreTypes.SseConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithSseConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<SequenceStoreFactory, T1, T2, InnerSequenceStoreSseConfigFactory> WithSseConfig<T1, T2>(this CombinedResult<SequenceStoreFactory, T1, T2> combinedResult, Action<Humidifier.Omics.SequenceStoreTypes.SseConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSseConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SequenceStoreFactory, T2, InnerSequenceStoreSseConfigFactory> WithSseConfig<T1, T2>(this CombinedResult<T1, SequenceStoreFactory, T2> combinedResult, Action<Humidifier.Omics.SequenceStoreTypes.SseConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSseConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SequenceStoreFactory, InnerSequenceStoreSseConfigFactory> WithSseConfig<T1, T2>(this CombinedResult<T1, T2, SequenceStoreFactory> combinedResult, Action<Humidifier.Omics.SequenceStoreTypes.SseConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSseConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<SequenceStoreFactory, T1, T2, T3, InnerSequenceStoreSseConfigFactory> WithSseConfig<T1, T2, T3>(this CombinedResult<SequenceStoreFactory, T1, T2, T3> combinedResult, Action<Humidifier.Omics.SequenceStoreTypes.SseConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSseConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SequenceStoreFactory, T2, T3, InnerSequenceStoreSseConfigFactory> WithSseConfig<T1, T2, T3>(this CombinedResult<T1, SequenceStoreFactory, T2, T3> combinedResult, Action<Humidifier.Omics.SequenceStoreTypes.SseConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSseConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SequenceStoreFactory, T3, InnerSequenceStoreSseConfigFactory> WithSseConfig<T1, T2, T3>(this CombinedResult<T1, T2, SequenceStoreFactory, T3> combinedResult, Action<Humidifier.Omics.SequenceStoreTypes.SseConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSseConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SequenceStoreFactory, InnerSequenceStoreSseConfigFactory> WithSseConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, SequenceStoreFactory> combinedResult, Action<Humidifier.Omics.SequenceStoreTypes.SseConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSseConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<SequenceStoreFactory, T1, T2, T3, T4, InnerSequenceStoreSseConfigFactory> WithSseConfig<T1, T2, T3, T4>(this CombinedResult<SequenceStoreFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Omics.SequenceStoreTypes.SseConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSseConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SequenceStoreFactory, T2, T3, T4, InnerSequenceStoreSseConfigFactory> WithSseConfig<T1, T2, T3, T4>(this CombinedResult<T1, SequenceStoreFactory, T2, T3, T4> combinedResult, Action<Humidifier.Omics.SequenceStoreTypes.SseConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSseConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SequenceStoreFactory, T3, T4, InnerSequenceStoreSseConfigFactory> WithSseConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, SequenceStoreFactory, T3, T4> combinedResult, Action<Humidifier.Omics.SequenceStoreTypes.SseConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSseConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SequenceStoreFactory, T4, InnerSequenceStoreSseConfigFactory> WithSseConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SequenceStoreFactory, T4> combinedResult, Action<Humidifier.Omics.SequenceStoreTypes.SseConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSseConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, SequenceStoreFactory, InnerSequenceStoreSseConfigFactory> WithSseConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SequenceStoreFactory> combinedResult, Action<Humidifier.Omics.SequenceStoreTypes.SseConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSseConfig(combinedResult.T5, subFactoryAction));
}
