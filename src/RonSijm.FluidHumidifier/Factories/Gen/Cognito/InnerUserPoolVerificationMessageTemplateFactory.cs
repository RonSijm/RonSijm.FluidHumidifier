// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cognito;

public class InnerUserPoolVerificationMessageTemplateFactory(Action<Humidifier.Cognito.UserPoolTypes.VerificationMessageTemplate> factoryAction = null) : SubResourceFactory<Humidifier.Cognito.UserPoolTypes.VerificationMessageTemplate>
{

    protected override Humidifier.Cognito.UserPoolTypes.VerificationMessageTemplate Create()
    {
        var verificationMessageTemplateResult = CreateVerificationMessageTemplate();
        factoryAction?.Invoke(verificationMessageTemplateResult);

        return verificationMessageTemplateResult;
    }

    private Humidifier.Cognito.UserPoolTypes.VerificationMessageTemplate CreateVerificationMessageTemplate()
    {
        var verificationMessageTemplateResult = new Humidifier.Cognito.UserPoolTypes.VerificationMessageTemplate();

        return verificationMessageTemplateResult;
    }

} // End Of Class

public static class InnerUserPoolVerificationMessageTemplateFactoryExtensions
{
}
