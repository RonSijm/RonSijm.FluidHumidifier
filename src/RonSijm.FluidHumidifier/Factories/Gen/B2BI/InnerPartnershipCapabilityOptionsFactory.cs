// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.B2BI;

public class InnerPartnershipCapabilityOptionsFactory(Action<Humidifier.B2BI.PartnershipTypes.CapabilityOptions> factoryAction = null) : SubResourceFactory<Humidifier.B2BI.PartnershipTypes.CapabilityOptions>
{

    internal InnerPartnershipOutboundEdiOptionsFactory OutboundEdiFactory { get; set; }

    protected override Humidifier.B2BI.PartnershipTypes.CapabilityOptions Create()
    {
        var capabilityOptionsResult = CreateCapabilityOptions();
        factoryAction?.Invoke(capabilityOptionsResult);

        return capabilityOptionsResult;
    }

    private Humidifier.B2BI.PartnershipTypes.CapabilityOptions CreateCapabilityOptions()
    {
        var capabilityOptionsResult = new Humidifier.B2BI.PartnershipTypes.CapabilityOptions();

        return capabilityOptionsResult;
    }
    public override void CreateChildren(Humidifier.B2BI.PartnershipTypes.CapabilityOptions result)
    {
        base.CreateChildren(result);

        result.OutboundEdi ??= OutboundEdiFactory?.Build();
    }

} // End Of Class

public static class InnerPartnershipCapabilityOptionsFactoryExtensions
{
    public static CombinedResult<InnerPartnershipCapabilityOptionsFactory, InnerPartnershipOutboundEdiOptionsFactory> WithOutboundEdi(this InnerPartnershipCapabilityOptionsFactory parentFactory, Action<Humidifier.B2BI.PartnershipTypes.OutboundEdiOptions> subFactoryAction = null)
    {
        parentFactory.OutboundEdiFactory = new InnerPartnershipOutboundEdiOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OutboundEdiFactory);
    }

    public static CombinedResult<InnerPartnershipCapabilityOptionsFactory, T1, InnerPartnershipOutboundEdiOptionsFactory> WithOutboundEdi<T1>(this CombinedResult<InnerPartnershipCapabilityOptionsFactory, T1> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.OutboundEdiOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithOutboundEdi(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPartnershipCapabilityOptionsFactory, InnerPartnershipOutboundEdiOptionsFactory> WithOutboundEdi<T1>(this CombinedResult<T1, InnerPartnershipCapabilityOptionsFactory> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.OutboundEdiOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithOutboundEdi(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerPartnershipCapabilityOptionsFactory, T1, T2, InnerPartnershipOutboundEdiOptionsFactory> WithOutboundEdi<T1, T2>(this CombinedResult<InnerPartnershipCapabilityOptionsFactory, T1, T2> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.OutboundEdiOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOutboundEdi(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPartnershipCapabilityOptionsFactory, T2, InnerPartnershipOutboundEdiOptionsFactory> WithOutboundEdi<T1, T2>(this CombinedResult<T1, InnerPartnershipCapabilityOptionsFactory, T2> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.OutboundEdiOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOutboundEdi(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPartnershipCapabilityOptionsFactory, InnerPartnershipOutboundEdiOptionsFactory> WithOutboundEdi<T1, T2>(this CombinedResult<T1, T2, InnerPartnershipCapabilityOptionsFactory> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.OutboundEdiOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOutboundEdi(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerPartnershipCapabilityOptionsFactory, T1, T2, T3, InnerPartnershipOutboundEdiOptionsFactory> WithOutboundEdi<T1, T2, T3>(this CombinedResult<InnerPartnershipCapabilityOptionsFactory, T1, T2, T3> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.OutboundEdiOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOutboundEdi(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPartnershipCapabilityOptionsFactory, T2, T3, InnerPartnershipOutboundEdiOptionsFactory> WithOutboundEdi<T1, T2, T3>(this CombinedResult<T1, InnerPartnershipCapabilityOptionsFactory, T2, T3> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.OutboundEdiOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOutboundEdi(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPartnershipCapabilityOptionsFactory, T3, InnerPartnershipOutboundEdiOptionsFactory> WithOutboundEdi<T1, T2, T3>(this CombinedResult<T1, T2, InnerPartnershipCapabilityOptionsFactory, T3> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.OutboundEdiOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOutboundEdi(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPartnershipCapabilityOptionsFactory, InnerPartnershipOutboundEdiOptionsFactory> WithOutboundEdi<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerPartnershipCapabilityOptionsFactory> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.OutboundEdiOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOutboundEdi(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerPartnershipCapabilityOptionsFactory, T1, T2, T3, T4, InnerPartnershipOutboundEdiOptionsFactory> WithOutboundEdi<T1, T2, T3, T4>(this CombinedResult<InnerPartnershipCapabilityOptionsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.OutboundEdiOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutboundEdi(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPartnershipCapabilityOptionsFactory, T2, T3, T4, InnerPartnershipOutboundEdiOptionsFactory> WithOutboundEdi<T1, T2, T3, T4>(this CombinedResult<T1, InnerPartnershipCapabilityOptionsFactory, T2, T3, T4> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.OutboundEdiOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutboundEdi(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPartnershipCapabilityOptionsFactory, T3, T4, InnerPartnershipOutboundEdiOptionsFactory> WithOutboundEdi<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerPartnershipCapabilityOptionsFactory, T3, T4> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.OutboundEdiOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutboundEdi(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPartnershipCapabilityOptionsFactory, T4, InnerPartnershipOutboundEdiOptionsFactory> WithOutboundEdi<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerPartnershipCapabilityOptionsFactory, T4> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.OutboundEdiOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutboundEdi(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerPartnershipCapabilityOptionsFactory, InnerPartnershipOutboundEdiOptionsFactory> WithOutboundEdi<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerPartnershipCapabilityOptionsFactory> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.OutboundEdiOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutboundEdi(combinedResult.T5, subFactoryAction));
}
