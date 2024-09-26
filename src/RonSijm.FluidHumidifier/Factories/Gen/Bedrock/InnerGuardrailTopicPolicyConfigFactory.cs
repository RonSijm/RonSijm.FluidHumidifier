// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerGuardrailTopicPolicyConfigFactory(Action<Humidifier.Bedrock.GuardrailTypes.TopicPolicyConfig> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.GuardrailTypes.TopicPolicyConfig>
{

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

} // End Of Class

public static class InnerGuardrailTopicPolicyConfigFactoryExtensions
{
}
