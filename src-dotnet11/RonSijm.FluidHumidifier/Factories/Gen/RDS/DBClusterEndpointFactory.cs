// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RDS;

public class DBClusterEndpointFactory(string resourceName = null, Action<Humidifier.RDS.DBClusterEndpoint> factoryAction = null) : ResourceFactory<Humidifier.RDS.DBClusterEndpoint>(resourceName)
{

    protected override Humidifier.RDS.DBClusterEndpoint Create()
    {
        var dBClusterEndpointResult = CreateDBClusterEndpoint();
        factoryAction?.Invoke(dBClusterEndpointResult);

        return dBClusterEndpointResult;
    }

    private Humidifier.RDS.DBClusterEndpoint CreateDBClusterEndpoint()
    {
        var dBClusterEndpointResult = new Humidifier.RDS.DBClusterEndpoint
        {
            GivenName = InputResourceName,
        };

        return dBClusterEndpointResult;
    }

} // End Of Class

public static class DBClusterEndpointFactoryExtensions
{
}
