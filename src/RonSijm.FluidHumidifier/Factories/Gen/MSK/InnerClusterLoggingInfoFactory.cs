// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MSK;

public class InnerClusterLoggingInfoFactory(Action<Humidifier.MSK.ClusterTypes.LoggingInfo> factoryAction = null) : SubResourceFactory<Humidifier.MSK.ClusterTypes.LoggingInfo>
{

    internal InnerClusterBrokerLogsFactory BrokerLogsFactory { get; set; }

    protected override Humidifier.MSK.ClusterTypes.LoggingInfo Create()
    {
        var loggingInfoResult = CreateLoggingInfo();
        factoryAction?.Invoke(loggingInfoResult);

        return loggingInfoResult;
    }

    private Humidifier.MSK.ClusterTypes.LoggingInfo CreateLoggingInfo()
    {
        var loggingInfoResult = new Humidifier.MSK.ClusterTypes.LoggingInfo();

        return loggingInfoResult;
    }
    public override void CreateChildren(Humidifier.MSK.ClusterTypes.LoggingInfo result)
    {
        base.CreateChildren(result);

        result.BrokerLogs ??= BrokerLogsFactory?.Build();
    }

} // End Of Class

public static class InnerClusterLoggingInfoFactoryExtensions
{
    public static CombinedResult<InnerClusterLoggingInfoFactory, InnerClusterBrokerLogsFactory> WithBrokerLogs(this InnerClusterLoggingInfoFactory parentFactory, Action<Humidifier.MSK.ClusterTypes.BrokerLogs> subFactoryAction = null)
    {
        parentFactory.BrokerLogsFactory = new InnerClusterBrokerLogsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.BrokerLogsFactory);
    }

    public static CombinedResult<InnerClusterLoggingInfoFactory, T1, InnerClusterBrokerLogsFactory> WithBrokerLogs<T1>(this CombinedResult<InnerClusterLoggingInfoFactory, T1> combinedResult, Action<Humidifier.MSK.ClusterTypes.BrokerLogs> subFactoryAction = null) => new (combinedResult, combinedResult, WithBrokerLogs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterLoggingInfoFactory, InnerClusterBrokerLogsFactory> WithBrokerLogs<T1>(this CombinedResult<T1, InnerClusterLoggingInfoFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.BrokerLogs> subFactoryAction = null) => new (combinedResult, combinedResult, WithBrokerLogs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerClusterLoggingInfoFactory, T1, T2, InnerClusterBrokerLogsFactory> WithBrokerLogs<T1, T2>(this CombinedResult<InnerClusterLoggingInfoFactory, T1, T2> combinedResult, Action<Humidifier.MSK.ClusterTypes.BrokerLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBrokerLogs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterLoggingInfoFactory, T2, InnerClusterBrokerLogsFactory> WithBrokerLogs<T1, T2>(this CombinedResult<T1, InnerClusterLoggingInfoFactory, T2> combinedResult, Action<Humidifier.MSK.ClusterTypes.BrokerLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBrokerLogs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterLoggingInfoFactory, InnerClusterBrokerLogsFactory> WithBrokerLogs<T1, T2>(this CombinedResult<T1, T2, InnerClusterLoggingInfoFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.BrokerLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBrokerLogs(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerClusterLoggingInfoFactory, T1, T2, T3, InnerClusterBrokerLogsFactory> WithBrokerLogs<T1, T2, T3>(this CombinedResult<InnerClusterLoggingInfoFactory, T1, T2, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.BrokerLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBrokerLogs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterLoggingInfoFactory, T2, T3, InnerClusterBrokerLogsFactory> WithBrokerLogs<T1, T2, T3>(this CombinedResult<T1, InnerClusterLoggingInfoFactory, T2, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.BrokerLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBrokerLogs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterLoggingInfoFactory, T3, InnerClusterBrokerLogsFactory> WithBrokerLogs<T1, T2, T3>(this CombinedResult<T1, T2, InnerClusterLoggingInfoFactory, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.BrokerLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBrokerLogs(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterLoggingInfoFactory, InnerClusterBrokerLogsFactory> WithBrokerLogs<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerClusterLoggingInfoFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.BrokerLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBrokerLogs(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerClusterLoggingInfoFactory, T1, T2, T3, T4, InnerClusterBrokerLogsFactory> WithBrokerLogs<T1, T2, T3, T4>(this CombinedResult<InnerClusterLoggingInfoFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.BrokerLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBrokerLogs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterLoggingInfoFactory, T2, T3, T4, InnerClusterBrokerLogsFactory> WithBrokerLogs<T1, T2, T3, T4>(this CombinedResult<T1, InnerClusterLoggingInfoFactory, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.BrokerLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBrokerLogs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterLoggingInfoFactory, T3, T4, InnerClusterBrokerLogsFactory> WithBrokerLogs<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerClusterLoggingInfoFactory, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.BrokerLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBrokerLogs(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterLoggingInfoFactory, T4, InnerClusterBrokerLogsFactory> WithBrokerLogs<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerClusterLoggingInfoFactory, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.BrokerLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBrokerLogs(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerClusterLoggingInfoFactory, InnerClusterBrokerLogsFactory> WithBrokerLogs<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerClusterLoggingInfoFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.BrokerLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBrokerLogs(combinedResult.T5, subFactoryAction));
}
