// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3Tables;

public class InnerTableIcebergPartitionSpecFactory(Action<Humidifier.S3Tables.TableTypes.IcebergPartitionSpec> factoryAction = null) : SubResourceFactory<Humidifier.S3Tables.TableTypes.IcebergPartitionSpec>
{

    protected override Humidifier.S3Tables.TableTypes.IcebergPartitionSpec Create()
    {
        var icebergPartitionSpecResult = CreateIcebergPartitionSpec();
        factoryAction?.Invoke(icebergPartitionSpecResult);

        return icebergPartitionSpecResult;
    }

    private Humidifier.S3Tables.TableTypes.IcebergPartitionSpec CreateIcebergPartitionSpec()
    {
        var icebergPartitionSpecResult = new Humidifier.S3Tables.TableTypes.IcebergPartitionSpec();

        return icebergPartitionSpecResult;
    }

} // End Of Class

public static class InnerTableIcebergPartitionSpecFactoryExtensions
{
}
