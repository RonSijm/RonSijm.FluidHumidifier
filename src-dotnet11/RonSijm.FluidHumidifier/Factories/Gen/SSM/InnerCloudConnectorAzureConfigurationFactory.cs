// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SSM;

public class InnerCloudConnectorAzureConfigurationFactory(Action<Humidifier.SSM.CloudConnectorTypes.AzureConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.SSM.CloudConnectorTypes.AzureConfiguration>
{

    internal InnerCloudConnectorConfigurationTargetsFactory TargetsFactory { get; set; }

    protected override Humidifier.SSM.CloudConnectorTypes.AzureConfiguration Create()
    {
        var azureConfigurationResult = CreateAzureConfiguration();
        factoryAction?.Invoke(azureConfigurationResult);

        return azureConfigurationResult;
    }

    private Humidifier.SSM.CloudConnectorTypes.AzureConfiguration CreateAzureConfiguration()
    {
        var azureConfigurationResult = new Humidifier.SSM.CloudConnectorTypes.AzureConfiguration();

        return azureConfigurationResult;
    }
    public override void CreateChildren(Humidifier.SSM.CloudConnectorTypes.AzureConfiguration result)
    {
        base.CreateChildren(result);

        result.Targets ??= TargetsFactory?.Build();
    }

} // End Of Class

public static class InnerCloudConnectorAzureConfigurationFactoryExtensions
{
    public static CombinedResult<InnerCloudConnectorAzureConfigurationFactory, InnerCloudConnectorConfigurationTargetsFactory> WithTargets(this InnerCloudConnectorAzureConfigurationFactory parentFactory, Action<Humidifier.SSM.CloudConnectorTypes.ConfigurationTargets> subFactoryAction = null)
    {
        parentFactory.TargetsFactory = new InnerCloudConnectorConfigurationTargetsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TargetsFactory);
    }

    public static CombinedResult<InnerCloudConnectorAzureConfigurationFactory, T1, InnerCloudConnectorConfigurationTargetsFactory> WithTargets<T1>(this CombinedResult<InnerCloudConnectorAzureConfigurationFactory, T1> combinedResult, Action<Humidifier.SSM.CloudConnectorTypes.ConfigurationTargets> subFactoryAction = null) => new (combinedResult, combinedResult, WithTargets(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCloudConnectorAzureConfigurationFactory, InnerCloudConnectorConfigurationTargetsFactory> WithTargets<T1>(this CombinedResult<T1, InnerCloudConnectorAzureConfigurationFactory> combinedResult, Action<Humidifier.SSM.CloudConnectorTypes.ConfigurationTargets> subFactoryAction = null) => new (combinedResult, combinedResult, WithTargets(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerCloudConnectorAzureConfigurationFactory, T1, T2, InnerCloudConnectorConfigurationTargetsFactory> WithTargets<T1, T2>(this CombinedResult<InnerCloudConnectorAzureConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.SSM.CloudConnectorTypes.ConfigurationTargets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCloudConnectorAzureConfigurationFactory, T2, InnerCloudConnectorConfigurationTargetsFactory> WithTargets<T1, T2>(this CombinedResult<T1, InnerCloudConnectorAzureConfigurationFactory, T2> combinedResult, Action<Humidifier.SSM.CloudConnectorTypes.ConfigurationTargets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCloudConnectorAzureConfigurationFactory, InnerCloudConnectorConfigurationTargetsFactory> WithTargets<T1, T2>(this CombinedResult<T1, T2, InnerCloudConnectorAzureConfigurationFactory> combinedResult, Action<Humidifier.SSM.CloudConnectorTypes.ConfigurationTargets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerCloudConnectorAzureConfigurationFactory, T1, T2, T3, InnerCloudConnectorConfigurationTargetsFactory> WithTargets<T1, T2, T3>(this CombinedResult<InnerCloudConnectorAzureConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.SSM.CloudConnectorTypes.ConfigurationTargets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCloudConnectorAzureConfigurationFactory, T2, T3, InnerCloudConnectorConfigurationTargetsFactory> WithTargets<T1, T2, T3>(this CombinedResult<T1, InnerCloudConnectorAzureConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.SSM.CloudConnectorTypes.ConfigurationTargets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCloudConnectorAzureConfigurationFactory, T3, InnerCloudConnectorConfigurationTargetsFactory> WithTargets<T1, T2, T3>(this CombinedResult<T1, T2, InnerCloudConnectorAzureConfigurationFactory, T3> combinedResult, Action<Humidifier.SSM.CloudConnectorTypes.ConfigurationTargets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerCloudConnectorAzureConfigurationFactory, InnerCloudConnectorConfigurationTargetsFactory> WithTargets<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerCloudConnectorAzureConfigurationFactory> combinedResult, Action<Humidifier.SSM.CloudConnectorTypes.ConfigurationTargets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerCloudConnectorAzureConfigurationFactory, T1, T2, T3, T4, InnerCloudConnectorConfigurationTargetsFactory> WithTargets<T1, T2, T3, T4>(this CombinedResult<InnerCloudConnectorAzureConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SSM.CloudConnectorTypes.ConfigurationTargets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCloudConnectorAzureConfigurationFactory, T2, T3, T4, InnerCloudConnectorConfigurationTargetsFactory> WithTargets<T1, T2, T3, T4>(this CombinedResult<T1, InnerCloudConnectorAzureConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.SSM.CloudConnectorTypes.ConfigurationTargets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCloudConnectorAzureConfigurationFactory, T3, T4, InnerCloudConnectorConfigurationTargetsFactory> WithTargets<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerCloudConnectorAzureConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.SSM.CloudConnectorTypes.ConfigurationTargets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerCloudConnectorAzureConfigurationFactory, T4, InnerCloudConnectorConfigurationTargetsFactory> WithTargets<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerCloudConnectorAzureConfigurationFactory, T4> combinedResult, Action<Humidifier.SSM.CloudConnectorTypes.ConfigurationTargets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerCloudConnectorAzureConfigurationFactory, InnerCloudConnectorConfigurationTargetsFactory> WithTargets<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerCloudConnectorAzureConfigurationFactory> combinedResult, Action<Humidifier.SSM.CloudConnectorTypes.ConfigurationTargets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T5, subFactoryAction).T2);
}
