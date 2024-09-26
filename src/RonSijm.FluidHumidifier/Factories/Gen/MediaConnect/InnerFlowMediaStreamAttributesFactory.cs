// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerFlowMediaStreamAttributesFactory(Action<Humidifier.MediaConnect.FlowTypes.MediaStreamAttributes> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.FlowTypes.MediaStreamAttributes>
{

    internal InnerFlowFmtpFactory FmtpFactory { get; set; }

    protected override Humidifier.MediaConnect.FlowTypes.MediaStreamAttributes Create()
    {
        var mediaStreamAttributesResult = CreateMediaStreamAttributes();
        factoryAction?.Invoke(mediaStreamAttributesResult);

        return mediaStreamAttributesResult;
    }

    private Humidifier.MediaConnect.FlowTypes.MediaStreamAttributes CreateMediaStreamAttributes()
    {
        var mediaStreamAttributesResult = new Humidifier.MediaConnect.FlowTypes.MediaStreamAttributes();

        return mediaStreamAttributesResult;
    }
    public override void CreateChildren(Humidifier.MediaConnect.FlowTypes.MediaStreamAttributes result)
    {
        base.CreateChildren(result);

        result.Fmtp ??= FmtpFactory?.Build();
    }

} // End Of Class

public static class InnerFlowMediaStreamAttributesFactoryExtensions
{
    public static CombinedResult<InnerFlowMediaStreamAttributesFactory, InnerFlowFmtpFactory> WithFmtp(this InnerFlowMediaStreamAttributesFactory parentFactory, Action<Humidifier.MediaConnect.FlowTypes.Fmtp> subFactoryAction = null)
    {
        parentFactory.FmtpFactory = new InnerFlowFmtpFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FmtpFactory);
    }

    public static CombinedResult<InnerFlowMediaStreamAttributesFactory, T1, InnerFlowFmtpFactory> WithFmtp<T1>(this CombinedResult<InnerFlowMediaStreamAttributesFactory, T1> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.Fmtp> subFactoryAction = null) => new (combinedResult, combinedResult, WithFmtp(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowMediaStreamAttributesFactory, InnerFlowFmtpFactory> WithFmtp<T1>(this CombinedResult<T1, InnerFlowMediaStreamAttributesFactory> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.Fmtp> subFactoryAction = null) => new (combinedResult, combinedResult, WithFmtp(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerFlowMediaStreamAttributesFactory, T1, T2, InnerFlowFmtpFactory> WithFmtp<T1, T2>(this CombinedResult<InnerFlowMediaStreamAttributesFactory, T1, T2> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.Fmtp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFmtp(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowMediaStreamAttributesFactory, T2, InnerFlowFmtpFactory> WithFmtp<T1, T2>(this CombinedResult<T1, InnerFlowMediaStreamAttributesFactory, T2> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.Fmtp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFmtp(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowMediaStreamAttributesFactory, InnerFlowFmtpFactory> WithFmtp<T1, T2>(this CombinedResult<T1, T2, InnerFlowMediaStreamAttributesFactory> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.Fmtp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFmtp(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerFlowMediaStreamAttributesFactory, T1, T2, T3, InnerFlowFmtpFactory> WithFmtp<T1, T2, T3>(this CombinedResult<InnerFlowMediaStreamAttributesFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.Fmtp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFmtp(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowMediaStreamAttributesFactory, T2, T3, InnerFlowFmtpFactory> WithFmtp<T1, T2, T3>(this CombinedResult<T1, InnerFlowMediaStreamAttributesFactory, T2, T3> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.Fmtp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFmtp(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowMediaStreamAttributesFactory, T3, InnerFlowFmtpFactory> WithFmtp<T1, T2, T3>(this CombinedResult<T1, T2, InnerFlowMediaStreamAttributesFactory, T3> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.Fmtp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFmtp(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFlowMediaStreamAttributesFactory, InnerFlowFmtpFactory> WithFmtp<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFlowMediaStreamAttributesFactory> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.Fmtp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFmtp(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerFlowMediaStreamAttributesFactory, T1, T2, T3, T4, InnerFlowFmtpFactory> WithFmtp<T1, T2, T3, T4>(this CombinedResult<InnerFlowMediaStreamAttributesFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.Fmtp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFmtp(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowMediaStreamAttributesFactory, T2, T3, T4, InnerFlowFmtpFactory> WithFmtp<T1, T2, T3, T4>(this CombinedResult<T1, InnerFlowMediaStreamAttributesFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.Fmtp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFmtp(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowMediaStreamAttributesFactory, T3, T4, InnerFlowFmtpFactory> WithFmtp<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFlowMediaStreamAttributesFactory, T3, T4> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.Fmtp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFmtp(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFlowMediaStreamAttributesFactory, T4, InnerFlowFmtpFactory> WithFmtp<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFlowMediaStreamAttributesFactory, T4> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.Fmtp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFmtp(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerFlowMediaStreamAttributesFactory, InnerFlowFmtpFactory> WithFmtp<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFlowMediaStreamAttributesFactory> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.Fmtp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFmtp(combinedResult.T5, subFactoryAction));
}
