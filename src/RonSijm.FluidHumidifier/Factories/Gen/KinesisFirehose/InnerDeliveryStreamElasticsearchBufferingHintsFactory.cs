// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisFirehose;

public class InnerDeliveryStreamElasticsearchBufferingHintsFactory(Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.ElasticsearchBufferingHints> factoryAction = null) : SubResourceFactory<Humidifier.KinesisFirehose.DeliveryStreamTypes.ElasticsearchBufferingHints>
{

    protected override Humidifier.KinesisFirehose.DeliveryStreamTypes.ElasticsearchBufferingHints Create()
    {
        var elasticsearchBufferingHintsResult = CreateElasticsearchBufferingHints();
        factoryAction?.Invoke(elasticsearchBufferingHintsResult);

        return elasticsearchBufferingHintsResult;
    }

    private Humidifier.KinesisFirehose.DeliveryStreamTypes.ElasticsearchBufferingHints CreateElasticsearchBufferingHints()
    {
        var elasticsearchBufferingHintsResult = new Humidifier.KinesisFirehose.DeliveryStreamTypes.ElasticsearchBufferingHints();

        return elasticsearchBufferingHintsResult;
    }

} // End Of Class

public static class InnerDeliveryStreamElasticsearchBufferingHintsFactoryExtensions
{
}
