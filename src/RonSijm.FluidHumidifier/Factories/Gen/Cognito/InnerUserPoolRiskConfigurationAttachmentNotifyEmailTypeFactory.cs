// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cognito;

public class InnerUserPoolRiskConfigurationAttachmentNotifyEmailTypeFactory(Action<Humidifier.Cognito.UserPoolRiskConfigurationAttachmentTypes.NotifyEmailType> factoryAction = null) : SubResourceFactory<Humidifier.Cognito.UserPoolRiskConfigurationAttachmentTypes.NotifyEmailType>
{

    protected override Humidifier.Cognito.UserPoolRiskConfigurationAttachmentTypes.NotifyEmailType Create()
    {
        var notifyEmailTypeResult = CreateNotifyEmailType();
        factoryAction?.Invoke(notifyEmailTypeResult);

        return notifyEmailTypeResult;
    }

    private Humidifier.Cognito.UserPoolRiskConfigurationAttachmentTypes.NotifyEmailType CreateNotifyEmailType()
    {
        var notifyEmailTypeResult = new Humidifier.Cognito.UserPoolRiskConfigurationAttachmentTypes.NotifyEmailType();

        return notifyEmailTypeResult;
    }

} // End Of Class

public static class InnerUserPoolRiskConfigurationAttachmentNotifyEmailTypeFactoryExtensions
{
}
