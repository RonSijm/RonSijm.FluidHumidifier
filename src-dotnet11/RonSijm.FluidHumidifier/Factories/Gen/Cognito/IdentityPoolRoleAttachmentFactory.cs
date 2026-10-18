// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cognito;

public class IdentityPoolRoleAttachmentFactory(string resourceName = null, Action<Humidifier.Cognito.IdentityPoolRoleAttachment> factoryAction = null) : ResourceFactory<Humidifier.Cognito.IdentityPoolRoleAttachment>(resourceName)
{

    protected override Humidifier.Cognito.IdentityPoolRoleAttachment Create()
    {
        var identityPoolRoleAttachmentResult = CreateIdentityPoolRoleAttachment();
        factoryAction?.Invoke(identityPoolRoleAttachmentResult);

        return identityPoolRoleAttachmentResult;
    }

    private Humidifier.Cognito.IdentityPoolRoleAttachment CreateIdentityPoolRoleAttachment()
    {
        var identityPoolRoleAttachmentResult = new Humidifier.Cognito.IdentityPoolRoleAttachment
        {
            GivenName = InputResourceName,
        };

        return identityPoolRoleAttachmentResult;
    }

} // End Of Class

public static class IdentityPoolRoleAttachmentFactoryExtensions
{
}
