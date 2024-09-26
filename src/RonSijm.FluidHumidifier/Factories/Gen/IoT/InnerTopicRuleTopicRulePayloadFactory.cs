// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerTopicRuleTopicRulePayloadFactory(Action<Humidifier.IoT.TopicRuleTypes.TopicRulePayload> factoryAction = null) : SubResourceFactory<Humidifier.IoT.TopicRuleTypes.TopicRulePayload>
{

    internal InnerTopicRuleActionFactory ErrorActionFactory { get; set; }

    protected override Humidifier.IoT.TopicRuleTypes.TopicRulePayload Create()
    {
        var topicRulePayloadResult = CreateTopicRulePayload();
        factoryAction?.Invoke(topicRulePayloadResult);

        return topicRulePayloadResult;
    }

    private Humidifier.IoT.TopicRuleTypes.TopicRulePayload CreateTopicRulePayload()
    {
        var topicRulePayloadResult = new Humidifier.IoT.TopicRuleTypes.TopicRulePayload();

        return topicRulePayloadResult;
    }
    public override void CreateChildren(Humidifier.IoT.TopicRuleTypes.TopicRulePayload result)
    {
        base.CreateChildren(result);

        result.ErrorAction ??= ErrorActionFactory?.Build();
    }

} // End Of Class

public static class InnerTopicRuleTopicRulePayloadFactoryExtensions
{
    public static CombinedResult<InnerTopicRuleTopicRulePayloadFactory, InnerTopicRuleActionFactory> WithErrorAction(this InnerTopicRuleTopicRulePayloadFactory parentFactory, Action<Humidifier.IoT.TopicRuleTypes.Action> subFactoryAction = null)
    {
        parentFactory.ErrorActionFactory = new InnerTopicRuleActionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ErrorActionFactory);
    }

    public static CombinedResult<InnerTopicRuleTopicRulePayloadFactory, T1, InnerTopicRuleActionFactory> WithErrorAction<T1>(this CombinedResult<InnerTopicRuleTopicRulePayloadFactory, T1> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, WithErrorAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTopicRuleTopicRulePayloadFactory, InnerTopicRuleActionFactory> WithErrorAction<T1>(this CombinedResult<T1, InnerTopicRuleTopicRulePayloadFactory> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, WithErrorAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTopicRuleTopicRulePayloadFactory, T1, T2, InnerTopicRuleActionFactory> WithErrorAction<T1, T2>(this CombinedResult<InnerTopicRuleTopicRulePayloadFactory, T1, T2> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithErrorAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTopicRuleTopicRulePayloadFactory, T2, InnerTopicRuleActionFactory> WithErrorAction<T1, T2>(this CombinedResult<T1, InnerTopicRuleTopicRulePayloadFactory, T2> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithErrorAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTopicRuleTopicRulePayloadFactory, InnerTopicRuleActionFactory> WithErrorAction<T1, T2>(this CombinedResult<T1, T2, InnerTopicRuleTopicRulePayloadFactory> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithErrorAction(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTopicRuleTopicRulePayloadFactory, T1, T2, T3, InnerTopicRuleActionFactory> WithErrorAction<T1, T2, T3>(this CombinedResult<InnerTopicRuleTopicRulePayloadFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithErrorAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTopicRuleTopicRulePayloadFactory, T2, T3, InnerTopicRuleActionFactory> WithErrorAction<T1, T2, T3>(this CombinedResult<T1, InnerTopicRuleTopicRulePayloadFactory, T2, T3> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithErrorAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTopicRuleTopicRulePayloadFactory, T3, InnerTopicRuleActionFactory> WithErrorAction<T1, T2, T3>(this CombinedResult<T1, T2, InnerTopicRuleTopicRulePayloadFactory, T3> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithErrorAction(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTopicRuleTopicRulePayloadFactory, InnerTopicRuleActionFactory> WithErrorAction<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTopicRuleTopicRulePayloadFactory> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithErrorAction(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTopicRuleTopicRulePayloadFactory, T1, T2, T3, T4, InnerTopicRuleActionFactory> WithErrorAction<T1, T2, T3, T4>(this CombinedResult<InnerTopicRuleTopicRulePayloadFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithErrorAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTopicRuleTopicRulePayloadFactory, T2, T3, T4, InnerTopicRuleActionFactory> WithErrorAction<T1, T2, T3, T4>(this CombinedResult<T1, InnerTopicRuleTopicRulePayloadFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithErrorAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTopicRuleTopicRulePayloadFactory, T3, T4, InnerTopicRuleActionFactory> WithErrorAction<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTopicRuleTopicRulePayloadFactory, T3, T4> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithErrorAction(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTopicRuleTopicRulePayloadFactory, T4, InnerTopicRuleActionFactory> WithErrorAction<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTopicRuleTopicRulePayloadFactory, T4> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithErrorAction(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTopicRuleTopicRulePayloadFactory, InnerTopicRuleActionFactory> WithErrorAction<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTopicRuleTopicRulePayloadFactory> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithErrorAction(combinedResult.T5, subFactoryAction));
}
