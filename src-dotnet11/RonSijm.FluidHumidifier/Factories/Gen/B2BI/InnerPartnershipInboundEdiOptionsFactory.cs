// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.B2BI;

public class InnerPartnershipInboundEdiOptionsFactory(Action<Humidifier.B2BI.PartnershipTypes.InboundEdiOptions> factoryAction = null) : SubResourceFactory<Humidifier.B2BI.PartnershipTypes.InboundEdiOptions>
{

    internal InnerPartnershipX12InboundEdiOptionsFactory X12Factory { get; set; }

    protected override Humidifier.B2BI.PartnershipTypes.InboundEdiOptions Create()
    {
        var inboundEdiOptionsResult = CreateInboundEdiOptions();
        factoryAction?.Invoke(inboundEdiOptionsResult);

        return inboundEdiOptionsResult;
    }

    private Humidifier.B2BI.PartnershipTypes.InboundEdiOptions CreateInboundEdiOptions()
    {
        var inboundEdiOptionsResult = new Humidifier.B2BI.PartnershipTypes.InboundEdiOptions();

        return inboundEdiOptionsResult;
    }
    public override void CreateChildren(Humidifier.B2BI.PartnershipTypes.InboundEdiOptions result)
    {
        base.CreateChildren(result);

        result.X12 ??= X12Factory?.Build();
    }

} // End Of Class

public static class InnerPartnershipInboundEdiOptionsFactoryExtensions
{
    public static CombinedResult<InnerPartnershipInboundEdiOptionsFactory, InnerPartnershipX12InboundEdiOptionsFactory> WithX12(this InnerPartnershipInboundEdiOptionsFactory parentFactory, Action<Humidifier.B2BI.PartnershipTypes.X12InboundEdiOptions> subFactoryAction = null)
    {
        parentFactory.X12Factory = new InnerPartnershipX12InboundEdiOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.X12Factory);
    }

    public static CombinedResult<InnerPartnershipInboundEdiOptionsFactory, T1, InnerPartnershipX12InboundEdiOptionsFactory> WithX12<T1>(this CombinedResult<InnerPartnershipInboundEdiOptionsFactory, T1> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.X12InboundEdiOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithX12(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPartnershipInboundEdiOptionsFactory, InnerPartnershipX12InboundEdiOptionsFactory> WithX12<T1>(this CombinedResult<T1, InnerPartnershipInboundEdiOptionsFactory> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.X12InboundEdiOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithX12(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerPartnershipInboundEdiOptionsFactory, T1, T2, InnerPartnershipX12InboundEdiOptionsFactory> WithX12<T1, T2>(this CombinedResult<InnerPartnershipInboundEdiOptionsFactory, T1, T2> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.X12InboundEdiOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithX12(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPartnershipInboundEdiOptionsFactory, T2, InnerPartnershipX12InboundEdiOptionsFactory> WithX12<T1, T2>(this CombinedResult<T1, InnerPartnershipInboundEdiOptionsFactory, T2> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.X12InboundEdiOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithX12(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerPartnershipInboundEdiOptionsFactory, InnerPartnershipX12InboundEdiOptionsFactory> WithX12<T1, T2>(this CombinedResult<T1, T2, InnerPartnershipInboundEdiOptionsFactory> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.X12InboundEdiOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithX12(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerPartnershipInboundEdiOptionsFactory, T1, T2, T3, InnerPartnershipX12InboundEdiOptionsFactory> WithX12<T1, T2, T3>(this CombinedResult<InnerPartnershipInboundEdiOptionsFactory, T1, T2, T3> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.X12InboundEdiOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithX12(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPartnershipInboundEdiOptionsFactory, T2, T3, InnerPartnershipX12InboundEdiOptionsFactory> WithX12<T1, T2, T3>(this CombinedResult<T1, InnerPartnershipInboundEdiOptionsFactory, T2, T3> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.X12InboundEdiOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithX12(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerPartnershipInboundEdiOptionsFactory, T3, InnerPartnershipX12InboundEdiOptionsFactory> WithX12<T1, T2, T3>(this CombinedResult<T1, T2, InnerPartnershipInboundEdiOptionsFactory, T3> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.X12InboundEdiOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithX12(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerPartnershipInboundEdiOptionsFactory, InnerPartnershipX12InboundEdiOptionsFactory> WithX12<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerPartnershipInboundEdiOptionsFactory> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.X12InboundEdiOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithX12(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerPartnershipInboundEdiOptionsFactory, T1, T2, T3, T4, InnerPartnershipX12InboundEdiOptionsFactory> WithX12<T1, T2, T3, T4>(this CombinedResult<InnerPartnershipInboundEdiOptionsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.X12InboundEdiOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithX12(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPartnershipInboundEdiOptionsFactory, T2, T3, T4, InnerPartnershipX12InboundEdiOptionsFactory> WithX12<T1, T2, T3, T4>(this CombinedResult<T1, InnerPartnershipInboundEdiOptionsFactory, T2, T3, T4> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.X12InboundEdiOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithX12(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerPartnershipInboundEdiOptionsFactory, T3, T4, InnerPartnershipX12InboundEdiOptionsFactory> WithX12<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerPartnershipInboundEdiOptionsFactory, T3, T4> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.X12InboundEdiOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithX12(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerPartnershipInboundEdiOptionsFactory, T4, InnerPartnershipX12InboundEdiOptionsFactory> WithX12<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerPartnershipInboundEdiOptionsFactory, T4> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.X12InboundEdiOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithX12(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerPartnershipInboundEdiOptionsFactory, InnerPartnershipX12InboundEdiOptionsFactory> WithX12<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerPartnershipInboundEdiOptionsFactory> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.X12InboundEdiOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithX12(combinedResult.T5, subFactoryAction).T2);
}
