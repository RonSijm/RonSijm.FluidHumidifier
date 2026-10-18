// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SES;

public class CustomVerificationEmailTemplateFactory(string resourceName = null, Action<Humidifier.SES.CustomVerificationEmailTemplate> factoryAction = null) : ResourceFactory<Humidifier.SES.CustomVerificationEmailTemplate>(resourceName)
{

    protected override Humidifier.SES.CustomVerificationEmailTemplate Create()
    {
        var customVerificationEmailTemplateResult = CreateCustomVerificationEmailTemplate();
        factoryAction?.Invoke(customVerificationEmailTemplateResult);

        return customVerificationEmailTemplateResult;
    }

    private Humidifier.SES.CustomVerificationEmailTemplate CreateCustomVerificationEmailTemplate()
    {
        var customVerificationEmailTemplateResult = new Humidifier.SES.CustomVerificationEmailTemplate
        {
            GivenName = InputResourceName,
        };

        return customVerificationEmailTemplateResult;
    }

} // End Of Class

public static class CustomVerificationEmailTemplateFactoryExtensions
{
}
