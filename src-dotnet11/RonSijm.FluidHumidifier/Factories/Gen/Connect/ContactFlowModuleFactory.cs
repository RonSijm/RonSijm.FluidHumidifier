// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class ContactFlowModuleFactory(string resourceName = null, Action<Humidifier.Connect.ContactFlowModule> factoryAction = null) : ResourceFactory<Humidifier.Connect.ContactFlowModule>(resourceName)
{

    internal InnerContactFlowModuleExternalInvocationConfigurationFactory ExternalInvocationConfigurationFactory { get; set; }

    protected override Humidifier.Connect.ContactFlowModule Create()
    {
        var contactFlowModuleResult = CreateContactFlowModule();
        factoryAction?.Invoke(contactFlowModuleResult);

        return contactFlowModuleResult;
    }

    private Humidifier.Connect.ContactFlowModule CreateContactFlowModule()
    {
        var contactFlowModuleResult = new Humidifier.Connect.ContactFlowModule
        {
            GivenName = InputResourceName,
        };

        return contactFlowModuleResult;
    }
    public override void CreateChildren(Humidifier.Connect.ContactFlowModule result)
    {
        base.CreateChildren(result);

        result.ExternalInvocationConfiguration ??= ExternalInvocationConfigurationFactory?.Build();
    }

} // End Of Class

public static class ContactFlowModuleFactoryExtensions
{
    public static CombinedResult<ContactFlowModuleFactory, InnerContactFlowModuleExternalInvocationConfigurationFactory> WithExternalInvocationConfiguration(this ContactFlowModuleFactory parentFactory, Action<Humidifier.Connect.ContactFlowModuleTypes.ExternalInvocationConfiguration> subFactoryAction = null)
    {
        parentFactory.ExternalInvocationConfigurationFactory = new InnerContactFlowModuleExternalInvocationConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ExternalInvocationConfigurationFactory);
    }

    public static CombinedResult<ContactFlowModuleFactory, T1, InnerContactFlowModuleExternalInvocationConfigurationFactory> WithExternalInvocationConfiguration<T1>(this CombinedResult<ContactFlowModuleFactory, T1> combinedResult, Action<Humidifier.Connect.ContactFlowModuleTypes.ExternalInvocationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithExternalInvocationConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ContactFlowModuleFactory, InnerContactFlowModuleExternalInvocationConfigurationFactory> WithExternalInvocationConfiguration<T1>(this CombinedResult<T1, ContactFlowModuleFactory> combinedResult, Action<Humidifier.Connect.ContactFlowModuleTypes.ExternalInvocationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithExternalInvocationConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ContactFlowModuleFactory, T1, T2, InnerContactFlowModuleExternalInvocationConfigurationFactory> WithExternalInvocationConfiguration<T1, T2>(this CombinedResult<ContactFlowModuleFactory, T1, T2> combinedResult, Action<Humidifier.Connect.ContactFlowModuleTypes.ExternalInvocationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExternalInvocationConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ContactFlowModuleFactory, T2, InnerContactFlowModuleExternalInvocationConfigurationFactory> WithExternalInvocationConfiguration<T1, T2>(this CombinedResult<T1, ContactFlowModuleFactory, T2> combinedResult, Action<Humidifier.Connect.ContactFlowModuleTypes.ExternalInvocationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExternalInvocationConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ContactFlowModuleFactory, InnerContactFlowModuleExternalInvocationConfigurationFactory> WithExternalInvocationConfiguration<T1, T2>(this CombinedResult<T1, T2, ContactFlowModuleFactory> combinedResult, Action<Humidifier.Connect.ContactFlowModuleTypes.ExternalInvocationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExternalInvocationConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ContactFlowModuleFactory, T1, T2, T3, InnerContactFlowModuleExternalInvocationConfigurationFactory> WithExternalInvocationConfiguration<T1, T2, T3>(this CombinedResult<ContactFlowModuleFactory, T1, T2, T3> combinedResult, Action<Humidifier.Connect.ContactFlowModuleTypes.ExternalInvocationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExternalInvocationConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ContactFlowModuleFactory, T2, T3, InnerContactFlowModuleExternalInvocationConfigurationFactory> WithExternalInvocationConfiguration<T1, T2, T3>(this CombinedResult<T1, ContactFlowModuleFactory, T2, T3> combinedResult, Action<Humidifier.Connect.ContactFlowModuleTypes.ExternalInvocationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExternalInvocationConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ContactFlowModuleFactory, T3, InnerContactFlowModuleExternalInvocationConfigurationFactory> WithExternalInvocationConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, ContactFlowModuleFactory, T3> combinedResult, Action<Humidifier.Connect.ContactFlowModuleTypes.ExternalInvocationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExternalInvocationConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ContactFlowModuleFactory, InnerContactFlowModuleExternalInvocationConfigurationFactory> WithExternalInvocationConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, ContactFlowModuleFactory> combinedResult, Action<Humidifier.Connect.ContactFlowModuleTypes.ExternalInvocationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExternalInvocationConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ContactFlowModuleFactory, T1, T2, T3, T4, InnerContactFlowModuleExternalInvocationConfigurationFactory> WithExternalInvocationConfiguration<T1, T2, T3, T4>(this CombinedResult<ContactFlowModuleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Connect.ContactFlowModuleTypes.ExternalInvocationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExternalInvocationConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ContactFlowModuleFactory, T2, T3, T4, InnerContactFlowModuleExternalInvocationConfigurationFactory> WithExternalInvocationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, ContactFlowModuleFactory, T2, T3, T4> combinedResult, Action<Humidifier.Connect.ContactFlowModuleTypes.ExternalInvocationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExternalInvocationConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ContactFlowModuleFactory, T3, T4, InnerContactFlowModuleExternalInvocationConfigurationFactory> WithExternalInvocationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, ContactFlowModuleFactory, T3, T4> combinedResult, Action<Humidifier.Connect.ContactFlowModuleTypes.ExternalInvocationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExternalInvocationConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ContactFlowModuleFactory, T4, InnerContactFlowModuleExternalInvocationConfigurationFactory> WithExternalInvocationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ContactFlowModuleFactory, T4> combinedResult, Action<Humidifier.Connect.ContactFlowModuleTypes.ExternalInvocationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExternalInvocationConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ContactFlowModuleFactory, InnerContactFlowModuleExternalInvocationConfigurationFactory> WithExternalInvocationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ContactFlowModuleFactory> combinedResult, Action<Humidifier.Connect.ContactFlowModuleTypes.ExternalInvocationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExternalInvocationConfiguration(combinedResult.T5, subFactoryAction).T2);
}
