// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecurityLake;

public class InnerDataLakeEncryptionConfigurationFactory(Action<Humidifier.SecurityLake.DataLakeTypes.EncryptionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.SecurityLake.DataLakeTypes.EncryptionConfiguration>
{

    protected override Humidifier.SecurityLake.DataLakeTypes.EncryptionConfiguration Create()
    {
        var encryptionConfigurationResult = CreateEncryptionConfiguration();
        factoryAction?.Invoke(encryptionConfigurationResult);

        return encryptionConfigurationResult;
    }

    private Humidifier.SecurityLake.DataLakeTypes.EncryptionConfiguration CreateEncryptionConfiguration()
    {
        var encryptionConfigurationResult = new Humidifier.SecurityLake.DataLakeTypes.EncryptionConfiguration();

        return encryptionConfigurationResult;
    }

} // End Of Class

public static class InnerDataLakeEncryptionConfigurationFactoryExtensions
{
}
