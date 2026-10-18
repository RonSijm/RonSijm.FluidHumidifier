// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecurityHub;

public class InnerConnectorProviderFactory(Action<Humidifier.SecurityHub.ConnectorTypes.Provider> factoryAction = null) : SubResourceFactory<Humidifier.SecurityHub.ConnectorTypes.Provider>
{

    internal InnerConnectorAzureProviderConfigurationFactory AzureFactory { get; set; }

    protected override Humidifier.SecurityHub.ConnectorTypes.Provider Create()
    {
        var providerResult = CreateProvider();
        factoryAction?.Invoke(providerResult);

        return providerResult;
    }

    private Humidifier.SecurityHub.ConnectorTypes.Provider CreateProvider()
    {
        var providerResult = new Humidifier.SecurityHub.ConnectorTypes.Provider();

        return providerResult;
    }
    public override void CreateChildren(Humidifier.SecurityHub.ConnectorTypes.Provider result)
    {
        base.CreateChildren(result);

        result.Azure ??= AzureFactory?.Build();
    }

} // End Of Class

public static class InnerConnectorProviderFactoryExtensions
{
    public static CombinedResult<InnerConnectorProviderFactory, InnerConnectorAzureProviderConfigurationFactory> WithAzure(this InnerConnectorProviderFactory parentFactory, Action<Humidifier.SecurityHub.ConnectorTypes.AzureProviderConfiguration> subFactoryAction = null)
    {
        parentFactory.AzureFactory = new InnerConnectorAzureProviderConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AzureFactory);
    }

    public static CombinedResult<InnerConnectorProviderFactory, T1, InnerConnectorAzureProviderConfigurationFactory> WithAzure<T1>(this CombinedResult<InnerConnectorProviderFactory, T1> combinedResult, Action<Humidifier.SecurityHub.ConnectorTypes.AzureProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithAzure(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConnectorProviderFactory, InnerConnectorAzureProviderConfigurationFactory> WithAzure<T1>(this CombinedResult<T1, InnerConnectorProviderFactory> combinedResult, Action<Humidifier.SecurityHub.ConnectorTypes.AzureProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithAzure(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerConnectorProviderFactory, T1, T2, InnerConnectorAzureProviderConfigurationFactory> WithAzure<T1, T2>(this CombinedResult<InnerConnectorProviderFactory, T1, T2> combinedResult, Action<Humidifier.SecurityHub.ConnectorTypes.AzureProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAzure(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConnectorProviderFactory, T2, InnerConnectorAzureProviderConfigurationFactory> WithAzure<T1, T2>(this CombinedResult<T1, InnerConnectorProviderFactory, T2> combinedResult, Action<Humidifier.SecurityHub.ConnectorTypes.AzureProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAzure(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConnectorProviderFactory, InnerConnectorAzureProviderConfigurationFactory> WithAzure<T1, T2>(this CombinedResult<T1, T2, InnerConnectorProviderFactory> combinedResult, Action<Humidifier.SecurityHub.ConnectorTypes.AzureProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAzure(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerConnectorProviderFactory, T1, T2, T3, InnerConnectorAzureProviderConfigurationFactory> WithAzure<T1, T2, T3>(this CombinedResult<InnerConnectorProviderFactory, T1, T2, T3> combinedResult, Action<Humidifier.SecurityHub.ConnectorTypes.AzureProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAzure(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConnectorProviderFactory, T2, T3, InnerConnectorAzureProviderConfigurationFactory> WithAzure<T1, T2, T3>(this CombinedResult<T1, InnerConnectorProviderFactory, T2, T3> combinedResult, Action<Humidifier.SecurityHub.ConnectorTypes.AzureProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAzure(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConnectorProviderFactory, T3, InnerConnectorAzureProviderConfigurationFactory> WithAzure<T1, T2, T3>(this CombinedResult<T1, T2, InnerConnectorProviderFactory, T3> combinedResult, Action<Humidifier.SecurityHub.ConnectorTypes.AzureProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAzure(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerConnectorProviderFactory, InnerConnectorAzureProviderConfigurationFactory> WithAzure<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerConnectorProviderFactory> combinedResult, Action<Humidifier.SecurityHub.ConnectorTypes.AzureProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAzure(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerConnectorProviderFactory, T1, T2, T3, T4, InnerConnectorAzureProviderConfigurationFactory> WithAzure<T1, T2, T3, T4>(this CombinedResult<InnerConnectorProviderFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SecurityHub.ConnectorTypes.AzureProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAzure(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConnectorProviderFactory, T2, T3, T4, InnerConnectorAzureProviderConfigurationFactory> WithAzure<T1, T2, T3, T4>(this CombinedResult<T1, InnerConnectorProviderFactory, T2, T3, T4> combinedResult, Action<Humidifier.SecurityHub.ConnectorTypes.AzureProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAzure(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConnectorProviderFactory, T3, T4, InnerConnectorAzureProviderConfigurationFactory> WithAzure<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerConnectorProviderFactory, T3, T4> combinedResult, Action<Humidifier.SecurityHub.ConnectorTypes.AzureProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAzure(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerConnectorProviderFactory, T4, InnerConnectorAzureProviderConfigurationFactory> WithAzure<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerConnectorProviderFactory, T4> combinedResult, Action<Humidifier.SecurityHub.ConnectorTypes.AzureProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAzure(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerConnectorProviderFactory, InnerConnectorAzureProviderConfigurationFactory> WithAzure<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerConnectorProviderFactory> combinedResult, Action<Humidifier.SecurityHub.ConnectorTypes.AzureProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAzure(combinedResult.T5, subFactoryAction).T2);
}
