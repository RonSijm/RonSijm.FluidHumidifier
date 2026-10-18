// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class TransitGatewayMulticastGroupMemberFactory(string resourceName = null, Action<Humidifier.EC2.TransitGatewayMulticastGroupMember> factoryAction = null) : ResourceFactory<Humidifier.EC2.TransitGatewayMulticastGroupMember>(resourceName)
{

    protected override Humidifier.EC2.TransitGatewayMulticastGroupMember Create()
    {
        var transitGatewayMulticastGroupMemberResult = CreateTransitGatewayMulticastGroupMember();
        factoryAction?.Invoke(transitGatewayMulticastGroupMemberResult);

        return transitGatewayMulticastGroupMemberResult;
    }

    private Humidifier.EC2.TransitGatewayMulticastGroupMember CreateTransitGatewayMulticastGroupMember()
    {
        var transitGatewayMulticastGroupMemberResult = new Humidifier.EC2.TransitGatewayMulticastGroupMember
        {
            GivenName = InputResourceName,
        };

        return transitGatewayMulticastGroupMemberResult;
    }

} // End Of Class

public static class TransitGatewayMulticastGroupMemberFactoryExtensions
{
}
