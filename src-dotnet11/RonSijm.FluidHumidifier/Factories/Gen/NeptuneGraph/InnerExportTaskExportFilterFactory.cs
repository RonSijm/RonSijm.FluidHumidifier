// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NeptuneGraph;

public class InnerExportTaskExportFilterFactory(Action<Humidifier.NeptuneGraph.ExportTaskTypes.ExportFilter> factoryAction = null) : SubResourceFactory<Humidifier.NeptuneGraph.ExportTaskTypes.ExportFilter>
{

    protected override Humidifier.NeptuneGraph.ExportTaskTypes.ExportFilter Create()
    {
        var exportFilterResult = CreateExportFilter();
        factoryAction?.Invoke(exportFilterResult);

        return exportFilterResult;
    }

    private Humidifier.NeptuneGraph.ExportTaskTypes.ExportFilter CreateExportFilter()
    {
        var exportFilterResult = new Humidifier.NeptuneGraph.ExportTaskTypes.ExportFilter();

        return exportFilterResult;
    }

} // End Of Class

public static class InnerExportTaskExportFilterFactoryExtensions
{
}
