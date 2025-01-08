// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Logs;

public class IntegrationFactory(string resourceName = null, Action<Humidifier.Logs.Integration> factoryAction = null) : ResourceFactory<Humidifier.Logs.Integration>(resourceName)
{

    internal InnerIntegrationResourceConfigFactory ResourceConfigFactory { get; set; }

    protected override Humidifier.Logs.Integration Create()
    {
        var integrationResult = CreateIntegration();
        factoryAction?.Invoke(integrationResult);

        return integrationResult;
    }

    private Humidifier.Logs.Integration CreateIntegration()
    {
        var integrationResult = new Humidifier.Logs.Integration
        {
            GivenName = InputResourceName,
        };

        return integrationResult;
    }
    public override void CreateChildren(Humidifier.Logs.Integration result)
    {
        base.CreateChildren(result);

        result.ResourceConfig ??= ResourceConfigFactory?.Build();
    }

} // End Of Class

public static class IntegrationFactoryExtensions
{
    public static CombinedResult<IntegrationFactory, InnerIntegrationResourceConfigFactory> WithResourceConfig(this IntegrationFactory parentFactory, Action<Humidifier.Logs.IntegrationTypes.ResourceConfig> subFactoryAction = null)
    {
        parentFactory.ResourceConfigFactory = new InnerIntegrationResourceConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ResourceConfigFactory);
    }

    public static CombinedResult<IntegrationFactory, T1, InnerIntegrationResourceConfigFactory> WithResourceConfig<T1>(this CombinedResult<IntegrationFactory, T1> combinedResult, Action<Humidifier.Logs.IntegrationTypes.ResourceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithResourceConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IntegrationFactory, InnerIntegrationResourceConfigFactory> WithResourceConfig<T1>(this CombinedResult<T1, IntegrationFactory> combinedResult, Action<Humidifier.Logs.IntegrationTypes.ResourceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithResourceConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<IntegrationFactory, T1, T2, InnerIntegrationResourceConfigFactory> WithResourceConfig<T1, T2>(this CombinedResult<IntegrationFactory, T1, T2> combinedResult, Action<Humidifier.Logs.IntegrationTypes.ResourceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IntegrationFactory, T2, InnerIntegrationResourceConfigFactory> WithResourceConfig<T1, T2>(this CombinedResult<T1, IntegrationFactory, T2> combinedResult, Action<Humidifier.Logs.IntegrationTypes.ResourceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IntegrationFactory, InnerIntegrationResourceConfigFactory> WithResourceConfig<T1, T2>(this CombinedResult<T1, T2, IntegrationFactory> combinedResult, Action<Humidifier.Logs.IntegrationTypes.ResourceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<IntegrationFactory, T1, T2, T3, InnerIntegrationResourceConfigFactory> WithResourceConfig<T1, T2, T3>(this CombinedResult<IntegrationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Logs.IntegrationTypes.ResourceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IntegrationFactory, T2, T3, InnerIntegrationResourceConfigFactory> WithResourceConfig<T1, T2, T3>(this CombinedResult<T1, IntegrationFactory, T2, T3> combinedResult, Action<Humidifier.Logs.IntegrationTypes.ResourceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IntegrationFactory, T3, InnerIntegrationResourceConfigFactory> WithResourceConfig<T1, T2, T3>(this CombinedResult<T1, T2, IntegrationFactory, T3> combinedResult, Action<Humidifier.Logs.IntegrationTypes.ResourceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, IntegrationFactory, InnerIntegrationResourceConfigFactory> WithResourceConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, IntegrationFactory> combinedResult, Action<Humidifier.Logs.IntegrationTypes.ResourceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<IntegrationFactory, T1, T2, T3, T4, InnerIntegrationResourceConfigFactory> WithResourceConfig<T1, T2, T3, T4>(this CombinedResult<IntegrationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Logs.IntegrationTypes.ResourceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IntegrationFactory, T2, T3, T4, InnerIntegrationResourceConfigFactory> WithResourceConfig<T1, T2, T3, T4>(this CombinedResult<T1, IntegrationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Logs.IntegrationTypes.ResourceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IntegrationFactory, T3, T4, InnerIntegrationResourceConfigFactory> WithResourceConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, IntegrationFactory, T3, T4> combinedResult, Action<Humidifier.Logs.IntegrationTypes.ResourceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, IntegrationFactory, T4, InnerIntegrationResourceConfigFactory> WithResourceConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, IntegrationFactory, T4> combinedResult, Action<Humidifier.Logs.IntegrationTypes.ResourceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, IntegrationFactory, InnerIntegrationResourceConfigFactory> WithResourceConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, IntegrationFactory> combinedResult, Action<Humidifier.Logs.IntegrationTypes.ResourceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceConfig(combinedResult.T5, subFactoryAction));
}
