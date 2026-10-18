// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WellArchitected;

public class LensFactory(string resourceName = null, Action<Humidifier.WellArchitected.Lens> factoryAction = null) : ResourceFactory<Humidifier.WellArchitected.Lens>(resourceName)
{

    internal List<InnerLensTagsItemsFactory> TagsFactories { get; set; } = [];

    protected override Humidifier.WellArchitected.Lens Create()
    {
        var lensResult = CreateLens();
        factoryAction?.Invoke(lensResult);

        return lensResult;
    }

    private Humidifier.WellArchitected.Lens CreateLens()
    {
        var lensResult = new Humidifier.WellArchitected.Lens
        {
            GivenName = InputResourceName,
        };

        return lensResult;
    }
    public override void CreateChildren(Humidifier.WellArchitected.Lens result)
    {
        base.CreateChildren(result);

        result.Tags = TagsFactories.Any() ? TagsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class LensFactoryExtensions
{
    public static CombinedResult<LensFactory, InnerLensTagsItemsFactory> WithTags(this LensFactory parentFactory, Action<Humidifier.WellArchitected.LensTypes.TagsItems> subFactoryAction = null)
    {
        var factory = new InnerLensTagsItemsFactory(subFactoryAction);
        parentFactory.TagsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<LensFactory, T1, InnerLensTagsItemsFactory> WithTags<T1>(this CombinedResult<LensFactory, T1> combinedResult, Action<Humidifier.WellArchitected.LensTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LensFactory, InnerLensTagsItemsFactory> WithTags<T1>(this CombinedResult<T1, LensFactory> combinedResult, Action<Humidifier.WellArchitected.LensTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<LensFactory, T1, T2, InnerLensTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<LensFactory, T1, T2> combinedResult, Action<Humidifier.WellArchitected.LensTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LensFactory, T2, InnerLensTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<T1, LensFactory, T2> combinedResult, Action<Humidifier.WellArchitected.LensTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, LensFactory, InnerLensTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<T1, T2, LensFactory> combinedResult, Action<Humidifier.WellArchitected.LensTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<LensFactory, T1, T2, T3, InnerLensTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<LensFactory, T1, T2, T3> combinedResult, Action<Humidifier.WellArchitected.LensTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LensFactory, T2, T3, InnerLensTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, LensFactory, T2, T3> combinedResult, Action<Humidifier.WellArchitected.LensTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, LensFactory, T3, InnerLensTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, LensFactory, T3> combinedResult, Action<Humidifier.WellArchitected.LensTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, LensFactory, InnerLensTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, T3, LensFactory> combinedResult, Action<Humidifier.WellArchitected.LensTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<LensFactory, T1, T2, T3, T4, InnerLensTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<LensFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WellArchitected.LensTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LensFactory, T2, T3, T4, InnerLensTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, LensFactory, T2, T3, T4> combinedResult, Action<Humidifier.WellArchitected.LensTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, LensFactory, T3, T4, InnerLensTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, LensFactory, T3, T4> combinedResult, Action<Humidifier.WellArchitected.LensTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, LensFactory, T4, InnerLensTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, LensFactory, T4> combinedResult, Action<Humidifier.WellArchitected.LensTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, LensFactory, InnerLensTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, LensFactory> combinedResult, Action<Humidifier.WellArchitected.LensTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T5, subFactoryAction).T2);
}
