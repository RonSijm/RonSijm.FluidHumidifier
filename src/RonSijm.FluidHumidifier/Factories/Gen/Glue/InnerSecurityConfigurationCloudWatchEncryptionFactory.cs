// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerSecurityConfigurationCloudWatchEncryptionFactory(Action<Humidifier.Glue.SecurityConfigurationTypes.CloudWatchEncryption> factoryAction = null) : SubResourceFactory<Humidifier.Glue.SecurityConfigurationTypes.CloudWatchEncryption>
{

    protected override Humidifier.Glue.SecurityConfigurationTypes.CloudWatchEncryption Create()
    {
        var cloudWatchEncryptionResult = CreateCloudWatchEncryption();
        factoryAction?.Invoke(cloudWatchEncryptionResult);

        return cloudWatchEncryptionResult;
    }

    private Humidifier.Glue.SecurityConfigurationTypes.CloudWatchEncryption CreateCloudWatchEncryption()
    {
        var cloudWatchEncryptionResult = new Humidifier.Glue.SecurityConfigurationTypes.CloudWatchEncryption();

        return cloudWatchEncryptionResult;
    }

} // End Of Class

public static class InnerSecurityConfigurationCloudWatchEncryptionFactoryExtensions
{
}
