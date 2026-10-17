// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerTableIcebergPartitionSpecFactory(Action<Humidifier.Glue.TableTypes.IcebergPartitionSpec> factoryAction = null) : SubResourceFactory<Humidifier.Glue.TableTypes.IcebergPartitionSpec>
{

    protected override Humidifier.Glue.TableTypes.IcebergPartitionSpec Create()
    {
        var icebergPartitionSpecResult = CreateIcebergPartitionSpec();
        factoryAction?.Invoke(icebergPartitionSpecResult);

        return icebergPartitionSpecResult;
    }

    private Humidifier.Glue.TableTypes.IcebergPartitionSpec CreateIcebergPartitionSpec()
    {
        var icebergPartitionSpecResult = new Humidifier.Glue.TableTypes.IcebergPartitionSpec();

        return icebergPartitionSpecResult;
    }

} // End Of Class

public static class InnerTableIcebergPartitionSpecFactoryExtensions
{
}
