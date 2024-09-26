// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Omics;

public class InnerAnnotationStoreStoreOptionsFactory(Action<Humidifier.Omics.AnnotationStoreTypes.StoreOptions> factoryAction = null) : SubResourceFactory<Humidifier.Omics.AnnotationStoreTypes.StoreOptions>
{

    internal InnerAnnotationStoreTsvStoreOptionsFactory TsvStoreOptionsFactory { get; set; }

    protected override Humidifier.Omics.AnnotationStoreTypes.StoreOptions Create()
    {
        var storeOptionsResult = CreateStoreOptions();
        factoryAction?.Invoke(storeOptionsResult);

        return storeOptionsResult;
    }

    private Humidifier.Omics.AnnotationStoreTypes.StoreOptions CreateStoreOptions()
    {
        var storeOptionsResult = new Humidifier.Omics.AnnotationStoreTypes.StoreOptions();

        return storeOptionsResult;
    }
    public override void CreateChildren(Humidifier.Omics.AnnotationStoreTypes.StoreOptions result)
    {
        base.CreateChildren(result);

        result.TsvStoreOptions ??= TsvStoreOptionsFactory?.Build();
    }

} // End Of Class

public static class InnerAnnotationStoreStoreOptionsFactoryExtensions
{
    public static CombinedResult<InnerAnnotationStoreStoreOptionsFactory, InnerAnnotationStoreTsvStoreOptionsFactory> WithTsvStoreOptions(this InnerAnnotationStoreStoreOptionsFactory parentFactory, Action<Humidifier.Omics.AnnotationStoreTypes.TsvStoreOptions> subFactoryAction = null)
    {
        parentFactory.TsvStoreOptionsFactory = new InnerAnnotationStoreTsvStoreOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TsvStoreOptionsFactory);
    }

    public static CombinedResult<InnerAnnotationStoreStoreOptionsFactory, T1, InnerAnnotationStoreTsvStoreOptionsFactory> WithTsvStoreOptions<T1>(this CombinedResult<InnerAnnotationStoreStoreOptionsFactory, T1> combinedResult, Action<Humidifier.Omics.AnnotationStoreTypes.TsvStoreOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithTsvStoreOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAnnotationStoreStoreOptionsFactory, InnerAnnotationStoreTsvStoreOptionsFactory> WithTsvStoreOptions<T1>(this CombinedResult<T1, InnerAnnotationStoreStoreOptionsFactory> combinedResult, Action<Humidifier.Omics.AnnotationStoreTypes.TsvStoreOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithTsvStoreOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerAnnotationStoreStoreOptionsFactory, T1, T2, InnerAnnotationStoreTsvStoreOptionsFactory> WithTsvStoreOptions<T1, T2>(this CombinedResult<InnerAnnotationStoreStoreOptionsFactory, T1, T2> combinedResult, Action<Humidifier.Omics.AnnotationStoreTypes.TsvStoreOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTsvStoreOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAnnotationStoreStoreOptionsFactory, T2, InnerAnnotationStoreTsvStoreOptionsFactory> WithTsvStoreOptions<T1, T2>(this CombinedResult<T1, InnerAnnotationStoreStoreOptionsFactory, T2> combinedResult, Action<Humidifier.Omics.AnnotationStoreTypes.TsvStoreOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTsvStoreOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAnnotationStoreStoreOptionsFactory, InnerAnnotationStoreTsvStoreOptionsFactory> WithTsvStoreOptions<T1, T2>(this CombinedResult<T1, T2, InnerAnnotationStoreStoreOptionsFactory> combinedResult, Action<Humidifier.Omics.AnnotationStoreTypes.TsvStoreOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTsvStoreOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerAnnotationStoreStoreOptionsFactory, T1, T2, T3, InnerAnnotationStoreTsvStoreOptionsFactory> WithTsvStoreOptions<T1, T2, T3>(this CombinedResult<InnerAnnotationStoreStoreOptionsFactory, T1, T2, T3> combinedResult, Action<Humidifier.Omics.AnnotationStoreTypes.TsvStoreOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTsvStoreOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAnnotationStoreStoreOptionsFactory, T2, T3, InnerAnnotationStoreTsvStoreOptionsFactory> WithTsvStoreOptions<T1, T2, T3>(this CombinedResult<T1, InnerAnnotationStoreStoreOptionsFactory, T2, T3> combinedResult, Action<Humidifier.Omics.AnnotationStoreTypes.TsvStoreOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTsvStoreOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAnnotationStoreStoreOptionsFactory, T3, InnerAnnotationStoreTsvStoreOptionsFactory> WithTsvStoreOptions<T1, T2, T3>(this CombinedResult<T1, T2, InnerAnnotationStoreStoreOptionsFactory, T3> combinedResult, Action<Humidifier.Omics.AnnotationStoreTypes.TsvStoreOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTsvStoreOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAnnotationStoreStoreOptionsFactory, InnerAnnotationStoreTsvStoreOptionsFactory> WithTsvStoreOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAnnotationStoreStoreOptionsFactory> combinedResult, Action<Humidifier.Omics.AnnotationStoreTypes.TsvStoreOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTsvStoreOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerAnnotationStoreStoreOptionsFactory, T1, T2, T3, T4, InnerAnnotationStoreTsvStoreOptionsFactory> WithTsvStoreOptions<T1, T2, T3, T4>(this CombinedResult<InnerAnnotationStoreStoreOptionsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Omics.AnnotationStoreTypes.TsvStoreOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTsvStoreOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAnnotationStoreStoreOptionsFactory, T2, T3, T4, InnerAnnotationStoreTsvStoreOptionsFactory> WithTsvStoreOptions<T1, T2, T3, T4>(this CombinedResult<T1, InnerAnnotationStoreStoreOptionsFactory, T2, T3, T4> combinedResult, Action<Humidifier.Omics.AnnotationStoreTypes.TsvStoreOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTsvStoreOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAnnotationStoreStoreOptionsFactory, T3, T4, InnerAnnotationStoreTsvStoreOptionsFactory> WithTsvStoreOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAnnotationStoreStoreOptionsFactory, T3, T4> combinedResult, Action<Humidifier.Omics.AnnotationStoreTypes.TsvStoreOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTsvStoreOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAnnotationStoreStoreOptionsFactory, T4, InnerAnnotationStoreTsvStoreOptionsFactory> WithTsvStoreOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAnnotationStoreStoreOptionsFactory, T4> combinedResult, Action<Humidifier.Omics.AnnotationStoreTypes.TsvStoreOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTsvStoreOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerAnnotationStoreStoreOptionsFactory, InnerAnnotationStoreTsvStoreOptionsFactory> WithTsvStoreOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAnnotationStoreStoreOptionsFactory> combinedResult, Action<Humidifier.Omics.AnnotationStoreTypes.TsvStoreOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTsvStoreOptions(combinedResult.T5, subFactoryAction));
}
