// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Omics;

public class ReferenceStoreFactory(string resourceName = null, Action<Humidifier.Omics.ReferenceStore> factoryAction = null) : ResourceFactory<Humidifier.Omics.ReferenceStore>(resourceName)
{

    internal InnerReferenceStoreSseConfigFactory SseConfigFactory { get; set; }

    protected override Humidifier.Omics.ReferenceStore Create()
    {
        var referenceStoreResult = CreateReferenceStore();
        factoryAction?.Invoke(referenceStoreResult);

        return referenceStoreResult;
    }

    private Humidifier.Omics.ReferenceStore CreateReferenceStore()
    {
        var referenceStoreResult = new Humidifier.Omics.ReferenceStore
        {
            GivenName = InputResourceName,
        };

        return referenceStoreResult;
    }
    public override void CreateChildren(Humidifier.Omics.ReferenceStore result)
    {
        base.CreateChildren(result);

        result.SseConfig ??= SseConfigFactory?.Build();
    }

} // End Of Class

public static class ReferenceStoreFactoryExtensions
{
    public static CombinedResult<ReferenceStoreFactory, InnerReferenceStoreSseConfigFactory> WithSseConfig(this ReferenceStoreFactory parentFactory, Action<Humidifier.Omics.ReferenceStoreTypes.SseConfig> subFactoryAction = null)
    {
        parentFactory.SseConfigFactory = new InnerReferenceStoreSseConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SseConfigFactory);
    }

    public static CombinedResult<ReferenceStoreFactory, T1, InnerReferenceStoreSseConfigFactory> WithSseConfig<T1>(this CombinedResult<ReferenceStoreFactory, T1> combinedResult, Action<Humidifier.Omics.ReferenceStoreTypes.SseConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithSseConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ReferenceStoreFactory, InnerReferenceStoreSseConfigFactory> WithSseConfig<T1>(this CombinedResult<T1, ReferenceStoreFactory> combinedResult, Action<Humidifier.Omics.ReferenceStoreTypes.SseConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithSseConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ReferenceStoreFactory, T1, T2, InnerReferenceStoreSseConfigFactory> WithSseConfig<T1, T2>(this CombinedResult<ReferenceStoreFactory, T1, T2> combinedResult, Action<Humidifier.Omics.ReferenceStoreTypes.SseConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSseConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ReferenceStoreFactory, T2, InnerReferenceStoreSseConfigFactory> WithSseConfig<T1, T2>(this CombinedResult<T1, ReferenceStoreFactory, T2> combinedResult, Action<Humidifier.Omics.ReferenceStoreTypes.SseConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSseConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ReferenceStoreFactory, InnerReferenceStoreSseConfigFactory> WithSseConfig<T1, T2>(this CombinedResult<T1, T2, ReferenceStoreFactory> combinedResult, Action<Humidifier.Omics.ReferenceStoreTypes.SseConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSseConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ReferenceStoreFactory, T1, T2, T3, InnerReferenceStoreSseConfigFactory> WithSseConfig<T1, T2, T3>(this CombinedResult<ReferenceStoreFactory, T1, T2, T3> combinedResult, Action<Humidifier.Omics.ReferenceStoreTypes.SseConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSseConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ReferenceStoreFactory, T2, T3, InnerReferenceStoreSseConfigFactory> WithSseConfig<T1, T2, T3>(this CombinedResult<T1, ReferenceStoreFactory, T2, T3> combinedResult, Action<Humidifier.Omics.ReferenceStoreTypes.SseConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSseConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ReferenceStoreFactory, T3, InnerReferenceStoreSseConfigFactory> WithSseConfig<T1, T2, T3>(this CombinedResult<T1, T2, ReferenceStoreFactory, T3> combinedResult, Action<Humidifier.Omics.ReferenceStoreTypes.SseConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSseConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ReferenceStoreFactory, InnerReferenceStoreSseConfigFactory> WithSseConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, ReferenceStoreFactory> combinedResult, Action<Humidifier.Omics.ReferenceStoreTypes.SseConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSseConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ReferenceStoreFactory, T1, T2, T3, T4, InnerReferenceStoreSseConfigFactory> WithSseConfig<T1, T2, T3, T4>(this CombinedResult<ReferenceStoreFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Omics.ReferenceStoreTypes.SseConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSseConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ReferenceStoreFactory, T2, T3, T4, InnerReferenceStoreSseConfigFactory> WithSseConfig<T1, T2, T3, T4>(this CombinedResult<T1, ReferenceStoreFactory, T2, T3, T4> combinedResult, Action<Humidifier.Omics.ReferenceStoreTypes.SseConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSseConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ReferenceStoreFactory, T3, T4, InnerReferenceStoreSseConfigFactory> WithSseConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, ReferenceStoreFactory, T3, T4> combinedResult, Action<Humidifier.Omics.ReferenceStoreTypes.SseConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSseConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ReferenceStoreFactory, T4, InnerReferenceStoreSseConfigFactory> WithSseConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ReferenceStoreFactory, T4> combinedResult, Action<Humidifier.Omics.ReferenceStoreTypes.SseConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSseConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ReferenceStoreFactory, InnerReferenceStoreSseConfigFactory> WithSseConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ReferenceStoreFactory> combinedResult, Action<Humidifier.Omics.ReferenceStoreTypes.SseConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSseConfig(combinedResult.T5, subFactoryAction));
}
