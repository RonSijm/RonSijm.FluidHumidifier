// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Omics;

public class AnnotationStoreFactory(string resourceName = null, Action<Humidifier.Omics.AnnotationStore> factoryAction = null) : ResourceFactory<Humidifier.Omics.AnnotationStore>(resourceName)
{

    internal InnerAnnotationStoreReferenceItemFactory ReferenceFactory { get; set; }

    internal InnerAnnotationStoreSseConfigFactory SseConfigFactory { get; set; }

    internal InnerAnnotationStoreStoreOptionsFactory StoreOptionsFactory { get; set; }

    protected override Humidifier.Omics.AnnotationStore Create()
    {
        var annotationStoreResult = CreateAnnotationStore();
        factoryAction?.Invoke(annotationStoreResult);

        return annotationStoreResult;
    }

    private Humidifier.Omics.AnnotationStore CreateAnnotationStore()
    {
        var annotationStoreResult = new Humidifier.Omics.AnnotationStore
        {
            GivenName = InputResourceName,
        };

        return annotationStoreResult;
    }
    public override void CreateChildren(Humidifier.Omics.AnnotationStore result)
    {
        base.CreateChildren(result);

        result.Reference ??= ReferenceFactory?.Build();
        result.SseConfig ??= SseConfigFactory?.Build();
        result.StoreOptions ??= StoreOptionsFactory?.Build();
    }

} // End Of Class

public static class AnnotationStoreFactoryExtensions
{
    public static CombinedResult<AnnotationStoreFactory, InnerAnnotationStoreReferenceItemFactory> WithReference(this AnnotationStoreFactory parentFactory, Action<Humidifier.Omics.AnnotationStoreTypes.ReferenceItem> subFactoryAction = null)
    {
        parentFactory.ReferenceFactory = new InnerAnnotationStoreReferenceItemFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ReferenceFactory);
    }

    public static CombinedResult<AnnotationStoreFactory, InnerAnnotationStoreSseConfigFactory> WithSseConfig(this AnnotationStoreFactory parentFactory, Action<Humidifier.Omics.AnnotationStoreTypes.SseConfig> subFactoryAction = null)
    {
        parentFactory.SseConfigFactory = new InnerAnnotationStoreSseConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SseConfigFactory);
    }

    public static CombinedResult<AnnotationStoreFactory, InnerAnnotationStoreStoreOptionsFactory> WithStoreOptions(this AnnotationStoreFactory parentFactory, Action<Humidifier.Omics.AnnotationStoreTypes.StoreOptions> subFactoryAction = null)
    {
        parentFactory.StoreOptionsFactory = new InnerAnnotationStoreStoreOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.StoreOptionsFactory);
    }

    public static CombinedResult<AnnotationStoreFactory, T1, InnerAnnotationStoreReferenceItemFactory> WithReference<T1>(this CombinedResult<AnnotationStoreFactory, T1> combinedResult, Action<Humidifier.Omics.AnnotationStoreTypes.ReferenceItem> subFactoryAction = null) => new (combinedResult, combinedResult, WithReference(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AnnotationStoreFactory, InnerAnnotationStoreReferenceItemFactory> WithReference<T1>(this CombinedResult<T1, AnnotationStoreFactory> combinedResult, Action<Humidifier.Omics.AnnotationStoreTypes.ReferenceItem> subFactoryAction = null) => new (combinedResult, combinedResult, WithReference(combinedResult.T2, subFactoryAction));
    public static CombinedResult<AnnotationStoreFactory, T1, T2, InnerAnnotationStoreReferenceItemFactory> WithReference<T1, T2>(this CombinedResult<AnnotationStoreFactory, T1, T2> combinedResult, Action<Humidifier.Omics.AnnotationStoreTypes.ReferenceItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReference(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AnnotationStoreFactory, T2, InnerAnnotationStoreReferenceItemFactory> WithReference<T1, T2>(this CombinedResult<T1, AnnotationStoreFactory, T2> combinedResult, Action<Humidifier.Omics.AnnotationStoreTypes.ReferenceItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReference(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AnnotationStoreFactory, InnerAnnotationStoreReferenceItemFactory> WithReference<T1, T2>(this CombinedResult<T1, T2, AnnotationStoreFactory> combinedResult, Action<Humidifier.Omics.AnnotationStoreTypes.ReferenceItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReference(combinedResult.T3, subFactoryAction));
    public static CombinedResult<AnnotationStoreFactory, T1, T2, T3, InnerAnnotationStoreReferenceItemFactory> WithReference<T1, T2, T3>(this CombinedResult<AnnotationStoreFactory, T1, T2, T3> combinedResult, Action<Humidifier.Omics.AnnotationStoreTypes.ReferenceItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReference(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AnnotationStoreFactory, T2, T3, InnerAnnotationStoreReferenceItemFactory> WithReference<T1, T2, T3>(this CombinedResult<T1, AnnotationStoreFactory, T2, T3> combinedResult, Action<Humidifier.Omics.AnnotationStoreTypes.ReferenceItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReference(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AnnotationStoreFactory, T3, InnerAnnotationStoreReferenceItemFactory> WithReference<T1, T2, T3>(this CombinedResult<T1, T2, AnnotationStoreFactory, T3> combinedResult, Action<Humidifier.Omics.AnnotationStoreTypes.ReferenceItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReference(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AnnotationStoreFactory, InnerAnnotationStoreReferenceItemFactory> WithReference<T1, T2, T3>(this CombinedResult<T1, T2, T3, AnnotationStoreFactory> combinedResult, Action<Humidifier.Omics.AnnotationStoreTypes.ReferenceItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReference(combinedResult.T4, subFactoryAction));
    public static CombinedResult<AnnotationStoreFactory, T1, T2, T3, T4, InnerAnnotationStoreReferenceItemFactory> WithReference<T1, T2, T3, T4>(this CombinedResult<AnnotationStoreFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Omics.AnnotationStoreTypes.ReferenceItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReference(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AnnotationStoreFactory, T2, T3, T4, InnerAnnotationStoreReferenceItemFactory> WithReference<T1, T2, T3, T4>(this CombinedResult<T1, AnnotationStoreFactory, T2, T3, T4> combinedResult, Action<Humidifier.Omics.AnnotationStoreTypes.ReferenceItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReference(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AnnotationStoreFactory, T3, T4, InnerAnnotationStoreReferenceItemFactory> WithReference<T1, T2, T3, T4>(this CombinedResult<T1, T2, AnnotationStoreFactory, T3, T4> combinedResult, Action<Humidifier.Omics.AnnotationStoreTypes.ReferenceItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReference(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AnnotationStoreFactory, T4, InnerAnnotationStoreReferenceItemFactory> WithReference<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AnnotationStoreFactory, T4> combinedResult, Action<Humidifier.Omics.AnnotationStoreTypes.ReferenceItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReference(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, AnnotationStoreFactory, InnerAnnotationStoreReferenceItemFactory> WithReference<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AnnotationStoreFactory> combinedResult, Action<Humidifier.Omics.AnnotationStoreTypes.ReferenceItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReference(combinedResult.T5, subFactoryAction));
    public static CombinedResult<AnnotationStoreFactory, T1, InnerAnnotationStoreSseConfigFactory> WithSseConfig<T1>(this CombinedResult<AnnotationStoreFactory, T1> combinedResult, Action<Humidifier.Omics.AnnotationStoreTypes.SseConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithSseConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AnnotationStoreFactory, InnerAnnotationStoreSseConfigFactory> WithSseConfig<T1>(this CombinedResult<T1, AnnotationStoreFactory> combinedResult, Action<Humidifier.Omics.AnnotationStoreTypes.SseConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithSseConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<AnnotationStoreFactory, T1, T2, InnerAnnotationStoreSseConfigFactory> WithSseConfig<T1, T2>(this CombinedResult<AnnotationStoreFactory, T1, T2> combinedResult, Action<Humidifier.Omics.AnnotationStoreTypes.SseConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSseConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AnnotationStoreFactory, T2, InnerAnnotationStoreSseConfigFactory> WithSseConfig<T1, T2>(this CombinedResult<T1, AnnotationStoreFactory, T2> combinedResult, Action<Humidifier.Omics.AnnotationStoreTypes.SseConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSseConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AnnotationStoreFactory, InnerAnnotationStoreSseConfigFactory> WithSseConfig<T1, T2>(this CombinedResult<T1, T2, AnnotationStoreFactory> combinedResult, Action<Humidifier.Omics.AnnotationStoreTypes.SseConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSseConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<AnnotationStoreFactory, T1, T2, T3, InnerAnnotationStoreSseConfigFactory> WithSseConfig<T1, T2, T3>(this CombinedResult<AnnotationStoreFactory, T1, T2, T3> combinedResult, Action<Humidifier.Omics.AnnotationStoreTypes.SseConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSseConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AnnotationStoreFactory, T2, T3, InnerAnnotationStoreSseConfigFactory> WithSseConfig<T1, T2, T3>(this CombinedResult<T1, AnnotationStoreFactory, T2, T3> combinedResult, Action<Humidifier.Omics.AnnotationStoreTypes.SseConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSseConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AnnotationStoreFactory, T3, InnerAnnotationStoreSseConfigFactory> WithSseConfig<T1, T2, T3>(this CombinedResult<T1, T2, AnnotationStoreFactory, T3> combinedResult, Action<Humidifier.Omics.AnnotationStoreTypes.SseConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSseConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AnnotationStoreFactory, InnerAnnotationStoreSseConfigFactory> WithSseConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, AnnotationStoreFactory> combinedResult, Action<Humidifier.Omics.AnnotationStoreTypes.SseConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSseConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<AnnotationStoreFactory, T1, T2, T3, T4, InnerAnnotationStoreSseConfigFactory> WithSseConfig<T1, T2, T3, T4>(this CombinedResult<AnnotationStoreFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Omics.AnnotationStoreTypes.SseConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSseConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AnnotationStoreFactory, T2, T3, T4, InnerAnnotationStoreSseConfigFactory> WithSseConfig<T1, T2, T3, T4>(this CombinedResult<T1, AnnotationStoreFactory, T2, T3, T4> combinedResult, Action<Humidifier.Omics.AnnotationStoreTypes.SseConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSseConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AnnotationStoreFactory, T3, T4, InnerAnnotationStoreSseConfigFactory> WithSseConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, AnnotationStoreFactory, T3, T4> combinedResult, Action<Humidifier.Omics.AnnotationStoreTypes.SseConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSseConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AnnotationStoreFactory, T4, InnerAnnotationStoreSseConfigFactory> WithSseConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AnnotationStoreFactory, T4> combinedResult, Action<Humidifier.Omics.AnnotationStoreTypes.SseConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSseConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, AnnotationStoreFactory, InnerAnnotationStoreSseConfigFactory> WithSseConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AnnotationStoreFactory> combinedResult, Action<Humidifier.Omics.AnnotationStoreTypes.SseConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSseConfig(combinedResult.T5, subFactoryAction));
    public static CombinedResult<AnnotationStoreFactory, T1, InnerAnnotationStoreStoreOptionsFactory> WithStoreOptions<T1>(this CombinedResult<AnnotationStoreFactory, T1> combinedResult, Action<Humidifier.Omics.AnnotationStoreTypes.StoreOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithStoreOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AnnotationStoreFactory, InnerAnnotationStoreStoreOptionsFactory> WithStoreOptions<T1>(this CombinedResult<T1, AnnotationStoreFactory> combinedResult, Action<Humidifier.Omics.AnnotationStoreTypes.StoreOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithStoreOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<AnnotationStoreFactory, T1, T2, InnerAnnotationStoreStoreOptionsFactory> WithStoreOptions<T1, T2>(this CombinedResult<AnnotationStoreFactory, T1, T2> combinedResult, Action<Humidifier.Omics.AnnotationStoreTypes.StoreOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStoreOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AnnotationStoreFactory, T2, InnerAnnotationStoreStoreOptionsFactory> WithStoreOptions<T1, T2>(this CombinedResult<T1, AnnotationStoreFactory, T2> combinedResult, Action<Humidifier.Omics.AnnotationStoreTypes.StoreOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStoreOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AnnotationStoreFactory, InnerAnnotationStoreStoreOptionsFactory> WithStoreOptions<T1, T2>(this CombinedResult<T1, T2, AnnotationStoreFactory> combinedResult, Action<Humidifier.Omics.AnnotationStoreTypes.StoreOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStoreOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<AnnotationStoreFactory, T1, T2, T3, InnerAnnotationStoreStoreOptionsFactory> WithStoreOptions<T1, T2, T3>(this CombinedResult<AnnotationStoreFactory, T1, T2, T3> combinedResult, Action<Humidifier.Omics.AnnotationStoreTypes.StoreOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStoreOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AnnotationStoreFactory, T2, T3, InnerAnnotationStoreStoreOptionsFactory> WithStoreOptions<T1, T2, T3>(this CombinedResult<T1, AnnotationStoreFactory, T2, T3> combinedResult, Action<Humidifier.Omics.AnnotationStoreTypes.StoreOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStoreOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AnnotationStoreFactory, T3, InnerAnnotationStoreStoreOptionsFactory> WithStoreOptions<T1, T2, T3>(this CombinedResult<T1, T2, AnnotationStoreFactory, T3> combinedResult, Action<Humidifier.Omics.AnnotationStoreTypes.StoreOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStoreOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AnnotationStoreFactory, InnerAnnotationStoreStoreOptionsFactory> WithStoreOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, AnnotationStoreFactory> combinedResult, Action<Humidifier.Omics.AnnotationStoreTypes.StoreOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStoreOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<AnnotationStoreFactory, T1, T2, T3, T4, InnerAnnotationStoreStoreOptionsFactory> WithStoreOptions<T1, T2, T3, T4>(this CombinedResult<AnnotationStoreFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Omics.AnnotationStoreTypes.StoreOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStoreOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AnnotationStoreFactory, T2, T3, T4, InnerAnnotationStoreStoreOptionsFactory> WithStoreOptions<T1, T2, T3, T4>(this CombinedResult<T1, AnnotationStoreFactory, T2, T3, T4> combinedResult, Action<Humidifier.Omics.AnnotationStoreTypes.StoreOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStoreOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AnnotationStoreFactory, T3, T4, InnerAnnotationStoreStoreOptionsFactory> WithStoreOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, AnnotationStoreFactory, T3, T4> combinedResult, Action<Humidifier.Omics.AnnotationStoreTypes.StoreOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStoreOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AnnotationStoreFactory, T4, InnerAnnotationStoreStoreOptionsFactory> WithStoreOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AnnotationStoreFactory, T4> combinedResult, Action<Humidifier.Omics.AnnotationStoreTypes.StoreOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStoreOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, AnnotationStoreFactory, InnerAnnotationStoreStoreOptionsFactory> WithStoreOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AnnotationStoreFactory> combinedResult, Action<Humidifier.Omics.AnnotationStoreTypes.StoreOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStoreOptions(combinedResult.T5, subFactoryAction));
}
