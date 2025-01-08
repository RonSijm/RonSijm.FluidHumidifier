// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Logs;

public class InnerIntegrationResourceConfigFactory(Action<Humidifier.Logs.IntegrationTypes.ResourceConfig> factoryAction = null) : SubResourceFactory<Humidifier.Logs.IntegrationTypes.ResourceConfig>
{

    internal InnerIntegrationOpenSearchResourceConfigFactory OpenSearchResourceConfigFactory { get; set; }

    protected override Humidifier.Logs.IntegrationTypes.ResourceConfig Create()
    {
        var resourceConfigResult = CreateResourceConfig();
        factoryAction?.Invoke(resourceConfigResult);

        return resourceConfigResult;
    }

    private Humidifier.Logs.IntegrationTypes.ResourceConfig CreateResourceConfig()
    {
        var resourceConfigResult = new Humidifier.Logs.IntegrationTypes.ResourceConfig();

        return resourceConfigResult;
    }
    public override void CreateChildren(Humidifier.Logs.IntegrationTypes.ResourceConfig result)
    {
        base.CreateChildren(result);

        result.OpenSearchResourceConfig ??= OpenSearchResourceConfigFactory?.Build();
    }

} // End Of Class

public static class InnerIntegrationResourceConfigFactoryExtensions
{
    public static CombinedResult<InnerIntegrationResourceConfigFactory, InnerIntegrationOpenSearchResourceConfigFactory> WithOpenSearchResourceConfig(this InnerIntegrationResourceConfigFactory parentFactory, Action<Humidifier.Logs.IntegrationTypes.OpenSearchResourceConfig> subFactoryAction = null)
    {
        parentFactory.OpenSearchResourceConfigFactory = new InnerIntegrationOpenSearchResourceConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OpenSearchResourceConfigFactory);
    }

    public static CombinedResult<InnerIntegrationResourceConfigFactory, T1, InnerIntegrationOpenSearchResourceConfigFactory> WithOpenSearchResourceConfig<T1>(this CombinedResult<InnerIntegrationResourceConfigFactory, T1> combinedResult, Action<Humidifier.Logs.IntegrationTypes.OpenSearchResourceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithOpenSearchResourceConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerIntegrationResourceConfigFactory, InnerIntegrationOpenSearchResourceConfigFactory> WithOpenSearchResourceConfig<T1>(this CombinedResult<T1, InnerIntegrationResourceConfigFactory> combinedResult, Action<Humidifier.Logs.IntegrationTypes.OpenSearchResourceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithOpenSearchResourceConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerIntegrationResourceConfigFactory, T1, T2, InnerIntegrationOpenSearchResourceConfigFactory> WithOpenSearchResourceConfig<T1, T2>(this CombinedResult<InnerIntegrationResourceConfigFactory, T1, T2> combinedResult, Action<Humidifier.Logs.IntegrationTypes.OpenSearchResourceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOpenSearchResourceConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerIntegrationResourceConfigFactory, T2, InnerIntegrationOpenSearchResourceConfigFactory> WithOpenSearchResourceConfig<T1, T2>(this CombinedResult<T1, InnerIntegrationResourceConfigFactory, T2> combinedResult, Action<Humidifier.Logs.IntegrationTypes.OpenSearchResourceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOpenSearchResourceConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerIntegrationResourceConfigFactory, InnerIntegrationOpenSearchResourceConfigFactory> WithOpenSearchResourceConfig<T1, T2>(this CombinedResult<T1, T2, InnerIntegrationResourceConfigFactory> combinedResult, Action<Humidifier.Logs.IntegrationTypes.OpenSearchResourceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOpenSearchResourceConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerIntegrationResourceConfigFactory, T1, T2, T3, InnerIntegrationOpenSearchResourceConfigFactory> WithOpenSearchResourceConfig<T1, T2, T3>(this CombinedResult<InnerIntegrationResourceConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.Logs.IntegrationTypes.OpenSearchResourceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOpenSearchResourceConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerIntegrationResourceConfigFactory, T2, T3, InnerIntegrationOpenSearchResourceConfigFactory> WithOpenSearchResourceConfig<T1, T2, T3>(this CombinedResult<T1, InnerIntegrationResourceConfigFactory, T2, T3> combinedResult, Action<Humidifier.Logs.IntegrationTypes.OpenSearchResourceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOpenSearchResourceConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerIntegrationResourceConfigFactory, T3, InnerIntegrationOpenSearchResourceConfigFactory> WithOpenSearchResourceConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerIntegrationResourceConfigFactory, T3> combinedResult, Action<Humidifier.Logs.IntegrationTypes.OpenSearchResourceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOpenSearchResourceConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerIntegrationResourceConfigFactory, InnerIntegrationOpenSearchResourceConfigFactory> WithOpenSearchResourceConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerIntegrationResourceConfigFactory> combinedResult, Action<Humidifier.Logs.IntegrationTypes.OpenSearchResourceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOpenSearchResourceConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerIntegrationResourceConfigFactory, T1, T2, T3, T4, InnerIntegrationOpenSearchResourceConfigFactory> WithOpenSearchResourceConfig<T1, T2, T3, T4>(this CombinedResult<InnerIntegrationResourceConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Logs.IntegrationTypes.OpenSearchResourceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOpenSearchResourceConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerIntegrationResourceConfigFactory, T2, T3, T4, InnerIntegrationOpenSearchResourceConfigFactory> WithOpenSearchResourceConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerIntegrationResourceConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.Logs.IntegrationTypes.OpenSearchResourceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOpenSearchResourceConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerIntegrationResourceConfigFactory, T3, T4, InnerIntegrationOpenSearchResourceConfigFactory> WithOpenSearchResourceConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerIntegrationResourceConfigFactory, T3, T4> combinedResult, Action<Humidifier.Logs.IntegrationTypes.OpenSearchResourceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOpenSearchResourceConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerIntegrationResourceConfigFactory, T4, InnerIntegrationOpenSearchResourceConfigFactory> WithOpenSearchResourceConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerIntegrationResourceConfigFactory, T4> combinedResult, Action<Humidifier.Logs.IntegrationTypes.OpenSearchResourceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOpenSearchResourceConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerIntegrationResourceConfigFactory, InnerIntegrationOpenSearchResourceConfigFactory> WithOpenSearchResourceConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerIntegrationResourceConfigFactory> combinedResult, Action<Humidifier.Logs.IntegrationTypes.OpenSearchResourceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOpenSearchResourceConfig(combinedResult.T5, subFactoryAction));
}
