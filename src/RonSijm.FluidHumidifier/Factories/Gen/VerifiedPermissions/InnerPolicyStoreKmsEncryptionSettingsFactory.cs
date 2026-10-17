// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.VerifiedPermissions;

public class InnerPolicyStoreKmsEncryptionSettingsFactory(Action<Humidifier.VerifiedPermissions.PolicyStoreTypes.KmsEncryptionSettings> factoryAction = null) : SubResourceFactory<Humidifier.VerifiedPermissions.PolicyStoreTypes.KmsEncryptionSettings>
{

    protected override Humidifier.VerifiedPermissions.PolicyStoreTypes.KmsEncryptionSettings Create()
    {
        var kmsEncryptionSettingsResult = CreateKmsEncryptionSettings();
        factoryAction?.Invoke(kmsEncryptionSettingsResult);

        return kmsEncryptionSettingsResult;
    }

    private Humidifier.VerifiedPermissions.PolicyStoreTypes.KmsEncryptionSettings CreateKmsEncryptionSettings()
    {
        var kmsEncryptionSettingsResult = new Humidifier.VerifiedPermissions.PolicyStoreTypes.KmsEncryptionSettings();

        return kmsEncryptionSettingsResult;
    }

} // End Of Class

public static class InnerPolicyStoreKmsEncryptionSettingsFactoryExtensions
{
}
