// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pinpoint;

public class SmsTemplateFactory(string resourceName = null, Action<Humidifier.Pinpoint.SmsTemplate> factoryAction = null) : ResourceFactory<Humidifier.Pinpoint.SmsTemplate>(resourceName)
{

    protected override Humidifier.Pinpoint.SmsTemplate Create()
    {
        var smsTemplateResult = CreateSmsTemplate();
        factoryAction?.Invoke(smsTemplateResult);

        return smsTemplateResult;
    }

    private Humidifier.Pinpoint.SmsTemplate CreateSmsTemplate()
    {
        var smsTemplateResult = new Humidifier.Pinpoint.SmsTemplate
        {
            GivenName = InputResourceName,
        };

        return smsTemplateResult;
    }

} // End Of Class

public static class SmsTemplateFactoryExtensions
{
}
