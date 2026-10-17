// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MSK;

public class InnerChannelRecordSchemaFactory(Action<Humidifier.MSK.ChannelTypes.RecordSchema> factoryAction = null) : SubResourceFactory<Humidifier.MSK.ChannelTypes.RecordSchema>
{

    protected override Humidifier.MSK.ChannelTypes.RecordSchema Create()
    {
        var recordSchemaResult = CreateRecordSchema();
        factoryAction?.Invoke(recordSchemaResult);

        return recordSchemaResult;
    }

    private Humidifier.MSK.ChannelTypes.RecordSchema CreateRecordSchema()
    {
        var recordSchemaResult = new Humidifier.MSK.ChannelTypes.RecordSchema();

        return recordSchemaResult;
    }

} // End Of Class

public static class InnerChannelRecordSchemaFactoryExtensions
{
}
