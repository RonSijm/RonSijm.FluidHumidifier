// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Evidently;

public class FeatureFactory(string resourceName = null, Action<Humidifier.Evidently.Feature> factoryAction = null) : ResourceFactory<Humidifier.Evidently.Feature>(resourceName)
{

    internal List<InnerFeatureEntityOverrideFactory> EntityOverridesFactories { get; set; } = [];

    internal List<InnerFeatureVariationObjectFactory> VariationsFactories { get; set; } = [];

    protected override Humidifier.Evidently.Feature Create()
    {
        var featureResult = CreateFeature();
        factoryAction?.Invoke(featureResult);

        return featureResult;
    }

    private Humidifier.Evidently.Feature CreateFeature()
    {
        var featureResult = new Humidifier.Evidently.Feature
        {
            GivenName = InputResourceName,
        };

        return featureResult;
    }
    public override void CreateChildren(Humidifier.Evidently.Feature result)
    {
        base.CreateChildren(result);

        result.EntityOverrides = EntityOverridesFactories.Any() ? EntityOverridesFactories.Select(x => x.Build()).ToList() : null;
        result.Variations = VariationsFactories.Any() ? VariationsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class FeatureFactoryExtensions
{
    public static CombinedResult<FeatureFactory, InnerFeatureEntityOverrideFactory> WithEntityOverrides(this FeatureFactory parentFactory, Action<Humidifier.Evidently.FeatureTypes.EntityOverride> subFactoryAction = null)
    {
        var factory = new InnerFeatureEntityOverrideFactory(subFactoryAction);
        parentFactory.EntityOverridesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<FeatureFactory, InnerFeatureVariationObjectFactory> WithVariations(this FeatureFactory parentFactory, Action<Humidifier.Evidently.FeatureTypes.VariationObject> subFactoryAction = null)
    {
        var factory = new InnerFeatureVariationObjectFactory(subFactoryAction);
        parentFactory.VariationsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<FeatureFactory, T1, InnerFeatureEntityOverrideFactory> WithEntityOverrides<T1>(this CombinedResult<FeatureFactory, T1> combinedResult, Action<Humidifier.Evidently.FeatureTypes.EntityOverride> subFactoryAction = null) => new (combinedResult, combinedResult, WithEntityOverrides(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FeatureFactory, InnerFeatureEntityOverrideFactory> WithEntityOverrides<T1>(this CombinedResult<T1, FeatureFactory> combinedResult, Action<Humidifier.Evidently.FeatureTypes.EntityOverride> subFactoryAction = null) => new (combinedResult, combinedResult, WithEntityOverrides(combinedResult.T2, subFactoryAction));
    public static CombinedResult<FeatureFactory, T1, T2, InnerFeatureEntityOverrideFactory> WithEntityOverrides<T1, T2>(this CombinedResult<FeatureFactory, T1, T2> combinedResult, Action<Humidifier.Evidently.FeatureTypes.EntityOverride> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEntityOverrides(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FeatureFactory, T2, InnerFeatureEntityOverrideFactory> WithEntityOverrides<T1, T2>(this CombinedResult<T1, FeatureFactory, T2> combinedResult, Action<Humidifier.Evidently.FeatureTypes.EntityOverride> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEntityOverrides(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FeatureFactory, InnerFeatureEntityOverrideFactory> WithEntityOverrides<T1, T2>(this CombinedResult<T1, T2, FeatureFactory> combinedResult, Action<Humidifier.Evidently.FeatureTypes.EntityOverride> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEntityOverrides(combinedResult.T3, subFactoryAction));
    public static CombinedResult<FeatureFactory, T1, T2, T3, InnerFeatureEntityOverrideFactory> WithEntityOverrides<T1, T2, T3>(this CombinedResult<FeatureFactory, T1, T2, T3> combinedResult, Action<Humidifier.Evidently.FeatureTypes.EntityOverride> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEntityOverrides(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FeatureFactory, T2, T3, InnerFeatureEntityOverrideFactory> WithEntityOverrides<T1, T2, T3>(this CombinedResult<T1, FeatureFactory, T2, T3> combinedResult, Action<Humidifier.Evidently.FeatureTypes.EntityOverride> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEntityOverrides(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FeatureFactory, T3, InnerFeatureEntityOverrideFactory> WithEntityOverrides<T1, T2, T3>(this CombinedResult<T1, T2, FeatureFactory, T3> combinedResult, Action<Humidifier.Evidently.FeatureTypes.EntityOverride> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEntityOverrides(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FeatureFactory, InnerFeatureEntityOverrideFactory> WithEntityOverrides<T1, T2, T3>(this CombinedResult<T1, T2, T3, FeatureFactory> combinedResult, Action<Humidifier.Evidently.FeatureTypes.EntityOverride> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEntityOverrides(combinedResult.T4, subFactoryAction));
    public static CombinedResult<FeatureFactory, T1, T2, T3, T4, InnerFeatureEntityOverrideFactory> WithEntityOverrides<T1, T2, T3, T4>(this CombinedResult<FeatureFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Evidently.FeatureTypes.EntityOverride> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEntityOverrides(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FeatureFactory, T2, T3, T4, InnerFeatureEntityOverrideFactory> WithEntityOverrides<T1, T2, T3, T4>(this CombinedResult<T1, FeatureFactory, T2, T3, T4> combinedResult, Action<Humidifier.Evidently.FeatureTypes.EntityOverride> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEntityOverrides(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FeatureFactory, T3, T4, InnerFeatureEntityOverrideFactory> WithEntityOverrides<T1, T2, T3, T4>(this CombinedResult<T1, T2, FeatureFactory, T3, T4> combinedResult, Action<Humidifier.Evidently.FeatureTypes.EntityOverride> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEntityOverrides(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FeatureFactory, T4, InnerFeatureEntityOverrideFactory> WithEntityOverrides<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, FeatureFactory, T4> combinedResult, Action<Humidifier.Evidently.FeatureTypes.EntityOverride> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEntityOverrides(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, FeatureFactory, InnerFeatureEntityOverrideFactory> WithEntityOverrides<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, FeatureFactory> combinedResult, Action<Humidifier.Evidently.FeatureTypes.EntityOverride> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEntityOverrides(combinedResult.T5, subFactoryAction));
    public static CombinedResult<FeatureFactory, T1, InnerFeatureVariationObjectFactory> WithVariations<T1>(this CombinedResult<FeatureFactory, T1> combinedResult, Action<Humidifier.Evidently.FeatureTypes.VariationObject> subFactoryAction = null) => new (combinedResult, combinedResult, WithVariations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FeatureFactory, InnerFeatureVariationObjectFactory> WithVariations<T1>(this CombinedResult<T1, FeatureFactory> combinedResult, Action<Humidifier.Evidently.FeatureTypes.VariationObject> subFactoryAction = null) => new (combinedResult, combinedResult, WithVariations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<FeatureFactory, T1, T2, InnerFeatureVariationObjectFactory> WithVariations<T1, T2>(this CombinedResult<FeatureFactory, T1, T2> combinedResult, Action<Humidifier.Evidently.FeatureTypes.VariationObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVariations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FeatureFactory, T2, InnerFeatureVariationObjectFactory> WithVariations<T1, T2>(this CombinedResult<T1, FeatureFactory, T2> combinedResult, Action<Humidifier.Evidently.FeatureTypes.VariationObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVariations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FeatureFactory, InnerFeatureVariationObjectFactory> WithVariations<T1, T2>(this CombinedResult<T1, T2, FeatureFactory> combinedResult, Action<Humidifier.Evidently.FeatureTypes.VariationObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVariations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<FeatureFactory, T1, T2, T3, InnerFeatureVariationObjectFactory> WithVariations<T1, T2, T3>(this CombinedResult<FeatureFactory, T1, T2, T3> combinedResult, Action<Humidifier.Evidently.FeatureTypes.VariationObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVariations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FeatureFactory, T2, T3, InnerFeatureVariationObjectFactory> WithVariations<T1, T2, T3>(this CombinedResult<T1, FeatureFactory, T2, T3> combinedResult, Action<Humidifier.Evidently.FeatureTypes.VariationObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVariations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FeatureFactory, T3, InnerFeatureVariationObjectFactory> WithVariations<T1, T2, T3>(this CombinedResult<T1, T2, FeatureFactory, T3> combinedResult, Action<Humidifier.Evidently.FeatureTypes.VariationObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVariations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FeatureFactory, InnerFeatureVariationObjectFactory> WithVariations<T1, T2, T3>(this CombinedResult<T1, T2, T3, FeatureFactory> combinedResult, Action<Humidifier.Evidently.FeatureTypes.VariationObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVariations(combinedResult.T4, subFactoryAction));
    public static CombinedResult<FeatureFactory, T1, T2, T3, T4, InnerFeatureVariationObjectFactory> WithVariations<T1, T2, T3, T4>(this CombinedResult<FeatureFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Evidently.FeatureTypes.VariationObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVariations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FeatureFactory, T2, T3, T4, InnerFeatureVariationObjectFactory> WithVariations<T1, T2, T3, T4>(this CombinedResult<T1, FeatureFactory, T2, T3, T4> combinedResult, Action<Humidifier.Evidently.FeatureTypes.VariationObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVariations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FeatureFactory, T3, T4, InnerFeatureVariationObjectFactory> WithVariations<T1, T2, T3, T4>(this CombinedResult<T1, T2, FeatureFactory, T3, T4> combinedResult, Action<Humidifier.Evidently.FeatureTypes.VariationObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVariations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FeatureFactory, T4, InnerFeatureVariationObjectFactory> WithVariations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, FeatureFactory, T4> combinedResult, Action<Humidifier.Evidently.FeatureTypes.VariationObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVariations(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, FeatureFactory, InnerFeatureVariationObjectFactory> WithVariations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, FeatureFactory> combinedResult, Action<Humidifier.Evidently.FeatureTypes.VariationObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVariations(combinedResult.T5, subFactoryAction));
}
