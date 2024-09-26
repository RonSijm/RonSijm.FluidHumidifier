// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisAnalytics;

public class InnerApplicationOutputDestinationSchemaFactory(Action<Humidifier.KinesisAnalytics.ApplicationOutputTypes.DestinationSchema> factoryAction = null) : SubResourceFactory<Humidifier.KinesisAnalytics.ApplicationOutputTypes.DestinationSchema>
{

    protected override Humidifier.KinesisAnalytics.ApplicationOutputTypes.DestinationSchema Create()
    {
        var destinationSchemaResult = CreateDestinationSchema();
        factoryAction?.Invoke(destinationSchemaResult);

        return destinationSchemaResult;
    }

    private Humidifier.KinesisAnalytics.ApplicationOutputTypes.DestinationSchema CreateDestinationSchema()
    {
        var destinationSchemaResult = new Humidifier.KinesisAnalytics.ApplicationOutputTypes.DestinationSchema();

        return destinationSchemaResult;
    }

} // End Of Class

public static class InnerApplicationOutputDestinationSchemaFactoryExtensions
{
}
