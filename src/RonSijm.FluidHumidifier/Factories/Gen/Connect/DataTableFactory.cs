// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class DataTableFactory(string resourceName = null, Action<Humidifier.Connect.DataTable> factoryAction = null) : ResourceFactory<Humidifier.Connect.DataTable>(resourceName)
{

    protected override Humidifier.Connect.DataTable Create()
    {
        var dataTableResult = CreateDataTable();
        factoryAction?.Invoke(dataTableResult);

        return dataTableResult;
    }

    private Humidifier.Connect.DataTable CreateDataTable()
    {
        var dataTableResult = new Humidifier.Connect.DataTable
        {
            GivenName = InputResourceName,
        };

        return dataTableResult;
    }

} // End Of Class

public static class DataTableFactoryExtensions
{
}
