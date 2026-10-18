// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Athena;

public class InnerWorkGroupEncryptionConfigurationFactory(Action<Humidifier.Athena.WorkGroupTypes.EncryptionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Athena.WorkGroupTypes.EncryptionConfiguration>
{

    protected override Humidifier.Athena.WorkGroupTypes.EncryptionConfiguration Create()
    {
        var encryptionConfigurationResult = CreateEncryptionConfiguration();
        factoryAction?.Invoke(encryptionConfigurationResult);

        return encryptionConfigurationResult;
    }

    private Humidifier.Athena.WorkGroupTypes.EncryptionConfiguration CreateEncryptionConfiguration()
    {
        var encryptionConfigurationResult = new Humidifier.Athena.WorkGroupTypes.EncryptionConfiguration();

        return encryptionConfigurationResult;
    }

} // End Of Class

public static class InnerWorkGroupEncryptionConfigurationFactoryExtensions
{
}
