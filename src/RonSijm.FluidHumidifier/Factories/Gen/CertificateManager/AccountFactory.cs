// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CertificateManager;

public class AccountFactory(string resourceName = null, Action<Humidifier.CertificateManager.Account> factoryAction = null) : ResourceFactory<Humidifier.CertificateManager.Account>(resourceName)
{

    internal InnerAccountExpiryEventsConfigurationFactory ExpiryEventsConfigurationFactory { get; set; }

    protected override Humidifier.CertificateManager.Account Create()
    {
        var accountResult = CreateAccount();
        factoryAction?.Invoke(accountResult);

        return accountResult;
    }

    private Humidifier.CertificateManager.Account CreateAccount()
    {
        var accountResult = new Humidifier.CertificateManager.Account
        {
            GivenName = InputResourceName,
        };

        return accountResult;
    }
    public override void CreateChildren(Humidifier.CertificateManager.Account result)
    {
        base.CreateChildren(result);

        result.ExpiryEventsConfiguration ??= ExpiryEventsConfigurationFactory?.Build();
    }

} // End Of Class

public static class AccountFactoryExtensions
{
    public static CombinedResult<AccountFactory, InnerAccountExpiryEventsConfigurationFactory> WithExpiryEventsConfiguration(this AccountFactory parentFactory, Action<Humidifier.CertificateManager.AccountTypes.ExpiryEventsConfiguration> subFactoryAction = null)
    {
        parentFactory.ExpiryEventsConfigurationFactory = new InnerAccountExpiryEventsConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ExpiryEventsConfigurationFactory);
    }

    public static CombinedResult<AccountFactory, T1, InnerAccountExpiryEventsConfigurationFactory> WithExpiryEventsConfiguration<T1>(this CombinedResult<AccountFactory, T1> combinedResult, Action<Humidifier.CertificateManager.AccountTypes.ExpiryEventsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithExpiryEventsConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AccountFactory, InnerAccountExpiryEventsConfigurationFactory> WithExpiryEventsConfiguration<T1>(this CombinedResult<T1, AccountFactory> combinedResult, Action<Humidifier.CertificateManager.AccountTypes.ExpiryEventsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithExpiryEventsConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<AccountFactory, T1, T2, InnerAccountExpiryEventsConfigurationFactory> WithExpiryEventsConfiguration<T1, T2>(this CombinedResult<AccountFactory, T1, T2> combinedResult, Action<Humidifier.CertificateManager.AccountTypes.ExpiryEventsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExpiryEventsConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AccountFactory, T2, InnerAccountExpiryEventsConfigurationFactory> WithExpiryEventsConfiguration<T1, T2>(this CombinedResult<T1, AccountFactory, T2> combinedResult, Action<Humidifier.CertificateManager.AccountTypes.ExpiryEventsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExpiryEventsConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AccountFactory, InnerAccountExpiryEventsConfigurationFactory> WithExpiryEventsConfiguration<T1, T2>(this CombinedResult<T1, T2, AccountFactory> combinedResult, Action<Humidifier.CertificateManager.AccountTypes.ExpiryEventsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExpiryEventsConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<AccountFactory, T1, T2, T3, InnerAccountExpiryEventsConfigurationFactory> WithExpiryEventsConfiguration<T1, T2, T3>(this CombinedResult<AccountFactory, T1, T2, T3> combinedResult, Action<Humidifier.CertificateManager.AccountTypes.ExpiryEventsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExpiryEventsConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AccountFactory, T2, T3, InnerAccountExpiryEventsConfigurationFactory> WithExpiryEventsConfiguration<T1, T2, T3>(this CombinedResult<T1, AccountFactory, T2, T3> combinedResult, Action<Humidifier.CertificateManager.AccountTypes.ExpiryEventsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExpiryEventsConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AccountFactory, T3, InnerAccountExpiryEventsConfigurationFactory> WithExpiryEventsConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, AccountFactory, T3> combinedResult, Action<Humidifier.CertificateManager.AccountTypes.ExpiryEventsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExpiryEventsConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AccountFactory, InnerAccountExpiryEventsConfigurationFactory> WithExpiryEventsConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, AccountFactory> combinedResult, Action<Humidifier.CertificateManager.AccountTypes.ExpiryEventsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExpiryEventsConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<AccountFactory, T1, T2, T3, T4, InnerAccountExpiryEventsConfigurationFactory> WithExpiryEventsConfiguration<T1, T2, T3, T4>(this CombinedResult<AccountFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CertificateManager.AccountTypes.ExpiryEventsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExpiryEventsConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AccountFactory, T2, T3, T4, InnerAccountExpiryEventsConfigurationFactory> WithExpiryEventsConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, AccountFactory, T2, T3, T4> combinedResult, Action<Humidifier.CertificateManager.AccountTypes.ExpiryEventsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExpiryEventsConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AccountFactory, T3, T4, InnerAccountExpiryEventsConfigurationFactory> WithExpiryEventsConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, AccountFactory, T3, T4> combinedResult, Action<Humidifier.CertificateManager.AccountTypes.ExpiryEventsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExpiryEventsConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AccountFactory, T4, InnerAccountExpiryEventsConfigurationFactory> WithExpiryEventsConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AccountFactory, T4> combinedResult, Action<Humidifier.CertificateManager.AccountTypes.ExpiryEventsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExpiryEventsConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, AccountFactory, InnerAccountExpiryEventsConfigurationFactory> WithExpiryEventsConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AccountFactory> combinedResult, Action<Humidifier.CertificateManager.AccountTypes.ExpiryEventsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExpiryEventsConfiguration(combinedResult.T5, subFactoryAction));
}
