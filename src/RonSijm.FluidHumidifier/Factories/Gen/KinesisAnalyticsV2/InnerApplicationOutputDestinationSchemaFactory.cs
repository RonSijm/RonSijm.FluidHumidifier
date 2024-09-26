// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisAnalyticsV2;

public class InnerApplicationOutputDestinationSchemaFactory(Action<Humidifier.KinesisAnalyticsV2.ApplicationOutputTypes.DestinationSchema> factoryAction = null) : SubResourceFactory<Humidifier.KinesisAnalyticsV2.ApplicationOutputTypes.DestinationSchema>
{

    protected override Humidifier.KinesisAnalyticsV2.ApplicationOutputTypes.DestinationSchema Create()
    {
        var destinationSchemaResult = CreateDestinationSchema();
        factoryAction?.Invoke(destinationSchemaResult);

        return destinationSchemaResult;
    }

    private Humidifier.KinesisAnalyticsV2.ApplicationOutputTypes.DestinationSchema CreateDestinationSchema()
    {
        var destinationSchemaResult = new Humidifier.KinesisAnalyticsV2.ApplicationOutputTypes.DestinationSchema();

        return destinationSchemaResult;
    }

} // End Of Class

public static class InnerApplicationOutputDestinationSchemaFactoryExtensions
{
}
