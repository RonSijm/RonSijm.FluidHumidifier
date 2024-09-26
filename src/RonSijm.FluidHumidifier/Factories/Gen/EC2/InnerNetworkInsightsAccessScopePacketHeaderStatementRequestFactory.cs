// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerNetworkInsightsAccessScopePacketHeaderStatementRequestFactory(Action<Humidifier.EC2.NetworkInsightsAccessScopeTypes.PacketHeaderStatementRequest> factoryAction = null) : SubResourceFactory<Humidifier.EC2.NetworkInsightsAccessScopeTypes.PacketHeaderStatementRequest>
{

    protected override Humidifier.EC2.NetworkInsightsAccessScopeTypes.PacketHeaderStatementRequest Create()
    {
        var packetHeaderStatementRequestResult = CreatePacketHeaderStatementRequest();
        factoryAction?.Invoke(packetHeaderStatementRequestResult);

        return packetHeaderStatementRequestResult;
    }

    private Humidifier.EC2.NetworkInsightsAccessScopeTypes.PacketHeaderStatementRequest CreatePacketHeaderStatementRequest()
    {
        var packetHeaderStatementRequestResult = new Humidifier.EC2.NetworkInsightsAccessScopeTypes.PacketHeaderStatementRequest();

        return packetHeaderStatementRequestResult;
    }

} // End Of Class

public static class InnerNetworkInsightsAccessScopePacketHeaderStatementRequestFactoryExtensions
{
}
