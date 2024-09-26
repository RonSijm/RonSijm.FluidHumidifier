// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SSMContacts;

public class ContactFactory(string resourceName = null, Action<Humidifier.SSMContacts.Contact> factoryAction = null) : ResourceFactory<Humidifier.SSMContacts.Contact>(resourceName)
{

    internal List<InnerContactStageFactory> PlanFactories { get; set; } = [];

    protected override Humidifier.SSMContacts.Contact Create()
    {
        var contactResult = CreateContact();
        factoryAction?.Invoke(contactResult);

        return contactResult;
    }

    private Humidifier.SSMContacts.Contact CreateContact()
    {
        var contactResult = new Humidifier.SSMContacts.Contact
        {
            GivenName = InputResourceName,
        };

        return contactResult;
    }
    public override void CreateChildren(Humidifier.SSMContacts.Contact result)
    {
        base.CreateChildren(result);

        result.Plan = PlanFactories.Any() ? PlanFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class ContactFactoryExtensions
{
    public static CombinedResult<ContactFactory, InnerContactStageFactory> WithPlan(this ContactFactory parentFactory, Action<Humidifier.SSMContacts.ContactTypes.Stage> subFactoryAction = null)
    {
        var factory = new InnerContactStageFactory(subFactoryAction);
        parentFactory.PlanFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ContactFactory, T1, InnerContactStageFactory> WithPlan<T1>(this CombinedResult<ContactFactory, T1> combinedResult, Action<Humidifier.SSMContacts.ContactTypes.Stage> subFactoryAction = null) => new (combinedResult, combinedResult, WithPlan(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ContactFactory, InnerContactStageFactory> WithPlan<T1>(this CombinedResult<T1, ContactFactory> combinedResult, Action<Humidifier.SSMContacts.ContactTypes.Stage> subFactoryAction = null) => new (combinedResult, combinedResult, WithPlan(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ContactFactory, T1, T2, InnerContactStageFactory> WithPlan<T1, T2>(this CombinedResult<ContactFactory, T1, T2> combinedResult, Action<Humidifier.SSMContacts.ContactTypes.Stage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPlan(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ContactFactory, T2, InnerContactStageFactory> WithPlan<T1, T2>(this CombinedResult<T1, ContactFactory, T2> combinedResult, Action<Humidifier.SSMContacts.ContactTypes.Stage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPlan(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ContactFactory, InnerContactStageFactory> WithPlan<T1, T2>(this CombinedResult<T1, T2, ContactFactory> combinedResult, Action<Humidifier.SSMContacts.ContactTypes.Stage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPlan(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ContactFactory, T1, T2, T3, InnerContactStageFactory> WithPlan<T1, T2, T3>(this CombinedResult<ContactFactory, T1, T2, T3> combinedResult, Action<Humidifier.SSMContacts.ContactTypes.Stage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPlan(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ContactFactory, T2, T3, InnerContactStageFactory> WithPlan<T1, T2, T3>(this CombinedResult<T1, ContactFactory, T2, T3> combinedResult, Action<Humidifier.SSMContacts.ContactTypes.Stage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPlan(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ContactFactory, T3, InnerContactStageFactory> WithPlan<T1, T2, T3>(this CombinedResult<T1, T2, ContactFactory, T3> combinedResult, Action<Humidifier.SSMContacts.ContactTypes.Stage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPlan(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ContactFactory, InnerContactStageFactory> WithPlan<T1, T2, T3>(this CombinedResult<T1, T2, T3, ContactFactory> combinedResult, Action<Humidifier.SSMContacts.ContactTypes.Stage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPlan(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ContactFactory, T1, T2, T3, T4, InnerContactStageFactory> WithPlan<T1, T2, T3, T4>(this CombinedResult<ContactFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SSMContacts.ContactTypes.Stage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPlan(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ContactFactory, T2, T3, T4, InnerContactStageFactory> WithPlan<T1, T2, T3, T4>(this CombinedResult<T1, ContactFactory, T2, T3, T4> combinedResult, Action<Humidifier.SSMContacts.ContactTypes.Stage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPlan(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ContactFactory, T3, T4, InnerContactStageFactory> WithPlan<T1, T2, T3, T4>(this CombinedResult<T1, T2, ContactFactory, T3, T4> combinedResult, Action<Humidifier.SSMContacts.ContactTypes.Stage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPlan(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ContactFactory, T4, InnerContactStageFactory> WithPlan<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ContactFactory, T4> combinedResult, Action<Humidifier.SSMContacts.ContactTypes.Stage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPlan(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ContactFactory, InnerContactStageFactory> WithPlan<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ContactFactory> combinedResult, Action<Humidifier.SSMContacts.ContactTypes.Stage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPlan(combinedResult.T5, subFactoryAction));
}
