// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.PinpointEmail;

public class InnerIdentityMailFromAttributesFactory(Action<Humidifier.PinpointEmail.IdentityTypes.MailFromAttributes> factoryAction = null) : SubResourceFactory<Humidifier.PinpointEmail.IdentityTypes.MailFromAttributes>
{

    protected override Humidifier.PinpointEmail.IdentityTypes.MailFromAttributes Create()
    {
        var mailFromAttributesResult = CreateMailFromAttributes();
        factoryAction?.Invoke(mailFromAttributesResult);

        return mailFromAttributesResult;
    }

    private Humidifier.PinpointEmail.IdentityTypes.MailFromAttributes CreateMailFromAttributes()
    {
        var mailFromAttributesResult = new Humidifier.PinpointEmail.IdentityTypes.MailFromAttributes();

        return mailFromAttributesResult;
    }

} // End Of Class

public static class InnerIdentityMailFromAttributesFactoryExtensions
{
}
