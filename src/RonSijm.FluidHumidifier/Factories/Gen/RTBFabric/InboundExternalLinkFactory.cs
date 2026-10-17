// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RTBFabric;

public class InboundExternalLinkFactory(string resourceName = null, Action<Humidifier.RTBFabric.InboundExternalLink> factoryAction = null) : ResourceFactory<Humidifier.RTBFabric.InboundExternalLink>(resourceName)
{

    internal InnerInboundExternalLinkLinkAttributesFactory LinkAttributesFactory { get; set; }

    internal InnerInboundExternalLinkLinkLogSettingsFactory LinkLogSettingsFactory { get; set; }

    protected override Humidifier.RTBFabric.InboundExternalLink Create()
    {
        var inboundExternalLinkResult = CreateInboundExternalLink();
        factoryAction?.Invoke(inboundExternalLinkResult);

        return inboundExternalLinkResult;
    }

    private Humidifier.RTBFabric.InboundExternalLink CreateInboundExternalLink()
    {
        var inboundExternalLinkResult = new Humidifier.RTBFabric.InboundExternalLink
        {
            GivenName = InputResourceName,
        };

        return inboundExternalLinkResult;
    }
    public override void CreateChildren(Humidifier.RTBFabric.InboundExternalLink result)
    {
        base.CreateChildren(result);

        result.LinkAttributes ??= LinkAttributesFactory?.Build();
        result.LinkLogSettings ??= LinkLogSettingsFactory?.Build();
    }

} // End Of Class

public static class InboundExternalLinkFactoryExtensions
{
    public static CombinedResult<InboundExternalLinkFactory, InnerInboundExternalLinkLinkAttributesFactory> WithLinkAttributes(this InboundExternalLinkFactory parentFactory, Action<Humidifier.RTBFabric.InboundExternalLinkTypes.LinkAttributes> subFactoryAction = null)
    {
        parentFactory.LinkAttributesFactory = new InnerInboundExternalLinkLinkAttributesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LinkAttributesFactory);
    }

    public static CombinedResult<InboundExternalLinkFactory, InnerInboundExternalLinkLinkLogSettingsFactory> WithLinkLogSettings(this InboundExternalLinkFactory parentFactory, Action<Humidifier.RTBFabric.InboundExternalLinkTypes.LinkLogSettings> subFactoryAction = null)
    {
        parentFactory.LinkLogSettingsFactory = new InnerInboundExternalLinkLinkLogSettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LinkLogSettingsFactory);
    }

    public static CombinedResult<InboundExternalLinkFactory, T1, InnerInboundExternalLinkLinkAttributesFactory> WithLinkAttributes<T1>(this CombinedResult<InboundExternalLinkFactory, T1> combinedResult, Action<Humidifier.RTBFabric.InboundExternalLinkTypes.LinkAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, WithLinkAttributes(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InboundExternalLinkFactory, InnerInboundExternalLinkLinkAttributesFactory> WithLinkAttributes<T1>(this CombinedResult<T1, InboundExternalLinkFactory> combinedResult, Action<Humidifier.RTBFabric.InboundExternalLinkTypes.LinkAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, WithLinkAttributes(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InboundExternalLinkFactory, T1, T2, InnerInboundExternalLinkLinkAttributesFactory> WithLinkAttributes<T1, T2>(this CombinedResult<InboundExternalLinkFactory, T1, T2> combinedResult, Action<Humidifier.RTBFabric.InboundExternalLinkTypes.LinkAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLinkAttributes(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InboundExternalLinkFactory, T2, InnerInboundExternalLinkLinkAttributesFactory> WithLinkAttributes<T1, T2>(this CombinedResult<T1, InboundExternalLinkFactory, T2> combinedResult, Action<Humidifier.RTBFabric.InboundExternalLinkTypes.LinkAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLinkAttributes(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InboundExternalLinkFactory, InnerInboundExternalLinkLinkAttributesFactory> WithLinkAttributes<T1, T2>(this CombinedResult<T1, T2, InboundExternalLinkFactory> combinedResult, Action<Humidifier.RTBFabric.InboundExternalLinkTypes.LinkAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLinkAttributes(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InboundExternalLinkFactory, T1, T2, T3, InnerInboundExternalLinkLinkAttributesFactory> WithLinkAttributes<T1, T2, T3>(this CombinedResult<InboundExternalLinkFactory, T1, T2, T3> combinedResult, Action<Humidifier.RTBFabric.InboundExternalLinkTypes.LinkAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLinkAttributes(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InboundExternalLinkFactory, T2, T3, InnerInboundExternalLinkLinkAttributesFactory> WithLinkAttributes<T1, T2, T3>(this CombinedResult<T1, InboundExternalLinkFactory, T2, T3> combinedResult, Action<Humidifier.RTBFabric.InboundExternalLinkTypes.LinkAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLinkAttributes(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InboundExternalLinkFactory, T3, InnerInboundExternalLinkLinkAttributesFactory> WithLinkAttributes<T1, T2, T3>(this CombinedResult<T1, T2, InboundExternalLinkFactory, T3> combinedResult, Action<Humidifier.RTBFabric.InboundExternalLinkTypes.LinkAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLinkAttributes(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InboundExternalLinkFactory, InnerInboundExternalLinkLinkAttributesFactory> WithLinkAttributes<T1, T2, T3>(this CombinedResult<T1, T2, T3, InboundExternalLinkFactory> combinedResult, Action<Humidifier.RTBFabric.InboundExternalLinkTypes.LinkAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLinkAttributes(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InboundExternalLinkFactory, T1, T2, T3, T4, InnerInboundExternalLinkLinkAttributesFactory> WithLinkAttributes<T1, T2, T3, T4>(this CombinedResult<InboundExternalLinkFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.RTBFabric.InboundExternalLinkTypes.LinkAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLinkAttributes(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InboundExternalLinkFactory, T2, T3, T4, InnerInboundExternalLinkLinkAttributesFactory> WithLinkAttributes<T1, T2, T3, T4>(this CombinedResult<T1, InboundExternalLinkFactory, T2, T3, T4> combinedResult, Action<Humidifier.RTBFabric.InboundExternalLinkTypes.LinkAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLinkAttributes(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InboundExternalLinkFactory, T3, T4, InnerInboundExternalLinkLinkAttributesFactory> WithLinkAttributes<T1, T2, T3, T4>(this CombinedResult<T1, T2, InboundExternalLinkFactory, T3, T4> combinedResult, Action<Humidifier.RTBFabric.InboundExternalLinkTypes.LinkAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLinkAttributes(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InboundExternalLinkFactory, T4, InnerInboundExternalLinkLinkAttributesFactory> WithLinkAttributes<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InboundExternalLinkFactory, T4> combinedResult, Action<Humidifier.RTBFabric.InboundExternalLinkTypes.LinkAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLinkAttributes(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InboundExternalLinkFactory, InnerInboundExternalLinkLinkAttributesFactory> WithLinkAttributes<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InboundExternalLinkFactory> combinedResult, Action<Humidifier.RTBFabric.InboundExternalLinkTypes.LinkAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLinkAttributes(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<InboundExternalLinkFactory, T1, InnerInboundExternalLinkLinkLogSettingsFactory> WithLinkLogSettings<T1>(this CombinedResult<InboundExternalLinkFactory, T1> combinedResult, Action<Humidifier.RTBFabric.InboundExternalLinkTypes.LinkLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithLinkLogSettings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InboundExternalLinkFactory, InnerInboundExternalLinkLinkLogSettingsFactory> WithLinkLogSettings<T1>(this CombinedResult<T1, InboundExternalLinkFactory> combinedResult, Action<Humidifier.RTBFabric.InboundExternalLinkTypes.LinkLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithLinkLogSettings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InboundExternalLinkFactory, T1, T2, InnerInboundExternalLinkLinkLogSettingsFactory> WithLinkLogSettings<T1, T2>(this CombinedResult<InboundExternalLinkFactory, T1, T2> combinedResult, Action<Humidifier.RTBFabric.InboundExternalLinkTypes.LinkLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLinkLogSettings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InboundExternalLinkFactory, T2, InnerInboundExternalLinkLinkLogSettingsFactory> WithLinkLogSettings<T1, T2>(this CombinedResult<T1, InboundExternalLinkFactory, T2> combinedResult, Action<Humidifier.RTBFabric.InboundExternalLinkTypes.LinkLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLinkLogSettings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InboundExternalLinkFactory, InnerInboundExternalLinkLinkLogSettingsFactory> WithLinkLogSettings<T1, T2>(this CombinedResult<T1, T2, InboundExternalLinkFactory> combinedResult, Action<Humidifier.RTBFabric.InboundExternalLinkTypes.LinkLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLinkLogSettings(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InboundExternalLinkFactory, T1, T2, T3, InnerInboundExternalLinkLinkLogSettingsFactory> WithLinkLogSettings<T1, T2, T3>(this CombinedResult<InboundExternalLinkFactory, T1, T2, T3> combinedResult, Action<Humidifier.RTBFabric.InboundExternalLinkTypes.LinkLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLinkLogSettings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InboundExternalLinkFactory, T2, T3, InnerInboundExternalLinkLinkLogSettingsFactory> WithLinkLogSettings<T1, T2, T3>(this CombinedResult<T1, InboundExternalLinkFactory, T2, T3> combinedResult, Action<Humidifier.RTBFabric.InboundExternalLinkTypes.LinkLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLinkLogSettings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InboundExternalLinkFactory, T3, InnerInboundExternalLinkLinkLogSettingsFactory> WithLinkLogSettings<T1, T2, T3>(this CombinedResult<T1, T2, InboundExternalLinkFactory, T3> combinedResult, Action<Humidifier.RTBFabric.InboundExternalLinkTypes.LinkLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLinkLogSettings(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InboundExternalLinkFactory, InnerInboundExternalLinkLinkLogSettingsFactory> WithLinkLogSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, InboundExternalLinkFactory> combinedResult, Action<Humidifier.RTBFabric.InboundExternalLinkTypes.LinkLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLinkLogSettings(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InboundExternalLinkFactory, T1, T2, T3, T4, InnerInboundExternalLinkLinkLogSettingsFactory> WithLinkLogSettings<T1, T2, T3, T4>(this CombinedResult<InboundExternalLinkFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.RTBFabric.InboundExternalLinkTypes.LinkLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLinkLogSettings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InboundExternalLinkFactory, T2, T3, T4, InnerInboundExternalLinkLinkLogSettingsFactory> WithLinkLogSettings<T1, T2, T3, T4>(this CombinedResult<T1, InboundExternalLinkFactory, T2, T3, T4> combinedResult, Action<Humidifier.RTBFabric.InboundExternalLinkTypes.LinkLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLinkLogSettings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InboundExternalLinkFactory, T3, T4, InnerInboundExternalLinkLinkLogSettingsFactory> WithLinkLogSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, InboundExternalLinkFactory, T3, T4> combinedResult, Action<Humidifier.RTBFabric.InboundExternalLinkTypes.LinkLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLinkLogSettings(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InboundExternalLinkFactory, T4, InnerInboundExternalLinkLinkLogSettingsFactory> WithLinkLogSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InboundExternalLinkFactory, T4> combinedResult, Action<Humidifier.RTBFabric.InboundExternalLinkTypes.LinkLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLinkLogSettings(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InboundExternalLinkFactory, InnerInboundExternalLinkLinkLogSettingsFactory> WithLinkLogSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InboundExternalLinkFactory> combinedResult, Action<Humidifier.RTBFabric.InboundExternalLinkTypes.LinkLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLinkLogSettings(combinedResult.T5, subFactoryAction).T2);
}
