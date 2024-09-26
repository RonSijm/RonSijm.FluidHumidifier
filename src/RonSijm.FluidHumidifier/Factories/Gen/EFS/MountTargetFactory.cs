// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EFS;

public class MountTargetFactory(string resourceName = null, Action<Humidifier.EFS.MountTarget> factoryAction = null) : ResourceFactory<Humidifier.EFS.MountTarget>(resourceName)
{

    protected override Humidifier.EFS.MountTarget Create()
    {
        var mountTargetResult = CreateMountTarget();
        factoryAction?.Invoke(mountTargetResult);

        return mountTargetResult;
    }

    private Humidifier.EFS.MountTarget CreateMountTarget()
    {
        var mountTargetResult = new Humidifier.EFS.MountTarget
        {
            GivenName = InputResourceName,
        };

        return mountTargetResult;
    }

} // End Of Class

public static class MountTargetFactoryExtensions
{
}
