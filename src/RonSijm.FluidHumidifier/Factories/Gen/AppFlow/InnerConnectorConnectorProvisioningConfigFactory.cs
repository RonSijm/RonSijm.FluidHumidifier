// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerConnectorConnectorProvisioningConfigFactory(Action<Humidifier.AppFlow.ConnectorTypes.ConnectorProvisioningConfig> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.ConnectorTypes.ConnectorProvisioningConfig>
{

    internal InnerConnectorLambdaConnectorProvisioningConfigFactory LambdaFactory { get; set; }

    protected override Humidifier.AppFlow.ConnectorTypes.ConnectorProvisioningConfig Create()
    {
        var connectorProvisioningConfigResult = CreateConnectorProvisioningConfig();
        factoryAction?.Invoke(connectorProvisioningConfigResult);

        return connectorProvisioningConfigResult;
    }

    private Humidifier.AppFlow.ConnectorTypes.ConnectorProvisioningConfig CreateConnectorProvisioningConfig()
    {
        var connectorProvisioningConfigResult = new Humidifier.AppFlow.ConnectorTypes.ConnectorProvisioningConfig();

        return connectorProvisioningConfigResult;
    }
    public override void CreateChildren(Humidifier.AppFlow.ConnectorTypes.ConnectorProvisioningConfig result)
    {
        base.CreateChildren(result);

        result.Lambda ??= LambdaFactory?.Build();
    }

} // End Of Class

public static class InnerConnectorConnectorProvisioningConfigFactoryExtensions
{
    public static CombinedResult<InnerConnectorConnectorProvisioningConfigFactory, InnerConnectorLambdaConnectorProvisioningConfigFactory> WithLambda(this InnerConnectorConnectorProvisioningConfigFactory parentFactory, Action<Humidifier.AppFlow.ConnectorTypes.LambdaConnectorProvisioningConfig> subFactoryAction = null)
    {
        parentFactory.LambdaFactory = new InnerConnectorLambdaConnectorProvisioningConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LambdaFactory);
    }

    public static CombinedResult<InnerConnectorConnectorProvisioningConfigFactory, T1, InnerConnectorLambdaConnectorProvisioningConfigFactory> WithLambda<T1>(this CombinedResult<InnerConnectorConnectorProvisioningConfigFactory, T1> combinedResult, Action<Humidifier.AppFlow.ConnectorTypes.LambdaConnectorProvisioningConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithLambda(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectorConnectorProvisioningConfigFactory, InnerConnectorLambdaConnectorProvisioningConfigFactory> WithLambda<T1>(this CombinedResult<T1, InnerConnectorConnectorProvisioningConfigFactory> combinedResult, Action<Humidifier.AppFlow.ConnectorTypes.LambdaConnectorProvisioningConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithLambda(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerConnectorConnectorProvisioningConfigFactory, T1, T2, InnerConnectorLambdaConnectorProvisioningConfigFactory> WithLambda<T1, T2>(this CombinedResult<InnerConnectorConnectorProvisioningConfigFactory, T1, T2> combinedResult, Action<Humidifier.AppFlow.ConnectorTypes.LambdaConnectorProvisioningConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLambda(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectorConnectorProvisioningConfigFactory, T2, InnerConnectorLambdaConnectorProvisioningConfigFactory> WithLambda<T1, T2>(this CombinedResult<T1, InnerConnectorConnectorProvisioningConfigFactory, T2> combinedResult, Action<Humidifier.AppFlow.ConnectorTypes.LambdaConnectorProvisioningConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLambda(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConnectorConnectorProvisioningConfigFactory, InnerConnectorLambdaConnectorProvisioningConfigFactory> WithLambda<T1, T2>(this CombinedResult<T1, T2, InnerConnectorConnectorProvisioningConfigFactory> combinedResult, Action<Humidifier.AppFlow.ConnectorTypes.LambdaConnectorProvisioningConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLambda(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerConnectorConnectorProvisioningConfigFactory, T1, T2, T3, InnerConnectorLambdaConnectorProvisioningConfigFactory> WithLambda<T1, T2, T3>(this CombinedResult<InnerConnectorConnectorProvisioningConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppFlow.ConnectorTypes.LambdaConnectorProvisioningConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLambda(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectorConnectorProvisioningConfigFactory, T2, T3, InnerConnectorLambdaConnectorProvisioningConfigFactory> WithLambda<T1, T2, T3>(this CombinedResult<T1, InnerConnectorConnectorProvisioningConfigFactory, T2, T3> combinedResult, Action<Humidifier.AppFlow.ConnectorTypes.LambdaConnectorProvisioningConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLambda(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConnectorConnectorProvisioningConfigFactory, T3, InnerConnectorLambdaConnectorProvisioningConfigFactory> WithLambda<T1, T2, T3>(this CombinedResult<T1, T2, InnerConnectorConnectorProvisioningConfigFactory, T3> combinedResult, Action<Humidifier.AppFlow.ConnectorTypes.LambdaConnectorProvisioningConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLambda(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConnectorConnectorProvisioningConfigFactory, InnerConnectorLambdaConnectorProvisioningConfigFactory> WithLambda<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerConnectorConnectorProvisioningConfigFactory> combinedResult, Action<Humidifier.AppFlow.ConnectorTypes.LambdaConnectorProvisioningConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLambda(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerConnectorConnectorProvisioningConfigFactory, T1, T2, T3, T4, InnerConnectorLambdaConnectorProvisioningConfigFactory> WithLambda<T1, T2, T3, T4>(this CombinedResult<InnerConnectorConnectorProvisioningConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppFlow.ConnectorTypes.LambdaConnectorProvisioningConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLambda(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectorConnectorProvisioningConfigFactory, T2, T3, T4, InnerConnectorLambdaConnectorProvisioningConfigFactory> WithLambda<T1, T2, T3, T4>(this CombinedResult<T1, InnerConnectorConnectorProvisioningConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppFlow.ConnectorTypes.LambdaConnectorProvisioningConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLambda(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConnectorConnectorProvisioningConfigFactory, T3, T4, InnerConnectorLambdaConnectorProvisioningConfigFactory> WithLambda<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerConnectorConnectorProvisioningConfigFactory, T3, T4> combinedResult, Action<Humidifier.AppFlow.ConnectorTypes.LambdaConnectorProvisioningConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLambda(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConnectorConnectorProvisioningConfigFactory, T4, InnerConnectorLambdaConnectorProvisioningConfigFactory> WithLambda<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerConnectorConnectorProvisioningConfigFactory, T4> combinedResult, Action<Humidifier.AppFlow.ConnectorTypes.LambdaConnectorProvisioningConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLambda(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerConnectorConnectorProvisioningConfigFactory, InnerConnectorLambdaConnectorProvisioningConfigFactory> WithLambda<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerConnectorConnectorProvisioningConfigFactory> combinedResult, Action<Humidifier.AppFlow.ConnectorTypes.LambdaConnectorProvisioningConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLambda(combinedResult.T5, subFactoryAction));
}
