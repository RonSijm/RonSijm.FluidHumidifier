// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EventsV2;

public class InnerEventBusEncryptionConfigurationFactory(Action<Humidifier.EventsV2.EventBusTypes.EncryptionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.EventsV2.EventBusTypes.EncryptionConfiguration>
{

    protected override Humidifier.EventsV2.EventBusTypes.EncryptionConfiguration Create()
    {
        var encryptionConfigurationResult = CreateEncryptionConfiguration();
        factoryAction?.Invoke(encryptionConfigurationResult);

        return encryptionConfigurationResult;
    }

    private Humidifier.EventsV2.EventBusTypes.EncryptionConfiguration CreateEncryptionConfiguration()
    {
        var encryptionConfigurationResult = new Humidifier.EventsV2.EventBusTypes.EncryptionConfiguration();

        return encryptionConfigurationResult;
    }

} // End Of Class

public static class InnerEventBusEncryptionConfigurationFactoryExtensions
{
}
