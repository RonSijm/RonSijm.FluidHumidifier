// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerExportInstanceTaskExportToS3TaskFactory(Action<Humidifier.EC2.ExportInstanceTaskTypes.ExportToS3Task> factoryAction = null) : SubResourceFactory<Humidifier.EC2.ExportInstanceTaskTypes.ExportToS3Task>
{

    protected override Humidifier.EC2.ExportInstanceTaskTypes.ExportToS3Task Create()
    {
        var exportToS3TaskResult = CreateExportToS3Task();
        factoryAction?.Invoke(exportToS3TaskResult);

        return exportToS3TaskResult;
    }

    private Humidifier.EC2.ExportInstanceTaskTypes.ExportToS3Task CreateExportToS3Task()
    {
        var exportToS3TaskResult = new Humidifier.EC2.ExportInstanceTaskTypes.ExportToS3Task();

        return exportToS3TaskResult;
    }

} // End Of Class

public static class InnerExportInstanceTaskExportToS3TaskFactoryExtensions
{
}
