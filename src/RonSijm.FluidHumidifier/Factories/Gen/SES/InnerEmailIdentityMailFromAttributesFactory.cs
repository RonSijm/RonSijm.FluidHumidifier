// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SES;

public class InnerEmailIdentityMailFromAttributesFactory(Action<Humidifier.SES.EmailIdentityTypes.MailFromAttributes> factoryAction = null) : SubResourceFactory<Humidifier.SES.EmailIdentityTypes.MailFromAttributes>
{

    protected override Humidifier.SES.EmailIdentityTypes.MailFromAttributes Create()
    {
        var mailFromAttributesResult = CreateMailFromAttributes();
        factoryAction?.Invoke(mailFromAttributesResult);

        return mailFromAttributesResult;
    }

    private Humidifier.SES.EmailIdentityTypes.MailFromAttributes CreateMailFromAttributes()
    {
        var mailFromAttributesResult = new Humidifier.SES.EmailIdentityTypes.MailFromAttributes();

        return mailFromAttributesResult;
    }

} // End Of Class

public static class InnerEmailIdentityMailFromAttributesFactoryExtensions
{
}
