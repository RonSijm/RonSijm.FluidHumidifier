// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BCMDataExports;

public class InnerExportDataQueryFactory(Action<Humidifier.BCMDataExports.ExportTypes.DataQuery> factoryAction = null) : SubResourceFactory<Humidifier.BCMDataExports.ExportTypes.DataQuery>
{

    protected override Humidifier.BCMDataExports.ExportTypes.DataQuery Create()
    {
        var dataQueryResult = CreateDataQuery();
        factoryAction?.Invoke(dataQueryResult);

        return dataQueryResult;
    }

    private Humidifier.BCMDataExports.ExportTypes.DataQuery CreateDataQuery()
    {
        var dataQueryResult = new Humidifier.BCMDataExports.ExportTypes.DataQuery();

        return dataQueryResult;
    }

} // End Of Class

public static class InnerExportDataQueryFactoryExtensions
{
}
