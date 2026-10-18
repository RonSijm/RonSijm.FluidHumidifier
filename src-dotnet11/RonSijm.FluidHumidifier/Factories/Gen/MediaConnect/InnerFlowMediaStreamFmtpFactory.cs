// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerFlowMediaStreamFmtpFactory(Action<Humidifier.MediaConnect.FlowMediaStreamTypes.Fmtp> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.FlowMediaStreamTypes.Fmtp>
{

    protected override Humidifier.MediaConnect.FlowMediaStreamTypes.Fmtp Create()
    {
        var fmtpResult = CreateFmtp();
        factoryAction?.Invoke(fmtpResult);

        return fmtpResult;
    }

    private Humidifier.MediaConnect.FlowMediaStreamTypes.Fmtp CreateFmtp()
    {
        var fmtpResult = new Humidifier.MediaConnect.FlowMediaStreamTypes.Fmtp();

        return fmtpResult;
    }

} // End Of Class

public static class InnerFlowMediaStreamFmtpFactoryExtensions
{
}
