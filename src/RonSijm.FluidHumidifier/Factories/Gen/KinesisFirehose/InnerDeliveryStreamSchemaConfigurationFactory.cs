// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisFirehose;

public class InnerDeliveryStreamSchemaConfigurationFactory(Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.SchemaConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.KinesisFirehose.DeliveryStreamTypes.SchemaConfiguration>
{

    protected override Humidifier.KinesisFirehose.DeliveryStreamTypes.SchemaConfiguration Create()
    {
        var schemaConfigurationResult = CreateSchemaConfiguration();
        factoryAction?.Invoke(schemaConfigurationResult);

        return schemaConfigurationResult;
    }

    private Humidifier.KinesisFirehose.DeliveryStreamTypes.SchemaConfiguration CreateSchemaConfiguration()
    {
        var schemaConfigurationResult = new Humidifier.KinesisFirehose.DeliveryStreamTypes.SchemaConfiguration();

        return schemaConfigurationResult;
    }

} // End Of Class

public static class InnerDeliveryStreamSchemaConfigurationFactoryExtensions
{
}
