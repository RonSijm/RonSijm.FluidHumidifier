// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3Tables;

public class InnerTableIcebergSortOrderFactory(Action<Humidifier.S3Tables.TableTypes.IcebergSortOrder> factoryAction = null) : SubResourceFactory<Humidifier.S3Tables.TableTypes.IcebergSortOrder>
{

    protected override Humidifier.S3Tables.TableTypes.IcebergSortOrder Create()
    {
        var icebergSortOrderResult = CreateIcebergSortOrder();
        factoryAction?.Invoke(icebergSortOrderResult);

        return icebergSortOrderResult;
    }

    private Humidifier.S3Tables.TableTypes.IcebergSortOrder CreateIcebergSortOrder()
    {
        var icebergSortOrderResult = new Humidifier.S3Tables.TableTypes.IcebergSortOrder();

        return icebergSortOrderResult;
    }

} // End Of Class

public static class InnerTableIcebergSortOrderFactoryExtensions
{
}
