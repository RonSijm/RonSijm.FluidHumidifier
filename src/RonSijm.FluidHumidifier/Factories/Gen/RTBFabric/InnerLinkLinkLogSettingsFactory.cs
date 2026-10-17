// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RTBFabric;

public class InnerLinkLinkLogSettingsFactory(Action<Humidifier.RTBFabric.LinkTypes.LinkLogSettings> factoryAction = null) : SubResourceFactory<Humidifier.RTBFabric.LinkTypes.LinkLogSettings>
{

    internal InnerLinkApplicationLogsFactory ApplicationLogsFactory { get; set; }

    protected override Humidifier.RTBFabric.LinkTypes.LinkLogSettings Create()
    {
        var linkLogSettingsResult = CreateLinkLogSettings();
        factoryAction?.Invoke(linkLogSettingsResult);

        return linkLogSettingsResult;
    }

    private Humidifier.RTBFabric.LinkTypes.LinkLogSettings CreateLinkLogSettings()
    {
        var linkLogSettingsResult = new Humidifier.RTBFabric.LinkTypes.LinkLogSettings();

        return linkLogSettingsResult;
    }
    public override void CreateChildren(Humidifier.RTBFabric.LinkTypes.LinkLogSettings result)
    {
        base.CreateChildren(result);

        result.ApplicationLogs ??= ApplicationLogsFactory?.Build();
    }

} // End Of Class

public static class InnerLinkLinkLogSettingsFactoryExtensions
{
    public static CombinedResult<InnerLinkLinkLogSettingsFactory, InnerLinkApplicationLogsFactory> WithApplicationLogs(this InnerLinkLinkLogSettingsFactory parentFactory, Action<Humidifier.RTBFabric.LinkTypes.ApplicationLogs> subFactoryAction = null)
    {
        parentFactory.ApplicationLogsFactory = new InnerLinkApplicationLogsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ApplicationLogsFactory);
    }

    public static CombinedResult<InnerLinkLinkLogSettingsFactory, T1, InnerLinkApplicationLogsFactory> WithApplicationLogs<T1>(this CombinedResult<InnerLinkLinkLogSettingsFactory, T1> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.ApplicationLogs> subFactoryAction = null) => new (combinedResult, combinedResult, WithApplicationLogs(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLinkLinkLogSettingsFactory, InnerLinkApplicationLogsFactory> WithApplicationLogs<T1>(this CombinedResult<T1, InnerLinkLinkLogSettingsFactory> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.ApplicationLogs> subFactoryAction = null) => new (combinedResult, combinedResult, WithApplicationLogs(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerLinkLinkLogSettingsFactory, T1, T2, InnerLinkApplicationLogsFactory> WithApplicationLogs<T1, T2>(this CombinedResult<InnerLinkLinkLogSettingsFactory, T1, T2> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.ApplicationLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApplicationLogs(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLinkLinkLogSettingsFactory, T2, InnerLinkApplicationLogsFactory> WithApplicationLogs<T1, T2>(this CombinedResult<T1, InnerLinkLinkLogSettingsFactory, T2> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.ApplicationLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApplicationLogs(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerLinkLinkLogSettingsFactory, InnerLinkApplicationLogsFactory> WithApplicationLogs<T1, T2>(this CombinedResult<T1, T2, InnerLinkLinkLogSettingsFactory> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.ApplicationLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApplicationLogs(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerLinkLinkLogSettingsFactory, T1, T2, T3, InnerLinkApplicationLogsFactory> WithApplicationLogs<T1, T2, T3>(this CombinedResult<InnerLinkLinkLogSettingsFactory, T1, T2, T3> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.ApplicationLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationLogs(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLinkLinkLogSettingsFactory, T2, T3, InnerLinkApplicationLogsFactory> WithApplicationLogs<T1, T2, T3>(this CombinedResult<T1, InnerLinkLinkLogSettingsFactory, T2, T3> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.ApplicationLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationLogs(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerLinkLinkLogSettingsFactory, T3, InnerLinkApplicationLogsFactory> WithApplicationLogs<T1, T2, T3>(this CombinedResult<T1, T2, InnerLinkLinkLogSettingsFactory, T3> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.ApplicationLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationLogs(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerLinkLinkLogSettingsFactory, InnerLinkApplicationLogsFactory> WithApplicationLogs<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerLinkLinkLogSettingsFactory> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.ApplicationLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationLogs(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerLinkLinkLogSettingsFactory, T1, T2, T3, T4, InnerLinkApplicationLogsFactory> WithApplicationLogs<T1, T2, T3, T4>(this CombinedResult<InnerLinkLinkLogSettingsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.ApplicationLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationLogs(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLinkLinkLogSettingsFactory, T2, T3, T4, InnerLinkApplicationLogsFactory> WithApplicationLogs<T1, T2, T3, T4>(this CombinedResult<T1, InnerLinkLinkLogSettingsFactory, T2, T3, T4> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.ApplicationLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationLogs(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerLinkLinkLogSettingsFactory, T3, T4, InnerLinkApplicationLogsFactory> WithApplicationLogs<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerLinkLinkLogSettingsFactory, T3, T4> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.ApplicationLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationLogs(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerLinkLinkLogSettingsFactory, T4, InnerLinkApplicationLogsFactory> WithApplicationLogs<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerLinkLinkLogSettingsFactory, T4> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.ApplicationLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationLogs(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerLinkLinkLogSettingsFactory, InnerLinkApplicationLogsFactory> WithApplicationLogs<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerLinkLinkLogSettingsFactory> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.ApplicationLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationLogs(combinedResult.T5, subFactoryAction).T2);
}
