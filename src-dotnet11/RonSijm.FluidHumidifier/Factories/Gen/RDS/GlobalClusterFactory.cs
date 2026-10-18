// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RDS;

public class GlobalClusterFactory(string resourceName = null, Action<Humidifier.RDS.GlobalCluster> factoryAction = null) : ResourceFactory<Humidifier.RDS.GlobalCluster>(resourceName)
{

    protected override Humidifier.RDS.GlobalCluster Create()
    {
        var globalClusterResult = CreateGlobalCluster();
        factoryAction?.Invoke(globalClusterResult);

        return globalClusterResult;
    }

    private Humidifier.RDS.GlobalCluster CreateGlobalCluster()
    {
        var globalClusterResult = new Humidifier.RDS.GlobalCluster
        {
            GivenName = InputResourceName,
        };

        return globalClusterResult;
    }

} // End Of Class

public static class GlobalClusterFactoryExtensions
{
}
