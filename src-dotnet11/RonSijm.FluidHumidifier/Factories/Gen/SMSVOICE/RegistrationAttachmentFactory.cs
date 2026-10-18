// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SMSVOICE;

public class RegistrationAttachmentFactory(string resourceName = null, Action<Humidifier.SMSVOICE.RegistrationAttachment> factoryAction = null) : ResourceFactory<Humidifier.SMSVOICE.RegistrationAttachment>(resourceName)
{

    protected override Humidifier.SMSVOICE.RegistrationAttachment Create()
    {
        var registrationAttachmentResult = CreateRegistrationAttachment();
        factoryAction?.Invoke(registrationAttachmentResult);

        return registrationAttachmentResult;
    }

    private Humidifier.SMSVOICE.RegistrationAttachment CreateRegistrationAttachment()
    {
        var registrationAttachmentResult = new Humidifier.SMSVOICE.RegistrationAttachment
        {
            GivenName = InputResourceName,
        };

        return registrationAttachmentResult;
    }

} // End Of Class

public static class RegistrationAttachmentFactoryExtensions
{
}
