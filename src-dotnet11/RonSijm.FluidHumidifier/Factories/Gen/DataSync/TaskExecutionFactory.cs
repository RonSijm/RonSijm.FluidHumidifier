// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataSync;

public class TaskExecutionFactory(string resourceName = null, Action<Humidifier.DataSync.TaskExecution> factoryAction = null) : ResourceFactory<Humidifier.DataSync.TaskExecution>(resourceName)
{

    protected override Humidifier.DataSync.TaskExecution Create()
    {
        var taskExecutionResult = CreateTaskExecution();
        factoryAction?.Invoke(taskExecutionResult);

        return taskExecutionResult;
    }

    private Humidifier.DataSync.TaskExecution CreateTaskExecution()
    {
        var taskExecutionResult = new Humidifier.DataSync.TaskExecution
        {
            GivenName = InputResourceName,
        };

        return taskExecutionResult;
    }

} // End Of Class

public static class TaskExecutionFactoryExtensions
{
}
