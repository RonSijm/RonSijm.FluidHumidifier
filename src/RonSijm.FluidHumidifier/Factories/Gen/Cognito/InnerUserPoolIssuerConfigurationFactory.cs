// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cognito;

public class InnerUserPoolIssuerConfigurationFactory(Action<Humidifier.Cognito.UserPoolTypes.IssuerConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Cognito.UserPoolTypes.IssuerConfiguration>
{

    protected override Humidifier.Cognito.UserPoolTypes.IssuerConfiguration Create()
    {
        var issuerConfigurationResult = CreateIssuerConfiguration();
        factoryAction?.Invoke(issuerConfigurationResult);

        return issuerConfigurationResult;
    }

    private Humidifier.Cognito.UserPoolTypes.IssuerConfiguration CreateIssuerConfiguration()
    {
        var issuerConfigurationResult = new Humidifier.Cognito.UserPoolTypes.IssuerConfiguration();

        return issuerConfigurationResult;
    }

} // End Of Class

public static class InnerUserPoolIssuerConfigurationFactoryExtensions
{
}
