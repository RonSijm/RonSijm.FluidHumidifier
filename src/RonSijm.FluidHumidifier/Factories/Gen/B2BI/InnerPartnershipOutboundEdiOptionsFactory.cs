// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.B2BI;

public class InnerPartnershipOutboundEdiOptionsFactory(Action<Humidifier.B2BI.PartnershipTypes.OutboundEdiOptions> factoryAction = null) : SubResourceFactory<Humidifier.B2BI.PartnershipTypes.OutboundEdiOptions>
{

    internal InnerPartnershipX12EnvelopeFactory X12Factory { get; set; }

    protected override Humidifier.B2BI.PartnershipTypes.OutboundEdiOptions Create()
    {
        var outboundEdiOptionsResult = CreateOutboundEdiOptions();
        factoryAction?.Invoke(outboundEdiOptionsResult);

        return outboundEdiOptionsResult;
    }

    private Humidifier.B2BI.PartnershipTypes.OutboundEdiOptions CreateOutboundEdiOptions()
    {
        var outboundEdiOptionsResult = new Humidifier.B2BI.PartnershipTypes.OutboundEdiOptions();

        return outboundEdiOptionsResult;
    }
    public override void CreateChildren(Humidifier.B2BI.PartnershipTypes.OutboundEdiOptions result)
    {
        base.CreateChildren(result);

        result.X12 ??= X12Factory?.Build();
    }

} // End Of Class

public static class InnerPartnershipOutboundEdiOptionsFactoryExtensions
{
    public static CombinedResult<InnerPartnershipOutboundEdiOptionsFactory, InnerPartnershipX12EnvelopeFactory> WithX12(this InnerPartnershipOutboundEdiOptionsFactory parentFactory, Action<Humidifier.B2BI.PartnershipTypes.X12Envelope> subFactoryAction = null)
    {
        parentFactory.X12Factory = new InnerPartnershipX12EnvelopeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.X12Factory);
    }

    public static CombinedResult<InnerPartnershipOutboundEdiOptionsFactory, T1, InnerPartnershipX12EnvelopeFactory> WithX12<T1>(this CombinedResult<InnerPartnershipOutboundEdiOptionsFactory, T1> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.X12Envelope> subFactoryAction = null) => new (combinedResult, combinedResult, WithX12(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPartnershipOutboundEdiOptionsFactory, InnerPartnershipX12EnvelopeFactory> WithX12<T1>(this CombinedResult<T1, InnerPartnershipOutboundEdiOptionsFactory> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.X12Envelope> subFactoryAction = null) => new (combinedResult, combinedResult, WithX12(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerPartnershipOutboundEdiOptionsFactory, T1, T2, InnerPartnershipX12EnvelopeFactory> WithX12<T1, T2>(this CombinedResult<InnerPartnershipOutboundEdiOptionsFactory, T1, T2> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.X12Envelope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithX12(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPartnershipOutboundEdiOptionsFactory, T2, InnerPartnershipX12EnvelopeFactory> WithX12<T1, T2>(this CombinedResult<T1, InnerPartnershipOutboundEdiOptionsFactory, T2> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.X12Envelope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithX12(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPartnershipOutboundEdiOptionsFactory, InnerPartnershipX12EnvelopeFactory> WithX12<T1, T2>(this CombinedResult<T1, T2, InnerPartnershipOutboundEdiOptionsFactory> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.X12Envelope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithX12(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerPartnershipOutboundEdiOptionsFactory, T1, T2, T3, InnerPartnershipX12EnvelopeFactory> WithX12<T1, T2, T3>(this CombinedResult<InnerPartnershipOutboundEdiOptionsFactory, T1, T2, T3> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.X12Envelope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithX12(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPartnershipOutboundEdiOptionsFactory, T2, T3, InnerPartnershipX12EnvelopeFactory> WithX12<T1, T2, T3>(this CombinedResult<T1, InnerPartnershipOutboundEdiOptionsFactory, T2, T3> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.X12Envelope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithX12(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPartnershipOutboundEdiOptionsFactory, T3, InnerPartnershipX12EnvelopeFactory> WithX12<T1, T2, T3>(this CombinedResult<T1, T2, InnerPartnershipOutboundEdiOptionsFactory, T3> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.X12Envelope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithX12(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPartnershipOutboundEdiOptionsFactory, InnerPartnershipX12EnvelopeFactory> WithX12<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerPartnershipOutboundEdiOptionsFactory> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.X12Envelope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithX12(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerPartnershipOutboundEdiOptionsFactory, T1, T2, T3, T4, InnerPartnershipX12EnvelopeFactory> WithX12<T1, T2, T3, T4>(this CombinedResult<InnerPartnershipOutboundEdiOptionsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.X12Envelope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithX12(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPartnershipOutboundEdiOptionsFactory, T2, T3, T4, InnerPartnershipX12EnvelopeFactory> WithX12<T1, T2, T3, T4>(this CombinedResult<T1, InnerPartnershipOutboundEdiOptionsFactory, T2, T3, T4> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.X12Envelope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithX12(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPartnershipOutboundEdiOptionsFactory, T3, T4, InnerPartnershipX12EnvelopeFactory> WithX12<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerPartnershipOutboundEdiOptionsFactory, T3, T4> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.X12Envelope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithX12(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPartnershipOutboundEdiOptionsFactory, T4, InnerPartnershipX12EnvelopeFactory> WithX12<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerPartnershipOutboundEdiOptionsFactory, T4> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.X12Envelope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithX12(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerPartnershipOutboundEdiOptionsFactory, InnerPartnershipX12EnvelopeFactory> WithX12<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerPartnershipOutboundEdiOptionsFactory> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.X12Envelope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithX12(combinedResult.T5, subFactoryAction));
}
