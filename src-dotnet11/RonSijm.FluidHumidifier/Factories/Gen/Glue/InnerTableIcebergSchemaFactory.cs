// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerTableIcebergSchemaFactory(Action<Humidifier.Glue.TableTypes.IcebergSchema> factoryAction = null) : SubResourceFactory<Humidifier.Glue.TableTypes.IcebergSchema>
{

    protected override Humidifier.Glue.TableTypes.IcebergSchema Create()
    {
        var icebergSchemaResult = CreateIcebergSchema();
        factoryAction?.Invoke(icebergSchemaResult);

        return icebergSchemaResult;
    }

    private Humidifier.Glue.TableTypes.IcebergSchema CreateIcebergSchema()
    {
        var icebergSchemaResult = new Humidifier.Glue.TableTypes.IcebergSchema();

        return icebergSchemaResult;
    }

} // End Of Class

public static class InnerTableIcebergSchemaFactoryExtensions
{
}
