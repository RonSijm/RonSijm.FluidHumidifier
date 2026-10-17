// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRooms;

public class InnerConfiguredTableSnowflakeTableSchemaFactory(Action<Humidifier.CleanRooms.ConfiguredTableTypes.SnowflakeTableSchema> factoryAction = null) : SubResourceFactory<Humidifier.CleanRooms.ConfiguredTableTypes.SnowflakeTableSchema>
{

    protected override Humidifier.CleanRooms.ConfiguredTableTypes.SnowflakeTableSchema Create()
    {
        var snowflakeTableSchemaResult = CreateSnowflakeTableSchema();
        factoryAction?.Invoke(snowflakeTableSchemaResult);

        return snowflakeTableSchemaResult;
    }

    private Humidifier.CleanRooms.ConfiguredTableTypes.SnowflakeTableSchema CreateSnowflakeTableSchema()
    {
        var snowflakeTableSchemaResult = new Humidifier.CleanRooms.ConfiguredTableTypes.SnowflakeTableSchema();

        return snowflakeTableSchemaResult;
    }

} // End Of Class

public static class InnerConfiguredTableSnowflakeTableSchemaFactoryExtensions
{
}
