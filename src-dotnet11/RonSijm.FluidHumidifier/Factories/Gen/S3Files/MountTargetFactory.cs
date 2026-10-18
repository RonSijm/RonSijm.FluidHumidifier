// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3Files;

public class MountTargetFactory(string resourceName = null, Action<Humidifier.S3Files.MountTarget> factoryAction = null) : ResourceFactory<Humidifier.S3Files.MountTarget>(resourceName)
{

    protected override Humidifier.S3Files.MountTarget Create()
    {
        var mountTargetResult = CreateMountTarget();
        factoryAction?.Invoke(mountTargetResult);

        return mountTargetResult;
    }

    private Humidifier.S3Files.MountTarget CreateMountTarget()
    {
        var mountTargetResult = new Humidifier.S3Files.MountTarget
        {
            GivenName = InputResourceName,
        };

        return mountTargetResult;
    }

} // End Of Class

public static class MountTargetFactoryExtensions
{
}
