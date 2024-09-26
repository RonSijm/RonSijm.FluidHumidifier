// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GuardDuty;

public class ThreatIntelSetFactory(string resourceName = null, Action<Humidifier.GuardDuty.ThreatIntelSet> factoryAction = null) : ResourceFactory<Humidifier.GuardDuty.ThreatIntelSet>(resourceName)
{

    internal List<InnerThreatIntelSetTagItemFactory> TagsFactories { get; set; } = [];

    protected override Humidifier.GuardDuty.ThreatIntelSet Create()
    {
        var threatIntelSetResult = CreateThreatIntelSet();
        factoryAction?.Invoke(threatIntelSetResult);

        return threatIntelSetResult;
    }

    private Humidifier.GuardDuty.ThreatIntelSet CreateThreatIntelSet()
    {
        var threatIntelSetResult = new Humidifier.GuardDuty.ThreatIntelSet
        {
            GivenName = InputResourceName,
        };

        return threatIntelSetResult;
    }
    public override void CreateChildren(Humidifier.GuardDuty.ThreatIntelSet result)
    {
        base.CreateChildren(result);

        result.Tags = TagsFactories.Any() ? TagsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class ThreatIntelSetFactoryExtensions
{
    public static CombinedResult<ThreatIntelSetFactory, InnerThreatIntelSetTagItemFactory> WithTags(this ThreatIntelSetFactory parentFactory, Action<Humidifier.GuardDuty.ThreatIntelSetTypes.TagItem> subFactoryAction = null)
    {
        var factory = new InnerThreatIntelSetTagItemFactory(subFactoryAction);
        parentFactory.TagsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ThreatIntelSetFactory, T1, InnerThreatIntelSetTagItemFactory> WithTags<T1>(this CombinedResult<ThreatIntelSetFactory, T1> combinedResult, Action<Humidifier.GuardDuty.ThreatIntelSetTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ThreatIntelSetFactory, InnerThreatIntelSetTagItemFactory> WithTags<T1>(this CombinedResult<T1, ThreatIntelSetFactory> combinedResult, Action<Humidifier.GuardDuty.ThreatIntelSetTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ThreatIntelSetFactory, T1, T2, InnerThreatIntelSetTagItemFactory> WithTags<T1, T2>(this CombinedResult<ThreatIntelSetFactory, T1, T2> combinedResult, Action<Humidifier.GuardDuty.ThreatIntelSetTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ThreatIntelSetFactory, T2, InnerThreatIntelSetTagItemFactory> WithTags<T1, T2>(this CombinedResult<T1, ThreatIntelSetFactory, T2> combinedResult, Action<Humidifier.GuardDuty.ThreatIntelSetTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ThreatIntelSetFactory, InnerThreatIntelSetTagItemFactory> WithTags<T1, T2>(this CombinedResult<T1, T2, ThreatIntelSetFactory> combinedResult, Action<Humidifier.GuardDuty.ThreatIntelSetTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ThreatIntelSetFactory, T1, T2, T3, InnerThreatIntelSetTagItemFactory> WithTags<T1, T2, T3>(this CombinedResult<ThreatIntelSetFactory, T1, T2, T3> combinedResult, Action<Humidifier.GuardDuty.ThreatIntelSetTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ThreatIntelSetFactory, T2, T3, InnerThreatIntelSetTagItemFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, ThreatIntelSetFactory, T2, T3> combinedResult, Action<Humidifier.GuardDuty.ThreatIntelSetTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ThreatIntelSetFactory, T3, InnerThreatIntelSetTagItemFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, ThreatIntelSetFactory, T3> combinedResult, Action<Humidifier.GuardDuty.ThreatIntelSetTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ThreatIntelSetFactory, InnerThreatIntelSetTagItemFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, T3, ThreatIntelSetFactory> combinedResult, Action<Humidifier.GuardDuty.ThreatIntelSetTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ThreatIntelSetFactory, T1, T2, T3, T4, InnerThreatIntelSetTagItemFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<ThreatIntelSetFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.GuardDuty.ThreatIntelSetTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ThreatIntelSetFactory, T2, T3, T4, InnerThreatIntelSetTagItemFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, ThreatIntelSetFactory, T2, T3, T4> combinedResult, Action<Humidifier.GuardDuty.ThreatIntelSetTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ThreatIntelSetFactory, T3, T4, InnerThreatIntelSetTagItemFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, ThreatIntelSetFactory, T3, T4> combinedResult, Action<Humidifier.GuardDuty.ThreatIntelSetTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ThreatIntelSetFactory, T4, InnerThreatIntelSetTagItemFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ThreatIntelSetFactory, T4> combinedResult, Action<Humidifier.GuardDuty.ThreatIntelSetTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ThreatIntelSetFactory, InnerThreatIntelSetTagItemFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ThreatIntelSetFactory> combinedResult, Action<Humidifier.GuardDuty.ThreatIntelSetTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T5, subFactoryAction));
}
