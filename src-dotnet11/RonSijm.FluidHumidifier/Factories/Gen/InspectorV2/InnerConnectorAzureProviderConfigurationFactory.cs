// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.InspectorV2;

public class InnerConnectorAzureProviderConfigurationFactory(Action<Humidifier.InspectorV2.ConnectorTypes.AzureProviderConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.InspectorV2.ConnectorTypes.AzureProviderConfiguration>
{

    internal InnerConnectorAzureScopeConfigurationMapFactory ScopeConfigurationFactory { get; set; }

    protected override Humidifier.InspectorV2.ConnectorTypes.AzureProviderConfiguration Create()
    {
        var azureProviderConfigurationResult = CreateAzureProviderConfiguration();
        factoryAction?.Invoke(azureProviderConfigurationResult);

        return azureProviderConfigurationResult;
    }

    private Humidifier.InspectorV2.ConnectorTypes.AzureProviderConfiguration CreateAzureProviderConfiguration()
    {
        var azureProviderConfigurationResult = new Humidifier.InspectorV2.ConnectorTypes.AzureProviderConfiguration();

        return azureProviderConfigurationResult;
    }
    public override void CreateChildren(Humidifier.InspectorV2.ConnectorTypes.AzureProviderConfiguration result)
    {
        base.CreateChildren(result);

        result.ScopeConfiguration ??= ScopeConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerConnectorAzureProviderConfigurationFactoryExtensions
{
    public static CombinedResult<InnerConnectorAzureProviderConfigurationFactory, InnerConnectorAzureScopeConfigurationMapFactory> WithScopeConfiguration(this InnerConnectorAzureProviderConfigurationFactory parentFactory, Action<Humidifier.InspectorV2.ConnectorTypes.AzureScopeConfigurationMap> subFactoryAction = null)
    {
        parentFactory.ScopeConfigurationFactory = new InnerConnectorAzureScopeConfigurationMapFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ScopeConfigurationFactory);
    }

    public static CombinedResult<InnerConnectorAzureProviderConfigurationFactory, T1, InnerConnectorAzureScopeConfigurationMapFactory> WithScopeConfiguration<T1>(this CombinedResult<InnerConnectorAzureProviderConfigurationFactory, T1> combinedResult, Action<Humidifier.InspectorV2.ConnectorTypes.AzureScopeConfigurationMap> subFactoryAction = null) => new (combinedResult, combinedResult, WithScopeConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConnectorAzureProviderConfigurationFactory, InnerConnectorAzureScopeConfigurationMapFactory> WithScopeConfiguration<T1>(this CombinedResult<T1, InnerConnectorAzureProviderConfigurationFactory> combinedResult, Action<Humidifier.InspectorV2.ConnectorTypes.AzureScopeConfigurationMap> subFactoryAction = null) => new (combinedResult, combinedResult, WithScopeConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerConnectorAzureProviderConfigurationFactory, T1, T2, InnerConnectorAzureScopeConfigurationMapFactory> WithScopeConfiguration<T1, T2>(this CombinedResult<InnerConnectorAzureProviderConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.InspectorV2.ConnectorTypes.AzureScopeConfigurationMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScopeConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConnectorAzureProviderConfigurationFactory, T2, InnerConnectorAzureScopeConfigurationMapFactory> WithScopeConfiguration<T1, T2>(this CombinedResult<T1, InnerConnectorAzureProviderConfigurationFactory, T2> combinedResult, Action<Humidifier.InspectorV2.ConnectorTypes.AzureScopeConfigurationMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScopeConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConnectorAzureProviderConfigurationFactory, InnerConnectorAzureScopeConfigurationMapFactory> WithScopeConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerConnectorAzureProviderConfigurationFactory> combinedResult, Action<Humidifier.InspectorV2.ConnectorTypes.AzureScopeConfigurationMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScopeConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerConnectorAzureProviderConfigurationFactory, T1, T2, T3, InnerConnectorAzureScopeConfigurationMapFactory> WithScopeConfiguration<T1, T2, T3>(this CombinedResult<InnerConnectorAzureProviderConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.InspectorV2.ConnectorTypes.AzureScopeConfigurationMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScopeConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConnectorAzureProviderConfigurationFactory, T2, T3, InnerConnectorAzureScopeConfigurationMapFactory> WithScopeConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerConnectorAzureProviderConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.InspectorV2.ConnectorTypes.AzureScopeConfigurationMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScopeConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConnectorAzureProviderConfigurationFactory, T3, InnerConnectorAzureScopeConfigurationMapFactory> WithScopeConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerConnectorAzureProviderConfigurationFactory, T3> combinedResult, Action<Humidifier.InspectorV2.ConnectorTypes.AzureScopeConfigurationMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScopeConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerConnectorAzureProviderConfigurationFactory, InnerConnectorAzureScopeConfigurationMapFactory> WithScopeConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerConnectorAzureProviderConfigurationFactory> combinedResult, Action<Humidifier.InspectorV2.ConnectorTypes.AzureScopeConfigurationMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScopeConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerConnectorAzureProviderConfigurationFactory, T1, T2, T3, T4, InnerConnectorAzureScopeConfigurationMapFactory> WithScopeConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerConnectorAzureProviderConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.InspectorV2.ConnectorTypes.AzureScopeConfigurationMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScopeConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConnectorAzureProviderConfigurationFactory, T2, T3, T4, InnerConnectorAzureScopeConfigurationMapFactory> WithScopeConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerConnectorAzureProviderConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.InspectorV2.ConnectorTypes.AzureScopeConfigurationMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScopeConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConnectorAzureProviderConfigurationFactory, T3, T4, InnerConnectorAzureScopeConfigurationMapFactory> WithScopeConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerConnectorAzureProviderConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.InspectorV2.ConnectorTypes.AzureScopeConfigurationMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScopeConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerConnectorAzureProviderConfigurationFactory, T4, InnerConnectorAzureScopeConfigurationMapFactory> WithScopeConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerConnectorAzureProviderConfigurationFactory, T4> combinedResult, Action<Humidifier.InspectorV2.ConnectorTypes.AzureScopeConfigurationMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScopeConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerConnectorAzureProviderConfigurationFactory, InnerConnectorAzureScopeConfigurationMapFactory> WithScopeConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerConnectorAzureProviderConfigurationFactory> combinedResult, Action<Humidifier.InspectorV2.ConnectorTypes.AzureScopeConfigurationMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScopeConfiguration(combinedResult.T5, subFactoryAction).T2);
}
