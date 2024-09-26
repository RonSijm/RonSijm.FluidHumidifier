// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class ConnectorProfileFactory(string resourceName = null, Action<Humidifier.AppFlow.ConnectorProfile> factoryAction = null) : ResourceFactory<Humidifier.AppFlow.ConnectorProfile>(resourceName)
{

    internal InnerConnectorProfileConnectorProfileConfigFactory ConnectorProfileConfigFactory { get; set; }

    protected override Humidifier.AppFlow.ConnectorProfile Create()
    {
        var connectorProfileResult = CreateConnectorProfile();
        factoryAction?.Invoke(connectorProfileResult);

        return connectorProfileResult;
    }

    private Humidifier.AppFlow.ConnectorProfile CreateConnectorProfile()
    {
        var connectorProfileResult = new Humidifier.AppFlow.ConnectorProfile
        {
            GivenName = InputResourceName,
        };

        return connectorProfileResult;
    }
    public override void CreateChildren(Humidifier.AppFlow.ConnectorProfile result)
    {
        base.CreateChildren(result);

        result.ConnectorProfileConfig ??= ConnectorProfileConfigFactory?.Build();
    }

} // End Of Class

public static class ConnectorProfileFactoryExtensions
{
    public static CombinedResult<ConnectorProfileFactory, InnerConnectorProfileConnectorProfileConfigFactory> WithConnectorProfileConfig(this ConnectorProfileFactory parentFactory, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorProfileConfig> subFactoryAction = null)
    {
        parentFactory.ConnectorProfileConfigFactory = new InnerConnectorProfileConnectorProfileConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConnectorProfileConfigFactory);
    }

    public static CombinedResult<ConnectorProfileFactory, T1, InnerConnectorProfileConnectorProfileConfigFactory> WithConnectorProfileConfig<T1>(this CombinedResult<ConnectorProfileFactory, T1> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorProfileConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithConnectorProfileConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConnectorProfileFactory, InnerConnectorProfileConnectorProfileConfigFactory> WithConnectorProfileConfig<T1>(this CombinedResult<T1, ConnectorProfileFactory> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorProfileConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithConnectorProfileConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ConnectorProfileFactory, T1, T2, InnerConnectorProfileConnectorProfileConfigFactory> WithConnectorProfileConfig<T1, T2>(this CombinedResult<ConnectorProfileFactory, T1, T2> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorProfileConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConnectorProfileConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConnectorProfileFactory, T2, InnerConnectorProfileConnectorProfileConfigFactory> WithConnectorProfileConfig<T1, T2>(this CombinedResult<T1, ConnectorProfileFactory, T2> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorProfileConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConnectorProfileConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConnectorProfileFactory, InnerConnectorProfileConnectorProfileConfigFactory> WithConnectorProfileConfig<T1, T2>(this CombinedResult<T1, T2, ConnectorProfileFactory> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorProfileConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConnectorProfileConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ConnectorProfileFactory, T1, T2, T3, InnerConnectorProfileConnectorProfileConfigFactory> WithConnectorProfileConfig<T1, T2, T3>(this CombinedResult<ConnectorProfileFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorProfileConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorProfileConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConnectorProfileFactory, T2, T3, InnerConnectorProfileConnectorProfileConfigFactory> WithConnectorProfileConfig<T1, T2, T3>(this CombinedResult<T1, ConnectorProfileFactory, T2, T3> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorProfileConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorProfileConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConnectorProfileFactory, T3, InnerConnectorProfileConnectorProfileConfigFactory> WithConnectorProfileConfig<T1, T2, T3>(this CombinedResult<T1, T2, ConnectorProfileFactory, T3> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorProfileConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorProfileConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ConnectorProfileFactory, InnerConnectorProfileConnectorProfileConfigFactory> WithConnectorProfileConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, ConnectorProfileFactory> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorProfileConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorProfileConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ConnectorProfileFactory, T1, T2, T3, T4, InnerConnectorProfileConnectorProfileConfigFactory> WithConnectorProfileConfig<T1, T2, T3, T4>(this CombinedResult<ConnectorProfileFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorProfileConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorProfileConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConnectorProfileFactory, T2, T3, T4, InnerConnectorProfileConnectorProfileConfigFactory> WithConnectorProfileConfig<T1, T2, T3, T4>(this CombinedResult<T1, ConnectorProfileFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorProfileConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorProfileConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConnectorProfileFactory, T3, T4, InnerConnectorProfileConnectorProfileConfigFactory> WithConnectorProfileConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, ConnectorProfileFactory, T3, T4> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorProfileConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorProfileConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ConnectorProfileFactory, T4, InnerConnectorProfileConnectorProfileConfigFactory> WithConnectorProfileConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ConnectorProfileFactory, T4> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorProfileConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorProfileConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ConnectorProfileFactory, InnerConnectorProfileConnectorProfileConfigFactory> WithConnectorProfileConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ConnectorProfileFactory> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorProfileConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorProfileConfig(combinedResult.T5, subFactoryAction));
}
