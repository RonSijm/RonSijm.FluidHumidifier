// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cognito;

public class InnerUserPoolRegionalConfigurationAttachmentEmailConfigurationFactory(Action<Humidifier.Cognito.UserPoolRegionalConfigurationAttachmentTypes.EmailConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Cognito.UserPoolRegionalConfigurationAttachmentTypes.EmailConfiguration>
{

    protected override Humidifier.Cognito.UserPoolRegionalConfigurationAttachmentTypes.EmailConfiguration Create()
    {
        var emailConfigurationResult = CreateEmailConfiguration();
        factoryAction?.Invoke(emailConfigurationResult);

        return emailConfigurationResult;
    }

    private Humidifier.Cognito.UserPoolRegionalConfigurationAttachmentTypes.EmailConfiguration CreateEmailConfiguration()
    {
        var emailConfigurationResult = new Humidifier.Cognito.UserPoolRegionalConfigurationAttachmentTypes.EmailConfiguration();

        return emailConfigurationResult;
    }

} // End Of Class

public static class InnerUserPoolRegionalConfigurationAttachmentEmailConfigurationFactoryExtensions
{
}
