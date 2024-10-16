// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AmazonMQ;

public class ConfigurationAssociationFactory(string resourceName = null, Action<Humidifier.AmazonMQ.ConfigurationAssociation> factoryAction = null) : ResourceFactory<Humidifier.AmazonMQ.ConfigurationAssociation>(resourceName)
{

    internal InnerConfigurationAssociationConfigurationIdFactory ConfigurationFactory { get; set; }

    protected override Humidifier.AmazonMQ.ConfigurationAssociation Create()
    {
        var configurationAssociationResult = CreateConfigurationAssociation();
        factoryAction?.Invoke(configurationAssociationResult);

        return configurationAssociationResult;
    }

    private Humidifier.AmazonMQ.ConfigurationAssociation CreateConfigurationAssociation()
    {
        var configurationAssociationResult = new Humidifier.AmazonMQ.ConfigurationAssociation
        {
            GivenName = InputResourceName,
        };

        return configurationAssociationResult;
    }
    public override void CreateChildren(Humidifier.AmazonMQ.ConfigurationAssociation result)
    {
        base.CreateChildren(result);

        result.Configuration ??= ConfigurationFactory?.Build();
    }

} // End Of Class

public static class ConfigurationAssociationFactoryExtensions
{
    public static CombinedResult<ConfigurationAssociationFactory, InnerConfigurationAssociationConfigurationIdFactory> WithConfiguration(this ConfigurationAssociationFactory parentFactory, Action<Humidifier.AmazonMQ.ConfigurationAssociationTypes.ConfigurationId> subFactoryAction = null)
    {
        parentFactory.ConfigurationFactory = new InnerConfigurationAssociationConfigurationIdFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConfigurationFactory);
    }

    public static CombinedResult<ConfigurationAssociationFactory, T1, InnerConfigurationAssociationConfigurationIdFactory> WithConfiguration<T1>(this CombinedResult<ConfigurationAssociationFactory, T1> combinedResult, Action<Humidifier.AmazonMQ.ConfigurationAssociationTypes.ConfigurationId> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConfigurationAssociationFactory, InnerConfigurationAssociationConfigurationIdFactory> WithConfiguration<T1>(this CombinedResult<T1, ConfigurationAssociationFactory> combinedResult, Action<Humidifier.AmazonMQ.ConfigurationAssociationTypes.ConfigurationId> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ConfigurationAssociationFactory, T1, T2, InnerConfigurationAssociationConfigurationIdFactory> WithConfiguration<T1, T2>(this CombinedResult<ConfigurationAssociationFactory, T1, T2> combinedResult, Action<Humidifier.AmazonMQ.ConfigurationAssociationTypes.ConfigurationId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConfigurationAssociationFactory, T2, InnerConfigurationAssociationConfigurationIdFactory> WithConfiguration<T1, T2>(this CombinedResult<T1, ConfigurationAssociationFactory, T2> combinedResult, Action<Humidifier.AmazonMQ.ConfigurationAssociationTypes.ConfigurationId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConfigurationAssociationFactory, InnerConfigurationAssociationConfigurationIdFactory> WithConfiguration<T1, T2>(this CombinedResult<T1, T2, ConfigurationAssociationFactory> combinedResult, Action<Humidifier.AmazonMQ.ConfigurationAssociationTypes.ConfigurationId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ConfigurationAssociationFactory, T1, T2, T3, InnerConfigurationAssociationConfigurationIdFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<ConfigurationAssociationFactory, T1, T2, T3> combinedResult, Action<Humidifier.AmazonMQ.ConfigurationAssociationTypes.ConfigurationId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConfigurationAssociationFactory, T2, T3, InnerConfigurationAssociationConfigurationIdFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<T1, ConfigurationAssociationFactory, T2, T3> combinedResult, Action<Humidifier.AmazonMQ.ConfigurationAssociationTypes.ConfigurationId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConfigurationAssociationFactory, T3, InnerConfigurationAssociationConfigurationIdFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, ConfigurationAssociationFactory, T3> combinedResult, Action<Humidifier.AmazonMQ.ConfigurationAssociationTypes.ConfigurationId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ConfigurationAssociationFactory, InnerConfigurationAssociationConfigurationIdFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, ConfigurationAssociationFactory> combinedResult, Action<Humidifier.AmazonMQ.ConfigurationAssociationTypes.ConfigurationId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ConfigurationAssociationFactory, T1, T2, T3, T4, InnerConfigurationAssociationConfigurationIdFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<ConfigurationAssociationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AmazonMQ.ConfigurationAssociationTypes.ConfigurationId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConfigurationAssociationFactory, T2, T3, T4, InnerConfigurationAssociationConfigurationIdFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, ConfigurationAssociationFactory, T2, T3, T4> combinedResult, Action<Humidifier.AmazonMQ.ConfigurationAssociationTypes.ConfigurationId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConfigurationAssociationFactory, T3, T4, InnerConfigurationAssociationConfigurationIdFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, ConfigurationAssociationFactory, T3, T4> combinedResult, Action<Humidifier.AmazonMQ.ConfigurationAssociationTypes.ConfigurationId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ConfigurationAssociationFactory, T4, InnerConfigurationAssociationConfigurationIdFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ConfigurationAssociationFactory, T4> combinedResult, Action<Humidifier.AmazonMQ.ConfigurationAssociationTypes.ConfigurationId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ConfigurationAssociationFactory, InnerConfigurationAssociationConfigurationIdFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ConfigurationAssociationFactory> combinedResult, Action<Humidifier.AmazonMQ.ConfigurationAssociationTypes.ConfigurationId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T5, subFactoryAction));
}
