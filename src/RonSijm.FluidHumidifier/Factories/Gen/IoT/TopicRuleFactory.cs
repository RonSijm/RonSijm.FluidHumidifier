// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class TopicRuleFactory(string resourceName = null, Action<Humidifier.IoT.TopicRule> factoryAction = null) : ResourceFactory<Humidifier.IoT.TopicRule>(resourceName)
{

    internal InnerTopicRuleTopicRulePayloadFactory TopicRulePayloadFactory { get; set; }

    protected override Humidifier.IoT.TopicRule Create()
    {
        var topicRuleResult = CreateTopicRule();
        factoryAction?.Invoke(topicRuleResult);

        return topicRuleResult;
    }

    private Humidifier.IoT.TopicRule CreateTopicRule()
    {
        var topicRuleResult = new Humidifier.IoT.TopicRule
        {
            GivenName = InputResourceName,
        };

        return topicRuleResult;
    }
    public override void CreateChildren(Humidifier.IoT.TopicRule result)
    {
        base.CreateChildren(result);

        result.TopicRulePayload ??= TopicRulePayloadFactory?.Build();
    }

} // End Of Class

public static class TopicRuleFactoryExtensions
{
    public static CombinedResult<TopicRuleFactory, InnerTopicRuleTopicRulePayloadFactory> WithTopicRulePayload(this TopicRuleFactory parentFactory, Action<Humidifier.IoT.TopicRuleTypes.TopicRulePayload> subFactoryAction = null)
    {
        parentFactory.TopicRulePayloadFactory = new InnerTopicRuleTopicRulePayloadFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TopicRulePayloadFactory);
    }

    public static CombinedResult<TopicRuleFactory, T1, InnerTopicRuleTopicRulePayloadFactory> WithTopicRulePayload<T1>(this CombinedResult<TopicRuleFactory, T1> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.TopicRulePayload> subFactoryAction = null) => new (combinedResult, combinedResult, WithTopicRulePayload(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TopicRuleFactory, InnerTopicRuleTopicRulePayloadFactory> WithTopicRulePayload<T1>(this CombinedResult<T1, TopicRuleFactory> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.TopicRulePayload> subFactoryAction = null) => new (combinedResult, combinedResult, WithTopicRulePayload(combinedResult.T2, subFactoryAction));
    public static CombinedResult<TopicRuleFactory, T1, T2, InnerTopicRuleTopicRulePayloadFactory> WithTopicRulePayload<T1, T2>(this CombinedResult<TopicRuleFactory, T1, T2> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.TopicRulePayload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTopicRulePayload(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TopicRuleFactory, T2, InnerTopicRuleTopicRulePayloadFactory> WithTopicRulePayload<T1, T2>(this CombinedResult<T1, TopicRuleFactory, T2> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.TopicRulePayload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTopicRulePayload(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TopicRuleFactory, InnerTopicRuleTopicRulePayloadFactory> WithTopicRulePayload<T1, T2>(this CombinedResult<T1, T2, TopicRuleFactory> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.TopicRulePayload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTopicRulePayload(combinedResult.T3, subFactoryAction));
    public static CombinedResult<TopicRuleFactory, T1, T2, T3, InnerTopicRuleTopicRulePayloadFactory> WithTopicRulePayload<T1, T2, T3>(this CombinedResult<TopicRuleFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.TopicRulePayload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTopicRulePayload(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TopicRuleFactory, T2, T3, InnerTopicRuleTopicRulePayloadFactory> WithTopicRulePayload<T1, T2, T3>(this CombinedResult<T1, TopicRuleFactory, T2, T3> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.TopicRulePayload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTopicRulePayload(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TopicRuleFactory, T3, InnerTopicRuleTopicRulePayloadFactory> WithTopicRulePayload<T1, T2, T3>(this CombinedResult<T1, T2, TopicRuleFactory, T3> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.TopicRulePayload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTopicRulePayload(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TopicRuleFactory, InnerTopicRuleTopicRulePayloadFactory> WithTopicRulePayload<T1, T2, T3>(this CombinedResult<T1, T2, T3, TopicRuleFactory> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.TopicRulePayload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTopicRulePayload(combinedResult.T4, subFactoryAction));
    public static CombinedResult<TopicRuleFactory, T1, T2, T3, T4, InnerTopicRuleTopicRulePayloadFactory> WithTopicRulePayload<T1, T2, T3, T4>(this CombinedResult<TopicRuleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.TopicRulePayload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTopicRulePayload(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TopicRuleFactory, T2, T3, T4, InnerTopicRuleTopicRulePayloadFactory> WithTopicRulePayload<T1, T2, T3, T4>(this CombinedResult<T1, TopicRuleFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.TopicRulePayload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTopicRulePayload(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TopicRuleFactory, T3, T4, InnerTopicRuleTopicRulePayloadFactory> WithTopicRulePayload<T1, T2, T3, T4>(this CombinedResult<T1, T2, TopicRuleFactory, T3, T4> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.TopicRulePayload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTopicRulePayload(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TopicRuleFactory, T4, InnerTopicRuleTopicRulePayloadFactory> WithTopicRulePayload<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TopicRuleFactory, T4> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.TopicRulePayload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTopicRulePayload(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, TopicRuleFactory, InnerTopicRuleTopicRulePayloadFactory> WithTopicRulePayload<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TopicRuleFactory> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.TopicRulePayload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTopicRulePayload(combinedResult.T5, subFactoryAction));
}
