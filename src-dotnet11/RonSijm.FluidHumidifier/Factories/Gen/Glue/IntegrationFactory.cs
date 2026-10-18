// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class IntegrationFactory(string resourceName = null, Action<Humidifier.Glue.Integration> factoryAction = null) : ResourceFactory<Humidifier.Glue.Integration>(resourceName)
{

    internal InnerIntegrationIntegrationConfigFactory IntegrationConfigFactory { get; set; }

    protected override Humidifier.Glue.Integration Create()
    {
        var integrationResult = CreateIntegration();
        factoryAction?.Invoke(integrationResult);

        return integrationResult;
    }

    private Humidifier.Glue.Integration CreateIntegration()
    {
        var integrationResult = new Humidifier.Glue.Integration
        {
            GivenName = InputResourceName,
        };

        return integrationResult;
    }
    public override void CreateChildren(Humidifier.Glue.Integration result)
    {
        base.CreateChildren(result);

        result.IntegrationConfig ??= IntegrationConfigFactory?.Build();
    }

} // End Of Class

public static class IntegrationFactoryExtensions
{
    public static CombinedResult<IntegrationFactory, InnerIntegrationIntegrationConfigFactory> WithIntegrationConfig(this IntegrationFactory parentFactory, Action<Humidifier.Glue.IntegrationTypes.IntegrationConfig> subFactoryAction = null)
    {
        parentFactory.IntegrationConfigFactory = new InnerIntegrationIntegrationConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.IntegrationConfigFactory);
    }

    public static CombinedResult<IntegrationFactory, T1, InnerIntegrationIntegrationConfigFactory> WithIntegrationConfig<T1>(this CombinedResult<IntegrationFactory, T1> combinedResult, Action<Humidifier.Glue.IntegrationTypes.IntegrationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithIntegrationConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, IntegrationFactory, InnerIntegrationIntegrationConfigFactory> WithIntegrationConfig<T1>(this CombinedResult<T1, IntegrationFactory> combinedResult, Action<Humidifier.Glue.IntegrationTypes.IntegrationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithIntegrationConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<IntegrationFactory, T1, T2, InnerIntegrationIntegrationConfigFactory> WithIntegrationConfig<T1, T2>(this CombinedResult<IntegrationFactory, T1, T2> combinedResult, Action<Humidifier.Glue.IntegrationTypes.IntegrationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIntegrationConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, IntegrationFactory, T2, InnerIntegrationIntegrationConfigFactory> WithIntegrationConfig<T1, T2>(this CombinedResult<T1, IntegrationFactory, T2> combinedResult, Action<Humidifier.Glue.IntegrationTypes.IntegrationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIntegrationConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, IntegrationFactory, InnerIntegrationIntegrationConfigFactory> WithIntegrationConfig<T1, T2>(this CombinedResult<T1, T2, IntegrationFactory> combinedResult, Action<Humidifier.Glue.IntegrationTypes.IntegrationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIntegrationConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<IntegrationFactory, T1, T2, T3, InnerIntegrationIntegrationConfigFactory> WithIntegrationConfig<T1, T2, T3>(this CombinedResult<IntegrationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Glue.IntegrationTypes.IntegrationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIntegrationConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, IntegrationFactory, T2, T3, InnerIntegrationIntegrationConfigFactory> WithIntegrationConfig<T1, T2, T3>(this CombinedResult<T1, IntegrationFactory, T2, T3> combinedResult, Action<Humidifier.Glue.IntegrationTypes.IntegrationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIntegrationConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, IntegrationFactory, T3, InnerIntegrationIntegrationConfigFactory> WithIntegrationConfig<T1, T2, T3>(this CombinedResult<T1, T2, IntegrationFactory, T3> combinedResult, Action<Humidifier.Glue.IntegrationTypes.IntegrationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIntegrationConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, IntegrationFactory, InnerIntegrationIntegrationConfigFactory> WithIntegrationConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, IntegrationFactory> combinedResult, Action<Humidifier.Glue.IntegrationTypes.IntegrationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIntegrationConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<IntegrationFactory, T1, T2, T3, T4, InnerIntegrationIntegrationConfigFactory> WithIntegrationConfig<T1, T2, T3, T4>(this CombinedResult<IntegrationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Glue.IntegrationTypes.IntegrationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIntegrationConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, IntegrationFactory, T2, T3, T4, InnerIntegrationIntegrationConfigFactory> WithIntegrationConfig<T1, T2, T3, T4>(this CombinedResult<T1, IntegrationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Glue.IntegrationTypes.IntegrationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIntegrationConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, IntegrationFactory, T3, T4, InnerIntegrationIntegrationConfigFactory> WithIntegrationConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, IntegrationFactory, T3, T4> combinedResult, Action<Humidifier.Glue.IntegrationTypes.IntegrationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIntegrationConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, IntegrationFactory, T4, InnerIntegrationIntegrationConfigFactory> WithIntegrationConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, IntegrationFactory, T4> combinedResult, Action<Humidifier.Glue.IntegrationTypes.IntegrationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIntegrationConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, IntegrationFactory, InnerIntegrationIntegrationConfigFactory> WithIntegrationConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, IntegrationFactory> combinedResult, Action<Humidifier.Glue.IntegrationTypes.IntegrationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIntegrationConfig(combinedResult.T5, subFactoryAction).T2);
}
