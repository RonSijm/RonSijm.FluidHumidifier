// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ResourceGroups;

public class TagSyncTaskFactory(string resourceName = null, Action<Humidifier.ResourceGroups.TagSyncTask> factoryAction = null) : ResourceFactory<Humidifier.ResourceGroups.TagSyncTask>(resourceName)
{

    protected override Humidifier.ResourceGroups.TagSyncTask Create()
    {
        var tagSyncTaskResult = CreateTagSyncTask();
        factoryAction?.Invoke(tagSyncTaskResult);

        return tagSyncTaskResult;
    }

    private Humidifier.ResourceGroups.TagSyncTask CreateTagSyncTask()
    {
        var tagSyncTaskResult = new Humidifier.ResourceGroups.TagSyncTask
        {
            GivenName = InputResourceName,
        };

        return tagSyncTaskResult;
    }

} // End Of Class

public static class TagSyncTaskFactoryExtensions
{
}
