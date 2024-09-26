// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECR;

public class InnerRepositoryCreationTemplateEncryptionConfigurationFactory(Action<Humidifier.ECR.RepositoryCreationTemplateTypes.EncryptionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ECR.RepositoryCreationTemplateTypes.EncryptionConfiguration>
{

    protected override Humidifier.ECR.RepositoryCreationTemplateTypes.EncryptionConfiguration Create()
    {
        var encryptionConfigurationResult = CreateEncryptionConfiguration();
        factoryAction?.Invoke(encryptionConfigurationResult);

        return encryptionConfigurationResult;
    }

    private Humidifier.ECR.RepositoryCreationTemplateTypes.EncryptionConfiguration CreateEncryptionConfiguration()
    {
        var encryptionConfigurationResult = new Humidifier.ECR.RepositoryCreationTemplateTypes.EncryptionConfiguration();

        return encryptionConfigurationResult;
    }

} // End Of Class

public static class InnerRepositoryCreationTemplateEncryptionConfigurationFactoryExtensions
{
}
