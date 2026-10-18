// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BCMDataExports;

public class TableFactory(string resourceName = null, Action<Humidifier.BCMDataExports.Table> factoryAction = null) : ResourceFactory<Humidifier.BCMDataExports.Table>(resourceName)
{

    protected override Humidifier.BCMDataExports.Table Create()
    {
        var tableResult = CreateTable();
        factoryAction?.Invoke(tableResult);

        return tableResult;
    }

    private Humidifier.BCMDataExports.Table CreateTable()
    {
        var tableResult = new Humidifier.BCMDataExports.Table
        {
            GivenName = InputResourceName,
        };

        return tableResult;
    }

} // End Of Class

public static class TableFactoryExtensions
{
}
