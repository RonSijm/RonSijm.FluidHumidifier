// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecurityHub;

public class InnerConnectorV2AzureProviderConfigurationFactory(Action<Humidifier.SecurityHub.ConnectorV2Types.AzureProviderConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.SecurityHub.ConnectorV2Types.AzureProviderConfiguration>
{

    internal InnerConnectorV2AzureScopeConfigurationFactory ScopeConfigurationFactory { get; set; }

    protected override Humidifier.SecurityHub.ConnectorV2Types.AzureProviderConfiguration Create()
    {
        var azureProviderConfigurationResult = CreateAzureProviderConfiguration();
        factoryAction?.Invoke(azureProviderConfigurationResult);

        return azureProviderConfigurationResult;
    }

    private Humidifier.SecurityHub.ConnectorV2Types.AzureProviderConfiguration CreateAzureProviderConfiguration()
    {
        var azureProviderConfigurationResult = new Humidifier.SecurityHub.ConnectorV2Types.AzureProviderConfiguration();

        return azureProviderConfigurationResult;
    }
    public override void CreateChildren(Humidifier.SecurityHub.ConnectorV2Types.AzureProviderConfiguration result)
    {
        base.CreateChildren(result);

        result.ScopeConfiguration ??= ScopeConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerConnectorV2AzureProviderConfigurationFactoryExtensions
{
    public static CombinedResult<InnerConnectorV2AzureProviderConfigurationFactory, InnerConnectorV2AzureScopeConfigurationFactory> WithScopeConfiguration(this InnerConnectorV2AzureProviderConfigurationFactory parentFactory, Action<Humidifier.SecurityHub.ConnectorV2Types.AzureScopeConfiguration> subFactoryAction = null)
    {
        parentFactory.ScopeConfigurationFactory = new InnerConnectorV2AzureScopeConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ScopeConfigurationFactory);
    }

    public static CombinedResult<InnerConnectorV2AzureProviderConfigurationFactory, T1, InnerConnectorV2AzureScopeConfigurationFactory> WithScopeConfiguration<T1>(this CombinedResult<InnerConnectorV2AzureProviderConfigurationFactory, T1> combinedResult, Action<Humidifier.SecurityHub.ConnectorV2Types.AzureScopeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithScopeConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConnectorV2AzureProviderConfigurationFactory, InnerConnectorV2AzureScopeConfigurationFactory> WithScopeConfiguration<T1>(this CombinedResult<T1, InnerConnectorV2AzureProviderConfigurationFactory> combinedResult, Action<Humidifier.SecurityHub.ConnectorV2Types.AzureScopeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithScopeConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerConnectorV2AzureProviderConfigurationFactory, T1, T2, InnerConnectorV2AzureScopeConfigurationFactory> WithScopeConfiguration<T1, T2>(this CombinedResult<InnerConnectorV2AzureProviderConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.SecurityHub.ConnectorV2Types.AzureScopeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScopeConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConnectorV2AzureProviderConfigurationFactory, T2, InnerConnectorV2AzureScopeConfigurationFactory> WithScopeConfiguration<T1, T2>(this CombinedResult<T1, InnerConnectorV2AzureProviderConfigurationFactory, T2> combinedResult, Action<Humidifier.SecurityHub.ConnectorV2Types.AzureScopeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScopeConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConnectorV2AzureProviderConfigurationFactory, InnerConnectorV2AzureScopeConfigurationFactory> WithScopeConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerConnectorV2AzureProviderConfigurationFactory> combinedResult, Action<Humidifier.SecurityHub.ConnectorV2Types.AzureScopeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScopeConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerConnectorV2AzureProviderConfigurationFactory, T1, T2, T3, InnerConnectorV2AzureScopeConfigurationFactory> WithScopeConfiguration<T1, T2, T3>(this CombinedResult<InnerConnectorV2AzureProviderConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.SecurityHub.ConnectorV2Types.AzureScopeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScopeConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConnectorV2AzureProviderConfigurationFactory, T2, T3, InnerConnectorV2AzureScopeConfigurationFactory> WithScopeConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerConnectorV2AzureProviderConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.SecurityHub.ConnectorV2Types.AzureScopeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScopeConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConnectorV2AzureProviderConfigurationFactory, T3, InnerConnectorV2AzureScopeConfigurationFactory> WithScopeConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerConnectorV2AzureProviderConfigurationFactory, T3> combinedResult, Action<Humidifier.SecurityHub.ConnectorV2Types.AzureScopeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScopeConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerConnectorV2AzureProviderConfigurationFactory, InnerConnectorV2AzureScopeConfigurationFactory> WithScopeConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerConnectorV2AzureProviderConfigurationFactory> combinedResult, Action<Humidifier.SecurityHub.ConnectorV2Types.AzureScopeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScopeConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerConnectorV2AzureProviderConfigurationFactory, T1, T2, T3, T4, InnerConnectorV2AzureScopeConfigurationFactory> WithScopeConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerConnectorV2AzureProviderConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SecurityHub.ConnectorV2Types.AzureScopeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScopeConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConnectorV2AzureProviderConfigurationFactory, T2, T3, T4, InnerConnectorV2AzureScopeConfigurationFactory> WithScopeConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerConnectorV2AzureProviderConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.SecurityHub.ConnectorV2Types.AzureScopeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScopeConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConnectorV2AzureProviderConfigurationFactory, T3, T4, InnerConnectorV2AzureScopeConfigurationFactory> WithScopeConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerConnectorV2AzureProviderConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.SecurityHub.ConnectorV2Types.AzureScopeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScopeConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerConnectorV2AzureProviderConfigurationFactory, T4, InnerConnectorV2AzureScopeConfigurationFactory> WithScopeConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerConnectorV2AzureProviderConfigurationFactory, T4> combinedResult, Action<Humidifier.SecurityHub.ConnectorV2Types.AzureScopeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScopeConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerConnectorV2AzureProviderConfigurationFactory, InnerConnectorV2AzureScopeConfigurationFactory> WithScopeConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerConnectorV2AzureProviderConfigurationFactory> combinedResult, Action<Humidifier.SecurityHub.ConnectorV2Types.AzureScopeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScopeConfiguration(combinedResult.T5, subFactoryAction).T2);
}
