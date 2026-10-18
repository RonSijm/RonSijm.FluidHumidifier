// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerFlowFmtpFactory(Action<Humidifier.MediaConnect.FlowTypes.Fmtp> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.FlowTypes.Fmtp>
{

    protected override Humidifier.MediaConnect.FlowTypes.Fmtp Create()
    {
        var fmtpResult = CreateFmtp();
        factoryAction?.Invoke(fmtpResult);

        return fmtpResult;
    }

    private Humidifier.MediaConnect.FlowTypes.Fmtp CreateFmtp()
    {
        var fmtpResult = new Humidifier.MediaConnect.FlowTypes.Fmtp();

        return fmtpResult;
    }

} // End Of Class

public static class InnerFlowFmtpFactoryExtensions
{
}
