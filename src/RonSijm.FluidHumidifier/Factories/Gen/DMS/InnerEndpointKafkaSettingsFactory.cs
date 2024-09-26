// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DMS;

public class InnerEndpointKafkaSettingsFactory(Action<Humidifier.DMS.EndpointTypes.KafkaSettings> factoryAction = null) : SubResourceFactory<Humidifier.DMS.EndpointTypes.KafkaSettings>
{

    protected override Humidifier.DMS.EndpointTypes.KafkaSettings Create()
    {
        var kafkaSettingsResult = CreateKafkaSettings();
        factoryAction?.Invoke(kafkaSettingsResult);

        return kafkaSettingsResult;
    }

    private Humidifier.DMS.EndpointTypes.KafkaSettings CreateKafkaSettings()
    {
        var kafkaSettingsResult = new Humidifier.DMS.EndpointTypes.KafkaSettings();

        return kafkaSettingsResult;
    }

} // End Of Class

public static class InnerEndpointKafkaSettingsFactoryExtensions
{
}
