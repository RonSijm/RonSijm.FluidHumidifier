// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMRContainers;

public class InnerSecurityConfigurationLocalDiskEncryptionConfigurationFactory(Action<Humidifier.EMRContainers.SecurityConfigurationTypes.LocalDiskEncryptionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.EMRContainers.SecurityConfigurationTypes.LocalDiskEncryptionConfiguration>
{

    protected override Humidifier.EMRContainers.SecurityConfigurationTypes.LocalDiskEncryptionConfiguration Create()
    {
        var localDiskEncryptionConfigurationResult = CreateLocalDiskEncryptionConfiguration();
        factoryAction?.Invoke(localDiskEncryptionConfigurationResult);

        return localDiskEncryptionConfigurationResult;
    }

    private Humidifier.EMRContainers.SecurityConfigurationTypes.LocalDiskEncryptionConfiguration CreateLocalDiskEncryptionConfiguration()
    {
        var localDiskEncryptionConfigurationResult = new Humidifier.EMRContainers.SecurityConfigurationTypes.LocalDiskEncryptionConfiguration();

        return localDiskEncryptionConfigurationResult;
    }

} // End Of Class

public static class InnerSecurityConfigurationLocalDiskEncryptionConfigurationFactoryExtensions
{
}
