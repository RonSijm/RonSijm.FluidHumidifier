// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class ReplaceRootVolumeTaskFactory(string resourceName = null, Action<Humidifier.EC2.ReplaceRootVolumeTask> factoryAction = null) : ResourceFactory<Humidifier.EC2.ReplaceRootVolumeTask>(resourceName)
{

    protected override Humidifier.EC2.ReplaceRootVolumeTask Create()
    {
        var replaceRootVolumeTaskResult = CreateReplaceRootVolumeTask();
        factoryAction?.Invoke(replaceRootVolumeTaskResult);

        return replaceRootVolumeTaskResult;
    }

    private Humidifier.EC2.ReplaceRootVolumeTask CreateReplaceRootVolumeTask()
    {
        var replaceRootVolumeTaskResult = new Humidifier.EC2.ReplaceRootVolumeTask
        {
            GivenName = InputResourceName,
        };

        return replaceRootVolumeTaskResult;
    }

} // End Of Class

public static class ReplaceRootVolumeTaskFactoryExtensions
{
}
