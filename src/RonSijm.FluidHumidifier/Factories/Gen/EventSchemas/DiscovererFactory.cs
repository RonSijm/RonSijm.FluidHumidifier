// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EventSchemas;

public class DiscovererFactory(string resourceName = null, Action<Humidifier.EventSchemas.Discoverer> factoryAction = null) : ResourceFactory<Humidifier.EventSchemas.Discoverer>(resourceName)
{

    internal List<InnerDiscovererTagsEntryFactory> TagsFactories { get; set; } = [];

    protected override Humidifier.EventSchemas.Discoverer Create()
    {
        var discovererResult = CreateDiscoverer();
        factoryAction?.Invoke(discovererResult);

        return discovererResult;
    }

    private Humidifier.EventSchemas.Discoverer CreateDiscoverer()
    {
        var discovererResult = new Humidifier.EventSchemas.Discoverer
        {
            GivenName = InputResourceName,
        };

        return discovererResult;
    }
    public override void CreateChildren(Humidifier.EventSchemas.Discoverer result)
    {
        base.CreateChildren(result);

        result.Tags = TagsFactories.Any() ? TagsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class DiscovererFactoryExtensions
{
    public static CombinedResult<DiscovererFactory, InnerDiscovererTagsEntryFactory> WithTags(this DiscovererFactory parentFactory, Action<Humidifier.EventSchemas.DiscovererTypes.TagsEntry> subFactoryAction = null)
    {
        var factory = new InnerDiscovererTagsEntryFactory(subFactoryAction);
        parentFactory.TagsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<DiscovererFactory, T1, InnerDiscovererTagsEntryFactory> WithTags<T1>(this CombinedResult<DiscovererFactory, T1> combinedResult, Action<Humidifier.EventSchemas.DiscovererTypes.TagsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DiscovererFactory, InnerDiscovererTagsEntryFactory> WithTags<T1>(this CombinedResult<T1, DiscovererFactory> combinedResult, Action<Humidifier.EventSchemas.DiscovererTypes.TagsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DiscovererFactory, T1, T2, InnerDiscovererTagsEntryFactory> WithTags<T1, T2>(this CombinedResult<DiscovererFactory, T1, T2> combinedResult, Action<Humidifier.EventSchemas.DiscovererTypes.TagsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DiscovererFactory, T2, InnerDiscovererTagsEntryFactory> WithTags<T1, T2>(this CombinedResult<T1, DiscovererFactory, T2> combinedResult, Action<Humidifier.EventSchemas.DiscovererTypes.TagsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DiscovererFactory, InnerDiscovererTagsEntryFactory> WithTags<T1, T2>(this CombinedResult<T1, T2, DiscovererFactory> combinedResult, Action<Humidifier.EventSchemas.DiscovererTypes.TagsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DiscovererFactory, T1, T2, T3, InnerDiscovererTagsEntryFactory> WithTags<T1, T2, T3>(this CombinedResult<DiscovererFactory, T1, T2, T3> combinedResult, Action<Humidifier.EventSchemas.DiscovererTypes.TagsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DiscovererFactory, T2, T3, InnerDiscovererTagsEntryFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, DiscovererFactory, T2, T3> combinedResult, Action<Humidifier.EventSchemas.DiscovererTypes.TagsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DiscovererFactory, T3, InnerDiscovererTagsEntryFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, DiscovererFactory, T3> combinedResult, Action<Humidifier.EventSchemas.DiscovererTypes.TagsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DiscovererFactory, InnerDiscovererTagsEntryFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, T3, DiscovererFactory> combinedResult, Action<Humidifier.EventSchemas.DiscovererTypes.TagsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DiscovererFactory, T1, T2, T3, T4, InnerDiscovererTagsEntryFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<DiscovererFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EventSchemas.DiscovererTypes.TagsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DiscovererFactory, T2, T3, T4, InnerDiscovererTagsEntryFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, DiscovererFactory, T2, T3, T4> combinedResult, Action<Humidifier.EventSchemas.DiscovererTypes.TagsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DiscovererFactory, T3, T4, InnerDiscovererTagsEntryFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, DiscovererFactory, T3, T4> combinedResult, Action<Humidifier.EventSchemas.DiscovererTypes.TagsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DiscovererFactory, T4, InnerDiscovererTagsEntryFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DiscovererFactory, T4> combinedResult, Action<Humidifier.EventSchemas.DiscovererTypes.TagsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DiscovererFactory, InnerDiscovererTagsEntryFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DiscovererFactory> combinedResult, Action<Humidifier.EventSchemas.DiscovererTypes.TagsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T5, subFactoryAction));
}
