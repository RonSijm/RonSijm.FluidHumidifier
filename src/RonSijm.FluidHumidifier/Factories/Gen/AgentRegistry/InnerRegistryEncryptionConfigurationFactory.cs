// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AgentRegistry;

public class InnerRegistryEncryptionConfigurationFactory(Action<Humidifier.AgentRegistry.RegistryTypes.EncryptionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.AgentRegistry.RegistryTypes.EncryptionConfiguration>
{

    protected override Humidifier.AgentRegistry.RegistryTypes.EncryptionConfiguration Create()
    {
        var encryptionConfigurationResult = CreateEncryptionConfiguration();
        factoryAction?.Invoke(encryptionConfigurationResult);

        return encryptionConfigurationResult;
    }

    private Humidifier.AgentRegistry.RegistryTypes.EncryptionConfiguration CreateEncryptionConfiguration()
    {
        var encryptionConfigurationResult = new Humidifier.AgentRegistry.RegistryTypes.EncryptionConfiguration();

        return encryptionConfigurationResult;
    }

} // End Of Class

public static class InnerRegistryEncryptionConfigurationFactoryExtensions
{
}
