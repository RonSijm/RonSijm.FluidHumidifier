// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.B2BI;

public class InnerPartnershipX12EnvelopeFactory(Action<Humidifier.B2BI.PartnershipTypes.X12Envelope> factoryAction = null) : SubResourceFactory<Humidifier.B2BI.PartnershipTypes.X12Envelope>
{

    internal InnerPartnershipX12OutboundEdiHeadersFactory CommonFactory { get; set; }

    protected override Humidifier.B2BI.PartnershipTypes.X12Envelope Create()
    {
        var x12EnvelopeResult = CreateX12Envelope();
        factoryAction?.Invoke(x12EnvelopeResult);

        return x12EnvelopeResult;
    }

    private Humidifier.B2BI.PartnershipTypes.X12Envelope CreateX12Envelope()
    {
        var x12EnvelopeResult = new Humidifier.B2BI.PartnershipTypes.X12Envelope();

        return x12EnvelopeResult;
    }
    public override void CreateChildren(Humidifier.B2BI.PartnershipTypes.X12Envelope result)
    {
        base.CreateChildren(result);

        result.Common ??= CommonFactory?.Build();
    }

} // End Of Class

public static class InnerPartnershipX12EnvelopeFactoryExtensions
{
    public static CombinedResult<InnerPartnershipX12EnvelopeFactory, InnerPartnershipX12OutboundEdiHeadersFactory> WithCommon(this InnerPartnershipX12EnvelopeFactory parentFactory, Action<Humidifier.B2BI.PartnershipTypes.X12OutboundEdiHeaders> subFactoryAction = null)
    {
        parentFactory.CommonFactory = new InnerPartnershipX12OutboundEdiHeadersFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CommonFactory);
    }

    public static CombinedResult<InnerPartnershipX12EnvelopeFactory, T1, InnerPartnershipX12OutboundEdiHeadersFactory> WithCommon<T1>(this CombinedResult<InnerPartnershipX12EnvelopeFactory, T1> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.X12OutboundEdiHeaders> subFactoryAction = null) => new (combinedResult, combinedResult, WithCommon(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPartnershipX12EnvelopeFactory, InnerPartnershipX12OutboundEdiHeadersFactory> WithCommon<T1>(this CombinedResult<T1, InnerPartnershipX12EnvelopeFactory> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.X12OutboundEdiHeaders> subFactoryAction = null) => new (combinedResult, combinedResult, WithCommon(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerPartnershipX12EnvelopeFactory, T1, T2, InnerPartnershipX12OutboundEdiHeadersFactory> WithCommon<T1, T2>(this CombinedResult<InnerPartnershipX12EnvelopeFactory, T1, T2> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.X12OutboundEdiHeaders> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCommon(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPartnershipX12EnvelopeFactory, T2, InnerPartnershipX12OutboundEdiHeadersFactory> WithCommon<T1, T2>(this CombinedResult<T1, InnerPartnershipX12EnvelopeFactory, T2> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.X12OutboundEdiHeaders> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCommon(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPartnershipX12EnvelopeFactory, InnerPartnershipX12OutboundEdiHeadersFactory> WithCommon<T1, T2>(this CombinedResult<T1, T2, InnerPartnershipX12EnvelopeFactory> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.X12OutboundEdiHeaders> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCommon(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerPartnershipX12EnvelopeFactory, T1, T2, T3, InnerPartnershipX12OutboundEdiHeadersFactory> WithCommon<T1, T2, T3>(this CombinedResult<InnerPartnershipX12EnvelopeFactory, T1, T2, T3> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.X12OutboundEdiHeaders> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCommon(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPartnershipX12EnvelopeFactory, T2, T3, InnerPartnershipX12OutboundEdiHeadersFactory> WithCommon<T1, T2, T3>(this CombinedResult<T1, InnerPartnershipX12EnvelopeFactory, T2, T3> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.X12OutboundEdiHeaders> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCommon(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPartnershipX12EnvelopeFactory, T3, InnerPartnershipX12OutboundEdiHeadersFactory> WithCommon<T1, T2, T3>(this CombinedResult<T1, T2, InnerPartnershipX12EnvelopeFactory, T3> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.X12OutboundEdiHeaders> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCommon(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPartnershipX12EnvelopeFactory, InnerPartnershipX12OutboundEdiHeadersFactory> WithCommon<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerPartnershipX12EnvelopeFactory> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.X12OutboundEdiHeaders> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCommon(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerPartnershipX12EnvelopeFactory, T1, T2, T3, T4, InnerPartnershipX12OutboundEdiHeadersFactory> WithCommon<T1, T2, T3, T4>(this CombinedResult<InnerPartnershipX12EnvelopeFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.X12OutboundEdiHeaders> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCommon(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPartnershipX12EnvelopeFactory, T2, T3, T4, InnerPartnershipX12OutboundEdiHeadersFactory> WithCommon<T1, T2, T3, T4>(this CombinedResult<T1, InnerPartnershipX12EnvelopeFactory, T2, T3, T4> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.X12OutboundEdiHeaders> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCommon(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPartnershipX12EnvelopeFactory, T3, T4, InnerPartnershipX12OutboundEdiHeadersFactory> WithCommon<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerPartnershipX12EnvelopeFactory, T3, T4> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.X12OutboundEdiHeaders> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCommon(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPartnershipX12EnvelopeFactory, T4, InnerPartnershipX12OutboundEdiHeadersFactory> WithCommon<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerPartnershipX12EnvelopeFactory, T4> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.X12OutboundEdiHeaders> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCommon(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerPartnershipX12EnvelopeFactory, InnerPartnershipX12OutboundEdiHeadersFactory> WithCommon<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerPartnershipX12EnvelopeFactory> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.X12OutboundEdiHeaders> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCommon(combinedResult.T5, subFactoryAction));
}
