// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisFirehose;

public class InnerDeliveryStreamHttpEndpointConfigurationFactory(Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.HttpEndpointConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.KinesisFirehose.DeliveryStreamTypes.HttpEndpointConfiguration>
{

    protected override Humidifier.KinesisFirehose.DeliveryStreamTypes.HttpEndpointConfiguration Create()
    {
        var httpEndpointConfigurationResult = CreateHttpEndpointConfiguration();
        factoryAction?.Invoke(httpEndpointConfigurationResult);

        return httpEndpointConfigurationResult;
    }

    private Humidifier.KinesisFirehose.DeliveryStreamTypes.HttpEndpointConfiguration CreateHttpEndpointConfiguration()
    {
        var httpEndpointConfigurationResult = new Humidifier.KinesisFirehose.DeliveryStreamTypes.HttpEndpointConfiguration();

        return httpEndpointConfigurationResult;
    }

} // End Of Class

public static class InnerDeliveryStreamHttpEndpointConfigurationFactoryExtensions
{
}
