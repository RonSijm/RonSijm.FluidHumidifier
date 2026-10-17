// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SSM;

public class InnerCloudConnectorCloudConnectorConfigurationFactory(Action<Humidifier.SSM.CloudConnectorTypes.CloudConnectorConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.SSM.CloudConnectorTypes.CloudConnectorConfiguration>
{

    internal InnerCloudConnectorAzureConfigurationFactory AzureConfigurationFactory { get; set; }

    protected override Humidifier.SSM.CloudConnectorTypes.CloudConnectorConfiguration Create()
    {
        var cloudConnectorConfigurationResult = CreateCloudConnectorConfiguration();
        factoryAction?.Invoke(cloudConnectorConfigurationResult);

        return cloudConnectorConfigurationResult;
    }

    private Humidifier.SSM.CloudConnectorTypes.CloudConnectorConfiguration CreateCloudConnectorConfiguration()
    {
        var cloudConnectorConfigurationResult = new Humidifier.SSM.CloudConnectorTypes.CloudConnectorConfiguration();

        return cloudConnectorConfigurationResult;
    }
    public override void CreateChildren(Humidifier.SSM.CloudConnectorTypes.CloudConnectorConfiguration result)
    {
        base.CreateChildren(result);

        result.AzureConfiguration ??= AzureConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerCloudConnectorCloudConnectorConfigurationFactoryExtensions
{
    public static CombinedResult<InnerCloudConnectorCloudConnectorConfigurationFactory, InnerCloudConnectorAzureConfigurationFactory> WithAzureConfiguration(this InnerCloudConnectorCloudConnectorConfigurationFactory parentFactory, Action<Humidifier.SSM.CloudConnectorTypes.AzureConfiguration> subFactoryAction = null)
    {
        parentFactory.AzureConfigurationFactory = new InnerCloudConnectorAzureConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AzureConfigurationFactory);
    }

    public static CombinedResult<InnerCloudConnectorCloudConnectorConfigurationFactory, T1, InnerCloudConnectorAzureConfigurationFactory> WithAzureConfiguration<T1>(this CombinedResult<InnerCloudConnectorCloudConnectorConfigurationFactory, T1> combinedResult, Action<Humidifier.SSM.CloudConnectorTypes.AzureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithAzureConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCloudConnectorCloudConnectorConfigurationFactory, InnerCloudConnectorAzureConfigurationFactory> WithAzureConfiguration<T1>(this CombinedResult<T1, InnerCloudConnectorCloudConnectorConfigurationFactory> combinedResult, Action<Humidifier.SSM.CloudConnectorTypes.AzureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithAzureConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerCloudConnectorCloudConnectorConfigurationFactory, T1, T2, InnerCloudConnectorAzureConfigurationFactory> WithAzureConfiguration<T1, T2>(this CombinedResult<InnerCloudConnectorCloudConnectorConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.SSM.CloudConnectorTypes.AzureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAzureConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCloudConnectorCloudConnectorConfigurationFactory, T2, InnerCloudConnectorAzureConfigurationFactory> WithAzureConfiguration<T1, T2>(this CombinedResult<T1, InnerCloudConnectorCloudConnectorConfigurationFactory, T2> combinedResult, Action<Humidifier.SSM.CloudConnectorTypes.AzureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAzureConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCloudConnectorCloudConnectorConfigurationFactory, InnerCloudConnectorAzureConfigurationFactory> WithAzureConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerCloudConnectorCloudConnectorConfigurationFactory> combinedResult, Action<Humidifier.SSM.CloudConnectorTypes.AzureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAzureConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerCloudConnectorCloudConnectorConfigurationFactory, T1, T2, T3, InnerCloudConnectorAzureConfigurationFactory> WithAzureConfiguration<T1, T2, T3>(this CombinedResult<InnerCloudConnectorCloudConnectorConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.SSM.CloudConnectorTypes.AzureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAzureConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCloudConnectorCloudConnectorConfigurationFactory, T2, T3, InnerCloudConnectorAzureConfigurationFactory> WithAzureConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerCloudConnectorCloudConnectorConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.SSM.CloudConnectorTypes.AzureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAzureConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCloudConnectorCloudConnectorConfigurationFactory, T3, InnerCloudConnectorAzureConfigurationFactory> WithAzureConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerCloudConnectorCloudConnectorConfigurationFactory, T3> combinedResult, Action<Humidifier.SSM.CloudConnectorTypes.AzureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAzureConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerCloudConnectorCloudConnectorConfigurationFactory, InnerCloudConnectorAzureConfigurationFactory> WithAzureConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerCloudConnectorCloudConnectorConfigurationFactory> combinedResult, Action<Humidifier.SSM.CloudConnectorTypes.AzureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAzureConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerCloudConnectorCloudConnectorConfigurationFactory, T1, T2, T3, T4, InnerCloudConnectorAzureConfigurationFactory> WithAzureConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerCloudConnectorCloudConnectorConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SSM.CloudConnectorTypes.AzureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAzureConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCloudConnectorCloudConnectorConfigurationFactory, T2, T3, T4, InnerCloudConnectorAzureConfigurationFactory> WithAzureConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerCloudConnectorCloudConnectorConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.SSM.CloudConnectorTypes.AzureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAzureConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCloudConnectorCloudConnectorConfigurationFactory, T3, T4, InnerCloudConnectorAzureConfigurationFactory> WithAzureConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerCloudConnectorCloudConnectorConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.SSM.CloudConnectorTypes.AzureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAzureConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerCloudConnectorCloudConnectorConfigurationFactory, T4, InnerCloudConnectorAzureConfigurationFactory> WithAzureConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerCloudConnectorCloudConnectorConfigurationFactory, T4> combinedResult, Action<Humidifier.SSM.CloudConnectorTypes.AzureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAzureConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerCloudConnectorCloudConnectorConfigurationFactory, InnerCloudConnectorAzureConfigurationFactory> WithAzureConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerCloudConnectorCloudConnectorConfigurationFactory> combinedResult, Action<Humidifier.SSM.CloudConnectorTypes.AzureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAzureConfiguration(combinedResult.T5, subFactoryAction).T2);
}
