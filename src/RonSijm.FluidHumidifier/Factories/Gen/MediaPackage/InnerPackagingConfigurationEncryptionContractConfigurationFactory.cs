// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaPackage;

public class InnerPackagingConfigurationEncryptionContractConfigurationFactory(Action<Humidifier.MediaPackage.PackagingConfigurationTypes.EncryptionContractConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaPackage.PackagingConfigurationTypes.EncryptionContractConfiguration>
{

    protected override Humidifier.MediaPackage.PackagingConfigurationTypes.EncryptionContractConfiguration Create()
    {
        var encryptionContractConfigurationResult = CreateEncryptionContractConfiguration();
        factoryAction?.Invoke(encryptionContractConfigurationResult);

        return encryptionContractConfigurationResult;
    }

    private Humidifier.MediaPackage.PackagingConfigurationTypes.EncryptionContractConfiguration CreateEncryptionContractConfiguration()
    {
        var encryptionContractConfigurationResult = new Humidifier.MediaPackage.PackagingConfigurationTypes.EncryptionContractConfiguration();

        return encryptionContractConfigurationResult;
    }

} // End Of Class

public static class InnerPackagingConfigurationEncryptionContractConfigurationFactoryExtensions
{
}
