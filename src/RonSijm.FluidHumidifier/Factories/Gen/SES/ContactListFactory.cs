// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SES;

public class ContactListFactory(string resourceName = null, Action<Humidifier.SES.ContactList> factoryAction = null) : ResourceFactory<Humidifier.SES.ContactList>(resourceName)
{

    internal List<InnerContactListTopicFactory> TopicsFactories { get; set; } = [];

    protected override Humidifier.SES.ContactList Create()
    {
        var contactListResult = CreateContactList();
        factoryAction?.Invoke(contactListResult);

        return contactListResult;
    }

    private Humidifier.SES.ContactList CreateContactList()
    {
        var contactListResult = new Humidifier.SES.ContactList
        {
            GivenName = InputResourceName,
        };

        return contactListResult;
    }
    public override void CreateChildren(Humidifier.SES.ContactList result)
    {
        base.CreateChildren(result);

        result.Topics = TopicsFactories.Any() ? TopicsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class ContactListFactoryExtensions
{
    public static CombinedResult<ContactListFactory, InnerContactListTopicFactory> WithTopics(this ContactListFactory parentFactory, Action<Humidifier.SES.ContactListTypes.Topic> subFactoryAction = null)
    {
        var factory = new InnerContactListTopicFactory(subFactoryAction);
        parentFactory.TopicsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ContactListFactory, T1, InnerContactListTopicFactory> WithTopics<T1>(this CombinedResult<ContactListFactory, T1> combinedResult, Action<Humidifier.SES.ContactListTypes.Topic> subFactoryAction = null) => new (combinedResult, combinedResult, WithTopics(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ContactListFactory, InnerContactListTopicFactory> WithTopics<T1>(this CombinedResult<T1, ContactListFactory> combinedResult, Action<Humidifier.SES.ContactListTypes.Topic> subFactoryAction = null) => new (combinedResult, combinedResult, WithTopics(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ContactListFactory, T1, T2, InnerContactListTopicFactory> WithTopics<T1, T2>(this CombinedResult<ContactListFactory, T1, T2> combinedResult, Action<Humidifier.SES.ContactListTypes.Topic> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTopics(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ContactListFactory, T2, InnerContactListTopicFactory> WithTopics<T1, T2>(this CombinedResult<T1, ContactListFactory, T2> combinedResult, Action<Humidifier.SES.ContactListTypes.Topic> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTopics(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ContactListFactory, InnerContactListTopicFactory> WithTopics<T1, T2>(this CombinedResult<T1, T2, ContactListFactory> combinedResult, Action<Humidifier.SES.ContactListTypes.Topic> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTopics(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ContactListFactory, T1, T2, T3, InnerContactListTopicFactory> WithTopics<T1, T2, T3>(this CombinedResult<ContactListFactory, T1, T2, T3> combinedResult, Action<Humidifier.SES.ContactListTypes.Topic> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTopics(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ContactListFactory, T2, T3, InnerContactListTopicFactory> WithTopics<T1, T2, T3>(this CombinedResult<T1, ContactListFactory, T2, T3> combinedResult, Action<Humidifier.SES.ContactListTypes.Topic> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTopics(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ContactListFactory, T3, InnerContactListTopicFactory> WithTopics<T1, T2, T3>(this CombinedResult<T1, T2, ContactListFactory, T3> combinedResult, Action<Humidifier.SES.ContactListTypes.Topic> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTopics(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ContactListFactory, InnerContactListTopicFactory> WithTopics<T1, T2, T3>(this CombinedResult<T1, T2, T3, ContactListFactory> combinedResult, Action<Humidifier.SES.ContactListTypes.Topic> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTopics(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ContactListFactory, T1, T2, T3, T4, InnerContactListTopicFactory> WithTopics<T1, T2, T3, T4>(this CombinedResult<ContactListFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SES.ContactListTypes.Topic> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTopics(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ContactListFactory, T2, T3, T4, InnerContactListTopicFactory> WithTopics<T1, T2, T3, T4>(this CombinedResult<T1, ContactListFactory, T2, T3, T4> combinedResult, Action<Humidifier.SES.ContactListTypes.Topic> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTopics(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ContactListFactory, T3, T4, InnerContactListTopicFactory> WithTopics<T1, T2, T3, T4>(this CombinedResult<T1, T2, ContactListFactory, T3, T4> combinedResult, Action<Humidifier.SES.ContactListTypes.Topic> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTopics(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ContactListFactory, T4, InnerContactListTopicFactory> WithTopics<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ContactListFactory, T4> combinedResult, Action<Humidifier.SES.ContactListTypes.Topic> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTopics(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ContactListFactory, InnerContactListTopicFactory> WithTopics<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ContactListFactory> combinedResult, Action<Humidifier.SES.ContactListTypes.Topic> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTopics(combinedResult.T5, subFactoryAction));
}
