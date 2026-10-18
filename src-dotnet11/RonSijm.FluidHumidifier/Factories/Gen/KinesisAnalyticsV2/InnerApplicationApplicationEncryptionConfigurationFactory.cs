// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisAnalyticsV2;

public class InnerApplicationApplicationEncryptionConfigurationFactory(Action<Humidifier.KinesisAnalyticsV2.ApplicationTypes.ApplicationEncryptionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.KinesisAnalyticsV2.ApplicationTypes.ApplicationEncryptionConfiguration>
{

    protected override Humidifier.KinesisAnalyticsV2.ApplicationTypes.ApplicationEncryptionConfiguration Create()
    {
        var applicationEncryptionConfigurationResult = CreateApplicationEncryptionConfiguration();
        factoryAction?.Invoke(applicationEncryptionConfigurationResult);

        return applicationEncryptionConfigurationResult;
    }

    private Humidifier.KinesisAnalyticsV2.ApplicationTypes.ApplicationEncryptionConfiguration CreateApplicationEncryptionConfiguration()
    {
        var applicationEncryptionConfigurationResult = new Humidifier.KinesisAnalyticsV2.ApplicationTypes.ApplicationEncryptionConfiguration();

        return applicationEncryptionConfigurationResult;
    }

} // End Of Class

public static class InnerApplicationApplicationEncryptionConfigurationFactoryExtensions
{
}
