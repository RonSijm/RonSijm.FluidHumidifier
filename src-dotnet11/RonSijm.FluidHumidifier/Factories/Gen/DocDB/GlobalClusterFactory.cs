// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DocDB;

public class GlobalClusterFactory(string resourceName = null, Action<Humidifier.DocDB.GlobalCluster> factoryAction = null) : ResourceFactory<Humidifier.DocDB.GlobalCluster>(resourceName)
{

    protected override Humidifier.DocDB.GlobalCluster Create()
    {
        var globalClusterResult = CreateGlobalCluster();
        factoryAction?.Invoke(globalClusterResult);

        return globalClusterResult;
    }

    private Humidifier.DocDB.GlobalCluster CreateGlobalCluster()
    {
        var globalClusterResult = new Humidifier.DocDB.GlobalCluster
        {
            GivenName = InputResourceName,
        };

        return globalClusterResult;
    }

} // End Of Class

public static class GlobalClusterFactoryExtensions
{
}
