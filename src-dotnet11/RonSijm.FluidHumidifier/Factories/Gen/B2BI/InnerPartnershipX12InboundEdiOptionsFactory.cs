// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.B2BI;

public class InnerPartnershipX12InboundEdiOptionsFactory(Action<Humidifier.B2BI.PartnershipTypes.X12InboundEdiOptions> factoryAction = null) : SubResourceFactory<Humidifier.B2BI.PartnershipTypes.X12InboundEdiOptions>
{

    internal InnerPartnershipX12AcknowledgmentOptionsFactory AcknowledgmentOptionsFactory { get; set; }

    protected override Humidifier.B2BI.PartnershipTypes.X12InboundEdiOptions Create()
    {
        var x12InboundEdiOptionsResult = CreateX12InboundEdiOptions();
        factoryAction?.Invoke(x12InboundEdiOptionsResult);

        return x12InboundEdiOptionsResult;
    }

    private Humidifier.B2BI.PartnershipTypes.X12InboundEdiOptions CreateX12InboundEdiOptions()
    {
        var x12InboundEdiOptionsResult = new Humidifier.B2BI.PartnershipTypes.X12InboundEdiOptions();

        return x12InboundEdiOptionsResult;
    }
    public override void CreateChildren(Humidifier.B2BI.PartnershipTypes.X12InboundEdiOptions result)
    {
        base.CreateChildren(result);

        result.AcknowledgmentOptions ??= AcknowledgmentOptionsFactory?.Build();
    }

} // End Of Class

public static class InnerPartnershipX12InboundEdiOptionsFactoryExtensions
{
    public static CombinedResult<InnerPartnershipX12InboundEdiOptionsFactory, InnerPartnershipX12AcknowledgmentOptionsFactory> WithAcknowledgmentOptions(this InnerPartnershipX12InboundEdiOptionsFactory parentFactory, Action<Humidifier.B2BI.PartnershipTypes.X12AcknowledgmentOptions> subFactoryAction = null)
    {
        parentFactory.AcknowledgmentOptionsFactory = new InnerPartnershipX12AcknowledgmentOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AcknowledgmentOptionsFactory);
    }

    public static CombinedResult<InnerPartnershipX12InboundEdiOptionsFactory, T1, InnerPartnershipX12AcknowledgmentOptionsFactory> WithAcknowledgmentOptions<T1>(this CombinedResult<InnerPartnershipX12InboundEdiOptionsFactory, T1> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.X12AcknowledgmentOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithAcknowledgmentOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPartnershipX12InboundEdiOptionsFactory, InnerPartnershipX12AcknowledgmentOptionsFactory> WithAcknowledgmentOptions<T1>(this CombinedResult<T1, InnerPartnershipX12InboundEdiOptionsFactory> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.X12AcknowledgmentOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithAcknowledgmentOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerPartnershipX12InboundEdiOptionsFactory, T1, T2, InnerPartnershipX12AcknowledgmentOptionsFactory> WithAcknowledgmentOptions<T1, T2>(this CombinedResult<InnerPartnershipX12InboundEdiOptionsFactory, T1, T2> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.X12AcknowledgmentOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAcknowledgmentOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPartnershipX12InboundEdiOptionsFactory, T2, InnerPartnershipX12AcknowledgmentOptionsFactory> WithAcknowledgmentOptions<T1, T2>(this CombinedResult<T1, InnerPartnershipX12InboundEdiOptionsFactory, T2> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.X12AcknowledgmentOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAcknowledgmentOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerPartnershipX12InboundEdiOptionsFactory, InnerPartnershipX12AcknowledgmentOptionsFactory> WithAcknowledgmentOptions<T1, T2>(this CombinedResult<T1, T2, InnerPartnershipX12InboundEdiOptionsFactory> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.X12AcknowledgmentOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAcknowledgmentOptions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerPartnershipX12InboundEdiOptionsFactory, T1, T2, T3, InnerPartnershipX12AcknowledgmentOptionsFactory> WithAcknowledgmentOptions<T1, T2, T3>(this CombinedResult<InnerPartnershipX12InboundEdiOptionsFactory, T1, T2, T3> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.X12AcknowledgmentOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAcknowledgmentOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPartnershipX12InboundEdiOptionsFactory, T2, T3, InnerPartnershipX12AcknowledgmentOptionsFactory> WithAcknowledgmentOptions<T1, T2, T3>(this CombinedResult<T1, InnerPartnershipX12InboundEdiOptionsFactory, T2, T3> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.X12AcknowledgmentOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAcknowledgmentOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerPartnershipX12InboundEdiOptionsFactory, T3, InnerPartnershipX12AcknowledgmentOptionsFactory> WithAcknowledgmentOptions<T1, T2, T3>(this CombinedResult<T1, T2, InnerPartnershipX12InboundEdiOptionsFactory, T3> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.X12AcknowledgmentOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAcknowledgmentOptions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerPartnershipX12InboundEdiOptionsFactory, InnerPartnershipX12AcknowledgmentOptionsFactory> WithAcknowledgmentOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerPartnershipX12InboundEdiOptionsFactory> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.X12AcknowledgmentOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAcknowledgmentOptions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerPartnershipX12InboundEdiOptionsFactory, T1, T2, T3, T4, InnerPartnershipX12AcknowledgmentOptionsFactory> WithAcknowledgmentOptions<T1, T2, T3, T4>(this CombinedResult<InnerPartnershipX12InboundEdiOptionsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.X12AcknowledgmentOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAcknowledgmentOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPartnershipX12InboundEdiOptionsFactory, T2, T3, T4, InnerPartnershipX12AcknowledgmentOptionsFactory> WithAcknowledgmentOptions<T1, T2, T3, T4>(this CombinedResult<T1, InnerPartnershipX12InboundEdiOptionsFactory, T2, T3, T4> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.X12AcknowledgmentOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAcknowledgmentOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerPartnershipX12InboundEdiOptionsFactory, T3, T4, InnerPartnershipX12AcknowledgmentOptionsFactory> WithAcknowledgmentOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerPartnershipX12InboundEdiOptionsFactory, T3, T4> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.X12AcknowledgmentOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAcknowledgmentOptions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerPartnershipX12InboundEdiOptionsFactory, T4, InnerPartnershipX12AcknowledgmentOptionsFactory> WithAcknowledgmentOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerPartnershipX12InboundEdiOptionsFactory, T4> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.X12AcknowledgmentOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAcknowledgmentOptions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerPartnershipX12InboundEdiOptionsFactory, InnerPartnershipX12AcknowledgmentOptionsFactory> WithAcknowledgmentOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerPartnershipX12InboundEdiOptionsFactory> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.X12AcknowledgmentOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAcknowledgmentOptions(combinedResult.T5, subFactoryAction).T2);
}
