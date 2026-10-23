// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class GatewayClusterAssociationsFactory(string resourceName = null, Action<Humidifier.ECS.GatewayClusterAssociations> factoryAction = null) : ResourceFactory<Humidifier.ECS.GatewayClusterAssociations>(resourceName)
{

    protected override Humidifier.ECS.GatewayClusterAssociations Create()
    {
        var gatewayClusterAssociationsResult = CreateGatewayClusterAssociations();
        factoryAction?.Invoke(gatewayClusterAssociationsResult);

        return gatewayClusterAssociationsResult;
    }

    private Humidifier.ECS.GatewayClusterAssociations CreateGatewayClusterAssociations()
    {
        var gatewayClusterAssociationsResult = new Humidifier.ECS.GatewayClusterAssociations
        {
            GivenName = InputResourceName,
        };

        return gatewayClusterAssociationsResult;
    }

} // End Of Class

public static class GatewayClusterAssociationsFactoryExtensions
{
}
