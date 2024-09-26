// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pinpoint;

public class InnerSegmentBehaviorFactory(Action<Humidifier.Pinpoint.SegmentTypes.Behavior> factoryAction = null) : SubResourceFactory<Humidifier.Pinpoint.SegmentTypes.Behavior>
{

    internal InnerSegmentRecencyFactory RecencyFactory { get; set; }

    protected override Humidifier.Pinpoint.SegmentTypes.Behavior Create()
    {
        var behaviorResult = CreateBehavior();
        factoryAction?.Invoke(behaviorResult);

        return behaviorResult;
    }

    private Humidifier.Pinpoint.SegmentTypes.Behavior CreateBehavior()
    {
        var behaviorResult = new Humidifier.Pinpoint.SegmentTypes.Behavior();

        return behaviorResult;
    }
    public override void CreateChildren(Humidifier.Pinpoint.SegmentTypes.Behavior result)
    {
        base.CreateChildren(result);

        result.Recency ??= RecencyFactory?.Build();
    }

} // End Of Class

public static class InnerSegmentBehaviorFactoryExtensions
{
    public static CombinedResult<InnerSegmentBehaviorFactory, InnerSegmentRecencyFactory> WithRecency(this InnerSegmentBehaviorFactory parentFactory, Action<Humidifier.Pinpoint.SegmentTypes.Recency> subFactoryAction = null)
    {
        parentFactory.RecencyFactory = new InnerSegmentRecencyFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RecencyFactory);
    }

    public static CombinedResult<InnerSegmentBehaviorFactory, T1, InnerSegmentRecencyFactory> WithRecency<T1>(this CombinedResult<InnerSegmentBehaviorFactory, T1> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.Recency> subFactoryAction = null) => new (combinedResult, combinedResult, WithRecency(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSegmentBehaviorFactory, InnerSegmentRecencyFactory> WithRecency<T1>(this CombinedResult<T1, InnerSegmentBehaviorFactory> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.Recency> subFactoryAction = null) => new (combinedResult, combinedResult, WithRecency(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerSegmentBehaviorFactory, T1, T2, InnerSegmentRecencyFactory> WithRecency<T1, T2>(this CombinedResult<InnerSegmentBehaviorFactory, T1, T2> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.Recency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRecency(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSegmentBehaviorFactory, T2, InnerSegmentRecencyFactory> WithRecency<T1, T2>(this CombinedResult<T1, InnerSegmentBehaviorFactory, T2> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.Recency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRecency(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSegmentBehaviorFactory, InnerSegmentRecencyFactory> WithRecency<T1, T2>(this CombinedResult<T1, T2, InnerSegmentBehaviorFactory> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.Recency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRecency(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerSegmentBehaviorFactory, T1, T2, T3, InnerSegmentRecencyFactory> WithRecency<T1, T2, T3>(this CombinedResult<InnerSegmentBehaviorFactory, T1, T2, T3> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.Recency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRecency(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSegmentBehaviorFactory, T2, T3, InnerSegmentRecencyFactory> WithRecency<T1, T2, T3>(this CombinedResult<T1, InnerSegmentBehaviorFactory, T2, T3> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.Recency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRecency(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSegmentBehaviorFactory, T3, InnerSegmentRecencyFactory> WithRecency<T1, T2, T3>(this CombinedResult<T1, T2, InnerSegmentBehaviorFactory, T3> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.Recency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRecency(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerSegmentBehaviorFactory, InnerSegmentRecencyFactory> WithRecency<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerSegmentBehaviorFactory> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.Recency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRecency(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerSegmentBehaviorFactory, T1, T2, T3, T4, InnerSegmentRecencyFactory> WithRecency<T1, T2, T3, T4>(this CombinedResult<InnerSegmentBehaviorFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.Recency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecency(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSegmentBehaviorFactory, T2, T3, T4, InnerSegmentRecencyFactory> WithRecency<T1, T2, T3, T4>(this CombinedResult<T1, InnerSegmentBehaviorFactory, T2, T3, T4> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.Recency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecency(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSegmentBehaviorFactory, T3, T4, InnerSegmentRecencyFactory> WithRecency<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerSegmentBehaviorFactory, T3, T4> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.Recency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecency(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerSegmentBehaviorFactory, T4, InnerSegmentRecencyFactory> WithRecency<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerSegmentBehaviorFactory, T4> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.Recency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecency(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerSegmentBehaviorFactory, InnerSegmentRecencyFactory> WithRecency<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerSegmentBehaviorFactory> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.Recency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecency(combinedResult.T5, subFactoryAction));
}
