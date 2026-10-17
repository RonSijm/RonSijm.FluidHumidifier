// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.InspectorV2;

public class InnerConnectorProviderConfigurationFactory(Action<Humidifier.InspectorV2.ConnectorTypes.ProviderConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.InspectorV2.ConnectorTypes.ProviderConfiguration>
{

    internal InnerConnectorAzureProviderConfigurationFactory AzureFactory { get; set; }

    protected override Humidifier.InspectorV2.ConnectorTypes.ProviderConfiguration Create()
    {
        var providerConfigurationResult = CreateProviderConfiguration();
        factoryAction?.Invoke(providerConfigurationResult);

        return providerConfigurationResult;
    }

    private Humidifier.InspectorV2.ConnectorTypes.ProviderConfiguration CreateProviderConfiguration()
    {
        var providerConfigurationResult = new Humidifier.InspectorV2.ConnectorTypes.ProviderConfiguration();

        return providerConfigurationResult;
    }
    public override void CreateChildren(Humidifier.InspectorV2.ConnectorTypes.ProviderConfiguration result)
    {
        base.CreateChildren(result);

        result.Azure ??= AzureFactory?.Build();
    }

} // End Of Class

public static class InnerConnectorProviderConfigurationFactoryExtensions
{
    public static CombinedResult<InnerConnectorProviderConfigurationFactory, InnerConnectorAzureProviderConfigurationFactory> WithAzure(this InnerConnectorProviderConfigurationFactory parentFactory, Action<Humidifier.InspectorV2.ConnectorTypes.AzureProviderConfiguration> subFactoryAction = null)
    {
        parentFactory.AzureFactory = new InnerConnectorAzureProviderConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AzureFactory);
    }

    public static CombinedResult<InnerConnectorProviderConfigurationFactory, T1, InnerConnectorAzureProviderConfigurationFactory> WithAzure<T1>(this CombinedResult<InnerConnectorProviderConfigurationFactory, T1> combinedResult, Action<Humidifier.InspectorV2.ConnectorTypes.AzureProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithAzure(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConnectorProviderConfigurationFactory, InnerConnectorAzureProviderConfigurationFactory> WithAzure<T1>(this CombinedResult<T1, InnerConnectorProviderConfigurationFactory> combinedResult, Action<Humidifier.InspectorV2.ConnectorTypes.AzureProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithAzure(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerConnectorProviderConfigurationFactory, T1, T2, InnerConnectorAzureProviderConfigurationFactory> WithAzure<T1, T2>(this CombinedResult<InnerConnectorProviderConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.InspectorV2.ConnectorTypes.AzureProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAzure(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConnectorProviderConfigurationFactory, T2, InnerConnectorAzureProviderConfigurationFactory> WithAzure<T1, T2>(this CombinedResult<T1, InnerConnectorProviderConfigurationFactory, T2> combinedResult, Action<Humidifier.InspectorV2.ConnectorTypes.AzureProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAzure(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConnectorProviderConfigurationFactory, InnerConnectorAzureProviderConfigurationFactory> WithAzure<T1, T2>(this CombinedResult<T1, T2, InnerConnectorProviderConfigurationFactory> combinedResult, Action<Humidifier.InspectorV2.ConnectorTypes.AzureProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAzure(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerConnectorProviderConfigurationFactory, T1, T2, T3, InnerConnectorAzureProviderConfigurationFactory> WithAzure<T1, T2, T3>(this CombinedResult<InnerConnectorProviderConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.InspectorV2.ConnectorTypes.AzureProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAzure(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConnectorProviderConfigurationFactory, T2, T3, InnerConnectorAzureProviderConfigurationFactory> WithAzure<T1, T2, T3>(this CombinedResult<T1, InnerConnectorProviderConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.InspectorV2.ConnectorTypes.AzureProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAzure(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConnectorProviderConfigurationFactory, T3, InnerConnectorAzureProviderConfigurationFactory> WithAzure<T1, T2, T3>(this CombinedResult<T1, T2, InnerConnectorProviderConfigurationFactory, T3> combinedResult, Action<Humidifier.InspectorV2.ConnectorTypes.AzureProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAzure(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerConnectorProviderConfigurationFactory, InnerConnectorAzureProviderConfigurationFactory> WithAzure<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerConnectorProviderConfigurationFactory> combinedResult, Action<Humidifier.InspectorV2.ConnectorTypes.AzureProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAzure(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerConnectorProviderConfigurationFactory, T1, T2, T3, T4, InnerConnectorAzureProviderConfigurationFactory> WithAzure<T1, T2, T3, T4>(this CombinedResult<InnerConnectorProviderConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.InspectorV2.ConnectorTypes.AzureProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAzure(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConnectorProviderConfigurationFactory, T2, T3, T4, InnerConnectorAzureProviderConfigurationFactory> WithAzure<T1, T2, T3, T4>(this CombinedResult<T1, InnerConnectorProviderConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.InspectorV2.ConnectorTypes.AzureProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAzure(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConnectorProviderConfigurationFactory, T3, T4, InnerConnectorAzureProviderConfigurationFactory> WithAzure<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerConnectorProviderConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.InspectorV2.ConnectorTypes.AzureProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAzure(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerConnectorProviderConfigurationFactory, T4, InnerConnectorAzureProviderConfigurationFactory> WithAzure<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerConnectorProviderConfigurationFactory, T4> combinedResult, Action<Humidifier.InspectorV2.ConnectorTypes.AzureProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAzure(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerConnectorProviderConfigurationFactory, InnerConnectorAzureProviderConfigurationFactory> WithAzure<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerConnectorProviderConfigurationFactory> combinedResult, Action<Humidifier.InspectorV2.ConnectorTypes.AzureProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAzure(combinedResult.T5, subFactoryAction).T2);
}
