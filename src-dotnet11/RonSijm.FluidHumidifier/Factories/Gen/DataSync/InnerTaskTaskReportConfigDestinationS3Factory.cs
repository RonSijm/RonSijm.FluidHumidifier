// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataSync;

public class InnerTaskTaskReportConfigDestinationS3Factory(Action<Humidifier.DataSync.TaskTypes.TaskReportConfigDestinationS3> factoryAction = null) : SubResourceFactory<Humidifier.DataSync.TaskTypes.TaskReportConfigDestinationS3>
{

    protected override Humidifier.DataSync.TaskTypes.TaskReportConfigDestinationS3 Create()
    {
        var taskReportConfigDestinationS3Result = CreateTaskReportConfigDestinationS3();
        factoryAction?.Invoke(taskReportConfigDestinationS3Result);

        return taskReportConfigDestinationS3Result;
    }

    private Humidifier.DataSync.TaskTypes.TaskReportConfigDestinationS3 CreateTaskReportConfigDestinationS3()
    {
        var taskReportConfigDestinationS3Result = new Humidifier.DataSync.TaskTypes.TaskReportConfigDestinationS3();

        return taskReportConfigDestinationS3Result;
    }

} // End Of Class

public static class InnerTaskTaskReportConfigDestinationS3FactoryExtensions
{
}
