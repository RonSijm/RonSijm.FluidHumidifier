// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Omics;

public class TaskFactory(string resourceName = null, Action<Humidifier.Omics.Task> factoryAction = null) : ResourceFactory<Humidifier.Omics.Task>(resourceName)
{

    protected override Humidifier.Omics.Task Create()
    {
        var taskResult = CreateTask();
        factoryAction?.Invoke(taskResult);

        return taskResult;
    }

    private Humidifier.Omics.Task CreateTask()
    {
        var taskResult = new Humidifier.Omics.Task
        {
            GivenName = InputResourceName,
        };

        return taskResult;
    }

} // End Of Class

public static class TaskFactoryExtensions
{
}
