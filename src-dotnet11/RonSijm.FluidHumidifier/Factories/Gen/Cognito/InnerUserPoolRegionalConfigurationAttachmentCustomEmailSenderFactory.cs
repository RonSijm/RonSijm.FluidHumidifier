// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cognito;

public class InnerUserPoolRegionalConfigurationAttachmentCustomEmailSenderFactory(Action<Humidifier.Cognito.UserPoolRegionalConfigurationAttachmentTypes.CustomEmailSender> factoryAction = null) : SubResourceFactory<Humidifier.Cognito.UserPoolRegionalConfigurationAttachmentTypes.CustomEmailSender>
{

    protected override Humidifier.Cognito.UserPoolRegionalConfigurationAttachmentTypes.CustomEmailSender Create()
    {
        var customEmailSenderResult = CreateCustomEmailSender();
        factoryAction?.Invoke(customEmailSenderResult);

        return customEmailSenderResult;
    }

    private Humidifier.Cognito.UserPoolRegionalConfigurationAttachmentTypes.CustomEmailSender CreateCustomEmailSender()
    {
        var customEmailSenderResult = new Humidifier.Cognito.UserPoolRegionalConfigurationAttachmentTypes.CustomEmailSender();

        return customEmailSenderResult;
    }

} // End Of Class

public static class InnerUserPoolRegionalConfigurationAttachmentCustomEmailSenderFactoryExtensions
{
}
