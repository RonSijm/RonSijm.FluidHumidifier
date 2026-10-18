// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerGuardrailTopicPolicyConfigFactory(Action<Humidifier.Bedrock.GuardrailTypes.TopicPolicyConfig> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.GuardrailTypes.TopicPolicyConfig>
{

    internal InnerGuardrailTopicsTierConfigFactory TopicsTierConfigFactory { get; set; }

    protected override Humidifier.Bedrock.GuardrailTypes.TopicPolicyConfig Create()
    {
        var topicPolicyConfigResult = CreateTopicPolicyConfig();
        factoryAction?.Invoke(topicPolicyConfigResult);

        return topicPolicyConfigResult;
    }

    private Humidifier.Bedrock.GuardrailTypes.TopicPolicyConfig CreateTopicPolicyConfig()
    {
        var topicPolicyConfigResult = new Humidifier.Bedrock.GuardrailTypes.TopicPolicyConfig();

        return topicPolicyConfigResult;
    }
    public override void CreateChildren(Humidifier.Bedrock.GuardrailTypes.TopicPolicyConfig result)
    {
        base.CreateChildren(result);

        result.TopicsTierConfig ??= TopicsTierConfigFactory?.Build();
    }

} // End Of Class

public static class InnerGuardrailTopicPolicyConfigFactoryExtensions
{
    public static CombinedResult<InnerGuardrailTopicPolicyConfigFactory, InnerGuardrailTopicsTierConfigFactory> WithTopicsTierConfig(this InnerGuardrailTopicPolicyConfigFactory parentFactory, Action<Humidifier.Bedrock.GuardrailTypes.TopicsTierConfig> subFactoryAction = null)
    {
        parentFactory.TopicsTierConfigFactory = new InnerGuardrailTopicsTierConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TopicsTierConfigFactory);
    }

    public static CombinedResult<InnerGuardrailTopicPolicyConfigFactory, T1, InnerGuardrailTopicsTierConfigFactory> WithTopicsTierConfig<T1>(this CombinedResult<InnerGuardrailTopicPolicyConfigFactory, T1> combinedResult, Action<Humidifier.Bedrock.GuardrailTypes.TopicsTierConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithTopicsTierConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGuardrailTopicPolicyConfigFactory, InnerGuardrailTopicsTierConfigFactory> WithTopicsTierConfig<T1>(this CombinedResult<T1, InnerGuardrailTopicPolicyConfigFactory> combinedResult, Action<Humidifier.Bedrock.GuardrailTypes.TopicsTierConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithTopicsTierConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerGuardrailTopicPolicyConfigFactory, T1, T2, InnerGuardrailTopicsTierConfigFactory> WithTopicsTierConfig<T1, T2>(this CombinedResult<InnerGuardrailTopicPolicyConfigFactory, T1, T2> combinedResult, Action<Humidifier.Bedrock.GuardrailTypes.TopicsTierConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTopicsTierConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGuardrailTopicPolicyConfigFactory, T2, InnerGuardrailTopicsTierConfigFactory> WithTopicsTierConfig<T1, T2>(this CombinedResult<T1, InnerGuardrailTopicPolicyConfigFactory, T2> combinedResult, Action<Humidifier.Bedrock.GuardrailTypes.TopicsTierConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTopicsTierConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGuardrailTopicPolicyConfigFactory, InnerGuardrailTopicsTierConfigFactory> WithTopicsTierConfig<T1, T2>(this CombinedResult<T1, T2, InnerGuardrailTopicPolicyConfigFactory> combinedResult, Action<Humidifier.Bedrock.GuardrailTypes.TopicsTierConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTopicsTierConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerGuardrailTopicPolicyConfigFactory, T1, T2, T3, InnerGuardrailTopicsTierConfigFactory> WithTopicsTierConfig<T1, T2, T3>(this CombinedResult<InnerGuardrailTopicPolicyConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.Bedrock.GuardrailTypes.TopicsTierConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTopicsTierConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGuardrailTopicPolicyConfigFactory, T2, T3, InnerGuardrailTopicsTierConfigFactory> WithTopicsTierConfig<T1, T2, T3>(this CombinedResult<T1, InnerGuardrailTopicPolicyConfigFactory, T2, T3> combinedResult, Action<Humidifier.Bedrock.GuardrailTypes.TopicsTierConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTopicsTierConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGuardrailTopicPolicyConfigFactory, T3, InnerGuardrailTopicsTierConfigFactory> WithTopicsTierConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerGuardrailTopicPolicyConfigFactory, T3> combinedResult, Action<Humidifier.Bedrock.GuardrailTypes.TopicsTierConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTopicsTierConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerGuardrailTopicPolicyConfigFactory, InnerGuardrailTopicsTierConfigFactory> WithTopicsTierConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerGuardrailTopicPolicyConfigFactory> combinedResult, Action<Humidifier.Bedrock.GuardrailTypes.TopicsTierConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTopicsTierConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerGuardrailTopicPolicyConfigFactory, T1, T2, T3, T4, InnerGuardrailTopicsTierConfigFactory> WithTopicsTierConfig<T1, T2, T3, T4>(this CombinedResult<InnerGuardrailTopicPolicyConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.GuardrailTypes.TopicsTierConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTopicsTierConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGuardrailTopicPolicyConfigFactory, T2, T3, T4, InnerGuardrailTopicsTierConfigFactory> WithTopicsTierConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerGuardrailTopicPolicyConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.GuardrailTypes.TopicsTierConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTopicsTierConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGuardrailTopicPolicyConfigFactory, T3, T4, InnerGuardrailTopicsTierConfigFactory> WithTopicsTierConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerGuardrailTopicPolicyConfigFactory, T3, T4> combinedResult, Action<Humidifier.Bedrock.GuardrailTypes.TopicsTierConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTopicsTierConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerGuardrailTopicPolicyConfigFactory, T4, InnerGuardrailTopicsTierConfigFactory> WithTopicsTierConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerGuardrailTopicPolicyConfigFactory, T4> combinedResult, Action<Humidifier.Bedrock.GuardrailTypes.TopicsTierConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTopicsTierConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerGuardrailTopicPolicyConfigFactory, InnerGuardrailTopicsTierConfigFactory> WithTopicsTierConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerGuardrailTopicPolicyConfigFactory> combinedResult, Action<Humidifier.Bedrock.GuardrailTypes.TopicsTierConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTopicsTierConfig(combinedResult.T5, subFactoryAction).T2);
}
