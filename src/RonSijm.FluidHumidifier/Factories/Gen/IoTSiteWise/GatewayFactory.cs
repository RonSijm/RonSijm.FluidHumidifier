// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTSiteWise;

public class GatewayFactory(string resourceName = null, Action<Humidifier.IoTSiteWise.Gateway> factoryAction = null) : ResourceFactory<Humidifier.IoTSiteWise.Gateway>(resourceName)
{

    internal List<InnerGatewayGatewayCapabilitySummaryFactory> GatewayCapabilitySummariesFactories { get; set; } = [];

    internal InnerGatewayGatewayPlatformFactory GatewayPlatformFactory { get; set; }

    protected override Humidifier.IoTSiteWise.Gateway Create()
    {
        var gatewayResult = CreateGateway();
        factoryAction?.Invoke(gatewayResult);

        return gatewayResult;
    }

    private Humidifier.IoTSiteWise.Gateway CreateGateway()
    {
        var gatewayResult = new Humidifier.IoTSiteWise.Gateway
        {
            GivenName = InputResourceName,
        };

        return gatewayResult;
    }
    public override void CreateChildren(Humidifier.IoTSiteWise.Gateway result)
    {
        base.CreateChildren(result);

        result.GatewayCapabilitySummaries = GatewayCapabilitySummariesFactories.Any() ? GatewayCapabilitySummariesFactories.Select(x => x.Build()).ToList() : null;
        result.GatewayPlatform ??= GatewayPlatformFactory?.Build();
    }

} // End Of Class

public static class GatewayFactoryExtensions
{
    public static CombinedResult<GatewayFactory, InnerGatewayGatewayCapabilitySummaryFactory> WithGatewayCapabilitySummaries(this GatewayFactory parentFactory, Action<Humidifier.IoTSiteWise.GatewayTypes.GatewayCapabilitySummary> subFactoryAction = null)
    {
        var factory = new InnerGatewayGatewayCapabilitySummaryFactory(subFactoryAction);
        parentFactory.GatewayCapabilitySummariesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<GatewayFactory, InnerGatewayGatewayPlatformFactory> WithGatewayPlatform(this GatewayFactory parentFactory, Action<Humidifier.IoTSiteWise.GatewayTypes.GatewayPlatform> subFactoryAction = null)
    {
        parentFactory.GatewayPlatformFactory = new InnerGatewayGatewayPlatformFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.GatewayPlatformFactory);
    }

    public static CombinedResult<GatewayFactory, T1, InnerGatewayGatewayCapabilitySummaryFactory> WithGatewayCapabilitySummaries<T1>(this CombinedResult<GatewayFactory, T1> combinedResult, Action<Humidifier.IoTSiteWise.GatewayTypes.GatewayCapabilitySummary> subFactoryAction = null) => new (combinedResult, combinedResult, WithGatewayCapabilitySummaries(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, GatewayFactory, InnerGatewayGatewayCapabilitySummaryFactory> WithGatewayCapabilitySummaries<T1>(this CombinedResult<T1, GatewayFactory> combinedResult, Action<Humidifier.IoTSiteWise.GatewayTypes.GatewayCapabilitySummary> subFactoryAction = null) => new (combinedResult, combinedResult, WithGatewayCapabilitySummaries(combinedResult.T2, subFactoryAction));
    public static CombinedResult<GatewayFactory, T1, T2, InnerGatewayGatewayCapabilitySummaryFactory> WithGatewayCapabilitySummaries<T1, T2>(this CombinedResult<GatewayFactory, T1, T2> combinedResult, Action<Humidifier.IoTSiteWise.GatewayTypes.GatewayCapabilitySummary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGatewayCapabilitySummaries(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, GatewayFactory, T2, InnerGatewayGatewayCapabilitySummaryFactory> WithGatewayCapabilitySummaries<T1, T2>(this CombinedResult<T1, GatewayFactory, T2> combinedResult, Action<Humidifier.IoTSiteWise.GatewayTypes.GatewayCapabilitySummary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGatewayCapabilitySummaries(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, GatewayFactory, InnerGatewayGatewayCapabilitySummaryFactory> WithGatewayCapabilitySummaries<T1, T2>(this CombinedResult<T1, T2, GatewayFactory> combinedResult, Action<Humidifier.IoTSiteWise.GatewayTypes.GatewayCapabilitySummary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGatewayCapabilitySummaries(combinedResult.T3, subFactoryAction));
    public static CombinedResult<GatewayFactory, T1, T2, T3, InnerGatewayGatewayCapabilitySummaryFactory> WithGatewayCapabilitySummaries<T1, T2, T3>(this CombinedResult<GatewayFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTSiteWise.GatewayTypes.GatewayCapabilitySummary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGatewayCapabilitySummaries(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, GatewayFactory, T2, T3, InnerGatewayGatewayCapabilitySummaryFactory> WithGatewayCapabilitySummaries<T1, T2, T3>(this CombinedResult<T1, GatewayFactory, T2, T3> combinedResult, Action<Humidifier.IoTSiteWise.GatewayTypes.GatewayCapabilitySummary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGatewayCapabilitySummaries(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, GatewayFactory, T3, InnerGatewayGatewayCapabilitySummaryFactory> WithGatewayCapabilitySummaries<T1, T2, T3>(this CombinedResult<T1, T2, GatewayFactory, T3> combinedResult, Action<Humidifier.IoTSiteWise.GatewayTypes.GatewayCapabilitySummary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGatewayCapabilitySummaries(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, GatewayFactory, InnerGatewayGatewayCapabilitySummaryFactory> WithGatewayCapabilitySummaries<T1, T2, T3>(this CombinedResult<T1, T2, T3, GatewayFactory> combinedResult, Action<Humidifier.IoTSiteWise.GatewayTypes.GatewayCapabilitySummary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGatewayCapabilitySummaries(combinedResult.T4, subFactoryAction));
    public static CombinedResult<GatewayFactory, T1, T2, T3, T4, InnerGatewayGatewayCapabilitySummaryFactory> WithGatewayCapabilitySummaries<T1, T2, T3, T4>(this CombinedResult<GatewayFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.GatewayTypes.GatewayCapabilitySummary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGatewayCapabilitySummaries(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, GatewayFactory, T2, T3, T4, InnerGatewayGatewayCapabilitySummaryFactory> WithGatewayCapabilitySummaries<T1, T2, T3, T4>(this CombinedResult<T1, GatewayFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.GatewayTypes.GatewayCapabilitySummary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGatewayCapabilitySummaries(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, GatewayFactory, T3, T4, InnerGatewayGatewayCapabilitySummaryFactory> WithGatewayCapabilitySummaries<T1, T2, T3, T4>(this CombinedResult<T1, T2, GatewayFactory, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.GatewayTypes.GatewayCapabilitySummary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGatewayCapabilitySummaries(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, GatewayFactory, T4, InnerGatewayGatewayCapabilitySummaryFactory> WithGatewayCapabilitySummaries<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, GatewayFactory, T4> combinedResult, Action<Humidifier.IoTSiteWise.GatewayTypes.GatewayCapabilitySummary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGatewayCapabilitySummaries(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, GatewayFactory, InnerGatewayGatewayCapabilitySummaryFactory> WithGatewayCapabilitySummaries<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, GatewayFactory> combinedResult, Action<Humidifier.IoTSiteWise.GatewayTypes.GatewayCapabilitySummary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGatewayCapabilitySummaries(combinedResult.T5, subFactoryAction));
    public static CombinedResult<GatewayFactory, T1, InnerGatewayGatewayPlatformFactory> WithGatewayPlatform<T1>(this CombinedResult<GatewayFactory, T1> combinedResult, Action<Humidifier.IoTSiteWise.GatewayTypes.GatewayPlatform> subFactoryAction = null) => new (combinedResult, combinedResult, WithGatewayPlatform(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, GatewayFactory, InnerGatewayGatewayPlatformFactory> WithGatewayPlatform<T1>(this CombinedResult<T1, GatewayFactory> combinedResult, Action<Humidifier.IoTSiteWise.GatewayTypes.GatewayPlatform> subFactoryAction = null) => new (combinedResult, combinedResult, WithGatewayPlatform(combinedResult.T2, subFactoryAction));
    public static CombinedResult<GatewayFactory, T1, T2, InnerGatewayGatewayPlatformFactory> WithGatewayPlatform<T1, T2>(this CombinedResult<GatewayFactory, T1, T2> combinedResult, Action<Humidifier.IoTSiteWise.GatewayTypes.GatewayPlatform> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGatewayPlatform(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, GatewayFactory, T2, InnerGatewayGatewayPlatformFactory> WithGatewayPlatform<T1, T2>(this CombinedResult<T1, GatewayFactory, T2> combinedResult, Action<Humidifier.IoTSiteWise.GatewayTypes.GatewayPlatform> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGatewayPlatform(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, GatewayFactory, InnerGatewayGatewayPlatformFactory> WithGatewayPlatform<T1, T2>(this CombinedResult<T1, T2, GatewayFactory> combinedResult, Action<Humidifier.IoTSiteWise.GatewayTypes.GatewayPlatform> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGatewayPlatform(combinedResult.T3, subFactoryAction));
    public static CombinedResult<GatewayFactory, T1, T2, T3, InnerGatewayGatewayPlatformFactory> WithGatewayPlatform<T1, T2, T3>(this CombinedResult<GatewayFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTSiteWise.GatewayTypes.GatewayPlatform> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGatewayPlatform(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, GatewayFactory, T2, T3, InnerGatewayGatewayPlatformFactory> WithGatewayPlatform<T1, T2, T3>(this CombinedResult<T1, GatewayFactory, T2, T3> combinedResult, Action<Humidifier.IoTSiteWise.GatewayTypes.GatewayPlatform> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGatewayPlatform(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, GatewayFactory, T3, InnerGatewayGatewayPlatformFactory> WithGatewayPlatform<T1, T2, T3>(this CombinedResult<T1, T2, GatewayFactory, T3> combinedResult, Action<Humidifier.IoTSiteWise.GatewayTypes.GatewayPlatform> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGatewayPlatform(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, GatewayFactory, InnerGatewayGatewayPlatformFactory> WithGatewayPlatform<T1, T2, T3>(this CombinedResult<T1, T2, T3, GatewayFactory> combinedResult, Action<Humidifier.IoTSiteWise.GatewayTypes.GatewayPlatform> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGatewayPlatform(combinedResult.T4, subFactoryAction));
    public static CombinedResult<GatewayFactory, T1, T2, T3, T4, InnerGatewayGatewayPlatformFactory> WithGatewayPlatform<T1, T2, T3, T4>(this CombinedResult<GatewayFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.GatewayTypes.GatewayPlatform> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGatewayPlatform(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, GatewayFactory, T2, T3, T4, InnerGatewayGatewayPlatformFactory> WithGatewayPlatform<T1, T2, T3, T4>(this CombinedResult<T1, GatewayFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.GatewayTypes.GatewayPlatform> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGatewayPlatform(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, GatewayFactory, T3, T4, InnerGatewayGatewayPlatformFactory> WithGatewayPlatform<T1, T2, T3, T4>(this CombinedResult<T1, T2, GatewayFactory, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.GatewayTypes.GatewayPlatform> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGatewayPlatform(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, GatewayFactory, T4, InnerGatewayGatewayPlatformFactory> WithGatewayPlatform<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, GatewayFactory, T4> combinedResult, Action<Humidifier.IoTSiteWise.GatewayTypes.GatewayPlatform> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGatewayPlatform(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, GatewayFactory, InnerGatewayGatewayPlatformFactory> WithGatewayPlatform<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, GatewayFactory> combinedResult, Action<Humidifier.IoTSiteWise.GatewayTypes.GatewayPlatform> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGatewayPlatform(combinedResult.T5, subFactoryAction));
}
