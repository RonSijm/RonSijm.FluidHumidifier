// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SNS;

public class TopicInlinePolicyFactory(string resourceName = null, Action<Humidifier.SNS.TopicInlinePolicy> factoryAction = null) : ResourceFactory<Humidifier.SNS.TopicInlinePolicy>(resourceName)
{

    protected override Humidifier.SNS.TopicInlinePolicy Create()
    {
        var topicInlinePolicyResult = CreateTopicInlinePolicy();
        factoryAction?.Invoke(topicInlinePolicyResult);

        return topicInlinePolicyResult;
    }

    private Humidifier.SNS.TopicInlinePolicy CreateTopicInlinePolicy()
    {
        var topicInlinePolicyResult = new Humidifier.SNS.TopicInlinePolicy
        {
            GivenName = InputResourceName,
        };

        return topicInlinePolicyResult;
    }

} // End Of Class

public static class TopicInlinePolicyFactoryExtensions
{
}
