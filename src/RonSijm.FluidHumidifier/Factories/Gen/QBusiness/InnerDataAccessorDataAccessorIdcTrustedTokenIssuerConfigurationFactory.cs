// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QBusiness;

public class InnerDataAccessorDataAccessorIdcTrustedTokenIssuerConfigurationFactory(Action<Humidifier.QBusiness.DataAccessorTypes.DataAccessorIdcTrustedTokenIssuerConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.QBusiness.DataAccessorTypes.DataAccessorIdcTrustedTokenIssuerConfiguration>
{

    protected override Humidifier.QBusiness.DataAccessorTypes.DataAccessorIdcTrustedTokenIssuerConfiguration Create()
    {
        var dataAccessorIdcTrustedTokenIssuerConfigurationResult = CreateDataAccessorIdcTrustedTokenIssuerConfiguration();
        factoryAction?.Invoke(dataAccessorIdcTrustedTokenIssuerConfigurationResult);

        return dataAccessorIdcTrustedTokenIssuerConfigurationResult;
    }

    private Humidifier.QBusiness.DataAccessorTypes.DataAccessorIdcTrustedTokenIssuerConfiguration CreateDataAccessorIdcTrustedTokenIssuerConfiguration()
    {
        var dataAccessorIdcTrustedTokenIssuerConfigurationResult = new Humidifier.QBusiness.DataAccessorTypes.DataAccessorIdcTrustedTokenIssuerConfiguration();

        return dataAccessorIdcTrustedTokenIssuerConfigurationResult;
    }

} // End Of Class

public static class InnerDataAccessorDataAccessorIdcTrustedTokenIssuerConfigurationFactoryExtensions
{
}
