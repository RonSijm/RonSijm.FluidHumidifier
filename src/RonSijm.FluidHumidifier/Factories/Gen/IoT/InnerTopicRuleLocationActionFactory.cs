// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerTopicRuleLocationActionFactory(Action<Humidifier.IoT.TopicRuleTypes.LocationAction> factoryAction = null) : SubResourceFactory<Humidifier.IoT.TopicRuleTypes.LocationAction>
{

    internal InnerTopicRuleTimestampFactory TimestampFactory { get; set; }

    protected override Humidifier.IoT.TopicRuleTypes.LocationAction Create()
    {
        var locationActionResult = CreateLocationAction();
        factoryAction?.Invoke(locationActionResult);

        return locationActionResult;
    }

    private Humidifier.IoT.TopicRuleTypes.LocationAction CreateLocationAction()
    {
        var locationActionResult = new Humidifier.IoT.TopicRuleTypes.LocationAction();

        return locationActionResult;
    }
    public override void CreateChildren(Humidifier.IoT.TopicRuleTypes.LocationAction result)
    {
        base.CreateChildren(result);

        result.Timestamp ??= TimestampFactory?.Build();
    }

} // End Of Class

public static class InnerTopicRuleLocationActionFactoryExtensions
{
    public static CombinedResult<InnerTopicRuleLocationActionFactory, InnerTopicRuleTimestampFactory> WithTimestamp(this InnerTopicRuleLocationActionFactory parentFactory, Action<Humidifier.IoT.TopicRuleTypes.Timestamp> subFactoryAction = null)
    {
        parentFactory.TimestampFactory = new InnerTopicRuleTimestampFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TimestampFactory);
    }

    public static CombinedResult<InnerTopicRuleLocationActionFactory, T1, InnerTopicRuleTimestampFactory> WithTimestamp<T1>(this CombinedResult<InnerTopicRuleLocationActionFactory, T1> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.Timestamp> subFactoryAction = null) => new (combinedResult, combinedResult, WithTimestamp(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTopicRuleLocationActionFactory, InnerTopicRuleTimestampFactory> WithTimestamp<T1>(this CombinedResult<T1, InnerTopicRuleLocationActionFactory> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.Timestamp> subFactoryAction = null) => new (combinedResult, combinedResult, WithTimestamp(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTopicRuleLocationActionFactory, T1, T2, InnerTopicRuleTimestampFactory> WithTimestamp<T1, T2>(this CombinedResult<InnerTopicRuleLocationActionFactory, T1, T2> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.Timestamp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTimestamp(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTopicRuleLocationActionFactory, T2, InnerTopicRuleTimestampFactory> WithTimestamp<T1, T2>(this CombinedResult<T1, InnerTopicRuleLocationActionFactory, T2> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.Timestamp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTimestamp(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTopicRuleLocationActionFactory, InnerTopicRuleTimestampFactory> WithTimestamp<T1, T2>(this CombinedResult<T1, T2, InnerTopicRuleLocationActionFactory> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.Timestamp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTimestamp(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTopicRuleLocationActionFactory, T1, T2, T3, InnerTopicRuleTimestampFactory> WithTimestamp<T1, T2, T3>(this CombinedResult<InnerTopicRuleLocationActionFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.Timestamp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTimestamp(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTopicRuleLocationActionFactory, T2, T3, InnerTopicRuleTimestampFactory> WithTimestamp<T1, T2, T3>(this CombinedResult<T1, InnerTopicRuleLocationActionFactory, T2, T3> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.Timestamp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTimestamp(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTopicRuleLocationActionFactory, T3, InnerTopicRuleTimestampFactory> WithTimestamp<T1, T2, T3>(this CombinedResult<T1, T2, InnerTopicRuleLocationActionFactory, T3> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.Timestamp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTimestamp(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTopicRuleLocationActionFactory, InnerTopicRuleTimestampFactory> WithTimestamp<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTopicRuleLocationActionFactory> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.Timestamp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTimestamp(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTopicRuleLocationActionFactory, T1, T2, T3, T4, InnerTopicRuleTimestampFactory> WithTimestamp<T1, T2, T3, T4>(this CombinedResult<InnerTopicRuleLocationActionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.Timestamp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTimestamp(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTopicRuleLocationActionFactory, T2, T3, T4, InnerTopicRuleTimestampFactory> WithTimestamp<T1, T2, T3, T4>(this CombinedResult<T1, InnerTopicRuleLocationActionFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.Timestamp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTimestamp(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTopicRuleLocationActionFactory, T3, T4, InnerTopicRuleTimestampFactory> WithTimestamp<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTopicRuleLocationActionFactory, T3, T4> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.Timestamp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTimestamp(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTopicRuleLocationActionFactory, T4, InnerTopicRuleTimestampFactory> WithTimestamp<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTopicRuleLocationActionFactory, T4> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.Timestamp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTimestamp(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTopicRuleLocationActionFactory, InnerTopicRuleTimestampFactory> WithTimestamp<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTopicRuleLocationActionFactory> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.Timestamp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTimestamp(combinedResult.T5, subFactoryAction));
}
