// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerTopicRuleHttpAuthorizationFactory(Action<Humidifier.IoT.TopicRuleTypes.HttpAuthorization> factoryAction = null) : SubResourceFactory<Humidifier.IoT.TopicRuleTypes.HttpAuthorization>
{

    internal InnerTopicRuleSigV4AuthorizationFactory Sigv4Factory { get; set; }

    protected override Humidifier.IoT.TopicRuleTypes.HttpAuthorization Create()
    {
        var httpAuthorizationResult = CreateHttpAuthorization();
        factoryAction?.Invoke(httpAuthorizationResult);

        return httpAuthorizationResult;
    }

    private Humidifier.IoT.TopicRuleTypes.HttpAuthorization CreateHttpAuthorization()
    {
        var httpAuthorizationResult = new Humidifier.IoT.TopicRuleTypes.HttpAuthorization();

        return httpAuthorizationResult;
    }
    public override void CreateChildren(Humidifier.IoT.TopicRuleTypes.HttpAuthorization result)
    {
        base.CreateChildren(result);

        result.Sigv4 ??= Sigv4Factory?.Build();
    }

} // End Of Class

public static class InnerTopicRuleHttpAuthorizationFactoryExtensions
{
    public static CombinedResult<InnerTopicRuleHttpAuthorizationFactory, InnerTopicRuleSigV4AuthorizationFactory> WithSigv4(this InnerTopicRuleHttpAuthorizationFactory parentFactory, Action<Humidifier.IoT.TopicRuleTypes.SigV4Authorization> subFactoryAction = null)
    {
        parentFactory.Sigv4Factory = new InnerTopicRuleSigV4AuthorizationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.Sigv4Factory);
    }

    public static CombinedResult<InnerTopicRuleHttpAuthorizationFactory, T1, InnerTopicRuleSigV4AuthorizationFactory> WithSigv4<T1>(this CombinedResult<InnerTopicRuleHttpAuthorizationFactory, T1> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.SigV4Authorization> subFactoryAction = null) => new (combinedResult, combinedResult, WithSigv4(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTopicRuleHttpAuthorizationFactory, InnerTopicRuleSigV4AuthorizationFactory> WithSigv4<T1>(this CombinedResult<T1, InnerTopicRuleHttpAuthorizationFactory> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.SigV4Authorization> subFactoryAction = null) => new (combinedResult, combinedResult, WithSigv4(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTopicRuleHttpAuthorizationFactory, T1, T2, InnerTopicRuleSigV4AuthorizationFactory> WithSigv4<T1, T2>(this CombinedResult<InnerTopicRuleHttpAuthorizationFactory, T1, T2> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.SigV4Authorization> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSigv4(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTopicRuleHttpAuthorizationFactory, T2, InnerTopicRuleSigV4AuthorizationFactory> WithSigv4<T1, T2>(this CombinedResult<T1, InnerTopicRuleHttpAuthorizationFactory, T2> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.SigV4Authorization> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSigv4(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTopicRuleHttpAuthorizationFactory, InnerTopicRuleSigV4AuthorizationFactory> WithSigv4<T1, T2>(this CombinedResult<T1, T2, InnerTopicRuleHttpAuthorizationFactory> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.SigV4Authorization> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSigv4(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTopicRuleHttpAuthorizationFactory, T1, T2, T3, InnerTopicRuleSigV4AuthorizationFactory> WithSigv4<T1, T2, T3>(this CombinedResult<InnerTopicRuleHttpAuthorizationFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.SigV4Authorization> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSigv4(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTopicRuleHttpAuthorizationFactory, T2, T3, InnerTopicRuleSigV4AuthorizationFactory> WithSigv4<T1, T2, T3>(this CombinedResult<T1, InnerTopicRuleHttpAuthorizationFactory, T2, T3> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.SigV4Authorization> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSigv4(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTopicRuleHttpAuthorizationFactory, T3, InnerTopicRuleSigV4AuthorizationFactory> WithSigv4<T1, T2, T3>(this CombinedResult<T1, T2, InnerTopicRuleHttpAuthorizationFactory, T3> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.SigV4Authorization> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSigv4(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTopicRuleHttpAuthorizationFactory, InnerTopicRuleSigV4AuthorizationFactory> WithSigv4<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTopicRuleHttpAuthorizationFactory> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.SigV4Authorization> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSigv4(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTopicRuleHttpAuthorizationFactory, T1, T2, T3, T4, InnerTopicRuleSigV4AuthorizationFactory> WithSigv4<T1, T2, T3, T4>(this CombinedResult<InnerTopicRuleHttpAuthorizationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.SigV4Authorization> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSigv4(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTopicRuleHttpAuthorizationFactory, T2, T3, T4, InnerTopicRuleSigV4AuthorizationFactory> WithSigv4<T1, T2, T3, T4>(this CombinedResult<T1, InnerTopicRuleHttpAuthorizationFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.SigV4Authorization> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSigv4(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTopicRuleHttpAuthorizationFactory, T3, T4, InnerTopicRuleSigV4AuthorizationFactory> WithSigv4<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTopicRuleHttpAuthorizationFactory, T3, T4> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.SigV4Authorization> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSigv4(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTopicRuleHttpAuthorizationFactory, T4, InnerTopicRuleSigV4AuthorizationFactory> WithSigv4<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTopicRuleHttpAuthorizationFactory, T4> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.SigV4Authorization> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSigv4(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTopicRuleHttpAuthorizationFactory, InnerTopicRuleSigV4AuthorizationFactory> WithSigv4<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTopicRuleHttpAuthorizationFactory> combinedResult, Action<Humidifier.IoT.TopicRuleTypes.SigV4Authorization> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSigv4(combinedResult.T5, subFactoryAction));
}
