// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerTopicRuleTimestreamActionFactory(Action<Humidifier.IoT.TopicRuleTypes.TimestreamAction> factoryAction = null) : SubResourceFactory<Humidifier.IoT.TopicRuleTypes.TimestreamAction>
{

    internal InnerTopicRuleTimestreamTimestampFactory TimestampFactory { get; set; }

    protected override Humidifier.IoT.TopicRuleTypes.TimestreamAction Create()
    {
        var timestreamActionResult = CreateTimestreamAction();
        factoryAction?.Invoke(timestreamActionResult);

        return timestreamActionResult;
    }

    private Humidifier.IoT.TopicRuleTypes.TimestreamAction CreateTimestreamAction()
    {
        var timestreamActionResult = new Humidifier.IoT.TopicRuleTypes.TimestreamAction();

        return timestreamActionResult;
    }
    public override void CreateChildren(Humidifier.IoT.TopicRuleTypes.TimestreamAction result)
    {
        base.CreateChildren(result);

        result.Timestamp ??= TimestampFactory?.Build();
    }

} // End Of Class

public static class InnerTopicRuleTimestreamActionFactoryExtensions
{
    public static CombinedResult<InnerTopicRuleTimestreamActionFactory, InnerTopicRuleTimestreamTimestampFactory> WithTimestamp(this InnerTopicRuleTimestreamActionFactory parentFactory, Action<Humidifier.IoT.TopicRuleTypes.TimestreamTimestamp> subFactoryAction = null)
    {
        parentFactory.TimestampFactory = new InnerTopicRuleTimestreamTimestampFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TimestampFactory);
    }

    public static CombinedResult<InnerTopicRuleTimestreamActionFactory, T1, InnerTopicRuleTimestreamTimestampFactory> WithTimestamp<T1>(this CombinedResult<InnerTopicRuleTimestreamActionFactory, T1> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.TimestreamTimestamp> subFactoryAction = null) => new (combinedResult, combinedResult, WithTimestamp(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTopicRuleTimestreamActionFactory, InnerTopicRuleTimestreamTimestampFactory> WithTimestamp<T1>(this CombinedResult<T1, InnerTopicRuleTimestreamActionFactory> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.TimestreamTimestamp> subFactoryAction = null) => new (combinedResult, combinedResult, WithTimestamp(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTopicRuleTimestreamActionFactory, T1, T2, InnerTopicRuleTimestreamTimestampFactory> WithTimestamp<T1, T2>(this CombinedResult<InnerTopicRuleTimestreamActionFactory, T1, T2> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.TimestreamTimestamp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTimestamp(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTopicRuleTimestreamActionFactory, T2, InnerTopicRuleTimestreamTimestampFactory> WithTimestamp<T1, T2>(this CombinedResult<T1, InnerTopicRuleTimestreamActionFactory, T2> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.TimestreamTimestamp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTimestamp(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTopicRuleTimestreamActionFactory, InnerTopicRuleTimestreamTimestampFactory> WithTimestamp<T1, T2>(this CombinedResult<T1, T2, InnerTopicRuleTimestreamActionFactory> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.TimestreamTimestamp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTimestamp(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTopicRuleTimestreamActionFactory, T1, T2, T3, InnerTopicRuleTimestreamTimestampFactory> WithTimestamp<T1, T2, T3>(this CombinedResult<InnerTopicRuleTimestreamActionFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.TimestreamTimestamp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTimestamp(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTopicRuleTimestreamActionFactory, T2, T3, InnerTopicRuleTimestreamTimestampFactory> WithTimestamp<T1, T2, T3>(this CombinedResult<T1, InnerTopicRuleTimestreamActionFactory, T2, T3> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.TimestreamTimestamp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTimestamp(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTopicRuleTimestreamActionFactory, T3, InnerTopicRuleTimestreamTimestampFactory> WithTimestamp<T1, T2, T3>(this CombinedResult<T1, T2, InnerTopicRuleTimestreamActionFactory, T3> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.TimestreamTimestamp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTimestamp(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTopicRuleTimestreamActionFactory, InnerTopicRuleTimestreamTimestampFactory> WithTimestamp<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTopicRuleTimestreamActionFactory> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.TimestreamTimestamp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTimestamp(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTopicRuleTimestreamActionFactory, T1, T2, T3, T4, InnerTopicRuleTimestreamTimestampFactory> WithTimestamp<T1, T2, T3, T4>(this CombinedResult<InnerTopicRuleTimestreamActionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.TimestreamTimestamp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTimestamp(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTopicRuleTimestreamActionFactory, T2, T3, T4, InnerTopicRuleTimestreamTimestampFactory> WithTimestamp<T1, T2, T3, T4>(this CombinedResult<T1, InnerTopicRuleTimestreamActionFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.TimestreamTimestamp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTimestamp(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTopicRuleTimestreamActionFactory, T3, T4, InnerTopicRuleTimestreamTimestampFactory> WithTimestamp<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTopicRuleTimestreamActionFactory, T3, T4> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.TimestreamTimestamp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTimestamp(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTopicRuleTimestreamActionFactory, T4, InnerTopicRuleTimestreamTimestampFactory> WithTimestamp<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTopicRuleTimestreamActionFactory, T4> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.TimestreamTimestamp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTimestamp(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTopicRuleTimestreamActionFactory, InnerTopicRuleTimestreamTimestampFactory> WithTimestamp<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTopicRuleTimestreamActionFactory> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.TimestreamTimestamp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTimestamp(combinedResult.T5, subFactoryAction));
}
