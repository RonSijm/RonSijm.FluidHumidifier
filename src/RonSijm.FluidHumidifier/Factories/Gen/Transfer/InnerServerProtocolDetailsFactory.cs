// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Transfer;

public class InnerServerProtocolDetailsFactory(Action<Humidifier.Transfer.ServerTypes.ProtocolDetails> factoryAction = null) : SubResourceFactory<Humidifier.Transfer.ServerTypes.ProtocolDetails>
{

    protected override Humidifier.Transfer.ServerTypes.ProtocolDetails Create()
    {
        var protocolDetailsResult = CreateProtocolDetails();
        factoryAction?.Invoke(protocolDetailsResult);

        return protocolDetailsResult;
    }

    private Humidifier.Transfer.ServerTypes.ProtocolDetails CreateProtocolDetails()
    {
        var protocolDetailsResult = new Humidifier.Transfer.ServerTypes.ProtocolDetails();

        return protocolDetailsResult;
    }

} // End Of Class

public static class InnerServerProtocolDetailsFactoryExtensions
{
}
