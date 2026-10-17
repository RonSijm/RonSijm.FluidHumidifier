// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisFirehose;

public class InnerDeliveryStreamSchemaEvolutionConfigurationFactory(Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.SchemaEvolutionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.KinesisFirehose.DeliveryStreamTypes.SchemaEvolutionConfiguration>
{

    protected override Humidifier.KinesisFirehose.DeliveryStreamTypes.SchemaEvolutionConfiguration Create()
    {
        var schemaEvolutionConfigurationResult = CreateSchemaEvolutionConfiguration();
        factoryAction?.Invoke(schemaEvolutionConfigurationResult);

        return schemaEvolutionConfigurationResult;
    }

    private Humidifier.KinesisFirehose.DeliveryStreamTypes.SchemaEvolutionConfiguration CreateSchemaEvolutionConfiguration()
    {
        var schemaEvolutionConfigurationResult = new Humidifier.KinesisFirehose.DeliveryStreamTypes.SchemaEvolutionConfiguration();

        return schemaEvolutionConfigurationResult;
    }

} // End Of Class

public static class InnerDeliveryStreamSchemaEvolutionConfigurationFactoryExtensions
{
}
