// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisFirehose;

public class InnerDeliveryStreamHttpEndpointRequestConfigurationFactory(Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.HttpEndpointRequestConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.KinesisFirehose.DeliveryStreamTypes.HttpEndpointRequestConfiguration>
{

    protected override Humidifier.KinesisFirehose.DeliveryStreamTypes.HttpEndpointRequestConfiguration Create()
    {
        var httpEndpointRequestConfigurationResult = CreateHttpEndpointRequestConfiguration();
        factoryAction?.Invoke(httpEndpointRequestConfigurationResult);

        return httpEndpointRequestConfigurationResult;
    }

    private Humidifier.KinesisFirehose.DeliveryStreamTypes.HttpEndpointRequestConfiguration CreateHttpEndpointRequestConfiguration()
    {
        var httpEndpointRequestConfigurationResult = new Humidifier.KinesisFirehose.DeliveryStreamTypes.HttpEndpointRequestConfiguration();

        return httpEndpointRequestConfigurationResult;
    }

} // End Of Class

public static class InnerDeliveryStreamHttpEndpointRequestConfigurationFactoryExtensions
{
}
