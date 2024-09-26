// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudTrail;

public class TrailFactory(string resourceName = null, Action<Humidifier.CloudTrail.Trail> factoryAction = null) : ResourceFactory<Humidifier.CloudTrail.Trail>(resourceName)
{

    internal List<InnerTrailEventSelectorFactory> EventSelectorsFactories { get; set; } = [];

    internal List<InnerTrailAdvancedEventSelectorFactory> AdvancedEventSelectorsFactories { get; set; } = [];

    internal List<InnerTrailInsightSelectorFactory> InsightSelectorsFactories { get; set; } = [];

    protected override Humidifier.CloudTrail.Trail Create()
    {
        var trailResult = CreateTrail();
        factoryAction?.Invoke(trailResult);

        return trailResult;
    }

    private Humidifier.CloudTrail.Trail CreateTrail()
    {
        var trailResult = new Humidifier.CloudTrail.Trail
        {
            GivenName = InputResourceName,
        };

        return trailResult;
    }
    public override void CreateChildren(Humidifier.CloudTrail.Trail result)
    {
        base.CreateChildren(result);

        result.EventSelectors = EventSelectorsFactories.Any() ? EventSelectorsFactories.Select(x => x.Build()).ToList() : null;
        result.AdvancedEventSelectors = AdvancedEventSelectorsFactories.Any() ? AdvancedEventSelectorsFactories.Select(x => x.Build()).ToList() : null;
        result.InsightSelectors = InsightSelectorsFactories.Any() ? InsightSelectorsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class TrailFactoryExtensions
{
    public static CombinedResult<TrailFactory, InnerTrailEventSelectorFactory> WithEventSelectors(this TrailFactory parentFactory, Action<Humidifier.CloudTrail.TrailTypes.EventSelector> subFactoryAction = null)
    {
        var factory = new InnerTrailEventSelectorFactory(subFactoryAction);
        parentFactory.EventSelectorsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<TrailFactory, InnerTrailAdvancedEventSelectorFactory> WithAdvancedEventSelectors(this TrailFactory parentFactory, Action<Humidifier.CloudTrail.TrailTypes.AdvancedEventSelector> subFactoryAction = null)
    {
        var factory = new InnerTrailAdvancedEventSelectorFactory(subFactoryAction);
        parentFactory.AdvancedEventSelectorsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<TrailFactory, InnerTrailInsightSelectorFactory> WithInsightSelectors(this TrailFactory parentFactory, Action<Humidifier.CloudTrail.TrailTypes.InsightSelector> subFactoryAction = null)
    {
        var factory = new InnerTrailInsightSelectorFactory(subFactoryAction);
        parentFactory.InsightSelectorsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<TrailFactory, T1, InnerTrailEventSelectorFactory> WithEventSelectors<T1>(this CombinedResult<TrailFactory, T1> combinedResult, Action<Humidifier.CloudTrail.TrailTypes.EventSelector> subFactoryAction = null) => new (combinedResult, combinedResult, WithEventSelectors(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TrailFactory, InnerTrailEventSelectorFactory> WithEventSelectors<T1>(this CombinedResult<T1, TrailFactory> combinedResult, Action<Humidifier.CloudTrail.TrailTypes.EventSelector> subFactoryAction = null) => new (combinedResult, combinedResult, WithEventSelectors(combinedResult.T2, subFactoryAction));
    public static CombinedResult<TrailFactory, T1, T2, InnerTrailEventSelectorFactory> WithEventSelectors<T1, T2>(this CombinedResult<TrailFactory, T1, T2> combinedResult, Action<Humidifier.CloudTrail.TrailTypes.EventSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEventSelectors(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TrailFactory, T2, InnerTrailEventSelectorFactory> WithEventSelectors<T1, T2>(this CombinedResult<T1, TrailFactory, T2> combinedResult, Action<Humidifier.CloudTrail.TrailTypes.EventSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEventSelectors(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TrailFactory, InnerTrailEventSelectorFactory> WithEventSelectors<T1, T2>(this CombinedResult<T1, T2, TrailFactory> combinedResult, Action<Humidifier.CloudTrail.TrailTypes.EventSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEventSelectors(combinedResult.T3, subFactoryAction));
    public static CombinedResult<TrailFactory, T1, T2, T3, InnerTrailEventSelectorFactory> WithEventSelectors<T1, T2, T3>(this CombinedResult<TrailFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudTrail.TrailTypes.EventSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventSelectors(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TrailFactory, T2, T3, InnerTrailEventSelectorFactory> WithEventSelectors<T1, T2, T3>(this CombinedResult<T1, TrailFactory, T2, T3> combinedResult, Action<Humidifier.CloudTrail.TrailTypes.EventSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventSelectors(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TrailFactory, T3, InnerTrailEventSelectorFactory> WithEventSelectors<T1, T2, T3>(this CombinedResult<T1, T2, TrailFactory, T3> combinedResult, Action<Humidifier.CloudTrail.TrailTypes.EventSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventSelectors(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TrailFactory, InnerTrailEventSelectorFactory> WithEventSelectors<T1, T2, T3>(this CombinedResult<T1, T2, T3, TrailFactory> combinedResult, Action<Humidifier.CloudTrail.TrailTypes.EventSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventSelectors(combinedResult.T4, subFactoryAction));
    public static CombinedResult<TrailFactory, T1, T2, T3, T4, InnerTrailEventSelectorFactory> WithEventSelectors<T1, T2, T3, T4>(this CombinedResult<TrailFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudTrail.TrailTypes.EventSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventSelectors(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TrailFactory, T2, T3, T4, InnerTrailEventSelectorFactory> WithEventSelectors<T1, T2, T3, T4>(this CombinedResult<T1, TrailFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudTrail.TrailTypes.EventSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventSelectors(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TrailFactory, T3, T4, InnerTrailEventSelectorFactory> WithEventSelectors<T1, T2, T3, T4>(this CombinedResult<T1, T2, TrailFactory, T3, T4> combinedResult, Action<Humidifier.CloudTrail.TrailTypes.EventSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventSelectors(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TrailFactory, T4, InnerTrailEventSelectorFactory> WithEventSelectors<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TrailFactory, T4> combinedResult, Action<Humidifier.CloudTrail.TrailTypes.EventSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventSelectors(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, TrailFactory, InnerTrailEventSelectorFactory> WithEventSelectors<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TrailFactory> combinedResult, Action<Humidifier.CloudTrail.TrailTypes.EventSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventSelectors(combinedResult.T5, subFactoryAction));
    public static CombinedResult<TrailFactory, T1, InnerTrailAdvancedEventSelectorFactory> WithAdvancedEventSelectors<T1>(this CombinedResult<TrailFactory, T1> combinedResult, Action<Humidifier.CloudTrail.TrailTypes.AdvancedEventSelector> subFactoryAction = null) => new (combinedResult, combinedResult, WithAdvancedEventSelectors(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TrailFactory, InnerTrailAdvancedEventSelectorFactory> WithAdvancedEventSelectors<T1>(this CombinedResult<T1, TrailFactory> combinedResult, Action<Humidifier.CloudTrail.TrailTypes.AdvancedEventSelector> subFactoryAction = null) => new (combinedResult, combinedResult, WithAdvancedEventSelectors(combinedResult.T2, subFactoryAction));
    public static CombinedResult<TrailFactory, T1, T2, InnerTrailAdvancedEventSelectorFactory> WithAdvancedEventSelectors<T1, T2>(this CombinedResult<TrailFactory, T1, T2> combinedResult, Action<Humidifier.CloudTrail.TrailTypes.AdvancedEventSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAdvancedEventSelectors(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TrailFactory, T2, InnerTrailAdvancedEventSelectorFactory> WithAdvancedEventSelectors<T1, T2>(this CombinedResult<T1, TrailFactory, T2> combinedResult, Action<Humidifier.CloudTrail.TrailTypes.AdvancedEventSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAdvancedEventSelectors(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TrailFactory, InnerTrailAdvancedEventSelectorFactory> WithAdvancedEventSelectors<T1, T2>(this CombinedResult<T1, T2, TrailFactory> combinedResult, Action<Humidifier.CloudTrail.TrailTypes.AdvancedEventSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAdvancedEventSelectors(combinedResult.T3, subFactoryAction));
    public static CombinedResult<TrailFactory, T1, T2, T3, InnerTrailAdvancedEventSelectorFactory> WithAdvancedEventSelectors<T1, T2, T3>(this CombinedResult<TrailFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudTrail.TrailTypes.AdvancedEventSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAdvancedEventSelectors(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TrailFactory, T2, T3, InnerTrailAdvancedEventSelectorFactory> WithAdvancedEventSelectors<T1, T2, T3>(this CombinedResult<T1, TrailFactory, T2, T3> combinedResult, Action<Humidifier.CloudTrail.TrailTypes.AdvancedEventSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAdvancedEventSelectors(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TrailFactory, T3, InnerTrailAdvancedEventSelectorFactory> WithAdvancedEventSelectors<T1, T2, T3>(this CombinedResult<T1, T2, TrailFactory, T3> combinedResult, Action<Humidifier.CloudTrail.TrailTypes.AdvancedEventSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAdvancedEventSelectors(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TrailFactory, InnerTrailAdvancedEventSelectorFactory> WithAdvancedEventSelectors<T1, T2, T3>(this CombinedResult<T1, T2, T3, TrailFactory> combinedResult, Action<Humidifier.CloudTrail.TrailTypes.AdvancedEventSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAdvancedEventSelectors(combinedResult.T4, subFactoryAction));
    public static CombinedResult<TrailFactory, T1, T2, T3, T4, InnerTrailAdvancedEventSelectorFactory> WithAdvancedEventSelectors<T1, T2, T3, T4>(this CombinedResult<TrailFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudTrail.TrailTypes.AdvancedEventSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAdvancedEventSelectors(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TrailFactory, T2, T3, T4, InnerTrailAdvancedEventSelectorFactory> WithAdvancedEventSelectors<T1, T2, T3, T4>(this CombinedResult<T1, TrailFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudTrail.TrailTypes.AdvancedEventSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAdvancedEventSelectors(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TrailFactory, T3, T4, InnerTrailAdvancedEventSelectorFactory> WithAdvancedEventSelectors<T1, T2, T3, T4>(this CombinedResult<T1, T2, TrailFactory, T3, T4> combinedResult, Action<Humidifier.CloudTrail.TrailTypes.AdvancedEventSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAdvancedEventSelectors(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TrailFactory, T4, InnerTrailAdvancedEventSelectorFactory> WithAdvancedEventSelectors<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TrailFactory, T4> combinedResult, Action<Humidifier.CloudTrail.TrailTypes.AdvancedEventSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAdvancedEventSelectors(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, TrailFactory, InnerTrailAdvancedEventSelectorFactory> WithAdvancedEventSelectors<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TrailFactory> combinedResult, Action<Humidifier.CloudTrail.TrailTypes.AdvancedEventSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAdvancedEventSelectors(combinedResult.T5, subFactoryAction));
    public static CombinedResult<TrailFactory, T1, InnerTrailInsightSelectorFactory> WithInsightSelectors<T1>(this CombinedResult<TrailFactory, T1> combinedResult, Action<Humidifier.CloudTrail.TrailTypes.InsightSelector> subFactoryAction = null) => new (combinedResult, combinedResult, WithInsightSelectors(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TrailFactory, InnerTrailInsightSelectorFactory> WithInsightSelectors<T1>(this CombinedResult<T1, TrailFactory> combinedResult, Action<Humidifier.CloudTrail.TrailTypes.InsightSelector> subFactoryAction = null) => new (combinedResult, combinedResult, WithInsightSelectors(combinedResult.T2, subFactoryAction));
    public static CombinedResult<TrailFactory, T1, T2, InnerTrailInsightSelectorFactory> WithInsightSelectors<T1, T2>(this CombinedResult<TrailFactory, T1, T2> combinedResult, Action<Humidifier.CloudTrail.TrailTypes.InsightSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInsightSelectors(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TrailFactory, T2, InnerTrailInsightSelectorFactory> WithInsightSelectors<T1, T2>(this CombinedResult<T1, TrailFactory, T2> combinedResult, Action<Humidifier.CloudTrail.TrailTypes.InsightSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInsightSelectors(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TrailFactory, InnerTrailInsightSelectorFactory> WithInsightSelectors<T1, T2>(this CombinedResult<T1, T2, TrailFactory> combinedResult, Action<Humidifier.CloudTrail.TrailTypes.InsightSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInsightSelectors(combinedResult.T3, subFactoryAction));
    public static CombinedResult<TrailFactory, T1, T2, T3, InnerTrailInsightSelectorFactory> WithInsightSelectors<T1, T2, T3>(this CombinedResult<TrailFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudTrail.TrailTypes.InsightSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInsightSelectors(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TrailFactory, T2, T3, InnerTrailInsightSelectorFactory> WithInsightSelectors<T1, T2, T3>(this CombinedResult<T1, TrailFactory, T2, T3> combinedResult, Action<Humidifier.CloudTrail.TrailTypes.InsightSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInsightSelectors(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TrailFactory, T3, InnerTrailInsightSelectorFactory> WithInsightSelectors<T1, T2, T3>(this CombinedResult<T1, T2, TrailFactory, T3> combinedResult, Action<Humidifier.CloudTrail.TrailTypes.InsightSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInsightSelectors(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TrailFactory, InnerTrailInsightSelectorFactory> WithInsightSelectors<T1, T2, T3>(this CombinedResult<T1, T2, T3, TrailFactory> combinedResult, Action<Humidifier.CloudTrail.TrailTypes.InsightSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInsightSelectors(combinedResult.T4, subFactoryAction));
    public static CombinedResult<TrailFactory, T1, T2, T3, T4, InnerTrailInsightSelectorFactory> WithInsightSelectors<T1, T2, T3, T4>(this CombinedResult<TrailFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudTrail.TrailTypes.InsightSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInsightSelectors(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TrailFactory, T2, T3, T4, InnerTrailInsightSelectorFactory> WithInsightSelectors<T1, T2, T3, T4>(this CombinedResult<T1, TrailFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudTrail.TrailTypes.InsightSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInsightSelectors(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TrailFactory, T3, T4, InnerTrailInsightSelectorFactory> WithInsightSelectors<T1, T2, T3, T4>(this CombinedResult<T1, T2, TrailFactory, T3, T4> combinedResult, Action<Humidifier.CloudTrail.TrailTypes.InsightSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInsightSelectors(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TrailFactory, T4, InnerTrailInsightSelectorFactory> WithInsightSelectors<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TrailFactory, T4> combinedResult, Action<Humidifier.CloudTrail.TrailTypes.InsightSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInsightSelectors(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, TrailFactory, InnerTrailInsightSelectorFactory> WithInsightSelectors<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TrailFactory> combinedResult, Action<Humidifier.CloudTrail.TrailTypes.InsightSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInsightSelectors(combinedResult.T5, subFactoryAction));
}
