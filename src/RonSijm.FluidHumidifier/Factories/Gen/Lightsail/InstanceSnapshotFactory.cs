// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lightsail;

public class InstanceSnapshotFactory(string resourceName = null, Action<Humidifier.Lightsail.InstanceSnapshot> factoryAction = null) : ResourceFactory<Humidifier.Lightsail.InstanceSnapshot>(resourceName)
{

    protected override Humidifier.Lightsail.InstanceSnapshot Create()
    {
        var instanceSnapshotResult = CreateInstanceSnapshot();
        factoryAction?.Invoke(instanceSnapshotResult);

        return instanceSnapshotResult;
    }

    private Humidifier.Lightsail.InstanceSnapshot CreateInstanceSnapshot()
    {
        var instanceSnapshotResult = new Humidifier.Lightsail.InstanceSnapshot
        {
            GivenName = InputResourceName,
        };

        return instanceSnapshotResult;
    }

} // End Of Class

public static class InstanceSnapshotFactoryExtensions
{
}
