// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NeptuneGraph;

public class ImportTaskFactory(string resourceName = null, Action<Humidifier.NeptuneGraph.ImportTask> factoryAction = null) : ResourceFactory<Humidifier.NeptuneGraph.ImportTask>(resourceName)
{

    protected override Humidifier.NeptuneGraph.ImportTask Create()
    {
        var importTaskResult = CreateImportTask();
        factoryAction?.Invoke(importTaskResult);

        return importTaskResult;
    }

    private Humidifier.NeptuneGraph.ImportTask CreateImportTask()
    {
        var importTaskResult = new Humidifier.NeptuneGraph.ImportTask
        {
            GivenName = InputResourceName,
        };

        return importTaskResult;
    }

} // End Of Class

public static class ImportTaskFactoryExtensions
{
}
