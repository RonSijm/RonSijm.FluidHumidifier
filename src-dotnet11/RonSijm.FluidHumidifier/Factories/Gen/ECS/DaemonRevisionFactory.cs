// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class DaemonRevisionFactory(string resourceName = null, Action<Humidifier.ECS.DaemonRevision> factoryAction = null) : ResourceFactory<Humidifier.ECS.DaemonRevision>(resourceName)
{

    protected override Humidifier.ECS.DaemonRevision Create()
    {
        var daemonRevisionResult = CreateDaemonRevision();
        factoryAction?.Invoke(daemonRevisionResult);

        return daemonRevisionResult;
    }

    private Humidifier.ECS.DaemonRevision CreateDaemonRevision()
    {
        var daemonRevisionResult = new Humidifier.ECS.DaemonRevision
        {
            GivenName = InputResourceName,
        };

        return daemonRevisionResult;
    }

} // End Of Class

public static class DaemonRevisionFactoryExtensions
{
}
