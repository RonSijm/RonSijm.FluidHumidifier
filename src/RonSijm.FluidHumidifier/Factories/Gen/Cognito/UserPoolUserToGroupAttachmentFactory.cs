// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cognito;

public class UserPoolUserToGroupAttachmentFactory(string resourceName = null, Action<Humidifier.Cognito.UserPoolUserToGroupAttachment> factoryAction = null) : ResourceFactory<Humidifier.Cognito.UserPoolUserToGroupAttachment>(resourceName)
{

    protected override Humidifier.Cognito.UserPoolUserToGroupAttachment Create()
    {
        var userPoolUserToGroupAttachmentResult = CreateUserPoolUserToGroupAttachment();
        factoryAction?.Invoke(userPoolUserToGroupAttachmentResult);

        return userPoolUserToGroupAttachmentResult;
    }

    private Humidifier.Cognito.UserPoolUserToGroupAttachment CreateUserPoolUserToGroupAttachment()
    {
        var userPoolUserToGroupAttachmentResult = new Humidifier.Cognito.UserPoolUserToGroupAttachment
        {
            GivenName = InputResourceName,
        };

        return userPoolUserToGroupAttachmentResult;
    }

} // End Of Class

public static class UserPoolUserToGroupAttachmentFactoryExtensions
{
}
