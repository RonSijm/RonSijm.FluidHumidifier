// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerTableIcebergSortOrderFactory(Action<Humidifier.Glue.TableTypes.IcebergSortOrder> factoryAction = null) : SubResourceFactory<Humidifier.Glue.TableTypes.IcebergSortOrder>
{

    protected override Humidifier.Glue.TableTypes.IcebergSortOrder Create()
    {
        var icebergSortOrderResult = CreateIcebergSortOrder();
        factoryAction?.Invoke(icebergSortOrderResult);

        return icebergSortOrderResult;
    }

    private Humidifier.Glue.TableTypes.IcebergSortOrder CreateIcebergSortOrder()
    {
        var icebergSortOrderResult = new Humidifier.Glue.TableTypes.IcebergSortOrder();

        return icebergSortOrderResult;
    }

} // End Of Class

public static class InnerTableIcebergSortOrderFactoryExtensions
{
}
