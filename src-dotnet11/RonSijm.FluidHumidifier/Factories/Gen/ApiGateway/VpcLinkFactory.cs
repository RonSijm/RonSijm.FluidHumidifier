// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApiGateway;

public class VpcLinkFactory(string resourceName = null, Action<Humidifier.ApiGateway.VpcLink> factoryAction = null) : ResourceFactory<Humidifier.ApiGateway.VpcLink>(resourceName)
{

    protected override Humidifier.ApiGateway.VpcLink Create()
    {
        var vpcLinkResult = CreateVpcLink();
        factoryAction?.Invoke(vpcLinkResult);

        return vpcLinkResult;
    }

    private Humidifier.ApiGateway.VpcLink CreateVpcLink()
    {
        var vpcLinkResult = new Humidifier.ApiGateway.VpcLink
        {
            GivenName = InputResourceName,
        };

        return vpcLinkResult;
    }

} // End Of Class

public static class VpcLinkFactoryExtensions
{
}
