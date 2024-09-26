// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Timestream;

public class InnerTableSchemaFactory(Action<Humidifier.Timestream.TableTypes.Schema> factoryAction = null) : SubResourceFactory<Humidifier.Timestream.TableTypes.Schema>
{

    protected override Humidifier.Timestream.TableTypes.Schema Create()
    {
        var schemaResult = CreateSchema();
        factoryAction?.Invoke(schemaResult);

        return schemaResult;
    }

    private Humidifier.Timestream.TableTypes.Schema CreateSchema()
    {
        var schemaResult = new Humidifier.Timestream.TableTypes.Schema();

        return schemaResult;
    }

} // End Of Class

public static class InnerTableSchemaFactoryExtensions
{
}
