// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisFirehose;

public class InnerDeliveryStreamElasticsearchRetryOptionsFactory(Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.ElasticsearchRetryOptions> factoryAction = null) : SubResourceFactory<Humidifier.KinesisFirehose.DeliveryStreamTypes.ElasticsearchRetryOptions>
{

    protected override Humidifier.KinesisFirehose.DeliveryStreamTypes.ElasticsearchRetryOptions Create()
    {
        var elasticsearchRetryOptionsResult = CreateElasticsearchRetryOptions();
        factoryAction?.Invoke(elasticsearchRetryOptionsResult);

        return elasticsearchRetryOptionsResult;
    }

    private Humidifier.KinesisFirehose.DeliveryStreamTypes.ElasticsearchRetryOptions CreateElasticsearchRetryOptions()
    {
        var elasticsearchRetryOptionsResult = new Humidifier.KinesisFirehose.DeliveryStreamTypes.ElasticsearchRetryOptions();

        return elasticsearchRetryOptionsResult;
    }

} // End Of Class

public static class InnerDeliveryStreamElasticsearchRetryOptionsFactoryExtensions
{
}
