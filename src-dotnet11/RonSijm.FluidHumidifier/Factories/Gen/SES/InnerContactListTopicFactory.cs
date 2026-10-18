// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SES;

public class InnerContactListTopicFactory(Action<Humidifier.SES.ContactListTypes.Topic> factoryAction = null) : SubResourceFactory<Humidifier.SES.ContactListTypes.Topic>
{

    protected override Humidifier.SES.ContactListTypes.Topic Create()
    {
        var topicResult = CreateTopic();
        factoryAction?.Invoke(topicResult);

        return topicResult;
    }

    private Humidifier.SES.ContactListTypes.Topic CreateTopic()
    {
        var topicResult = new Humidifier.SES.ContactListTypes.Topic();

        return topicResult;
    }

} // End Of Class

public static class InnerContactListTopicFactoryExtensions
{
}
