// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QBusiness;

public class InnerDataAccessorDataAccessorAuthenticationConfigurationFactory(Action<Humidifier.QBusiness.DataAccessorTypes.DataAccessorAuthenticationConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.QBusiness.DataAccessorTypes.DataAccessorAuthenticationConfiguration>
{

    internal InnerDataAccessorDataAccessorIdcTrustedTokenIssuerConfigurationFactory IdcTrustedTokenIssuerConfigurationFactory { get; set; }

    protected override Humidifier.QBusiness.DataAccessorTypes.DataAccessorAuthenticationConfiguration Create()
    {
        var dataAccessorAuthenticationConfigurationResult = CreateDataAccessorAuthenticationConfiguration();
        factoryAction?.Invoke(dataAccessorAuthenticationConfigurationResult);

        return dataAccessorAuthenticationConfigurationResult;
    }

    private Humidifier.QBusiness.DataAccessorTypes.DataAccessorAuthenticationConfiguration CreateDataAccessorAuthenticationConfiguration()
    {
        var dataAccessorAuthenticationConfigurationResult = new Humidifier.QBusiness.DataAccessorTypes.DataAccessorAuthenticationConfiguration();

        return dataAccessorAuthenticationConfigurationResult;
    }
    public override void CreateChildren(Humidifier.QBusiness.DataAccessorTypes.DataAccessorAuthenticationConfiguration result)
    {
        base.CreateChildren(result);

        result.IdcTrustedTokenIssuerConfiguration ??= IdcTrustedTokenIssuerConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerDataAccessorDataAccessorAuthenticationConfigurationFactoryExtensions
{
    public static CombinedResult<InnerDataAccessorDataAccessorAuthenticationConfigurationFactory, InnerDataAccessorDataAccessorIdcTrustedTokenIssuerConfigurationFactory> WithIdcTrustedTokenIssuerConfiguration(this InnerDataAccessorDataAccessorAuthenticationConfigurationFactory parentFactory, Action<Humidifier.QBusiness.DataAccessorTypes.DataAccessorIdcTrustedTokenIssuerConfiguration> subFactoryAction = null)
    {
        parentFactory.IdcTrustedTokenIssuerConfigurationFactory = new InnerDataAccessorDataAccessorIdcTrustedTokenIssuerConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.IdcTrustedTokenIssuerConfigurationFactory);
    }

    public static CombinedResult<InnerDataAccessorDataAccessorAuthenticationConfigurationFactory, T1, InnerDataAccessorDataAccessorIdcTrustedTokenIssuerConfigurationFactory> WithIdcTrustedTokenIssuerConfiguration<T1>(this CombinedResult<InnerDataAccessorDataAccessorAuthenticationConfigurationFactory, T1> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.DataAccessorIdcTrustedTokenIssuerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithIdcTrustedTokenIssuerConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataAccessorDataAccessorAuthenticationConfigurationFactory, InnerDataAccessorDataAccessorIdcTrustedTokenIssuerConfigurationFactory> WithIdcTrustedTokenIssuerConfiguration<T1>(this CombinedResult<T1, InnerDataAccessorDataAccessorAuthenticationConfigurationFactory> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.DataAccessorIdcTrustedTokenIssuerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithIdcTrustedTokenIssuerConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerDataAccessorDataAccessorAuthenticationConfigurationFactory, T1, T2, InnerDataAccessorDataAccessorIdcTrustedTokenIssuerConfigurationFactory> WithIdcTrustedTokenIssuerConfiguration<T1, T2>(this CombinedResult<InnerDataAccessorDataAccessorAuthenticationConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.DataAccessorIdcTrustedTokenIssuerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIdcTrustedTokenIssuerConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataAccessorDataAccessorAuthenticationConfigurationFactory, T2, InnerDataAccessorDataAccessorIdcTrustedTokenIssuerConfigurationFactory> WithIdcTrustedTokenIssuerConfiguration<T1, T2>(this CombinedResult<T1, InnerDataAccessorDataAccessorAuthenticationConfigurationFactory, T2> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.DataAccessorIdcTrustedTokenIssuerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIdcTrustedTokenIssuerConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataAccessorDataAccessorAuthenticationConfigurationFactory, InnerDataAccessorDataAccessorIdcTrustedTokenIssuerConfigurationFactory> WithIdcTrustedTokenIssuerConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerDataAccessorDataAccessorAuthenticationConfigurationFactory> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.DataAccessorIdcTrustedTokenIssuerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIdcTrustedTokenIssuerConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerDataAccessorDataAccessorAuthenticationConfigurationFactory, T1, T2, T3, InnerDataAccessorDataAccessorIdcTrustedTokenIssuerConfigurationFactory> WithIdcTrustedTokenIssuerConfiguration<T1, T2, T3>(this CombinedResult<InnerDataAccessorDataAccessorAuthenticationConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.DataAccessorIdcTrustedTokenIssuerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdcTrustedTokenIssuerConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataAccessorDataAccessorAuthenticationConfigurationFactory, T2, T3, InnerDataAccessorDataAccessorIdcTrustedTokenIssuerConfigurationFactory> WithIdcTrustedTokenIssuerConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerDataAccessorDataAccessorAuthenticationConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.DataAccessorIdcTrustedTokenIssuerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdcTrustedTokenIssuerConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataAccessorDataAccessorAuthenticationConfigurationFactory, T3, InnerDataAccessorDataAccessorIdcTrustedTokenIssuerConfigurationFactory> WithIdcTrustedTokenIssuerConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataAccessorDataAccessorAuthenticationConfigurationFactory, T3> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.DataAccessorIdcTrustedTokenIssuerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdcTrustedTokenIssuerConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDataAccessorDataAccessorAuthenticationConfigurationFactory, InnerDataAccessorDataAccessorIdcTrustedTokenIssuerConfigurationFactory> WithIdcTrustedTokenIssuerConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataAccessorDataAccessorAuthenticationConfigurationFactory> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.DataAccessorIdcTrustedTokenIssuerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdcTrustedTokenIssuerConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerDataAccessorDataAccessorAuthenticationConfigurationFactory, T1, T2, T3, T4, InnerDataAccessorDataAccessorIdcTrustedTokenIssuerConfigurationFactory> WithIdcTrustedTokenIssuerConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerDataAccessorDataAccessorAuthenticationConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.DataAccessorIdcTrustedTokenIssuerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdcTrustedTokenIssuerConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataAccessorDataAccessorAuthenticationConfigurationFactory, T2, T3, T4, InnerDataAccessorDataAccessorIdcTrustedTokenIssuerConfigurationFactory> WithIdcTrustedTokenIssuerConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataAccessorDataAccessorAuthenticationConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.DataAccessorIdcTrustedTokenIssuerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdcTrustedTokenIssuerConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataAccessorDataAccessorAuthenticationConfigurationFactory, T3, T4, InnerDataAccessorDataAccessorIdcTrustedTokenIssuerConfigurationFactory> WithIdcTrustedTokenIssuerConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataAccessorDataAccessorAuthenticationConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.DataAccessorIdcTrustedTokenIssuerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdcTrustedTokenIssuerConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDataAccessorDataAccessorAuthenticationConfigurationFactory, T4, InnerDataAccessorDataAccessorIdcTrustedTokenIssuerConfigurationFactory> WithIdcTrustedTokenIssuerConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataAccessorDataAccessorAuthenticationConfigurationFactory, T4> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.DataAccessorIdcTrustedTokenIssuerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdcTrustedTokenIssuerConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerDataAccessorDataAccessorAuthenticationConfigurationFactory, InnerDataAccessorDataAccessorIdcTrustedTokenIssuerConfigurationFactory> WithIdcTrustedTokenIssuerConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataAccessorDataAccessorAuthenticationConfigurationFactory> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.DataAccessorIdcTrustedTokenIssuerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdcTrustedTokenIssuerConfiguration(combinedResult.T5, subFactoryAction).T2);
}
