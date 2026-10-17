// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerFlowMediaStreamMediaStreamAttributesFactory(Action<Humidifier.MediaConnect.FlowMediaStreamTypes.MediaStreamAttributes> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.FlowMediaStreamTypes.MediaStreamAttributes>
{

    internal InnerFlowMediaStreamFmtpFactory FmtpFactory { get; set; }

    protected override Humidifier.MediaConnect.FlowMediaStreamTypes.MediaStreamAttributes Create()
    {
        var mediaStreamAttributesResult = CreateMediaStreamAttributes();
        factoryAction?.Invoke(mediaStreamAttributesResult);

        return mediaStreamAttributesResult;
    }

    private Humidifier.MediaConnect.FlowMediaStreamTypes.MediaStreamAttributes CreateMediaStreamAttributes()
    {
        var mediaStreamAttributesResult = new Humidifier.MediaConnect.FlowMediaStreamTypes.MediaStreamAttributes();

        return mediaStreamAttributesResult;
    }
    public override void CreateChildren(Humidifier.MediaConnect.FlowMediaStreamTypes.MediaStreamAttributes result)
    {
        base.CreateChildren(result);

        result.Fmtp ??= FmtpFactory?.Build();
    }

} // End Of Class

public static class InnerFlowMediaStreamMediaStreamAttributesFactoryExtensions
{
    public static CombinedResult<InnerFlowMediaStreamMediaStreamAttributesFactory, InnerFlowMediaStreamFmtpFactory> WithFmtp(this InnerFlowMediaStreamMediaStreamAttributesFactory parentFactory, Action<Humidifier.MediaConnect.FlowMediaStreamTypes.Fmtp> subFactoryAction = null)
    {
        parentFactory.FmtpFactory = new InnerFlowMediaStreamFmtpFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FmtpFactory);
    }

    public static CombinedResult<InnerFlowMediaStreamMediaStreamAttributesFactory, T1, InnerFlowMediaStreamFmtpFactory> WithFmtp<T1>(this CombinedResult<InnerFlowMediaStreamMediaStreamAttributesFactory, T1> combinedResult, Action<Humidifier.MediaConnect.FlowMediaStreamTypes.Fmtp> subFactoryAction = null) => new (combinedResult, combinedResult, WithFmtp(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerFlowMediaStreamMediaStreamAttributesFactory, InnerFlowMediaStreamFmtpFactory> WithFmtp<T1>(this CombinedResult<T1, InnerFlowMediaStreamMediaStreamAttributesFactory> combinedResult, Action<Humidifier.MediaConnect.FlowMediaStreamTypes.Fmtp> subFactoryAction = null) => new (combinedResult, combinedResult, WithFmtp(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerFlowMediaStreamMediaStreamAttributesFactory, T1, T2, InnerFlowMediaStreamFmtpFactory> WithFmtp<T1, T2>(this CombinedResult<InnerFlowMediaStreamMediaStreamAttributesFactory, T1, T2> combinedResult, Action<Humidifier.MediaConnect.FlowMediaStreamTypes.Fmtp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFmtp(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerFlowMediaStreamMediaStreamAttributesFactory, T2, InnerFlowMediaStreamFmtpFactory> WithFmtp<T1, T2>(this CombinedResult<T1, InnerFlowMediaStreamMediaStreamAttributesFactory, T2> combinedResult, Action<Humidifier.MediaConnect.FlowMediaStreamTypes.Fmtp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFmtp(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerFlowMediaStreamMediaStreamAttributesFactory, InnerFlowMediaStreamFmtpFactory> WithFmtp<T1, T2>(this CombinedResult<T1, T2, InnerFlowMediaStreamMediaStreamAttributesFactory> combinedResult, Action<Humidifier.MediaConnect.FlowMediaStreamTypes.Fmtp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFmtp(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerFlowMediaStreamMediaStreamAttributesFactory, T1, T2, T3, InnerFlowMediaStreamFmtpFactory> WithFmtp<T1, T2, T3>(this CombinedResult<InnerFlowMediaStreamMediaStreamAttributesFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaConnect.FlowMediaStreamTypes.Fmtp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFmtp(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerFlowMediaStreamMediaStreamAttributesFactory, T2, T3, InnerFlowMediaStreamFmtpFactory> WithFmtp<T1, T2, T3>(this CombinedResult<T1, InnerFlowMediaStreamMediaStreamAttributesFactory, T2, T3> combinedResult, Action<Humidifier.MediaConnect.FlowMediaStreamTypes.Fmtp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFmtp(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerFlowMediaStreamMediaStreamAttributesFactory, T3, InnerFlowMediaStreamFmtpFactory> WithFmtp<T1, T2, T3>(this CombinedResult<T1, T2, InnerFlowMediaStreamMediaStreamAttributesFactory, T3> combinedResult, Action<Humidifier.MediaConnect.FlowMediaStreamTypes.Fmtp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFmtp(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerFlowMediaStreamMediaStreamAttributesFactory, InnerFlowMediaStreamFmtpFactory> WithFmtp<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFlowMediaStreamMediaStreamAttributesFactory> combinedResult, Action<Humidifier.MediaConnect.FlowMediaStreamTypes.Fmtp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFmtp(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerFlowMediaStreamMediaStreamAttributesFactory, T1, T2, T3, T4, InnerFlowMediaStreamFmtpFactory> WithFmtp<T1, T2, T3, T4>(this CombinedResult<InnerFlowMediaStreamMediaStreamAttributesFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.FlowMediaStreamTypes.Fmtp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFmtp(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerFlowMediaStreamMediaStreamAttributesFactory, T2, T3, T4, InnerFlowMediaStreamFmtpFactory> WithFmtp<T1, T2, T3, T4>(this CombinedResult<T1, InnerFlowMediaStreamMediaStreamAttributesFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.FlowMediaStreamTypes.Fmtp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFmtp(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerFlowMediaStreamMediaStreamAttributesFactory, T3, T4, InnerFlowMediaStreamFmtpFactory> WithFmtp<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFlowMediaStreamMediaStreamAttributesFactory, T3, T4> combinedResult, Action<Humidifier.MediaConnect.FlowMediaStreamTypes.Fmtp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFmtp(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerFlowMediaStreamMediaStreamAttributesFactory, T4, InnerFlowMediaStreamFmtpFactory> WithFmtp<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFlowMediaStreamMediaStreamAttributesFactory, T4> combinedResult, Action<Humidifier.MediaConnect.FlowMediaStreamTypes.Fmtp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFmtp(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerFlowMediaStreamMediaStreamAttributesFactory, InnerFlowMediaStreamFmtpFactory> WithFmtp<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFlowMediaStreamMediaStreamAttributesFactory> combinedResult, Action<Humidifier.MediaConnect.FlowMediaStreamTypes.Fmtp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFmtp(combinedResult.T5, subFactoryAction).T2);
}
