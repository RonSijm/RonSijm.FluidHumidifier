// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class EmailAddressFactory(string resourceName = null, Action<Humidifier.Connect.EmailAddress> factoryAction = null) : ResourceFactory<Humidifier.Connect.EmailAddress>(resourceName)
{

    internal List<InnerEmailAddressAliasConfigurationFactory> AliasConfigurationsFactories { get; set; } = [];

    protected override Humidifier.Connect.EmailAddress Create()
    {
        var emailAddressResult = CreateEmailAddress();
        factoryAction?.Invoke(emailAddressResult);

        return emailAddressResult;
    }

    private Humidifier.Connect.EmailAddress CreateEmailAddress()
    {
        var emailAddressResult = new Humidifier.Connect.EmailAddress
        {
            GivenName = InputResourceName,
        };

        return emailAddressResult;
    }
    public override void CreateChildren(Humidifier.Connect.EmailAddress result)
    {
        base.CreateChildren(result);

        result.AliasConfigurations = AliasConfigurationsFactories.Any() ? AliasConfigurationsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class EmailAddressFactoryExtensions
{
    public static CombinedResult<EmailAddressFactory, InnerEmailAddressAliasConfigurationFactory> WithAliasConfigurations(this EmailAddressFactory parentFactory, Action<Humidifier.Connect.EmailAddressTypes.AliasConfiguration> subFactoryAction = null)
    {
        var factory = new InnerEmailAddressAliasConfigurationFactory(subFactoryAction);
        parentFactory.AliasConfigurationsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<EmailAddressFactory, T1, InnerEmailAddressAliasConfigurationFactory> WithAliasConfigurations<T1>(this CombinedResult<EmailAddressFactory, T1> combinedResult, Action<Humidifier.Connect.EmailAddressTypes.AliasConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithAliasConfigurations(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, EmailAddressFactory, InnerEmailAddressAliasConfigurationFactory> WithAliasConfigurations<T1>(this CombinedResult<T1, EmailAddressFactory> combinedResult, Action<Humidifier.Connect.EmailAddressTypes.AliasConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithAliasConfigurations(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<EmailAddressFactory, T1, T2, InnerEmailAddressAliasConfigurationFactory> WithAliasConfigurations<T1, T2>(this CombinedResult<EmailAddressFactory, T1, T2> combinedResult, Action<Humidifier.Connect.EmailAddressTypes.AliasConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAliasConfigurations(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, EmailAddressFactory, T2, InnerEmailAddressAliasConfigurationFactory> WithAliasConfigurations<T1, T2>(this CombinedResult<T1, EmailAddressFactory, T2> combinedResult, Action<Humidifier.Connect.EmailAddressTypes.AliasConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAliasConfigurations(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, EmailAddressFactory, InnerEmailAddressAliasConfigurationFactory> WithAliasConfigurations<T1, T2>(this CombinedResult<T1, T2, EmailAddressFactory> combinedResult, Action<Humidifier.Connect.EmailAddressTypes.AliasConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAliasConfigurations(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<EmailAddressFactory, T1, T2, T3, InnerEmailAddressAliasConfigurationFactory> WithAliasConfigurations<T1, T2, T3>(this CombinedResult<EmailAddressFactory, T1, T2, T3> combinedResult, Action<Humidifier.Connect.EmailAddressTypes.AliasConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAliasConfigurations(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, EmailAddressFactory, T2, T3, InnerEmailAddressAliasConfigurationFactory> WithAliasConfigurations<T1, T2, T3>(this CombinedResult<T1, EmailAddressFactory, T2, T3> combinedResult, Action<Humidifier.Connect.EmailAddressTypes.AliasConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAliasConfigurations(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, EmailAddressFactory, T3, InnerEmailAddressAliasConfigurationFactory> WithAliasConfigurations<T1, T2, T3>(this CombinedResult<T1, T2, EmailAddressFactory, T3> combinedResult, Action<Humidifier.Connect.EmailAddressTypes.AliasConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAliasConfigurations(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, EmailAddressFactory, InnerEmailAddressAliasConfigurationFactory> WithAliasConfigurations<T1, T2, T3>(this CombinedResult<T1, T2, T3, EmailAddressFactory> combinedResult, Action<Humidifier.Connect.EmailAddressTypes.AliasConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAliasConfigurations(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<EmailAddressFactory, T1, T2, T3, T4, InnerEmailAddressAliasConfigurationFactory> WithAliasConfigurations<T1, T2, T3, T4>(this CombinedResult<EmailAddressFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Connect.EmailAddressTypes.AliasConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAliasConfigurations(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, EmailAddressFactory, T2, T3, T4, InnerEmailAddressAliasConfigurationFactory> WithAliasConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, EmailAddressFactory, T2, T3, T4> combinedResult, Action<Humidifier.Connect.EmailAddressTypes.AliasConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAliasConfigurations(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, EmailAddressFactory, T3, T4, InnerEmailAddressAliasConfigurationFactory> WithAliasConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, EmailAddressFactory, T3, T4> combinedResult, Action<Humidifier.Connect.EmailAddressTypes.AliasConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAliasConfigurations(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, EmailAddressFactory, T4, InnerEmailAddressAliasConfigurationFactory> WithAliasConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, EmailAddressFactory, T4> combinedResult, Action<Humidifier.Connect.EmailAddressTypes.AliasConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAliasConfigurations(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, EmailAddressFactory, InnerEmailAddressAliasConfigurationFactory> WithAliasConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, EmailAddressFactory> combinedResult, Action<Humidifier.Connect.EmailAddressTypes.AliasConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAliasConfigurations(combinedResult.T5, subFactoryAction).T2);
}
