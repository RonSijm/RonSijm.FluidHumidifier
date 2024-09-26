// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerTableSchemaIdFactory(Action<Humidifier.Glue.TableTypes.SchemaId> factoryAction = null) : SubResourceFactory<Humidifier.Glue.TableTypes.SchemaId>
{

    protected override Humidifier.Glue.TableTypes.SchemaId Create()
    {
        var schemaIdResult = CreateSchemaId();
        factoryAction?.Invoke(schemaIdResult);

        return schemaIdResult;
    }

    private Humidifier.Glue.TableTypes.SchemaId CreateSchemaId()
    {
        var schemaIdResult = new Humidifier.Glue.TableTypes.SchemaId();

        return schemaIdResult;
    }

} // End Of Class

public static class InnerTableSchemaIdFactoryExtensions
{
}
