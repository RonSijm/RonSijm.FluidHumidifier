// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerClusterManagedStorageConfigurationFactory(Action<Humidifier.ECS.ClusterTypes.ManagedStorageConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ECS.ClusterTypes.ManagedStorageConfiguration>
{

    protected override Humidifier.ECS.ClusterTypes.ManagedStorageConfiguration Create()
    {
        var managedStorageConfigurationResult = CreateManagedStorageConfiguration();
        factoryAction?.Invoke(managedStorageConfigurationResult);

        return managedStorageConfigurationResult;
    }

    private Humidifier.ECS.ClusterTypes.ManagedStorageConfiguration CreateManagedStorageConfiguration()
    {
        var managedStorageConfigurationResult = new Humidifier.ECS.ClusterTypes.ManagedStorageConfiguration();

        return managedStorageConfigurationResult;
    }

} // End Of Class

public static class InnerClusterManagedStorageConfigurationFactoryExtensions
{
}
