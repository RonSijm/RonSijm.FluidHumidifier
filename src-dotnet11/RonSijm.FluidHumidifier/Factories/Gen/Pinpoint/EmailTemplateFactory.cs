// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pinpoint;

public class EmailTemplateFactory(string resourceName = null, Action<Humidifier.Pinpoint.EmailTemplate> factoryAction = null) : ResourceFactory<Humidifier.Pinpoint.EmailTemplate>(resourceName)
{

    protected override Humidifier.Pinpoint.EmailTemplate Create()
    {
        var emailTemplateResult = CreateEmailTemplate();
        factoryAction?.Invoke(emailTemplateResult);

        return emailTemplateResult;
    }

    private Humidifier.Pinpoint.EmailTemplate CreateEmailTemplate()
    {
        var emailTemplateResult = new Humidifier.Pinpoint.EmailTemplate
        {
            GivenName = InputResourceName,
        };

        return emailTemplateResult;
    }

} // End Of Class

public static class EmailTemplateFactoryExtensions
{
}
