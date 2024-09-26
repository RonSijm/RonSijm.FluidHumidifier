// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisFirehose;

public class InnerDeliveryStreamProcessingConfigurationFactory(Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.ProcessingConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.KinesisFirehose.DeliveryStreamTypes.ProcessingConfiguration>
{

    protected override Humidifier.KinesisFirehose.DeliveryStreamTypes.ProcessingConfiguration Create()
    {
        var processingConfigurationResult = CreateProcessingConfiguration();
        factoryAction?.Invoke(processingConfigurationResult);

        return processingConfigurationResult;
    }

    private Humidifier.KinesisFirehose.DeliveryStreamTypes.ProcessingConfiguration CreateProcessingConfiguration()
    {
        var processingConfigurationResult = new Humidifier.KinesisFirehose.DeliveryStreamTypes.ProcessingConfiguration();

        return processingConfigurationResult;
    }

} // End Of Class

public static class InnerDeliveryStreamProcessingConfigurationFactoryExtensions
{
}
