// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MSK;

public class TopicFactory(string resourceName = null, Action<Humidifier.MSK.Topic> factoryAction = null) : ResourceFactory<Humidifier.MSK.Topic>(resourceName)
{

    protected override Humidifier.MSK.Topic Create()
    {
        var topicResult = CreateTopic();
        factoryAction?.Invoke(topicResult);

        return topicResult;
    }

    private Humidifier.MSK.Topic CreateTopic()
    {
        var topicResult = new Humidifier.MSK.Topic
        {
            GivenName = InputResourceName,
        };

        return topicResult;
    }

} // End Of Class

public static class TopicFactoryExtensions
{
}
