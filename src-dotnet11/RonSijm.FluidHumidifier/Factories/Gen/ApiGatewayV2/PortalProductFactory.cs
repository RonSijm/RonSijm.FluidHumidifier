// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApiGatewayV2;

public class PortalProductFactory(string resourceName = null, Action<Humidifier.ApiGatewayV2.PortalProduct> factoryAction = null) : ResourceFactory<Humidifier.ApiGatewayV2.PortalProduct>(resourceName)
{

    protected override Humidifier.ApiGatewayV2.PortalProduct Create()
    {
        var portalProductResult = CreatePortalProduct();
        factoryAction?.Invoke(portalProductResult);

        return portalProductResult;
    }

    private Humidifier.ApiGatewayV2.PortalProduct CreatePortalProduct()
    {
        var portalProductResult = new Humidifier.ApiGatewayV2.PortalProduct
        {
            GivenName = InputResourceName,
        };

        return portalProductResult;
    }

} // End Of Class

public static class PortalProductFactoryExtensions
{
}
