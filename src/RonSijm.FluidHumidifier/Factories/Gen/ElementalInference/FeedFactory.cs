// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElementalInference;

public class FeedFactory(string resourceName = null, Action<Humidifier.ElementalInference.Feed> factoryAction = null) : ResourceFactory<Humidifier.ElementalInference.Feed>(resourceName)
{

    internal List<InnerFeedGetOutputFactory> OutputsFactories { get; set; } = [];

    protected override Humidifier.ElementalInference.Feed Create()
    {
        var feedResult = CreateFeed();
        factoryAction?.Invoke(feedResult);

        return feedResult;
    }

    private Humidifier.ElementalInference.Feed CreateFeed()
    {
        var feedResult = new Humidifier.ElementalInference.Feed
        {
            GivenName = InputResourceName,
        };

        return feedResult;
    }
    public override void CreateChildren(Humidifier.ElementalInference.Feed result)
    {
        base.CreateChildren(result);

        result.Outputs = OutputsFactories.Any() ? OutputsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class FeedFactoryExtensions
{
    public static CombinedResult<FeedFactory, InnerFeedGetOutputFactory> WithOutputs(this FeedFactory parentFactory, Action<Humidifier.ElementalInference.FeedTypes.GetOutput> subFactoryAction = null)
    {
        var factory = new InnerFeedGetOutputFactory(subFactoryAction);
        parentFactory.OutputsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<FeedFactory, T1, InnerFeedGetOutputFactory> WithOutputs<T1>(this CombinedResult<FeedFactory, T1> combinedResult, Action<Humidifier.ElementalInference.FeedTypes.GetOutput> subFactoryAction = null) => new (combinedResult, combinedResult, WithOutputs(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, FeedFactory, InnerFeedGetOutputFactory> WithOutputs<T1>(this CombinedResult<T1, FeedFactory> combinedResult, Action<Humidifier.ElementalInference.FeedTypes.GetOutput> subFactoryAction = null) => new (combinedResult, combinedResult, WithOutputs(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<FeedFactory, T1, T2, InnerFeedGetOutputFactory> WithOutputs<T1, T2>(this CombinedResult<FeedFactory, T1, T2> combinedResult, Action<Humidifier.ElementalInference.FeedTypes.GetOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOutputs(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, FeedFactory, T2, InnerFeedGetOutputFactory> WithOutputs<T1, T2>(this CombinedResult<T1, FeedFactory, T2> combinedResult, Action<Humidifier.ElementalInference.FeedTypes.GetOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOutputs(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, FeedFactory, InnerFeedGetOutputFactory> WithOutputs<T1, T2>(this CombinedResult<T1, T2, FeedFactory> combinedResult, Action<Humidifier.ElementalInference.FeedTypes.GetOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOutputs(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<FeedFactory, T1, T2, T3, InnerFeedGetOutputFactory> WithOutputs<T1, T2, T3>(this CombinedResult<FeedFactory, T1, T2, T3> combinedResult, Action<Humidifier.ElementalInference.FeedTypes.GetOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOutputs(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, FeedFactory, T2, T3, InnerFeedGetOutputFactory> WithOutputs<T1, T2, T3>(this CombinedResult<T1, FeedFactory, T2, T3> combinedResult, Action<Humidifier.ElementalInference.FeedTypes.GetOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOutputs(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, FeedFactory, T3, InnerFeedGetOutputFactory> WithOutputs<T1, T2, T3>(this CombinedResult<T1, T2, FeedFactory, T3> combinedResult, Action<Humidifier.ElementalInference.FeedTypes.GetOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOutputs(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, FeedFactory, InnerFeedGetOutputFactory> WithOutputs<T1, T2, T3>(this CombinedResult<T1, T2, T3, FeedFactory> combinedResult, Action<Humidifier.ElementalInference.FeedTypes.GetOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOutputs(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<FeedFactory, T1, T2, T3, T4, InnerFeedGetOutputFactory> WithOutputs<T1, T2, T3, T4>(this CombinedResult<FeedFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ElementalInference.FeedTypes.GetOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutputs(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, FeedFactory, T2, T3, T4, InnerFeedGetOutputFactory> WithOutputs<T1, T2, T3, T4>(this CombinedResult<T1, FeedFactory, T2, T3, T4> combinedResult, Action<Humidifier.ElementalInference.FeedTypes.GetOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutputs(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, FeedFactory, T3, T4, InnerFeedGetOutputFactory> WithOutputs<T1, T2, T3, T4>(this CombinedResult<T1, T2, FeedFactory, T3, T4> combinedResult, Action<Humidifier.ElementalInference.FeedTypes.GetOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutputs(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, FeedFactory, T4, InnerFeedGetOutputFactory> WithOutputs<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, FeedFactory, T4> combinedResult, Action<Humidifier.ElementalInference.FeedTypes.GetOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutputs(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, FeedFactory, InnerFeedGetOutputFactory> WithOutputs<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, FeedFactory> combinedResult, Action<Humidifier.ElementalInference.FeedTypes.GetOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutputs(combinedResult.T5, subFactoryAction).T2);
}
