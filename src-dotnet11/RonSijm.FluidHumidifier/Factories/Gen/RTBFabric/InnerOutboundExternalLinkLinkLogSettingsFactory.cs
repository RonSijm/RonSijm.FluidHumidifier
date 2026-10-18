// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RTBFabric;

public class InnerOutboundExternalLinkLinkLogSettingsFactory(Action<Humidifier.RTBFabric.OutboundExternalLinkTypes.LinkLogSettings> factoryAction = null) : SubResourceFactory<Humidifier.RTBFabric.OutboundExternalLinkTypes.LinkLogSettings>
{

    internal InnerOutboundExternalLinkApplicationLogsFactory ApplicationLogsFactory { get; set; }

    protected override Humidifier.RTBFabric.OutboundExternalLinkTypes.LinkLogSettings Create()
    {
        var linkLogSettingsResult = CreateLinkLogSettings();
        factoryAction?.Invoke(linkLogSettingsResult);

        return linkLogSettingsResult;
    }

    private Humidifier.RTBFabric.OutboundExternalLinkTypes.LinkLogSettings CreateLinkLogSettings()
    {
        var linkLogSettingsResult = new Humidifier.RTBFabric.OutboundExternalLinkTypes.LinkLogSettings();

        return linkLogSettingsResult;
    }
    public override void CreateChildren(Humidifier.RTBFabric.OutboundExternalLinkTypes.LinkLogSettings result)
    {
        base.CreateChildren(result);

        result.ApplicationLogs ??= ApplicationLogsFactory?.Build();
    }

} // End Of Class

public static class InnerOutboundExternalLinkLinkLogSettingsFactoryExtensions
{
    public static CombinedResult<InnerOutboundExternalLinkLinkLogSettingsFactory, InnerOutboundExternalLinkApplicationLogsFactory> WithApplicationLogs(this InnerOutboundExternalLinkLinkLogSettingsFactory parentFactory, Action<Humidifier.RTBFabric.OutboundExternalLinkTypes.ApplicationLogs> subFactoryAction = null)
    {
        parentFactory.ApplicationLogsFactory = new InnerOutboundExternalLinkApplicationLogsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ApplicationLogsFactory);
    }

    public static CombinedResult<InnerOutboundExternalLinkLinkLogSettingsFactory, T1, InnerOutboundExternalLinkApplicationLogsFactory> WithApplicationLogs<T1>(this CombinedResult<InnerOutboundExternalLinkLinkLogSettingsFactory, T1> combinedResult, Action<Humidifier.RTBFabric.OutboundExternalLinkTypes.ApplicationLogs> subFactoryAction = null) => new (combinedResult, combinedResult, WithApplicationLogs(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOutboundExternalLinkLinkLogSettingsFactory, InnerOutboundExternalLinkApplicationLogsFactory> WithApplicationLogs<T1>(this CombinedResult<T1, InnerOutboundExternalLinkLinkLogSettingsFactory> combinedResult, Action<Humidifier.RTBFabric.OutboundExternalLinkTypes.ApplicationLogs> subFactoryAction = null) => new (combinedResult, combinedResult, WithApplicationLogs(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerOutboundExternalLinkLinkLogSettingsFactory, T1, T2, InnerOutboundExternalLinkApplicationLogsFactory> WithApplicationLogs<T1, T2>(this CombinedResult<InnerOutboundExternalLinkLinkLogSettingsFactory, T1, T2> combinedResult, Action<Humidifier.RTBFabric.OutboundExternalLinkTypes.ApplicationLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApplicationLogs(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOutboundExternalLinkLinkLogSettingsFactory, T2, InnerOutboundExternalLinkApplicationLogsFactory> WithApplicationLogs<T1, T2>(this CombinedResult<T1, InnerOutboundExternalLinkLinkLogSettingsFactory, T2> combinedResult, Action<Humidifier.RTBFabric.OutboundExternalLinkTypes.ApplicationLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApplicationLogs(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOutboundExternalLinkLinkLogSettingsFactory, InnerOutboundExternalLinkApplicationLogsFactory> WithApplicationLogs<T1, T2>(this CombinedResult<T1, T2, InnerOutboundExternalLinkLinkLogSettingsFactory> combinedResult, Action<Humidifier.RTBFabric.OutboundExternalLinkTypes.ApplicationLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApplicationLogs(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerOutboundExternalLinkLinkLogSettingsFactory, T1, T2, T3, InnerOutboundExternalLinkApplicationLogsFactory> WithApplicationLogs<T1, T2, T3>(this CombinedResult<InnerOutboundExternalLinkLinkLogSettingsFactory, T1, T2, T3> combinedResult, Action<Humidifier.RTBFabric.OutboundExternalLinkTypes.ApplicationLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationLogs(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOutboundExternalLinkLinkLogSettingsFactory, T2, T3, InnerOutboundExternalLinkApplicationLogsFactory> WithApplicationLogs<T1, T2, T3>(this CombinedResult<T1, InnerOutboundExternalLinkLinkLogSettingsFactory, T2, T3> combinedResult, Action<Humidifier.RTBFabric.OutboundExternalLinkTypes.ApplicationLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationLogs(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOutboundExternalLinkLinkLogSettingsFactory, T3, InnerOutboundExternalLinkApplicationLogsFactory> WithApplicationLogs<T1, T2, T3>(this CombinedResult<T1, T2, InnerOutboundExternalLinkLinkLogSettingsFactory, T3> combinedResult, Action<Humidifier.RTBFabric.OutboundExternalLinkTypes.ApplicationLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationLogs(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerOutboundExternalLinkLinkLogSettingsFactory, InnerOutboundExternalLinkApplicationLogsFactory> WithApplicationLogs<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerOutboundExternalLinkLinkLogSettingsFactory> combinedResult, Action<Humidifier.RTBFabric.OutboundExternalLinkTypes.ApplicationLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationLogs(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerOutboundExternalLinkLinkLogSettingsFactory, T1, T2, T3, T4, InnerOutboundExternalLinkApplicationLogsFactory> WithApplicationLogs<T1, T2, T3, T4>(this CombinedResult<InnerOutboundExternalLinkLinkLogSettingsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.RTBFabric.OutboundExternalLinkTypes.ApplicationLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationLogs(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOutboundExternalLinkLinkLogSettingsFactory, T2, T3, T4, InnerOutboundExternalLinkApplicationLogsFactory> WithApplicationLogs<T1, T2, T3, T4>(this CombinedResult<T1, InnerOutboundExternalLinkLinkLogSettingsFactory, T2, T3, T4> combinedResult, Action<Humidifier.RTBFabric.OutboundExternalLinkTypes.ApplicationLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationLogs(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOutboundExternalLinkLinkLogSettingsFactory, T3, T4, InnerOutboundExternalLinkApplicationLogsFactory> WithApplicationLogs<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerOutboundExternalLinkLinkLogSettingsFactory, T3, T4> combinedResult, Action<Humidifier.RTBFabric.OutboundExternalLinkTypes.ApplicationLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationLogs(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerOutboundExternalLinkLinkLogSettingsFactory, T4, InnerOutboundExternalLinkApplicationLogsFactory> WithApplicationLogs<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerOutboundExternalLinkLinkLogSettingsFactory, T4> combinedResult, Action<Humidifier.RTBFabric.OutboundExternalLinkTypes.ApplicationLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationLogs(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerOutboundExternalLinkLinkLogSettingsFactory, InnerOutboundExternalLinkApplicationLogsFactory> WithApplicationLogs<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerOutboundExternalLinkLinkLogSettingsFactory> combinedResult, Action<Humidifier.RTBFabric.OutboundExternalLinkTypes.ApplicationLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationLogs(combinedResult.T5, subFactoryAction).T2);
}
