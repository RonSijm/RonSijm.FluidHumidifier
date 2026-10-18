// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RTBFabric;

public class OutboundExternalLinkFactory(string resourceName = null, Action<Humidifier.RTBFabric.OutboundExternalLink> factoryAction = null) : ResourceFactory<Humidifier.RTBFabric.OutboundExternalLink>(resourceName)
{

    internal InnerOutboundExternalLinkLinkAttributesFactory LinkAttributesFactory { get; set; }

    internal InnerOutboundExternalLinkLinkLogSettingsFactory LinkLogSettingsFactory { get; set; }

    protected override Humidifier.RTBFabric.OutboundExternalLink Create()
    {
        var outboundExternalLinkResult = CreateOutboundExternalLink();
        factoryAction?.Invoke(outboundExternalLinkResult);

        return outboundExternalLinkResult;
    }

    private Humidifier.RTBFabric.OutboundExternalLink CreateOutboundExternalLink()
    {
        var outboundExternalLinkResult = new Humidifier.RTBFabric.OutboundExternalLink
        {
            GivenName = InputResourceName,
        };

        return outboundExternalLinkResult;
    }
    public override void CreateChildren(Humidifier.RTBFabric.OutboundExternalLink result)
    {
        base.CreateChildren(result);

        result.LinkAttributes ??= LinkAttributesFactory?.Build();
        result.LinkLogSettings ??= LinkLogSettingsFactory?.Build();
    }

} // End Of Class

public static class OutboundExternalLinkFactoryExtensions
{
    public static CombinedResult<OutboundExternalLinkFactory, InnerOutboundExternalLinkLinkAttributesFactory> WithLinkAttributes(this OutboundExternalLinkFactory parentFactory, Action<Humidifier.RTBFabric.OutboundExternalLinkTypes.LinkAttributes> subFactoryAction = null)
    {
        parentFactory.LinkAttributesFactory = new InnerOutboundExternalLinkLinkAttributesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LinkAttributesFactory);
    }

    public static CombinedResult<OutboundExternalLinkFactory, InnerOutboundExternalLinkLinkLogSettingsFactory> WithLinkLogSettings(this OutboundExternalLinkFactory parentFactory, Action<Humidifier.RTBFabric.OutboundExternalLinkTypes.LinkLogSettings> subFactoryAction = null)
    {
        parentFactory.LinkLogSettingsFactory = new InnerOutboundExternalLinkLinkLogSettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LinkLogSettingsFactory);
    }

    public static CombinedResult<OutboundExternalLinkFactory, T1, InnerOutboundExternalLinkLinkAttributesFactory> WithLinkAttributes<T1>(this CombinedResult<OutboundExternalLinkFactory, T1> combinedResult, Action<Humidifier.RTBFabric.OutboundExternalLinkTypes.LinkAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, WithLinkAttributes(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, OutboundExternalLinkFactory, InnerOutboundExternalLinkLinkAttributesFactory> WithLinkAttributes<T1>(this CombinedResult<T1, OutboundExternalLinkFactory> combinedResult, Action<Humidifier.RTBFabric.OutboundExternalLinkTypes.LinkAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, WithLinkAttributes(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<OutboundExternalLinkFactory, T1, T2, InnerOutboundExternalLinkLinkAttributesFactory> WithLinkAttributes<T1, T2>(this CombinedResult<OutboundExternalLinkFactory, T1, T2> combinedResult, Action<Humidifier.RTBFabric.OutboundExternalLinkTypes.LinkAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLinkAttributes(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, OutboundExternalLinkFactory, T2, InnerOutboundExternalLinkLinkAttributesFactory> WithLinkAttributes<T1, T2>(this CombinedResult<T1, OutboundExternalLinkFactory, T2> combinedResult, Action<Humidifier.RTBFabric.OutboundExternalLinkTypes.LinkAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLinkAttributes(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, OutboundExternalLinkFactory, InnerOutboundExternalLinkLinkAttributesFactory> WithLinkAttributes<T1, T2>(this CombinedResult<T1, T2, OutboundExternalLinkFactory> combinedResult, Action<Humidifier.RTBFabric.OutboundExternalLinkTypes.LinkAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLinkAttributes(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<OutboundExternalLinkFactory, T1, T2, T3, InnerOutboundExternalLinkLinkAttributesFactory> WithLinkAttributes<T1, T2, T3>(this CombinedResult<OutboundExternalLinkFactory, T1, T2, T3> combinedResult, Action<Humidifier.RTBFabric.OutboundExternalLinkTypes.LinkAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLinkAttributes(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, OutboundExternalLinkFactory, T2, T3, InnerOutboundExternalLinkLinkAttributesFactory> WithLinkAttributes<T1, T2, T3>(this CombinedResult<T1, OutboundExternalLinkFactory, T2, T3> combinedResult, Action<Humidifier.RTBFabric.OutboundExternalLinkTypes.LinkAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLinkAttributes(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, OutboundExternalLinkFactory, T3, InnerOutboundExternalLinkLinkAttributesFactory> WithLinkAttributes<T1, T2, T3>(this CombinedResult<T1, T2, OutboundExternalLinkFactory, T3> combinedResult, Action<Humidifier.RTBFabric.OutboundExternalLinkTypes.LinkAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLinkAttributes(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, OutboundExternalLinkFactory, InnerOutboundExternalLinkLinkAttributesFactory> WithLinkAttributes<T1, T2, T3>(this CombinedResult<T1, T2, T3, OutboundExternalLinkFactory> combinedResult, Action<Humidifier.RTBFabric.OutboundExternalLinkTypes.LinkAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLinkAttributes(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<OutboundExternalLinkFactory, T1, T2, T3, T4, InnerOutboundExternalLinkLinkAttributesFactory> WithLinkAttributes<T1, T2, T3, T4>(this CombinedResult<OutboundExternalLinkFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.RTBFabric.OutboundExternalLinkTypes.LinkAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLinkAttributes(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, OutboundExternalLinkFactory, T2, T3, T4, InnerOutboundExternalLinkLinkAttributesFactory> WithLinkAttributes<T1, T2, T3, T4>(this CombinedResult<T1, OutboundExternalLinkFactory, T2, T3, T4> combinedResult, Action<Humidifier.RTBFabric.OutboundExternalLinkTypes.LinkAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLinkAttributes(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, OutboundExternalLinkFactory, T3, T4, InnerOutboundExternalLinkLinkAttributesFactory> WithLinkAttributes<T1, T2, T3, T4>(this CombinedResult<T1, T2, OutboundExternalLinkFactory, T3, T4> combinedResult, Action<Humidifier.RTBFabric.OutboundExternalLinkTypes.LinkAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLinkAttributes(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, OutboundExternalLinkFactory, T4, InnerOutboundExternalLinkLinkAttributesFactory> WithLinkAttributes<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, OutboundExternalLinkFactory, T4> combinedResult, Action<Humidifier.RTBFabric.OutboundExternalLinkTypes.LinkAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLinkAttributes(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, OutboundExternalLinkFactory, InnerOutboundExternalLinkLinkAttributesFactory> WithLinkAttributes<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, OutboundExternalLinkFactory> combinedResult, Action<Humidifier.RTBFabric.OutboundExternalLinkTypes.LinkAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLinkAttributes(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<OutboundExternalLinkFactory, T1, InnerOutboundExternalLinkLinkLogSettingsFactory> WithLinkLogSettings<T1>(this CombinedResult<OutboundExternalLinkFactory, T1> combinedResult, Action<Humidifier.RTBFabric.OutboundExternalLinkTypes.LinkLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithLinkLogSettings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, OutboundExternalLinkFactory, InnerOutboundExternalLinkLinkLogSettingsFactory> WithLinkLogSettings<T1>(this CombinedResult<T1, OutboundExternalLinkFactory> combinedResult, Action<Humidifier.RTBFabric.OutboundExternalLinkTypes.LinkLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithLinkLogSettings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<OutboundExternalLinkFactory, T1, T2, InnerOutboundExternalLinkLinkLogSettingsFactory> WithLinkLogSettings<T1, T2>(this CombinedResult<OutboundExternalLinkFactory, T1, T2> combinedResult, Action<Humidifier.RTBFabric.OutboundExternalLinkTypes.LinkLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLinkLogSettings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, OutboundExternalLinkFactory, T2, InnerOutboundExternalLinkLinkLogSettingsFactory> WithLinkLogSettings<T1, T2>(this CombinedResult<T1, OutboundExternalLinkFactory, T2> combinedResult, Action<Humidifier.RTBFabric.OutboundExternalLinkTypes.LinkLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLinkLogSettings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, OutboundExternalLinkFactory, InnerOutboundExternalLinkLinkLogSettingsFactory> WithLinkLogSettings<T1, T2>(this CombinedResult<T1, T2, OutboundExternalLinkFactory> combinedResult, Action<Humidifier.RTBFabric.OutboundExternalLinkTypes.LinkLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLinkLogSettings(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<OutboundExternalLinkFactory, T1, T2, T3, InnerOutboundExternalLinkLinkLogSettingsFactory> WithLinkLogSettings<T1, T2, T3>(this CombinedResult<OutboundExternalLinkFactory, T1, T2, T3> combinedResult, Action<Humidifier.RTBFabric.OutboundExternalLinkTypes.LinkLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLinkLogSettings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, OutboundExternalLinkFactory, T2, T3, InnerOutboundExternalLinkLinkLogSettingsFactory> WithLinkLogSettings<T1, T2, T3>(this CombinedResult<T1, OutboundExternalLinkFactory, T2, T3> combinedResult, Action<Humidifier.RTBFabric.OutboundExternalLinkTypes.LinkLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLinkLogSettings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, OutboundExternalLinkFactory, T3, InnerOutboundExternalLinkLinkLogSettingsFactory> WithLinkLogSettings<T1, T2, T3>(this CombinedResult<T1, T2, OutboundExternalLinkFactory, T3> combinedResult, Action<Humidifier.RTBFabric.OutboundExternalLinkTypes.LinkLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLinkLogSettings(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, OutboundExternalLinkFactory, InnerOutboundExternalLinkLinkLogSettingsFactory> WithLinkLogSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, OutboundExternalLinkFactory> combinedResult, Action<Humidifier.RTBFabric.OutboundExternalLinkTypes.LinkLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLinkLogSettings(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<OutboundExternalLinkFactory, T1, T2, T3, T4, InnerOutboundExternalLinkLinkLogSettingsFactory> WithLinkLogSettings<T1, T2, T3, T4>(this CombinedResult<OutboundExternalLinkFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.RTBFabric.OutboundExternalLinkTypes.LinkLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLinkLogSettings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, OutboundExternalLinkFactory, T2, T3, T4, InnerOutboundExternalLinkLinkLogSettingsFactory> WithLinkLogSettings<T1, T2, T3, T4>(this CombinedResult<T1, OutboundExternalLinkFactory, T2, T3, T4> combinedResult, Action<Humidifier.RTBFabric.OutboundExternalLinkTypes.LinkLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLinkLogSettings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, OutboundExternalLinkFactory, T3, T4, InnerOutboundExternalLinkLinkLogSettingsFactory> WithLinkLogSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, OutboundExternalLinkFactory, T3, T4> combinedResult, Action<Humidifier.RTBFabric.OutboundExternalLinkTypes.LinkLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLinkLogSettings(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, OutboundExternalLinkFactory, T4, InnerOutboundExternalLinkLinkLogSettingsFactory> WithLinkLogSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, OutboundExternalLinkFactory, T4> combinedResult, Action<Humidifier.RTBFabric.OutboundExternalLinkTypes.LinkLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLinkLogSettings(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, OutboundExternalLinkFactory, InnerOutboundExternalLinkLinkLogSettingsFactory> WithLinkLogSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, OutboundExternalLinkFactory> combinedResult, Action<Humidifier.RTBFabric.OutboundExternalLinkTypes.LinkLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLinkLogSettings(combinedResult.T5, subFactoryAction).T2);
}
