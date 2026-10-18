// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisFirehose;

public class InnerDeliveryStreamCatalogConfigurationFactory(Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.CatalogConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.KinesisFirehose.DeliveryStreamTypes.CatalogConfiguration>
{

    protected override Humidifier.KinesisFirehose.DeliveryStreamTypes.CatalogConfiguration Create()
    {
        var catalogConfigurationResult = CreateCatalogConfiguration();
        factoryAction?.Invoke(catalogConfigurationResult);

        return catalogConfigurationResult;
    }

    private Humidifier.KinesisFirehose.DeliveryStreamTypes.CatalogConfiguration CreateCatalogConfiguration()
    {
        var catalogConfigurationResult = new Humidifier.KinesisFirehose.DeliveryStreamTypes.CatalogConfiguration();

        return catalogConfigurationResult;
    }

} // End Of Class

public static class InnerDeliveryStreamCatalogConfigurationFactoryExtensions
{
}
