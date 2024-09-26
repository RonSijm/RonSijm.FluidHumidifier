// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisFirehose;

public class InnerDeliveryStreamDocumentIdOptionsFactory(Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.DocumentIdOptions> factoryAction = null) : SubResourceFactory<Humidifier.KinesisFirehose.DeliveryStreamTypes.DocumentIdOptions>
{

    protected override Humidifier.KinesisFirehose.DeliveryStreamTypes.DocumentIdOptions Create()
    {
        var documentIdOptionsResult = CreateDocumentIdOptions();
        factoryAction?.Invoke(documentIdOptionsResult);

        return documentIdOptionsResult;
    }

    private Humidifier.KinesisFirehose.DeliveryStreamTypes.DocumentIdOptions CreateDocumentIdOptions()
    {
        var documentIdOptionsResult = new Humidifier.KinesisFirehose.DeliveryStreamTypes.DocumentIdOptions();

        return documentIdOptionsResult;
    }

} // End Of Class

public static class InnerDeliveryStreamDocumentIdOptionsFactoryExtensions
{
}
