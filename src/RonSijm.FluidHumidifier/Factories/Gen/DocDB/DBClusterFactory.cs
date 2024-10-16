// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DocDB;

public class DBClusterFactory(string resourceName = null, Action<Humidifier.DocDB.DBCluster> factoryAction = null) : ResourceFactory<Humidifier.DocDB.DBCluster>(resourceName)
{

    protected override Humidifier.DocDB.DBCluster Create()
    {
        var dBClusterResult = CreateDBCluster();
        factoryAction?.Invoke(dBClusterResult);

        return dBClusterResult;
    }

    private Humidifier.DocDB.DBCluster CreateDBCluster()
    {
        var dBClusterResult = new Humidifier.DocDB.DBCluster
        {
            GivenName = InputResourceName,
        };

        return dBClusterResult;
    }

} // End Of Class

public static class DBClusterFactoryExtensions
{
}
