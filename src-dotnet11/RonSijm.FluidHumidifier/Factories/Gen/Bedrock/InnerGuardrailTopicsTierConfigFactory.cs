// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerGuardrailTopicsTierConfigFactory(Action<Humidifier.Bedrock.GuardrailTypes.TopicsTierConfig> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.GuardrailTypes.TopicsTierConfig>
{

    protected override Humidifier.Bedrock.GuardrailTypes.TopicsTierConfig Create()
    {
        var topicsTierConfigResult = CreateTopicsTierConfig();
        factoryAction?.Invoke(topicsTierConfigResult);

        return topicsTierConfigResult;
    }

    private Humidifier.Bedrock.GuardrailTypes.TopicsTierConfig CreateTopicsTierConfig()
    {
        var topicsTierConfigResult = new Humidifier.Bedrock.GuardrailTypes.TopicsTierConfig();

        return topicsTierConfigResult;
    }

} // End Of Class

public static class InnerGuardrailTopicsTierConfigFactoryExtensions
{
}
