// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SNS;

public class TopicPolicyFactory(string resourceName = null, Action<Humidifier.SNS.TopicPolicy> factoryAction = null) : ResourceFactory<Humidifier.SNS.TopicPolicy>(resourceName)
{

    protected override Humidifier.SNS.TopicPolicy Create()
    {
        var topicPolicyResult = CreateTopicPolicy();
        factoryAction?.Invoke(topicPolicyResult);

        return topicPolicyResult;
    }

    private Humidifier.SNS.TopicPolicy CreateTopicPolicy()
    {
        var topicPolicyResult = new Humidifier.SNS.TopicPolicy
        {
            GivenName = InputResourceName,
        };

        return topicPolicyResult;
    }

} // End Of Class

public static class TopicPolicyFactoryExtensions
{
}
