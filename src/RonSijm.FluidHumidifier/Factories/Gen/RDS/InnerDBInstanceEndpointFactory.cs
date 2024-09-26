// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RDS;

public class InnerDBInstanceEndpointFactory(Action<Humidifier.RDS.DBInstanceTypes.Endpoint> factoryAction = null) : SubResourceFactory<Humidifier.RDS.DBInstanceTypes.Endpoint>
{

    protected override Humidifier.RDS.DBInstanceTypes.Endpoint Create()
    {
        var endpointResult = CreateEndpoint();
        factoryAction?.Invoke(endpointResult);

        return endpointResult;
    }

    private Humidifier.RDS.DBInstanceTypes.Endpoint CreateEndpoint()
    {
        var endpointResult = new Humidifier.RDS.DBInstanceTypes.Endpoint();

        return endpointResult;
    }

} // End Of Class

public static class InnerDBInstanceEndpointFactoryExtensions
{
}
