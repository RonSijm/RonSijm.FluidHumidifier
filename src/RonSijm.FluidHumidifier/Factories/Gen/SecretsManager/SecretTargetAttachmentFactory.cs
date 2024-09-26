// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecretsManager;

public class SecretTargetAttachmentFactory(string resourceName = null, Action<Humidifier.SecretsManager.SecretTargetAttachment> factoryAction = null) : ResourceFactory<Humidifier.SecretsManager.SecretTargetAttachment>(resourceName)
{

    protected override Humidifier.SecretsManager.SecretTargetAttachment Create()
    {
        var secretTargetAttachmentResult = CreateSecretTargetAttachment();
        factoryAction?.Invoke(secretTargetAttachmentResult);

        return secretTargetAttachmentResult;
    }

    private Humidifier.SecretsManager.SecretTargetAttachment CreateSecretTargetAttachment()
    {
        var secretTargetAttachmentResult = new Humidifier.SecretsManager.SecretTargetAttachment
        {
            GivenName = InputResourceName,
        };

        return secretTargetAttachmentResult;
    }

} // End Of Class

public static class SecretTargetAttachmentFactoryExtensions
{
}
