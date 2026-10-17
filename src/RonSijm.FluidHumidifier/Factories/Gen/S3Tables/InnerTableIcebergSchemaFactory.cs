// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3Tables;

public class InnerTableIcebergSchemaFactory(Action<Humidifier.S3Tables.TableTypes.IcebergSchema> factoryAction = null) : SubResourceFactory<Humidifier.S3Tables.TableTypes.IcebergSchema>
{

    protected override Humidifier.S3Tables.TableTypes.IcebergSchema Create()
    {
        var icebergSchemaResult = CreateIcebergSchema();
        factoryAction?.Invoke(icebergSchemaResult);

        return icebergSchemaResult;
    }

    private Humidifier.S3Tables.TableTypes.IcebergSchema CreateIcebergSchema()
    {
        var icebergSchemaResult = new Humidifier.S3Tables.TableTypes.IcebergSchema();

        return icebergSchemaResult;
    }

} // End Of Class

public static class InnerTableIcebergSchemaFactoryExtensions
{
}
