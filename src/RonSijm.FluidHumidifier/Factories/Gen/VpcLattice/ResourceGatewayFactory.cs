// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.VpcLattice;

public class ResourceGatewayFactory(string resourceName = null, Action<Humidifier.VpcLattice.ResourceGateway> factoryAction = null) : ResourceFactory<Humidifier.VpcLattice.ResourceGateway>(resourceName)
{

    protected override Humidifier.VpcLattice.ResourceGateway Create()
    {
        var resourceGatewayResult = CreateResourceGateway();
        factoryAction?.Invoke(resourceGatewayResult);

        return resourceGatewayResult;
    }

    private Humidifier.VpcLattice.ResourceGateway CreateResourceGateway()
    {
        var resourceGatewayResult = new Humidifier.VpcLattice.ResourceGateway
        {
            GivenName = InputResourceName,
        };

        return resourceGatewayResult;
    }

} // End Of Class

public static class ResourceGatewayFactoryExtensions
{
}
