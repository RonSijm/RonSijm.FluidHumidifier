// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Transfer;

public class InnerConnectorAs2ConfigFactory(Action<Humidifier.Transfer.ConnectorTypes.As2Config> factoryAction = null) : SubResourceFactory<Humidifier.Transfer.ConnectorTypes.As2Config>
{

    internal InnerConnectorConnectorAsyncMdnConfigFactory AsyncMdnConfigFactory { get; set; }

    protected override Humidifier.Transfer.ConnectorTypes.As2Config Create()
    {
        var as2ConfigResult = CreateAs2Config();
        factoryAction?.Invoke(as2ConfigResult);

        return as2ConfigResult;
    }

    private Humidifier.Transfer.ConnectorTypes.As2Config CreateAs2Config()
    {
        var as2ConfigResult = new Humidifier.Transfer.ConnectorTypes.As2Config();

        return as2ConfigResult;
    }
    public override void CreateChildren(Humidifier.Transfer.ConnectorTypes.As2Config result)
    {
        base.CreateChildren(result);

        result.AsyncMdnConfig ??= AsyncMdnConfigFactory?.Build();
    }

} // End Of Class

public static class InnerConnectorAs2ConfigFactoryExtensions
{
    public static CombinedResult<InnerConnectorAs2ConfigFactory, InnerConnectorConnectorAsyncMdnConfigFactory> WithAsyncMdnConfig(this InnerConnectorAs2ConfigFactory parentFactory, Action<Humidifier.Transfer.ConnectorTypes.ConnectorAsyncMdnConfig> subFactoryAction = null)
    {
        parentFactory.AsyncMdnConfigFactory = new InnerConnectorConnectorAsyncMdnConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AsyncMdnConfigFactory);
    }

    public static CombinedResult<InnerConnectorAs2ConfigFactory, T1, InnerConnectorConnectorAsyncMdnConfigFactory> WithAsyncMdnConfig<T1>(this CombinedResult<InnerConnectorAs2ConfigFactory, T1> combinedResult, Action<Humidifier.Transfer.ConnectorTypes.ConnectorAsyncMdnConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithAsyncMdnConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConnectorAs2ConfigFactory, InnerConnectorConnectorAsyncMdnConfigFactory> WithAsyncMdnConfig<T1>(this CombinedResult<T1, InnerConnectorAs2ConfigFactory> combinedResult, Action<Humidifier.Transfer.ConnectorTypes.ConnectorAsyncMdnConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithAsyncMdnConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerConnectorAs2ConfigFactory, T1, T2, InnerConnectorConnectorAsyncMdnConfigFactory> WithAsyncMdnConfig<T1, T2>(this CombinedResult<InnerConnectorAs2ConfigFactory, T1, T2> combinedResult, Action<Humidifier.Transfer.ConnectorTypes.ConnectorAsyncMdnConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAsyncMdnConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConnectorAs2ConfigFactory, T2, InnerConnectorConnectorAsyncMdnConfigFactory> WithAsyncMdnConfig<T1, T2>(this CombinedResult<T1, InnerConnectorAs2ConfigFactory, T2> combinedResult, Action<Humidifier.Transfer.ConnectorTypes.ConnectorAsyncMdnConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAsyncMdnConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConnectorAs2ConfigFactory, InnerConnectorConnectorAsyncMdnConfigFactory> WithAsyncMdnConfig<T1, T2>(this CombinedResult<T1, T2, InnerConnectorAs2ConfigFactory> combinedResult, Action<Humidifier.Transfer.ConnectorTypes.ConnectorAsyncMdnConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAsyncMdnConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerConnectorAs2ConfigFactory, T1, T2, T3, InnerConnectorConnectorAsyncMdnConfigFactory> WithAsyncMdnConfig<T1, T2, T3>(this CombinedResult<InnerConnectorAs2ConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.Transfer.ConnectorTypes.ConnectorAsyncMdnConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAsyncMdnConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConnectorAs2ConfigFactory, T2, T3, InnerConnectorConnectorAsyncMdnConfigFactory> WithAsyncMdnConfig<T1, T2, T3>(this CombinedResult<T1, InnerConnectorAs2ConfigFactory, T2, T3> combinedResult, Action<Humidifier.Transfer.ConnectorTypes.ConnectorAsyncMdnConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAsyncMdnConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConnectorAs2ConfigFactory, T3, InnerConnectorConnectorAsyncMdnConfigFactory> WithAsyncMdnConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerConnectorAs2ConfigFactory, T3> combinedResult, Action<Humidifier.Transfer.ConnectorTypes.ConnectorAsyncMdnConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAsyncMdnConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerConnectorAs2ConfigFactory, InnerConnectorConnectorAsyncMdnConfigFactory> WithAsyncMdnConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerConnectorAs2ConfigFactory> combinedResult, Action<Humidifier.Transfer.ConnectorTypes.ConnectorAsyncMdnConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAsyncMdnConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerConnectorAs2ConfigFactory, T1, T2, T3, T4, InnerConnectorConnectorAsyncMdnConfigFactory> WithAsyncMdnConfig<T1, T2, T3, T4>(this CombinedResult<InnerConnectorAs2ConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Transfer.ConnectorTypes.ConnectorAsyncMdnConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAsyncMdnConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConnectorAs2ConfigFactory, T2, T3, T4, InnerConnectorConnectorAsyncMdnConfigFactory> WithAsyncMdnConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerConnectorAs2ConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.Transfer.ConnectorTypes.ConnectorAsyncMdnConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAsyncMdnConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConnectorAs2ConfigFactory, T3, T4, InnerConnectorConnectorAsyncMdnConfigFactory> WithAsyncMdnConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerConnectorAs2ConfigFactory, T3, T4> combinedResult, Action<Humidifier.Transfer.ConnectorTypes.ConnectorAsyncMdnConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAsyncMdnConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerConnectorAs2ConfigFactory, T4, InnerConnectorConnectorAsyncMdnConfigFactory> WithAsyncMdnConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerConnectorAs2ConfigFactory, T4> combinedResult, Action<Humidifier.Transfer.ConnectorTypes.ConnectorAsyncMdnConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAsyncMdnConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerConnectorAs2ConfigFactory, InnerConnectorConnectorAsyncMdnConfigFactory> WithAsyncMdnConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerConnectorAs2ConfigFactory> combinedResult, Action<Humidifier.Transfer.ConnectorTypes.ConnectorAsyncMdnConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAsyncMdnConfig(combinedResult.T5, subFactoryAction).T2);
}
