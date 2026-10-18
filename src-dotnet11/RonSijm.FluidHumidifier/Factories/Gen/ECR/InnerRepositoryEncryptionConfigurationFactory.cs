// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECR;

public class InnerRepositoryEncryptionConfigurationFactory(Action<Humidifier.ECR.RepositoryTypes.EncryptionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ECR.RepositoryTypes.EncryptionConfiguration>
{

    protected override Humidifier.ECR.RepositoryTypes.EncryptionConfiguration Create()
    {
        var encryptionConfigurationResult = CreateEncryptionConfiguration();
        factoryAction?.Invoke(encryptionConfigurationResult);

        return encryptionConfigurationResult;
    }

    private Humidifier.ECR.RepositoryTypes.EncryptionConfiguration CreateEncryptionConfiguration()
    {
        var encryptionConfigurationResult = new Humidifier.ECR.RepositoryTypes.EncryptionConfiguration();

        return encryptionConfigurationResult;
    }

} // End Of Class

public static class InnerRepositoryEncryptionConfigurationFactoryExtensions
{
}
