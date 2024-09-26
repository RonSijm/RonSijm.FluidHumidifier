// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerTopicRuleHttpActionFactory(Action<Humidifier.IoT.TopicRuleTypes.HttpAction> factoryAction = null) : SubResourceFactory<Humidifier.IoT.TopicRuleTypes.HttpAction>
{

    internal InnerTopicRuleHttpAuthorizationFactory AuthFactory { get; set; }

    protected override Humidifier.IoT.TopicRuleTypes.HttpAction Create()
    {
        var httpActionResult = CreateHttpAction();
        factoryAction?.Invoke(httpActionResult);

        return httpActionResult;
    }

    private Humidifier.IoT.TopicRuleTypes.HttpAction CreateHttpAction()
    {
        var httpActionResult = new Humidifier.IoT.TopicRuleTypes.HttpAction();

        return httpActionResult;
    }
    public override void CreateChildren(Humidifier.IoT.TopicRuleTypes.HttpAction result)
    {
        base.CreateChildren(result);

        result.Auth ??= AuthFactory?.Build();
    }

} // End Of Class

public static class InnerTopicRuleHttpActionFactoryExtensions
{
    public static CombinedResult<InnerTopicRuleHttpActionFactory, InnerTopicRuleHttpAuthorizationFactory> WithAuth(this InnerTopicRuleHttpActionFactory parentFactory, Action<Humidifier.IoT.TopicRuleTypes.HttpAuthorization> subFactoryAction = null)
    {
        parentFactory.AuthFactory = new InnerTopicRuleHttpAuthorizationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AuthFactory);
    }

    public static CombinedResult<InnerTopicRuleHttpActionFactory, T1, InnerTopicRuleHttpAuthorizationFactory> WithAuth<T1>(this CombinedResult<InnerTopicRuleHttpActionFactory, T1> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.HttpAuthorization> subFactoryAction = null) => new (combinedResult, combinedResult, WithAuth(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTopicRuleHttpActionFactory, InnerTopicRuleHttpAuthorizationFactory> WithAuth<T1>(this CombinedResult<T1, InnerTopicRuleHttpActionFactory> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.HttpAuthorization> subFactoryAction = null) => new (combinedResult, combinedResult, WithAuth(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTopicRuleHttpActionFactory, T1, T2, InnerTopicRuleHttpAuthorizationFactory> WithAuth<T1, T2>(this CombinedResult<InnerTopicRuleHttpActionFactory, T1, T2> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.HttpAuthorization> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuth(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTopicRuleHttpActionFactory, T2, InnerTopicRuleHttpAuthorizationFactory> WithAuth<T1, T2>(this CombinedResult<T1, InnerTopicRuleHttpActionFactory, T2> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.HttpAuthorization> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuth(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTopicRuleHttpActionFactory, InnerTopicRuleHttpAuthorizationFactory> WithAuth<T1, T2>(this CombinedResult<T1, T2, InnerTopicRuleHttpActionFactory> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.HttpAuthorization> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuth(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTopicRuleHttpActionFactory, T1, T2, T3, InnerTopicRuleHttpAuthorizationFactory> WithAuth<T1, T2, T3>(this CombinedResult<InnerTopicRuleHttpActionFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.HttpAuthorization> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuth(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTopicRuleHttpActionFactory, T2, T3, InnerTopicRuleHttpAuthorizationFactory> WithAuth<T1, T2, T3>(this CombinedResult<T1, InnerTopicRuleHttpActionFactory, T2, T3> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.HttpAuthorization> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuth(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTopicRuleHttpActionFactory, T3, InnerTopicRuleHttpAuthorizationFactory> WithAuth<T1, T2, T3>(this CombinedResult<T1, T2, InnerTopicRuleHttpActionFactory, T3> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.HttpAuthorization> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuth(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTopicRuleHttpActionFactory, InnerTopicRuleHttpAuthorizationFactory> WithAuth<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTopicRuleHttpActionFactory> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.HttpAuthorization> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuth(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTopicRuleHttpActionFactory, T1, T2, T3, T4, InnerTopicRuleHttpAuthorizationFactory> WithAuth<T1, T2, T3, T4>(this CombinedResult<InnerTopicRuleHttpActionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.HttpAuthorization> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuth(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTopicRuleHttpActionFactory, T2, T3, T4, InnerTopicRuleHttpAuthorizationFactory> WithAuth<T1, T2, T3, T4>(this CombinedResult<T1, InnerTopicRuleHttpActionFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.HttpAuthorization> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuth(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTopicRuleHttpActionFactory, T3, T4, InnerTopicRuleHttpAuthorizationFactory> WithAuth<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTopicRuleHttpActionFactory, T3, T4> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.HttpAuthorization> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuth(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTopicRuleHttpActionFactory, T4, InnerTopicRuleHttpAuthorizationFactory> WithAuth<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTopicRuleHttpActionFactory, T4> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.HttpAuthorization> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuth(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTopicRuleHttpActionFactory, InnerTopicRuleHttpAuthorizationFactory> WithAuth<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTopicRuleHttpActionFactory> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.HttpAuthorization> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuth(combinedResult.T5, subFactoryAction));
}
