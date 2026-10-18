// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Events;

public class ReplayFactory(string resourceName = null, Action<Humidifier.Events.Replay> factoryAction = null) : ResourceFactory<Humidifier.Events.Replay>(resourceName)
{

    internal InnerReplayDestinationFactory DestinationFactory { get; set; }

    protected override Humidifier.Events.Replay Create()
    {
        var replayResult = CreateReplay();
        factoryAction?.Invoke(replayResult);

        return replayResult;
    }

    private Humidifier.Events.Replay CreateReplay()
    {
        var replayResult = new Humidifier.Events.Replay
        {
            GivenName = InputResourceName,
        };

        return replayResult;
    }
    public override void CreateChildren(Humidifier.Events.Replay result)
    {
        base.CreateChildren(result);

        result.Destination ??= DestinationFactory?.Build();
    }

} // End Of Class

public static class ReplayFactoryExtensions
{
    public static CombinedResult<ReplayFactory, InnerReplayDestinationFactory> WithDestination(this ReplayFactory parentFactory, Action<Humidifier.Events.ReplayTypes.Destination> subFactoryAction = null)
    {
        parentFactory.DestinationFactory = new InnerReplayDestinationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DestinationFactory);
    }

    public static CombinedResult<ReplayFactory, T1, InnerReplayDestinationFactory> WithDestination<T1>(this CombinedResult<ReplayFactory, T1> combinedResult, Action<Humidifier.Events.ReplayTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, WithDestination(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ReplayFactory, InnerReplayDestinationFactory> WithDestination<T1>(this CombinedResult<T1, ReplayFactory> combinedResult, Action<Humidifier.Events.ReplayTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, WithDestination(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ReplayFactory, T1, T2, InnerReplayDestinationFactory> WithDestination<T1, T2>(this CombinedResult<ReplayFactory, T1, T2> combinedResult, Action<Humidifier.Events.ReplayTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ReplayFactory, T2, InnerReplayDestinationFactory> WithDestination<T1, T2>(this CombinedResult<T1, ReplayFactory, T2> combinedResult, Action<Humidifier.Events.ReplayTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ReplayFactory, InnerReplayDestinationFactory> WithDestination<T1, T2>(this CombinedResult<T1, T2, ReplayFactory> combinedResult, Action<Humidifier.Events.ReplayTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ReplayFactory, T1, T2, T3, InnerReplayDestinationFactory> WithDestination<T1, T2, T3>(this CombinedResult<ReplayFactory, T1, T2, T3> combinedResult, Action<Humidifier.Events.ReplayTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ReplayFactory, T2, T3, InnerReplayDestinationFactory> WithDestination<T1, T2, T3>(this CombinedResult<T1, ReplayFactory, T2, T3> combinedResult, Action<Humidifier.Events.ReplayTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ReplayFactory, T3, InnerReplayDestinationFactory> WithDestination<T1, T2, T3>(this CombinedResult<T1, T2, ReplayFactory, T3> combinedResult, Action<Humidifier.Events.ReplayTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ReplayFactory, InnerReplayDestinationFactory> WithDestination<T1, T2, T3>(this CombinedResult<T1, T2, T3, ReplayFactory> combinedResult, Action<Humidifier.Events.ReplayTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ReplayFactory, T1, T2, T3, T4, InnerReplayDestinationFactory> WithDestination<T1, T2, T3, T4>(this CombinedResult<ReplayFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Events.ReplayTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ReplayFactory, T2, T3, T4, InnerReplayDestinationFactory> WithDestination<T1, T2, T3, T4>(this CombinedResult<T1, ReplayFactory, T2, T3, T4> combinedResult, Action<Humidifier.Events.ReplayTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ReplayFactory, T3, T4, InnerReplayDestinationFactory> WithDestination<T1, T2, T3, T4>(this CombinedResult<T1, T2, ReplayFactory, T3, T4> combinedResult, Action<Humidifier.Events.ReplayTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ReplayFactory, T4, InnerReplayDestinationFactory> WithDestination<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ReplayFactory, T4> combinedResult, Action<Humidifier.Events.ReplayTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ReplayFactory, InnerReplayDestinationFactory> WithDestination<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ReplayFactory> combinedResult, Action<Humidifier.Events.ReplayTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T5, subFactoryAction).T2);
}
