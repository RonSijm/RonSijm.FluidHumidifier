// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerTopicRuleRepublishActionFactory(Action<Humidifier.IoT.TopicRuleTypes.RepublishAction> factoryAction = null) : SubResourceFactory<Humidifier.IoT.TopicRuleTypes.RepublishAction>
{

    internal InnerTopicRuleRepublishActionHeadersFactory HeadersFactory { get; set; }

    protected override Humidifier.IoT.TopicRuleTypes.RepublishAction Create()
    {
        var republishActionResult = CreateRepublishAction();
        factoryAction?.Invoke(republishActionResult);

        return republishActionResult;
    }

    private Humidifier.IoT.TopicRuleTypes.RepublishAction CreateRepublishAction()
    {
        var republishActionResult = new Humidifier.IoT.TopicRuleTypes.RepublishAction();

        return republishActionResult;
    }
    public override void CreateChildren(Humidifier.IoT.TopicRuleTypes.RepublishAction result)
    {
        base.CreateChildren(result);

        result.Headers ??= HeadersFactory?.Build();
    }

} // End Of Class

public static class InnerTopicRuleRepublishActionFactoryExtensions
{
    public static CombinedResult<InnerTopicRuleRepublishActionFactory, InnerTopicRuleRepublishActionHeadersFactory> WithHeaders(this InnerTopicRuleRepublishActionFactory parentFactory, Action<Humidifier.IoT.TopicRuleTypes.RepublishActionHeaders> subFactoryAction = null)
    {
        parentFactory.HeadersFactory = new InnerTopicRuleRepublishActionHeadersFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.HeadersFactory);
    }

    public static CombinedResult<InnerTopicRuleRepublishActionFactory, T1, InnerTopicRuleRepublishActionHeadersFactory> WithHeaders<T1>(this CombinedResult<InnerTopicRuleRepublishActionFactory, T1> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.RepublishActionHeaders> subFactoryAction = null) => new (combinedResult, combinedResult, WithHeaders(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTopicRuleRepublishActionFactory, InnerTopicRuleRepublishActionHeadersFactory> WithHeaders<T1>(this CombinedResult<T1, InnerTopicRuleRepublishActionFactory> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.RepublishActionHeaders> subFactoryAction = null) => new (combinedResult, combinedResult, WithHeaders(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTopicRuleRepublishActionFactory, T1, T2, InnerTopicRuleRepublishActionHeadersFactory> WithHeaders<T1, T2>(this CombinedResult<InnerTopicRuleRepublishActionFactory, T1, T2> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.RepublishActionHeaders> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHeaders(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTopicRuleRepublishActionFactory, T2, InnerTopicRuleRepublishActionHeadersFactory> WithHeaders<T1, T2>(this CombinedResult<T1, InnerTopicRuleRepublishActionFactory, T2> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.RepublishActionHeaders> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHeaders(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTopicRuleRepublishActionFactory, InnerTopicRuleRepublishActionHeadersFactory> WithHeaders<T1, T2>(this CombinedResult<T1, T2, InnerTopicRuleRepublishActionFactory> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.RepublishActionHeaders> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHeaders(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTopicRuleRepublishActionFactory, T1, T2, T3, InnerTopicRuleRepublishActionHeadersFactory> WithHeaders<T1, T2, T3>(this CombinedResult<InnerTopicRuleRepublishActionFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.RepublishActionHeaders> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHeaders(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTopicRuleRepublishActionFactory, T2, T3, InnerTopicRuleRepublishActionHeadersFactory> WithHeaders<T1, T2, T3>(this CombinedResult<T1, InnerTopicRuleRepublishActionFactory, T2, T3> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.RepublishActionHeaders> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHeaders(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTopicRuleRepublishActionFactory, T3, InnerTopicRuleRepublishActionHeadersFactory> WithHeaders<T1, T2, T3>(this CombinedResult<T1, T2, InnerTopicRuleRepublishActionFactory, T3> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.RepublishActionHeaders> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHeaders(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTopicRuleRepublishActionFactory, InnerTopicRuleRepublishActionHeadersFactory> WithHeaders<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTopicRuleRepublishActionFactory> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.RepublishActionHeaders> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHeaders(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTopicRuleRepublishActionFactory, T1, T2, T3, T4, InnerTopicRuleRepublishActionHeadersFactory> WithHeaders<T1, T2, T3, T4>(this CombinedResult<InnerTopicRuleRepublishActionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.RepublishActionHeaders> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHeaders(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTopicRuleRepublishActionFactory, T2, T3, T4, InnerTopicRuleRepublishActionHeadersFactory> WithHeaders<T1, T2, T3, T4>(this CombinedResult<T1, InnerTopicRuleRepublishActionFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.RepublishActionHeaders> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHeaders(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTopicRuleRepublishActionFactory, T3, T4, InnerTopicRuleRepublishActionHeadersFactory> WithHeaders<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTopicRuleRepublishActionFactory, T3, T4> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.RepublishActionHeaders> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHeaders(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTopicRuleRepublishActionFactory, T4, InnerTopicRuleRepublishActionHeadersFactory> WithHeaders<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTopicRuleRepublishActionFactory, T4> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.RepublishActionHeaders> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHeaders(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTopicRuleRepublishActionFactory, InnerTopicRuleRepublishActionHeadersFactory> WithHeaders<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTopicRuleRepublishActionFactory> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.RepublishActionHeaders> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHeaders(combinedResult.T5, subFactoryAction));
}
