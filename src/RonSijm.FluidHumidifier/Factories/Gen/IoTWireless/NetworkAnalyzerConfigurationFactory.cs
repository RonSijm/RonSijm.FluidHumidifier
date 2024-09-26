// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTWireless;

public class NetworkAnalyzerConfigurationFactory(string resourceName = null, Action<Humidifier.IoTWireless.NetworkAnalyzerConfiguration> factoryAction = null) : ResourceFactory<Humidifier.IoTWireless.NetworkAnalyzerConfiguration>(resourceName)
{

    internal InnerNetworkAnalyzerConfigurationTraceContentFactory TraceContentFactory { get; set; }

    protected override Humidifier.IoTWireless.NetworkAnalyzerConfiguration Create()
    {
        var networkAnalyzerConfigurationResult = CreateNetworkAnalyzerConfiguration();
        factoryAction?.Invoke(networkAnalyzerConfigurationResult);

        return networkAnalyzerConfigurationResult;
    }

    private Humidifier.IoTWireless.NetworkAnalyzerConfiguration CreateNetworkAnalyzerConfiguration()
    {
        var networkAnalyzerConfigurationResult = new Humidifier.IoTWireless.NetworkAnalyzerConfiguration
        {
            GivenName = InputResourceName,
        };

        return networkAnalyzerConfigurationResult;
    }
    public override void CreateChildren(Humidifier.IoTWireless.NetworkAnalyzerConfiguration result)
    {
        base.CreateChildren(result);

        result.TraceContent ??= TraceContentFactory?.Build();
    }

} // End Of Class

public static class NetworkAnalyzerConfigurationFactoryExtensions
{
    public static CombinedResult<NetworkAnalyzerConfigurationFactory, InnerNetworkAnalyzerConfigurationTraceContentFactory> WithTraceContent(this NetworkAnalyzerConfigurationFactory parentFactory, Action<Humidifier.IoTWireless.NetworkAnalyzerConfigurationTypes.TraceContent> subFactoryAction = null)
    {
        parentFactory.TraceContentFactory = new InnerNetworkAnalyzerConfigurationTraceContentFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TraceContentFactory);
    }

    public static CombinedResult<NetworkAnalyzerConfigurationFactory, T1, InnerNetworkAnalyzerConfigurationTraceContentFactory> WithTraceContent<T1>(this CombinedResult<NetworkAnalyzerConfigurationFactory, T1> combinedResult, Action<Humidifier.IoTWireless.NetworkAnalyzerConfigurationTypes.TraceContent> subFactoryAction = null) => new (combinedResult, combinedResult, WithTraceContent(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, NetworkAnalyzerConfigurationFactory, InnerNetworkAnalyzerConfigurationTraceContentFactory> WithTraceContent<T1>(this CombinedResult<T1, NetworkAnalyzerConfigurationFactory> combinedResult, Action<Humidifier.IoTWireless.NetworkAnalyzerConfigurationTypes.TraceContent> subFactoryAction = null) => new (combinedResult, combinedResult, WithTraceContent(combinedResult.T2, subFactoryAction));
    public static CombinedResult<NetworkAnalyzerConfigurationFactory, T1, T2, InnerNetworkAnalyzerConfigurationTraceContentFactory> WithTraceContent<T1, T2>(this CombinedResult<NetworkAnalyzerConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.IoTWireless.NetworkAnalyzerConfigurationTypes.TraceContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTraceContent(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, NetworkAnalyzerConfigurationFactory, T2, InnerNetworkAnalyzerConfigurationTraceContentFactory> WithTraceContent<T1, T2>(this CombinedResult<T1, NetworkAnalyzerConfigurationFactory, T2> combinedResult, Action<Humidifier.IoTWireless.NetworkAnalyzerConfigurationTypes.TraceContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTraceContent(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, NetworkAnalyzerConfigurationFactory, InnerNetworkAnalyzerConfigurationTraceContentFactory> WithTraceContent<T1, T2>(this CombinedResult<T1, T2, NetworkAnalyzerConfigurationFactory> combinedResult, Action<Humidifier.IoTWireless.NetworkAnalyzerConfigurationTypes.TraceContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTraceContent(combinedResult.T3, subFactoryAction));
    public static CombinedResult<NetworkAnalyzerConfigurationFactory, T1, T2, T3, InnerNetworkAnalyzerConfigurationTraceContentFactory> WithTraceContent<T1, T2, T3>(this CombinedResult<NetworkAnalyzerConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTWireless.NetworkAnalyzerConfigurationTypes.TraceContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTraceContent(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, NetworkAnalyzerConfigurationFactory, T2, T3, InnerNetworkAnalyzerConfigurationTraceContentFactory> WithTraceContent<T1, T2, T3>(this CombinedResult<T1, NetworkAnalyzerConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.IoTWireless.NetworkAnalyzerConfigurationTypes.TraceContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTraceContent(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, NetworkAnalyzerConfigurationFactory, T3, InnerNetworkAnalyzerConfigurationTraceContentFactory> WithTraceContent<T1, T2, T3>(this CombinedResult<T1, T2, NetworkAnalyzerConfigurationFactory, T3> combinedResult, Action<Humidifier.IoTWireless.NetworkAnalyzerConfigurationTypes.TraceContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTraceContent(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, NetworkAnalyzerConfigurationFactory, InnerNetworkAnalyzerConfigurationTraceContentFactory> WithTraceContent<T1, T2, T3>(this CombinedResult<T1, T2, T3, NetworkAnalyzerConfigurationFactory> combinedResult, Action<Humidifier.IoTWireless.NetworkAnalyzerConfigurationTypes.TraceContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTraceContent(combinedResult.T4, subFactoryAction));
    public static CombinedResult<NetworkAnalyzerConfigurationFactory, T1, T2, T3, T4, InnerNetworkAnalyzerConfigurationTraceContentFactory> WithTraceContent<T1, T2, T3, T4>(this CombinedResult<NetworkAnalyzerConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTWireless.NetworkAnalyzerConfigurationTypes.TraceContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTraceContent(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, NetworkAnalyzerConfigurationFactory, T2, T3, T4, InnerNetworkAnalyzerConfigurationTraceContentFactory> WithTraceContent<T1, T2, T3, T4>(this CombinedResult<T1, NetworkAnalyzerConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTWireless.NetworkAnalyzerConfigurationTypes.TraceContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTraceContent(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, NetworkAnalyzerConfigurationFactory, T3, T4, InnerNetworkAnalyzerConfigurationTraceContentFactory> WithTraceContent<T1, T2, T3, T4>(this CombinedResult<T1, T2, NetworkAnalyzerConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.IoTWireless.NetworkAnalyzerConfigurationTypes.TraceContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTraceContent(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, NetworkAnalyzerConfigurationFactory, T4, InnerNetworkAnalyzerConfigurationTraceContentFactory> WithTraceContent<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, NetworkAnalyzerConfigurationFactory, T4> combinedResult, Action<Humidifier.IoTWireless.NetworkAnalyzerConfigurationTypes.TraceContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTraceContent(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, NetworkAnalyzerConfigurationFactory, InnerNetworkAnalyzerConfigurationTraceContentFactory> WithTraceContent<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, NetworkAnalyzerConfigurationFactory> combinedResult, Action<Humidifier.IoTWireless.NetworkAnalyzerConfigurationTypes.TraceContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTraceContent(combinedResult.T5, subFactoryAction));
}
