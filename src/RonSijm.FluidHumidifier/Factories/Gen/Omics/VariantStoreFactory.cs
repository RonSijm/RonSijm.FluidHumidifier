// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Omics;

public class VariantStoreFactory(string resourceName = null, Action<Humidifier.Omics.VariantStore> factoryAction = null) : ResourceFactory<Humidifier.Omics.VariantStore>(resourceName)
{

    internal InnerVariantStoreReferenceItemFactory ReferenceFactory { get; set; }

    internal InnerVariantStoreSseConfigFactory SseConfigFactory { get; set; }

    protected override Humidifier.Omics.VariantStore Create()
    {
        var variantStoreResult = CreateVariantStore();
        factoryAction?.Invoke(variantStoreResult);

        return variantStoreResult;
    }

    private Humidifier.Omics.VariantStore CreateVariantStore()
    {
        var variantStoreResult = new Humidifier.Omics.VariantStore
        {
            GivenName = InputResourceName,
        };

        return variantStoreResult;
    }
    public override void CreateChildren(Humidifier.Omics.VariantStore result)
    {
        base.CreateChildren(result);

        result.Reference ??= ReferenceFactory?.Build();
        result.SseConfig ??= SseConfigFactory?.Build();
    }

} // End Of Class

public static class VariantStoreFactoryExtensions
{
    public static CombinedResult<VariantStoreFactory, InnerVariantStoreReferenceItemFactory> WithReference(this VariantStoreFactory parentFactory, Action<Humidifier.Omics.VariantStoreTypes.ReferenceItem> subFactoryAction = null)
    {
        parentFactory.ReferenceFactory = new InnerVariantStoreReferenceItemFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ReferenceFactory);
    }

    public static CombinedResult<VariantStoreFactory, InnerVariantStoreSseConfigFactory> WithSseConfig(this VariantStoreFactory parentFactory, Action<Humidifier.Omics.VariantStoreTypes.SseConfig> subFactoryAction = null)
    {
        parentFactory.SseConfigFactory = new InnerVariantStoreSseConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SseConfigFactory);
    }

    public static CombinedResult<VariantStoreFactory, T1, InnerVariantStoreReferenceItemFactory> WithReference<T1>(this CombinedResult<VariantStoreFactory, T1> combinedResult, Action<Humidifier.Omics.VariantStoreTypes.ReferenceItem> subFactoryAction = null) => new (combinedResult, combinedResult, WithReference(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, VariantStoreFactory, InnerVariantStoreReferenceItemFactory> WithReference<T1>(this CombinedResult<T1, VariantStoreFactory> combinedResult, Action<Humidifier.Omics.VariantStoreTypes.ReferenceItem> subFactoryAction = null) => new (combinedResult, combinedResult, WithReference(combinedResult.T2, subFactoryAction));
    public static CombinedResult<VariantStoreFactory, T1, T2, InnerVariantStoreReferenceItemFactory> WithReference<T1, T2>(this CombinedResult<VariantStoreFactory, T1, T2> combinedResult, Action<Humidifier.Omics.VariantStoreTypes.ReferenceItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReference(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, VariantStoreFactory, T2, InnerVariantStoreReferenceItemFactory> WithReference<T1, T2>(this CombinedResult<T1, VariantStoreFactory, T2> combinedResult, Action<Humidifier.Omics.VariantStoreTypes.ReferenceItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReference(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, VariantStoreFactory, InnerVariantStoreReferenceItemFactory> WithReference<T1, T2>(this CombinedResult<T1, T2, VariantStoreFactory> combinedResult, Action<Humidifier.Omics.VariantStoreTypes.ReferenceItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReference(combinedResult.T3, subFactoryAction));
    public static CombinedResult<VariantStoreFactory, T1, T2, T3, InnerVariantStoreReferenceItemFactory> WithReference<T1, T2, T3>(this CombinedResult<VariantStoreFactory, T1, T2, T3> combinedResult, Action<Humidifier.Omics.VariantStoreTypes.ReferenceItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReference(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, VariantStoreFactory, T2, T3, InnerVariantStoreReferenceItemFactory> WithReference<T1, T2, T3>(this CombinedResult<T1, VariantStoreFactory, T2, T3> combinedResult, Action<Humidifier.Omics.VariantStoreTypes.ReferenceItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReference(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, VariantStoreFactory, T3, InnerVariantStoreReferenceItemFactory> WithReference<T1, T2, T3>(this CombinedResult<T1, T2, VariantStoreFactory, T3> combinedResult, Action<Humidifier.Omics.VariantStoreTypes.ReferenceItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReference(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, VariantStoreFactory, InnerVariantStoreReferenceItemFactory> WithReference<T1, T2, T3>(this CombinedResult<T1, T2, T3, VariantStoreFactory> combinedResult, Action<Humidifier.Omics.VariantStoreTypes.ReferenceItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReference(combinedResult.T4, subFactoryAction));
    public static CombinedResult<VariantStoreFactory, T1, T2, T3, T4, InnerVariantStoreReferenceItemFactory> WithReference<T1, T2, T3, T4>(this CombinedResult<VariantStoreFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Omics.VariantStoreTypes.ReferenceItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReference(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, VariantStoreFactory, T2, T3, T4, InnerVariantStoreReferenceItemFactory> WithReference<T1, T2, T3, T4>(this CombinedResult<T1, VariantStoreFactory, T2, T3, T4> combinedResult, Action<Humidifier.Omics.VariantStoreTypes.ReferenceItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReference(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, VariantStoreFactory, T3, T4, InnerVariantStoreReferenceItemFactory> WithReference<T1, T2, T3, T4>(this CombinedResult<T1, T2, VariantStoreFactory, T3, T4> combinedResult, Action<Humidifier.Omics.VariantStoreTypes.ReferenceItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReference(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, VariantStoreFactory, T4, InnerVariantStoreReferenceItemFactory> WithReference<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, VariantStoreFactory, T4> combinedResult, Action<Humidifier.Omics.VariantStoreTypes.ReferenceItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReference(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, VariantStoreFactory, InnerVariantStoreReferenceItemFactory> WithReference<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, VariantStoreFactory> combinedResult, Action<Humidifier.Omics.VariantStoreTypes.ReferenceItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReference(combinedResult.T5, subFactoryAction));
    public static CombinedResult<VariantStoreFactory, T1, InnerVariantStoreSseConfigFactory> WithSseConfig<T1>(this CombinedResult<VariantStoreFactory, T1> combinedResult, Action<Humidifier.Omics.VariantStoreTypes.SseConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithSseConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, VariantStoreFactory, InnerVariantStoreSseConfigFactory> WithSseConfig<T1>(this CombinedResult<T1, VariantStoreFactory> combinedResult, Action<Humidifier.Omics.VariantStoreTypes.SseConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithSseConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<VariantStoreFactory, T1, T2, InnerVariantStoreSseConfigFactory> WithSseConfig<T1, T2>(this CombinedResult<VariantStoreFactory, T1, T2> combinedResult, Action<Humidifier.Omics.VariantStoreTypes.SseConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSseConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, VariantStoreFactory, T2, InnerVariantStoreSseConfigFactory> WithSseConfig<T1, T2>(this CombinedResult<T1, VariantStoreFactory, T2> combinedResult, Action<Humidifier.Omics.VariantStoreTypes.SseConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSseConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, VariantStoreFactory, InnerVariantStoreSseConfigFactory> WithSseConfig<T1, T2>(this CombinedResult<T1, T2, VariantStoreFactory> combinedResult, Action<Humidifier.Omics.VariantStoreTypes.SseConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSseConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<VariantStoreFactory, T1, T2, T3, InnerVariantStoreSseConfigFactory> WithSseConfig<T1, T2, T3>(this CombinedResult<VariantStoreFactory, T1, T2, T3> combinedResult, Action<Humidifier.Omics.VariantStoreTypes.SseConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSseConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, VariantStoreFactory, T2, T3, InnerVariantStoreSseConfigFactory> WithSseConfig<T1, T2, T3>(this CombinedResult<T1, VariantStoreFactory, T2, T3> combinedResult, Action<Humidifier.Omics.VariantStoreTypes.SseConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSseConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, VariantStoreFactory, T3, InnerVariantStoreSseConfigFactory> WithSseConfig<T1, T2, T3>(this CombinedResult<T1, T2, VariantStoreFactory, T3> combinedResult, Action<Humidifier.Omics.VariantStoreTypes.SseConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSseConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, VariantStoreFactory, InnerVariantStoreSseConfigFactory> WithSseConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, VariantStoreFactory> combinedResult, Action<Humidifier.Omics.VariantStoreTypes.SseConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSseConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<VariantStoreFactory, T1, T2, T3, T4, InnerVariantStoreSseConfigFactory> WithSseConfig<T1, T2, T3, T4>(this CombinedResult<VariantStoreFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Omics.VariantStoreTypes.SseConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSseConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, VariantStoreFactory, T2, T3, T4, InnerVariantStoreSseConfigFactory> WithSseConfig<T1, T2, T3, T4>(this CombinedResult<T1, VariantStoreFactory, T2, T3, T4> combinedResult, Action<Humidifier.Omics.VariantStoreTypes.SseConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSseConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, VariantStoreFactory, T3, T4, InnerVariantStoreSseConfigFactory> WithSseConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, VariantStoreFactory, T3, T4> combinedResult, Action<Humidifier.Omics.VariantStoreTypes.SseConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSseConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, VariantStoreFactory, T4, InnerVariantStoreSseConfigFactory> WithSseConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, VariantStoreFactory, T4> combinedResult, Action<Humidifier.Omics.VariantStoreTypes.SseConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSseConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, VariantStoreFactory, InnerVariantStoreSseConfigFactory> WithSseConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, VariantStoreFactory> combinedResult, Action<Humidifier.Omics.VariantStoreTypes.SseConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSseConfig(combinedResult.T5, subFactoryAction));
}
