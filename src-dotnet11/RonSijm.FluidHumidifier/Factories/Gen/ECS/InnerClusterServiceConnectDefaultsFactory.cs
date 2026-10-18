// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerClusterServiceConnectDefaultsFactory(Action<Humidifier.ECS.ClusterTypes.ServiceConnectDefaults> factoryAction = null) : SubResourceFactory<Humidifier.ECS.ClusterTypes.ServiceConnectDefaults>
{

    protected override Humidifier.ECS.ClusterTypes.ServiceConnectDefaults Create()
    {
        var serviceConnectDefaultsResult = CreateServiceConnectDefaults();
        factoryAction?.Invoke(serviceConnectDefaultsResult);

        return serviceConnectDefaultsResult;
    }

    private Humidifier.ECS.ClusterTypes.ServiceConnectDefaults CreateServiceConnectDefaults()
    {
        var serviceConnectDefaultsResult = new Humidifier.ECS.ClusterTypes.ServiceConnectDefaults();

        return serviceConnectDefaultsResult;
    }

} // End Of Class

public static class InnerClusterServiceConnectDefaultsFactoryExtensions
{
}
