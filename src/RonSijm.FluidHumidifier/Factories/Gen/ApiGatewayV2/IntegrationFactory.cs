// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApiGatewayV2;

public class IntegrationFactory(string resourceName = null, Action<Humidifier.ApiGatewayV2.Integration> factoryAction = null) : ResourceFactory<Humidifier.ApiGatewayV2.Integration>(resourceName)
{

    internal InnerIntegrationTlsConfigFactory TlsConfigFactory { get; set; }

    protected override Humidifier.ApiGatewayV2.Integration Create()
    {
        var integrationResult = CreateIntegration();
        factoryAction?.Invoke(integrationResult);

        return integrationResult;
    }

    private Humidifier.ApiGatewayV2.Integration CreateIntegration()
    {
        var integrationResult = new Humidifier.ApiGatewayV2.Integration
        {
            GivenName = InputResourceName,
        };

        return integrationResult;
    }
    public override void CreateChildren(Humidifier.ApiGatewayV2.Integration result)
    {
        base.CreateChildren(result);

        result.TlsConfig ??= TlsConfigFactory?.Build();
    }

} // End Of Class

public static class IntegrationFactoryExtensions
{
    public static CombinedResult<IntegrationFactory, InnerIntegrationTlsConfigFactory> WithTlsConfig(this IntegrationFactory parentFactory, Action<Humidifier.ApiGatewayV2.IntegrationTypes.TlsConfig> subFactoryAction = null)
    {
        parentFactory.TlsConfigFactory = new InnerIntegrationTlsConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TlsConfigFactory);
    }

    public static CombinedResult<IntegrationFactory, T1, InnerIntegrationTlsConfigFactory> WithTlsConfig<T1>(this CombinedResult<IntegrationFactory, T1> combinedResult, Action<Humidifier.ApiGatewayV2.IntegrationTypes.TlsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithTlsConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IntegrationFactory, InnerIntegrationTlsConfigFactory> WithTlsConfig<T1>(this CombinedResult<T1, IntegrationFactory> combinedResult, Action<Humidifier.ApiGatewayV2.IntegrationTypes.TlsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithTlsConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<IntegrationFactory, T1, T2, InnerIntegrationTlsConfigFactory> WithTlsConfig<T1, T2>(this CombinedResult<IntegrationFactory, T1, T2> combinedResult, Action<Humidifier.ApiGatewayV2.IntegrationTypes.TlsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTlsConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IntegrationFactory, T2, InnerIntegrationTlsConfigFactory> WithTlsConfig<T1, T2>(this CombinedResult<T1, IntegrationFactory, T2> combinedResult, Action<Humidifier.ApiGatewayV2.IntegrationTypes.TlsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTlsConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IntegrationFactory, InnerIntegrationTlsConfigFactory> WithTlsConfig<T1, T2>(this CombinedResult<T1, T2, IntegrationFactory> combinedResult, Action<Humidifier.ApiGatewayV2.IntegrationTypes.TlsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTlsConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<IntegrationFactory, T1, T2, T3, InnerIntegrationTlsConfigFactory> WithTlsConfig<T1, T2, T3>(this CombinedResult<IntegrationFactory, T1, T2, T3> combinedResult, Action<Humidifier.ApiGatewayV2.IntegrationTypes.TlsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTlsConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IntegrationFactory, T2, T3, InnerIntegrationTlsConfigFactory> WithTlsConfig<T1, T2, T3>(this CombinedResult<T1, IntegrationFactory, T2, T3> combinedResult, Action<Humidifier.ApiGatewayV2.IntegrationTypes.TlsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTlsConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IntegrationFactory, T3, InnerIntegrationTlsConfigFactory> WithTlsConfig<T1, T2, T3>(this CombinedResult<T1, T2, IntegrationFactory, T3> combinedResult, Action<Humidifier.ApiGatewayV2.IntegrationTypes.TlsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTlsConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, IntegrationFactory, InnerIntegrationTlsConfigFactory> WithTlsConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, IntegrationFactory> combinedResult, Action<Humidifier.ApiGatewayV2.IntegrationTypes.TlsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTlsConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<IntegrationFactory, T1, T2, T3, T4, InnerIntegrationTlsConfigFactory> WithTlsConfig<T1, T2, T3, T4>(this CombinedResult<IntegrationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ApiGatewayV2.IntegrationTypes.TlsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTlsConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IntegrationFactory, T2, T3, T4, InnerIntegrationTlsConfigFactory> WithTlsConfig<T1, T2, T3, T4>(this CombinedResult<T1, IntegrationFactory, T2, T3, T4> combinedResult, Action<Humidifier.ApiGatewayV2.IntegrationTypes.TlsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTlsConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IntegrationFactory, T3, T4, InnerIntegrationTlsConfigFactory> WithTlsConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, IntegrationFactory, T3, T4> combinedResult, Action<Humidifier.ApiGatewayV2.IntegrationTypes.TlsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTlsConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, IntegrationFactory, T4, InnerIntegrationTlsConfigFactory> WithTlsConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, IntegrationFactory, T4> combinedResult, Action<Humidifier.ApiGatewayV2.IntegrationTypes.TlsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTlsConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, IntegrationFactory, InnerIntegrationTlsConfigFactory> WithTlsConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, IntegrationFactory> combinedResult, Action<Humidifier.ApiGatewayV2.IntegrationTypes.TlsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTlsConfig(combinedResult.T5, subFactoryAction));
}
