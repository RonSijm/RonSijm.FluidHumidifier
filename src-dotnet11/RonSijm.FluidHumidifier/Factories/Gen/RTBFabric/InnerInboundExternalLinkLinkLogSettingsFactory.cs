// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RTBFabric;

public class InnerInboundExternalLinkLinkLogSettingsFactory(Action<Humidifier.RTBFabric.InboundExternalLinkTypes.LinkLogSettings> factoryAction = null) : SubResourceFactory<Humidifier.RTBFabric.InboundExternalLinkTypes.LinkLogSettings>
{

    internal InnerInboundExternalLinkApplicationLogsFactory ApplicationLogsFactory { get; set; }

    protected override Humidifier.RTBFabric.InboundExternalLinkTypes.LinkLogSettings Create()
    {
        var linkLogSettingsResult = CreateLinkLogSettings();
        factoryAction?.Invoke(linkLogSettingsResult);

        return linkLogSettingsResult;
    }

    private Humidifier.RTBFabric.InboundExternalLinkTypes.LinkLogSettings CreateLinkLogSettings()
    {
        var linkLogSettingsResult = new Humidifier.RTBFabric.InboundExternalLinkTypes.LinkLogSettings();

        return linkLogSettingsResult;
    }
    public override void CreateChildren(Humidifier.RTBFabric.InboundExternalLinkTypes.LinkLogSettings result)
    {
        base.CreateChildren(result);

        result.ApplicationLogs ??= ApplicationLogsFactory?.Build();
    }

} // End Of Class

public static class InnerInboundExternalLinkLinkLogSettingsFactoryExtensions
{
    public static CombinedResult<InnerInboundExternalLinkLinkLogSettingsFactory, InnerInboundExternalLinkApplicationLogsFactory> WithApplicationLogs(this InnerInboundExternalLinkLinkLogSettingsFactory parentFactory, Action<Humidifier.RTBFabric.InboundExternalLinkTypes.ApplicationLogs> subFactoryAction = null)
    {
        parentFactory.ApplicationLogsFactory = new InnerInboundExternalLinkApplicationLogsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ApplicationLogsFactory);
    }

    public static CombinedResult<InnerInboundExternalLinkLinkLogSettingsFactory, T1, InnerInboundExternalLinkApplicationLogsFactory> WithApplicationLogs<T1>(this CombinedResult<InnerInboundExternalLinkLinkLogSettingsFactory, T1> combinedResult, Action<Humidifier.RTBFabric.InboundExternalLinkTypes.ApplicationLogs> subFactoryAction = null) => new (combinedResult, combinedResult, WithApplicationLogs(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerInboundExternalLinkLinkLogSettingsFactory, InnerInboundExternalLinkApplicationLogsFactory> WithApplicationLogs<T1>(this CombinedResult<T1, InnerInboundExternalLinkLinkLogSettingsFactory> combinedResult, Action<Humidifier.RTBFabric.InboundExternalLinkTypes.ApplicationLogs> subFactoryAction = null) => new (combinedResult, combinedResult, WithApplicationLogs(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerInboundExternalLinkLinkLogSettingsFactory, T1, T2, InnerInboundExternalLinkApplicationLogsFactory> WithApplicationLogs<T1, T2>(this CombinedResult<InnerInboundExternalLinkLinkLogSettingsFactory, T1, T2> combinedResult, Action<Humidifier.RTBFabric.InboundExternalLinkTypes.ApplicationLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApplicationLogs(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerInboundExternalLinkLinkLogSettingsFactory, T2, InnerInboundExternalLinkApplicationLogsFactory> WithApplicationLogs<T1, T2>(this CombinedResult<T1, InnerInboundExternalLinkLinkLogSettingsFactory, T2> combinedResult, Action<Humidifier.RTBFabric.InboundExternalLinkTypes.ApplicationLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApplicationLogs(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerInboundExternalLinkLinkLogSettingsFactory, InnerInboundExternalLinkApplicationLogsFactory> WithApplicationLogs<T1, T2>(this CombinedResult<T1, T2, InnerInboundExternalLinkLinkLogSettingsFactory> combinedResult, Action<Humidifier.RTBFabric.InboundExternalLinkTypes.ApplicationLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApplicationLogs(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerInboundExternalLinkLinkLogSettingsFactory, T1, T2, T3, InnerInboundExternalLinkApplicationLogsFactory> WithApplicationLogs<T1, T2, T3>(this CombinedResult<InnerInboundExternalLinkLinkLogSettingsFactory, T1, T2, T3> combinedResult, Action<Humidifier.RTBFabric.InboundExternalLinkTypes.ApplicationLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationLogs(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerInboundExternalLinkLinkLogSettingsFactory, T2, T3, InnerInboundExternalLinkApplicationLogsFactory> WithApplicationLogs<T1, T2, T3>(this CombinedResult<T1, InnerInboundExternalLinkLinkLogSettingsFactory, T2, T3> combinedResult, Action<Humidifier.RTBFabric.InboundExternalLinkTypes.ApplicationLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationLogs(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerInboundExternalLinkLinkLogSettingsFactory, T3, InnerInboundExternalLinkApplicationLogsFactory> WithApplicationLogs<T1, T2, T3>(this CombinedResult<T1, T2, InnerInboundExternalLinkLinkLogSettingsFactory, T3> combinedResult, Action<Humidifier.RTBFabric.InboundExternalLinkTypes.ApplicationLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationLogs(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerInboundExternalLinkLinkLogSettingsFactory, InnerInboundExternalLinkApplicationLogsFactory> WithApplicationLogs<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerInboundExternalLinkLinkLogSettingsFactory> combinedResult, Action<Humidifier.RTBFabric.InboundExternalLinkTypes.ApplicationLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationLogs(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerInboundExternalLinkLinkLogSettingsFactory, T1, T2, T3, T4, InnerInboundExternalLinkApplicationLogsFactory> WithApplicationLogs<T1, T2, T3, T4>(this CombinedResult<InnerInboundExternalLinkLinkLogSettingsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.RTBFabric.InboundExternalLinkTypes.ApplicationLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationLogs(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerInboundExternalLinkLinkLogSettingsFactory, T2, T3, T4, InnerInboundExternalLinkApplicationLogsFactory> WithApplicationLogs<T1, T2, T3, T4>(this CombinedResult<T1, InnerInboundExternalLinkLinkLogSettingsFactory, T2, T3, T4> combinedResult, Action<Humidifier.RTBFabric.InboundExternalLinkTypes.ApplicationLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationLogs(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerInboundExternalLinkLinkLogSettingsFactory, T3, T4, InnerInboundExternalLinkApplicationLogsFactory> WithApplicationLogs<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerInboundExternalLinkLinkLogSettingsFactory, T3, T4> combinedResult, Action<Humidifier.RTBFabric.InboundExternalLinkTypes.ApplicationLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationLogs(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerInboundExternalLinkLinkLogSettingsFactory, T4, InnerInboundExternalLinkApplicationLogsFactory> WithApplicationLogs<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerInboundExternalLinkLinkLogSettingsFactory, T4> combinedResult, Action<Humidifier.RTBFabric.InboundExternalLinkTypes.ApplicationLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationLogs(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerInboundExternalLinkLinkLogSettingsFactory, InnerInboundExternalLinkApplicationLogsFactory> WithApplicationLogs<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerInboundExternalLinkLinkLogSettingsFactory> combinedResult, Action<Humidifier.RTBFabric.InboundExternalLinkTypes.ApplicationLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationLogs(combinedResult.T5, subFactoryAction).T2);
}
