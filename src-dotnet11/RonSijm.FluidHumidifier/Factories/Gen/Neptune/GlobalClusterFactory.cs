// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Neptune;

public class GlobalClusterFactory(string resourceName = null, Action<Humidifier.Neptune.GlobalCluster> factoryAction = null) : ResourceFactory<Humidifier.Neptune.GlobalCluster>(resourceName)
{

    protected override Humidifier.Neptune.GlobalCluster Create()
    {
        var globalClusterResult = CreateGlobalCluster();
        factoryAction?.Invoke(globalClusterResult);

        return globalClusterResult;
    }

    private Humidifier.Neptune.GlobalCluster CreateGlobalCluster()
    {
        var globalClusterResult = new Humidifier.Neptune.GlobalCluster
        {
            GivenName = InputResourceName,
        };

        return globalClusterResult;
    }

} // End Of Class

public static class GlobalClusterFactoryExtensions
{
}
