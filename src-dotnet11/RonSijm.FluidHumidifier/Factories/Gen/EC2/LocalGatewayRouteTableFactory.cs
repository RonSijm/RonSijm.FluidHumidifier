// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class LocalGatewayRouteTableFactory(string resourceName = null, Action<Humidifier.EC2.LocalGatewayRouteTable> factoryAction = null) : ResourceFactory<Humidifier.EC2.LocalGatewayRouteTable>(resourceName)
{

    protected override Humidifier.EC2.LocalGatewayRouteTable Create()
    {
        var localGatewayRouteTableResult = CreateLocalGatewayRouteTable();
        factoryAction?.Invoke(localGatewayRouteTableResult);

        return localGatewayRouteTableResult;
    }

    private Humidifier.EC2.LocalGatewayRouteTable CreateLocalGatewayRouteTable()
    {
        var localGatewayRouteTableResult = new Humidifier.EC2.LocalGatewayRouteTable
        {
            GivenName = InputResourceName,
        };

        return localGatewayRouteTableResult;
    }

} // End Of Class

public static class LocalGatewayRouteTableFactoryExtensions
{
}
