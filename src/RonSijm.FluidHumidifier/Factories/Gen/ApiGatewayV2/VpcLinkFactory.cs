// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApiGatewayV2;

public class VpcLinkFactory(string resourceName = null, Action<Humidifier.ApiGatewayV2.VpcLink> factoryAction = null) : ResourceFactory<Humidifier.ApiGatewayV2.VpcLink>(resourceName)
{

    protected override Humidifier.ApiGatewayV2.VpcLink Create()
    {
        var vpcLinkResult = CreateVpcLink();
        factoryAction?.Invoke(vpcLinkResult);

        return vpcLinkResult;
    }

    private Humidifier.ApiGatewayV2.VpcLink CreateVpcLink()
    {
        var vpcLinkResult = new Humidifier.ApiGatewayV2.VpcLink
        {
            GivenName = InputResourceName,
        };

        return vpcLinkResult;
    }

} // End Of Class

public static class VpcLinkFactoryExtensions
{
}
