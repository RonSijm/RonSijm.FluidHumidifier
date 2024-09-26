// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KafkaConnect;

public class InnerConnectorPluginFactory(Action<Humidifier.KafkaConnect.ConnectorTypes.Plugin> factoryAction = null) : SubResourceFactory<Humidifier.KafkaConnect.ConnectorTypes.Plugin>
{

    internal InnerConnectorCustomPluginFactory CustomPluginFactory { get; set; }

    protected override Humidifier.KafkaConnect.ConnectorTypes.Plugin Create()
    {
        var pluginResult = CreatePlugin();
        factoryAction?.Invoke(pluginResult);

        return pluginResult;
    }

    private Humidifier.KafkaConnect.ConnectorTypes.Plugin CreatePlugin()
    {
        var pluginResult = new Humidifier.KafkaConnect.ConnectorTypes.Plugin();

        return pluginResult;
    }
    public override void CreateChildren(Humidifier.KafkaConnect.ConnectorTypes.Plugin result)
    {
        base.CreateChildren(result);

        result.CustomPlugin ??= CustomPluginFactory?.Build();
    }

} // End Of Class

public static class InnerConnectorPluginFactoryExtensions
{
    public static CombinedResult<InnerConnectorPluginFactory, InnerConnectorCustomPluginFactory> WithCustomPlugin(this InnerConnectorPluginFactory parentFactory, Action<Humidifier.KafkaConnect.ConnectorTypes.CustomPlugin> subFactoryAction = null)
    {
        parentFactory.CustomPluginFactory = new InnerConnectorCustomPluginFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CustomPluginFactory);
    }

    public static CombinedResult<InnerConnectorPluginFactory, T1, InnerConnectorCustomPluginFactory> WithCustomPlugin<T1>(this CombinedResult<InnerConnectorPluginFactory, T1> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.CustomPlugin> subFactoryAction = null) => new (combinedResult, combinedResult, WithCustomPlugin(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectorPluginFactory, InnerConnectorCustomPluginFactory> WithCustomPlugin<T1>(this CombinedResult<T1, InnerConnectorPluginFactory> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.CustomPlugin> subFactoryAction = null) => new (combinedResult, combinedResult, WithCustomPlugin(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerConnectorPluginFactory, T1, T2, InnerConnectorCustomPluginFactory> WithCustomPlugin<T1, T2>(this CombinedResult<InnerConnectorPluginFactory, T1, T2> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.CustomPlugin> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomPlugin(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectorPluginFactory, T2, InnerConnectorCustomPluginFactory> WithCustomPlugin<T1, T2>(this CombinedResult<T1, InnerConnectorPluginFactory, T2> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.CustomPlugin> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomPlugin(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConnectorPluginFactory, InnerConnectorCustomPluginFactory> WithCustomPlugin<T1, T2>(this CombinedResult<T1, T2, InnerConnectorPluginFactory> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.CustomPlugin> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomPlugin(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerConnectorPluginFactory, T1, T2, T3, InnerConnectorCustomPluginFactory> WithCustomPlugin<T1, T2, T3>(this CombinedResult<InnerConnectorPluginFactory, T1, T2, T3> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.CustomPlugin> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomPlugin(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectorPluginFactory, T2, T3, InnerConnectorCustomPluginFactory> WithCustomPlugin<T1, T2, T3>(this CombinedResult<T1, InnerConnectorPluginFactory, T2, T3> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.CustomPlugin> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomPlugin(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConnectorPluginFactory, T3, InnerConnectorCustomPluginFactory> WithCustomPlugin<T1, T2, T3>(this CombinedResult<T1, T2, InnerConnectorPluginFactory, T3> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.CustomPlugin> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomPlugin(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConnectorPluginFactory, InnerConnectorCustomPluginFactory> WithCustomPlugin<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerConnectorPluginFactory> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.CustomPlugin> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomPlugin(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerConnectorPluginFactory, T1, T2, T3, T4, InnerConnectorCustomPluginFactory> WithCustomPlugin<T1, T2, T3, T4>(this CombinedResult<InnerConnectorPluginFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.CustomPlugin> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomPlugin(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectorPluginFactory, T2, T3, T4, InnerConnectorCustomPluginFactory> WithCustomPlugin<T1, T2, T3, T4>(this CombinedResult<T1, InnerConnectorPluginFactory, T2, T3, T4> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.CustomPlugin> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomPlugin(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConnectorPluginFactory, T3, T4, InnerConnectorCustomPluginFactory> WithCustomPlugin<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerConnectorPluginFactory, T3, T4> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.CustomPlugin> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomPlugin(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConnectorPluginFactory, T4, InnerConnectorCustomPluginFactory> WithCustomPlugin<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerConnectorPluginFactory, T4> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.CustomPlugin> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomPlugin(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerConnectorPluginFactory, InnerConnectorCustomPluginFactory> WithCustomPlugin<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerConnectorPluginFactory> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.CustomPlugin> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomPlugin(combinedResult.T5, subFactoryAction));
}
