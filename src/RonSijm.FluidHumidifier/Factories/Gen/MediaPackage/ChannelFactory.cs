// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaPackage;

public class ChannelFactory(string resourceName = null, Action<Humidifier.MediaPackage.Channel> factoryAction = null) : ResourceFactory<Humidifier.MediaPackage.Channel>(resourceName)
{

    internal InnerChannelLogConfigurationFactory IngressAccessLogsFactory { get; set; }

    internal InnerChannelHlsIngestFactory HlsIngestFactory { get; set; }

    internal InnerChannelLogConfigurationFactory EgressAccessLogsFactory { get; set; }

    protected override Humidifier.MediaPackage.Channel Create()
    {
        var channelResult = CreateChannel();
        factoryAction?.Invoke(channelResult);

        return channelResult;
    }

    private Humidifier.MediaPackage.Channel CreateChannel()
    {
        var channelResult = new Humidifier.MediaPackage.Channel
        {
            GivenName = InputResourceName,
        };

        return channelResult;
    }
    public override void CreateChildren(Humidifier.MediaPackage.Channel result)
    {
        base.CreateChildren(result);

        result.IngressAccessLogs ??= IngressAccessLogsFactory?.Build();
        result.HlsIngest ??= HlsIngestFactory?.Build();
        result.EgressAccessLogs ??= EgressAccessLogsFactory?.Build();
    }

} // End Of Class

public static class ChannelFactoryExtensions
{
    public static CombinedResult<ChannelFactory, InnerChannelLogConfigurationFactory> WithIngressAccessLogs(this ChannelFactory parentFactory, Action<Humidifier.MediaPackage.ChannelTypes.LogConfiguration> subFactoryAction = null)
    {
        parentFactory.IngressAccessLogsFactory = new InnerChannelLogConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.IngressAccessLogsFactory);
    }

    public static CombinedResult<ChannelFactory, InnerChannelHlsIngestFactory> WithHlsIngest(this ChannelFactory parentFactory, Action<Humidifier.MediaPackage.ChannelTypes.HlsIngest> subFactoryAction = null)
    {
        parentFactory.HlsIngestFactory = new InnerChannelHlsIngestFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.HlsIngestFactory);
    }

    public static CombinedResult<ChannelFactory, InnerChannelLogConfigurationFactory> WithEgressAccessLogs(this ChannelFactory parentFactory, Action<Humidifier.MediaPackage.ChannelTypes.LogConfiguration> subFactoryAction = null)
    {
        parentFactory.EgressAccessLogsFactory = new InnerChannelLogConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EgressAccessLogsFactory);
    }

    public static CombinedResult<ChannelFactory, T1, InnerChannelLogConfigurationFactory> WithIngressAccessLogs<T1>(this CombinedResult<ChannelFactory, T1> combinedResult, Action<Humidifier.MediaPackage.ChannelTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithIngressAccessLogs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ChannelFactory, InnerChannelLogConfigurationFactory> WithIngressAccessLogs<T1>(this CombinedResult<T1, ChannelFactory> combinedResult, Action<Humidifier.MediaPackage.ChannelTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithIngressAccessLogs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ChannelFactory, T1, T2, InnerChannelLogConfigurationFactory> WithIngressAccessLogs<T1, T2>(this CombinedResult<ChannelFactory, T1, T2> combinedResult, Action<Humidifier.MediaPackage.ChannelTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIngressAccessLogs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ChannelFactory, T2, InnerChannelLogConfigurationFactory> WithIngressAccessLogs<T1, T2>(this CombinedResult<T1, ChannelFactory, T2> combinedResult, Action<Humidifier.MediaPackage.ChannelTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIngressAccessLogs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ChannelFactory, InnerChannelLogConfigurationFactory> WithIngressAccessLogs<T1, T2>(this CombinedResult<T1, T2, ChannelFactory> combinedResult, Action<Humidifier.MediaPackage.ChannelTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIngressAccessLogs(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ChannelFactory, T1, T2, T3, InnerChannelLogConfigurationFactory> WithIngressAccessLogs<T1, T2, T3>(this CombinedResult<ChannelFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaPackage.ChannelTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIngressAccessLogs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ChannelFactory, T2, T3, InnerChannelLogConfigurationFactory> WithIngressAccessLogs<T1, T2, T3>(this CombinedResult<T1, ChannelFactory, T2, T3> combinedResult, Action<Humidifier.MediaPackage.ChannelTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIngressAccessLogs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ChannelFactory, T3, InnerChannelLogConfigurationFactory> WithIngressAccessLogs<T1, T2, T3>(this CombinedResult<T1, T2, ChannelFactory, T3> combinedResult, Action<Humidifier.MediaPackage.ChannelTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIngressAccessLogs(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ChannelFactory, InnerChannelLogConfigurationFactory> WithIngressAccessLogs<T1, T2, T3>(this CombinedResult<T1, T2, T3, ChannelFactory> combinedResult, Action<Humidifier.MediaPackage.ChannelTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIngressAccessLogs(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ChannelFactory, T1, T2, T3, T4, InnerChannelLogConfigurationFactory> WithIngressAccessLogs<T1, T2, T3, T4>(this CombinedResult<ChannelFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaPackage.ChannelTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIngressAccessLogs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ChannelFactory, T2, T3, T4, InnerChannelLogConfigurationFactory> WithIngressAccessLogs<T1, T2, T3, T4>(this CombinedResult<T1, ChannelFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaPackage.ChannelTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIngressAccessLogs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ChannelFactory, T3, T4, InnerChannelLogConfigurationFactory> WithIngressAccessLogs<T1, T2, T3, T4>(this CombinedResult<T1, T2, ChannelFactory, T3, T4> combinedResult, Action<Humidifier.MediaPackage.ChannelTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIngressAccessLogs(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ChannelFactory, T4, InnerChannelLogConfigurationFactory> WithIngressAccessLogs<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ChannelFactory, T4> combinedResult, Action<Humidifier.MediaPackage.ChannelTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIngressAccessLogs(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ChannelFactory, InnerChannelLogConfigurationFactory> WithIngressAccessLogs<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ChannelFactory> combinedResult, Action<Humidifier.MediaPackage.ChannelTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIngressAccessLogs(combinedResult.T5, subFactoryAction));
    public static CombinedResult<ChannelFactory, T1, InnerChannelHlsIngestFactory> WithHlsIngest<T1>(this CombinedResult<ChannelFactory, T1> combinedResult, Action<Humidifier.MediaPackage.ChannelTypes.HlsIngest> subFactoryAction = null) => new (combinedResult, combinedResult, WithHlsIngest(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ChannelFactory, InnerChannelHlsIngestFactory> WithHlsIngest<T1>(this CombinedResult<T1, ChannelFactory> combinedResult, Action<Humidifier.MediaPackage.ChannelTypes.HlsIngest> subFactoryAction = null) => new (combinedResult, combinedResult, WithHlsIngest(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ChannelFactory, T1, T2, InnerChannelHlsIngestFactory> WithHlsIngest<T1, T2>(this CombinedResult<ChannelFactory, T1, T2> combinedResult, Action<Humidifier.MediaPackage.ChannelTypes.HlsIngest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHlsIngest(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ChannelFactory, T2, InnerChannelHlsIngestFactory> WithHlsIngest<T1, T2>(this CombinedResult<T1, ChannelFactory, T2> combinedResult, Action<Humidifier.MediaPackage.ChannelTypes.HlsIngest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHlsIngest(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ChannelFactory, InnerChannelHlsIngestFactory> WithHlsIngest<T1, T2>(this CombinedResult<T1, T2, ChannelFactory> combinedResult, Action<Humidifier.MediaPackage.ChannelTypes.HlsIngest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHlsIngest(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ChannelFactory, T1, T2, T3, InnerChannelHlsIngestFactory> WithHlsIngest<T1, T2, T3>(this CombinedResult<ChannelFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaPackage.ChannelTypes.HlsIngest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHlsIngest(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ChannelFactory, T2, T3, InnerChannelHlsIngestFactory> WithHlsIngest<T1, T2, T3>(this CombinedResult<T1, ChannelFactory, T2, T3> combinedResult, Action<Humidifier.MediaPackage.ChannelTypes.HlsIngest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHlsIngest(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ChannelFactory, T3, InnerChannelHlsIngestFactory> WithHlsIngest<T1, T2, T3>(this CombinedResult<T1, T2, ChannelFactory, T3> combinedResult, Action<Humidifier.MediaPackage.ChannelTypes.HlsIngest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHlsIngest(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ChannelFactory, InnerChannelHlsIngestFactory> WithHlsIngest<T1, T2, T3>(this CombinedResult<T1, T2, T3, ChannelFactory> combinedResult, Action<Humidifier.MediaPackage.ChannelTypes.HlsIngest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHlsIngest(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ChannelFactory, T1, T2, T3, T4, InnerChannelHlsIngestFactory> WithHlsIngest<T1, T2, T3, T4>(this CombinedResult<ChannelFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaPackage.ChannelTypes.HlsIngest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHlsIngest(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ChannelFactory, T2, T3, T4, InnerChannelHlsIngestFactory> WithHlsIngest<T1, T2, T3, T4>(this CombinedResult<T1, ChannelFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaPackage.ChannelTypes.HlsIngest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHlsIngest(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ChannelFactory, T3, T4, InnerChannelHlsIngestFactory> WithHlsIngest<T1, T2, T3, T4>(this CombinedResult<T1, T2, ChannelFactory, T3, T4> combinedResult, Action<Humidifier.MediaPackage.ChannelTypes.HlsIngest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHlsIngest(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ChannelFactory, T4, InnerChannelHlsIngestFactory> WithHlsIngest<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ChannelFactory, T4> combinedResult, Action<Humidifier.MediaPackage.ChannelTypes.HlsIngest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHlsIngest(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ChannelFactory, InnerChannelHlsIngestFactory> WithHlsIngest<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ChannelFactory> combinedResult, Action<Humidifier.MediaPackage.ChannelTypes.HlsIngest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHlsIngest(combinedResult.T5, subFactoryAction));
    public static CombinedResult<ChannelFactory, T1, InnerChannelLogConfigurationFactory> WithEgressAccessLogs<T1>(this CombinedResult<ChannelFactory, T1> combinedResult, Action<Humidifier.MediaPackage.ChannelTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEgressAccessLogs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ChannelFactory, InnerChannelLogConfigurationFactory> WithEgressAccessLogs<T1>(this CombinedResult<T1, ChannelFactory> combinedResult, Action<Humidifier.MediaPackage.ChannelTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEgressAccessLogs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ChannelFactory, T1, T2, InnerChannelLogConfigurationFactory> WithEgressAccessLogs<T1, T2>(this CombinedResult<ChannelFactory, T1, T2> combinedResult, Action<Humidifier.MediaPackage.ChannelTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEgressAccessLogs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ChannelFactory, T2, InnerChannelLogConfigurationFactory> WithEgressAccessLogs<T1, T2>(this CombinedResult<T1, ChannelFactory, T2> combinedResult, Action<Humidifier.MediaPackage.ChannelTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEgressAccessLogs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ChannelFactory, InnerChannelLogConfigurationFactory> WithEgressAccessLogs<T1, T2>(this CombinedResult<T1, T2, ChannelFactory> combinedResult, Action<Humidifier.MediaPackage.ChannelTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEgressAccessLogs(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ChannelFactory, T1, T2, T3, InnerChannelLogConfigurationFactory> WithEgressAccessLogs<T1, T2, T3>(this CombinedResult<ChannelFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaPackage.ChannelTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEgressAccessLogs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ChannelFactory, T2, T3, InnerChannelLogConfigurationFactory> WithEgressAccessLogs<T1, T2, T3>(this CombinedResult<T1, ChannelFactory, T2, T3> combinedResult, Action<Humidifier.MediaPackage.ChannelTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEgressAccessLogs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ChannelFactory, T3, InnerChannelLogConfigurationFactory> WithEgressAccessLogs<T1, T2, T3>(this CombinedResult<T1, T2, ChannelFactory, T3> combinedResult, Action<Humidifier.MediaPackage.ChannelTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEgressAccessLogs(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ChannelFactory, InnerChannelLogConfigurationFactory> WithEgressAccessLogs<T1, T2, T3>(this CombinedResult<T1, T2, T3, ChannelFactory> combinedResult, Action<Humidifier.MediaPackage.ChannelTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEgressAccessLogs(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ChannelFactory, T1, T2, T3, T4, InnerChannelLogConfigurationFactory> WithEgressAccessLogs<T1, T2, T3, T4>(this CombinedResult<ChannelFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaPackage.ChannelTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEgressAccessLogs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ChannelFactory, T2, T3, T4, InnerChannelLogConfigurationFactory> WithEgressAccessLogs<T1, T2, T3, T4>(this CombinedResult<T1, ChannelFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaPackage.ChannelTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEgressAccessLogs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ChannelFactory, T3, T4, InnerChannelLogConfigurationFactory> WithEgressAccessLogs<T1, T2, T3, T4>(this CombinedResult<T1, T2, ChannelFactory, T3, T4> combinedResult, Action<Humidifier.MediaPackage.ChannelTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEgressAccessLogs(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ChannelFactory, T4, InnerChannelLogConfigurationFactory> WithEgressAccessLogs<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ChannelFactory, T4> combinedResult, Action<Humidifier.MediaPackage.ChannelTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEgressAccessLogs(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ChannelFactory, InnerChannelLogConfigurationFactory> WithEgressAccessLogs<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ChannelFactory> combinedResult, Action<Humidifier.MediaPackage.ChannelTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEgressAccessLogs(combinedResult.T5, subFactoryAction));
}
