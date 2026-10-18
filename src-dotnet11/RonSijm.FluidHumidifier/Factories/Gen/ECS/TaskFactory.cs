// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class TaskFactory(string resourceName = null, Action<Humidifier.ECS.Task> factoryAction = null) : ResourceFactory<Humidifier.ECS.Task>(resourceName)
{

    protected override Humidifier.ECS.Task Create()
    {
        var taskResult = CreateTask();
        factoryAction?.Invoke(taskResult);

        return taskResult;
    }

    private Humidifier.ECS.Task CreateTask()
    {
        var taskResult = new Humidifier.ECS.Task
        {
            GivenName = InputResourceName,
        };

        return taskResult;
    }

} // End Of Class

public static class TaskFactoryExtensions
{
}
