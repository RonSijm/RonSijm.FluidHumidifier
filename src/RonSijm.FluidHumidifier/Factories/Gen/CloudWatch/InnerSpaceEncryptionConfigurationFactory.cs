// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudWatch;

public class InnerSpaceEncryptionConfigurationFactory(Action<Humidifier.CloudWatch.SpaceTypes.EncryptionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.CloudWatch.SpaceTypes.EncryptionConfiguration>
{

    protected override Humidifier.CloudWatch.SpaceTypes.EncryptionConfiguration Create()
    {
        var encryptionConfigurationResult = CreateEncryptionConfiguration();
        factoryAction?.Invoke(encryptionConfigurationResult);

        return encryptionConfigurationResult;
    }

    private Humidifier.CloudWatch.SpaceTypes.EncryptionConfiguration CreateEncryptionConfiguration()
    {
        var encryptionConfigurationResult = new Humidifier.CloudWatch.SpaceTypes.EncryptionConfiguration();

        return encryptionConfigurationResult;
    }

} // End Of Class

public static class InnerSpaceEncryptionConfigurationFactoryExtensions
{
}
