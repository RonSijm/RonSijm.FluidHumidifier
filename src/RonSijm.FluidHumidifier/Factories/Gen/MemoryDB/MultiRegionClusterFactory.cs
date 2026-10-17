// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MemoryDB;

public class MultiRegionClusterFactory(string resourceName = null, Action<Humidifier.MemoryDB.MultiRegionCluster> factoryAction = null) : ResourceFactory<Humidifier.MemoryDB.MultiRegionCluster>(resourceName)
{

    protected override Humidifier.MemoryDB.MultiRegionCluster Create()
    {
        var multiRegionClusterResult = CreateMultiRegionCluster();
        factoryAction?.Invoke(multiRegionClusterResult);

        return multiRegionClusterResult;
    }

    private Humidifier.MemoryDB.MultiRegionCluster CreateMultiRegionCluster()
    {
        var multiRegionClusterResult = new Humidifier.MemoryDB.MultiRegionCluster
        {
            GivenName = InputResourceName,
        };

        return multiRegionClusterResult;
    }

} // End Of Class

public static class MultiRegionClusterFactoryExtensions
{
}
