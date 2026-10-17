// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecurityHub;

public class InnerConnectorAzureProviderConfigurationFactory(Action<Humidifier.SecurityHub.ConnectorTypes.AzureProviderConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.SecurityHub.ConnectorTypes.AzureProviderConfiguration>
{

    internal InnerConnectorAzureScopeConfigurationFactory ScopeConfigurationFactory { get; set; }

    protected override Humidifier.SecurityHub.ConnectorTypes.AzureProviderConfiguration Create()
    {
        var azureProviderConfigurationResult = CreateAzureProviderConfiguration();
        factoryAction?.Invoke(azureProviderConfigurationResult);

        return azureProviderConfigurationResult;
    }

    private Humidifier.SecurityHub.ConnectorTypes.AzureProviderConfiguration CreateAzureProviderConfiguration()
    {
        var azureProviderConfigurationResult = new Humidifier.SecurityHub.ConnectorTypes.AzureProviderConfiguration();

        return azureProviderConfigurationResult;
    }
    public override void CreateChildren(Humidifier.SecurityHub.ConnectorTypes.AzureProviderConfiguration result)
    {
        base.CreateChildren(result);

        result.ScopeConfiguration ??= ScopeConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerConnectorAzureProviderConfigurationFactoryExtensions
{
    public static CombinedResult<InnerConnectorAzureProviderConfigurationFactory, InnerConnectorAzureScopeConfigurationFactory> WithScopeConfiguration(this InnerConnectorAzureProviderConfigurationFactory parentFactory, Action<Humidifier.SecurityHub.ConnectorTypes.AzureScopeConfiguration> subFactoryAction = null)
    {
        parentFactory.ScopeConfigurationFactory = new InnerConnectorAzureScopeConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ScopeConfigurationFactory);
    }

    public static CombinedResult<InnerConnectorAzureProviderConfigurationFactory, T1, InnerConnectorAzureScopeConfigurationFactory> WithScopeConfiguration<T1>(this CombinedResult<InnerConnectorAzureProviderConfigurationFactory, T1> combinedResult, Action<Humidifier.SecurityHub.ConnectorTypes.AzureScopeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithScopeConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConnectorAzureProviderConfigurationFactory, InnerConnectorAzureScopeConfigurationFactory> WithScopeConfiguration<T1>(this CombinedResult<T1, InnerConnectorAzureProviderConfigurationFactory> combinedResult, Action<Humidifier.SecurityHub.ConnectorTypes.AzureScopeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithScopeConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerConnectorAzureProviderConfigurationFactory, T1, T2, InnerConnectorAzureScopeConfigurationFactory> WithScopeConfiguration<T1, T2>(this CombinedResult<InnerConnectorAzureProviderConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.SecurityHub.ConnectorTypes.AzureScopeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScopeConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConnectorAzureProviderConfigurationFactory, T2, InnerConnectorAzureScopeConfigurationFactory> WithScopeConfiguration<T1, T2>(this CombinedResult<T1, InnerConnectorAzureProviderConfigurationFactory, T2> combinedResult, Action<Humidifier.SecurityHub.ConnectorTypes.AzureScopeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScopeConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConnectorAzureProviderConfigurationFactory, InnerConnectorAzureScopeConfigurationFactory> WithScopeConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerConnectorAzureProviderConfigurationFactory> combinedResult, Action<Humidifier.SecurityHub.ConnectorTypes.AzureScopeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScopeConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerConnectorAzureProviderConfigurationFactory, T1, T2, T3, InnerConnectorAzureScopeConfigurationFactory> WithScopeConfiguration<T1, T2, T3>(this CombinedResult<InnerConnectorAzureProviderConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.SecurityHub.ConnectorTypes.AzureScopeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScopeConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConnectorAzureProviderConfigurationFactory, T2, T3, InnerConnectorAzureScopeConfigurationFactory> WithScopeConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerConnectorAzureProviderConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.SecurityHub.ConnectorTypes.AzureScopeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScopeConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConnectorAzureProviderConfigurationFactory, T3, InnerConnectorAzureScopeConfigurationFactory> WithScopeConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerConnectorAzureProviderConfigurationFactory, T3> combinedResult, Action<Humidifier.SecurityHub.ConnectorTypes.AzureScopeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScopeConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerConnectorAzureProviderConfigurationFactory, InnerConnectorAzureScopeConfigurationFactory> WithScopeConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerConnectorAzureProviderConfigurationFactory> combinedResult, Action<Humidifier.SecurityHub.ConnectorTypes.AzureScopeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScopeConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerConnectorAzureProviderConfigurationFactory, T1, T2, T3, T4, InnerConnectorAzureScopeConfigurationFactory> WithScopeConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerConnectorAzureProviderConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SecurityHub.ConnectorTypes.AzureScopeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScopeConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConnectorAzureProviderConfigurationFactory, T2, T3, T4, InnerConnectorAzureScopeConfigurationFactory> WithScopeConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerConnectorAzureProviderConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.SecurityHub.ConnectorTypes.AzureScopeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScopeConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConnectorAzureProviderConfigurationFactory, T3, T4, InnerConnectorAzureScopeConfigurationFactory> WithScopeConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerConnectorAzureProviderConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.SecurityHub.ConnectorTypes.AzureScopeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScopeConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerConnectorAzureProviderConfigurationFactory, T4, InnerConnectorAzureScopeConfigurationFactory> WithScopeConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerConnectorAzureProviderConfigurationFactory, T4> combinedResult, Action<Humidifier.SecurityHub.ConnectorTypes.AzureScopeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScopeConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerConnectorAzureProviderConfigurationFactory, InnerConnectorAzureScopeConfigurationFactory> WithScopeConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerConnectorAzureProviderConfigurationFactory> combinedResult, Action<Humidifier.SecurityHub.ConnectorTypes.AzureScopeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScopeConfiguration(combinedResult.T5, subFactoryAction).T2);
}
