// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SSM;

public class CloudConnectorFactory(string resourceName = null, Action<Humidifier.SSM.CloudConnector> factoryAction = null) : ResourceFactory<Humidifier.SSM.CloudConnector>(resourceName)
{

    internal InnerCloudConnectorCloudConnectorConfigurationFactory ConfigurationFactory { get; set; }

    protected override Humidifier.SSM.CloudConnector Create()
    {
        var cloudConnectorResult = CreateCloudConnector();
        factoryAction?.Invoke(cloudConnectorResult);

        return cloudConnectorResult;
    }

    private Humidifier.SSM.CloudConnector CreateCloudConnector()
    {
        var cloudConnectorResult = new Humidifier.SSM.CloudConnector
        {
            GivenName = InputResourceName,
        };

        return cloudConnectorResult;
    }
    public override void CreateChildren(Humidifier.SSM.CloudConnector result)
    {
        base.CreateChildren(result);

        result.Configuration ??= ConfigurationFactory?.Build();
    }

} // End Of Class

public static class CloudConnectorFactoryExtensions
{
    public static CombinedResult<CloudConnectorFactory, InnerCloudConnectorCloudConnectorConfigurationFactory> WithConfiguration(this CloudConnectorFactory parentFactory, Action<Humidifier.SSM.CloudConnectorTypes.CloudConnectorConfiguration> subFactoryAction = null)
    {
        parentFactory.ConfigurationFactory = new InnerCloudConnectorCloudConnectorConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConfigurationFactory);
    }

    public static CombinedResult<CloudConnectorFactory, T1, InnerCloudConnectorCloudConnectorConfigurationFactory> WithConfiguration<T1>(this CombinedResult<CloudConnectorFactory, T1> combinedResult, Action<Humidifier.SSM.CloudConnectorTypes.CloudConnectorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CloudConnectorFactory, InnerCloudConnectorCloudConnectorConfigurationFactory> WithConfiguration<T1>(this CombinedResult<T1, CloudConnectorFactory> combinedResult, Action<Humidifier.SSM.CloudConnectorTypes.CloudConnectorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<CloudConnectorFactory, T1, T2, InnerCloudConnectorCloudConnectorConfigurationFactory> WithConfiguration<T1, T2>(this CombinedResult<CloudConnectorFactory, T1, T2> combinedResult, Action<Humidifier.SSM.CloudConnectorTypes.CloudConnectorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CloudConnectorFactory, T2, InnerCloudConnectorCloudConnectorConfigurationFactory> WithConfiguration<T1, T2>(this CombinedResult<T1, CloudConnectorFactory, T2> combinedResult, Action<Humidifier.SSM.CloudConnectorTypes.CloudConnectorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CloudConnectorFactory, InnerCloudConnectorCloudConnectorConfigurationFactory> WithConfiguration<T1, T2>(this CombinedResult<T1, T2, CloudConnectorFactory> combinedResult, Action<Humidifier.SSM.CloudConnectorTypes.CloudConnectorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<CloudConnectorFactory, T1, T2, T3, InnerCloudConnectorCloudConnectorConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<CloudConnectorFactory, T1, T2, T3> combinedResult, Action<Humidifier.SSM.CloudConnectorTypes.CloudConnectorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CloudConnectorFactory, T2, T3, InnerCloudConnectorCloudConnectorConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<T1, CloudConnectorFactory, T2, T3> combinedResult, Action<Humidifier.SSM.CloudConnectorTypes.CloudConnectorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CloudConnectorFactory, T3, InnerCloudConnectorCloudConnectorConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, CloudConnectorFactory, T3> combinedResult, Action<Humidifier.SSM.CloudConnectorTypes.CloudConnectorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, CloudConnectorFactory, InnerCloudConnectorCloudConnectorConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, CloudConnectorFactory> combinedResult, Action<Humidifier.SSM.CloudConnectorTypes.CloudConnectorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<CloudConnectorFactory, T1, T2, T3, T4, InnerCloudConnectorCloudConnectorConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<CloudConnectorFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SSM.CloudConnectorTypes.CloudConnectorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CloudConnectorFactory, T2, T3, T4, InnerCloudConnectorCloudConnectorConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, CloudConnectorFactory, T2, T3, T4> combinedResult, Action<Humidifier.SSM.CloudConnectorTypes.CloudConnectorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CloudConnectorFactory, T3, T4, InnerCloudConnectorCloudConnectorConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, CloudConnectorFactory, T3, T4> combinedResult, Action<Humidifier.SSM.CloudConnectorTypes.CloudConnectorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, CloudConnectorFactory, T4, InnerCloudConnectorCloudConnectorConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, CloudConnectorFactory, T4> combinedResult, Action<Humidifier.SSM.CloudConnectorTypes.CloudConnectorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, CloudConnectorFactory, InnerCloudConnectorCloudConnectorConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, CloudConnectorFactory> combinedResult, Action<Humidifier.SSM.CloudConnectorTypes.CloudConnectorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T5, subFactoryAction).T2);
}
