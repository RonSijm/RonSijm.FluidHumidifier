// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EKS;

public class InnerClusterGatewayApiCrdsFactory(Action<Humidifier.EKS.ClusterTypes.GatewayApiCrds> factoryAction = null) : SubResourceFactory<Humidifier.EKS.ClusterTypes.GatewayApiCrds>
{

    protected override Humidifier.EKS.ClusterTypes.GatewayApiCrds Create()
    {
        var gatewayApiCrdsResult = CreateGatewayApiCrds();
        factoryAction?.Invoke(gatewayApiCrdsResult);

        return gatewayApiCrdsResult;
    }

    private Humidifier.EKS.ClusterTypes.GatewayApiCrds CreateGatewayApiCrds()
    {
        var gatewayApiCrdsResult = new Humidifier.EKS.ClusterTypes.GatewayApiCrds();

        return gatewayApiCrdsResult;
    }

} // End Of Class

public static class InnerClusterGatewayApiCrdsFactoryExtensions
{
}
