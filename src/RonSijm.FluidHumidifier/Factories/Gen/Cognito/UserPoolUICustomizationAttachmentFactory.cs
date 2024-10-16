// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cognito;

public class UserPoolUICustomizationAttachmentFactory(string resourceName = null, Action<Humidifier.Cognito.UserPoolUICustomizationAttachment> factoryAction = null) : ResourceFactory<Humidifier.Cognito.UserPoolUICustomizationAttachment>(resourceName)
{

    protected override Humidifier.Cognito.UserPoolUICustomizationAttachment Create()
    {
        var userPoolUICustomizationAttachmentResult = CreateUserPoolUICustomizationAttachment();
        factoryAction?.Invoke(userPoolUICustomizationAttachmentResult);

        return userPoolUICustomizationAttachmentResult;
    }

    private Humidifier.Cognito.UserPoolUICustomizationAttachment CreateUserPoolUICustomizationAttachment()
    {
        var userPoolUICustomizationAttachmentResult = new Humidifier.Cognito.UserPoolUICustomizationAttachment
        {
            GivenName = InputResourceName,
        };

        return userPoolUICustomizationAttachmentResult;
    }

} // End Of Class

public static class UserPoolUICustomizationAttachmentFactoryExtensions
{
}
