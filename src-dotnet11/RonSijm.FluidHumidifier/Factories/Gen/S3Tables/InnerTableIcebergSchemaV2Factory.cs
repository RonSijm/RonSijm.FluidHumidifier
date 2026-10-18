// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3Tables;

public class InnerTableIcebergSchemaV2Factory(Action<Humidifier.S3Tables.TableTypes.IcebergSchemaV2> factoryAction = null) : SubResourceFactory<Humidifier.S3Tables.TableTypes.IcebergSchemaV2>
{

    protected override Humidifier.S3Tables.TableTypes.IcebergSchemaV2 Create()
    {
        var icebergSchemaV2Result = CreateIcebergSchemaV2();
        factoryAction?.Invoke(icebergSchemaV2Result);

        return icebergSchemaV2Result;
    }

    private Humidifier.S3Tables.TableTypes.IcebergSchemaV2 CreateIcebergSchemaV2()
    {
        var icebergSchemaV2Result = new Humidifier.S3Tables.TableTypes.IcebergSchemaV2();

        return icebergSchemaV2Result;
    }

} // End Of Class

public static class InnerTableIcebergSchemaV2FactoryExtensions
{
}
