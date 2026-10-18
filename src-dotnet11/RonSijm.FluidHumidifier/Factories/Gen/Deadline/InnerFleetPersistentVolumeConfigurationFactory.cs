// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Deadline;

public class InnerFleetPersistentVolumeConfigurationFactory(Action<Humidifier.Deadline.FleetTypes.PersistentVolumeConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Deadline.FleetTypes.PersistentVolumeConfiguration>
{

    protected override Humidifier.Deadline.FleetTypes.PersistentVolumeConfiguration Create()
    {
        var persistentVolumeConfigurationResult = CreatePersistentVolumeConfiguration();
        factoryAction?.Invoke(persistentVolumeConfigurationResult);

        return persistentVolumeConfigurationResult;
    }

    private Humidifier.Deadline.FleetTypes.PersistentVolumeConfiguration CreatePersistentVolumeConfiguration()
    {
        var persistentVolumeConfigurationResult = new Humidifier.Deadline.FleetTypes.PersistentVolumeConfiguration();

        return persistentVolumeConfigurationResult;
    }

} // End Of Class

public static class InnerFleetPersistentVolumeConfigurationFactoryExtensions
{
}
