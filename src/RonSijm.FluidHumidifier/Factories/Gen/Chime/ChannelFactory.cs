// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Chime;

public class ChannelFactory(string resourceName = null, Action<Humidifier.Chime.Channel> factoryAction = null) : ResourceFactory<Humidifier.Chime.Channel>(resourceName)
{

    internal InnerChannelElasticChannelConfigurationFactory ElasticChannelConfigurationFactory { get; set; }

    internal InnerChannelExpirationSettingsFactory ExpirationSettingsFactory { get; set; }

    protected override Humidifier.Chime.Channel Create()
    {
        var channelResult = CreateChannel();
        factoryAction?.Invoke(channelResult);

        return channelResult;
    }

    private Humidifier.Chime.Channel CreateChannel()
    {
        var channelResult = new Humidifier.Chime.Channel
        {
            GivenName = InputResourceName,
        };

        return channelResult;
    }
    public override void CreateChildren(Humidifier.Chime.Channel result)
    {
        base.CreateChildren(result);

        result.ElasticChannelConfiguration ??= ElasticChannelConfigurationFactory?.Build();
        result.ExpirationSettings ??= ExpirationSettingsFactory?.Build();
    }

} // End Of Class

public static class ChannelFactoryExtensions
{
    public static CombinedResult<ChannelFactory, InnerChannelElasticChannelConfigurationFactory> WithElasticChannelConfiguration(this ChannelFactory parentFactory, Action<Humidifier.Chime.ChannelTypes.ElasticChannelConfiguration> subFactoryAction = null)
    {
        parentFactory.ElasticChannelConfigurationFactory = new InnerChannelElasticChannelConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ElasticChannelConfigurationFactory);
    }

    public static CombinedResult<ChannelFactory, InnerChannelExpirationSettingsFactory> WithExpirationSettings(this ChannelFactory parentFactory, Action<Humidifier.Chime.ChannelTypes.ExpirationSettings> subFactoryAction = null)
    {
        parentFactory.ExpirationSettingsFactory = new InnerChannelExpirationSettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ExpirationSettingsFactory);
    }

    public static CombinedResult<ChannelFactory, T1, InnerChannelElasticChannelConfigurationFactory> WithElasticChannelConfiguration<T1>(this CombinedResult<ChannelFactory, T1> combinedResult, Action<Humidifier.Chime.ChannelTypes.ElasticChannelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithElasticChannelConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ChannelFactory, InnerChannelElasticChannelConfigurationFactory> WithElasticChannelConfiguration<T1>(this CombinedResult<T1, ChannelFactory> combinedResult, Action<Humidifier.Chime.ChannelTypes.ElasticChannelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithElasticChannelConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ChannelFactory, T1, T2, InnerChannelElasticChannelConfigurationFactory> WithElasticChannelConfiguration<T1, T2>(this CombinedResult<ChannelFactory, T1, T2> combinedResult, Action<Humidifier.Chime.ChannelTypes.ElasticChannelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithElasticChannelConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ChannelFactory, T2, InnerChannelElasticChannelConfigurationFactory> WithElasticChannelConfiguration<T1, T2>(this CombinedResult<T1, ChannelFactory, T2> combinedResult, Action<Humidifier.Chime.ChannelTypes.ElasticChannelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithElasticChannelConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ChannelFactory, InnerChannelElasticChannelConfigurationFactory> WithElasticChannelConfiguration<T1, T2>(this CombinedResult<T1, T2, ChannelFactory> combinedResult, Action<Humidifier.Chime.ChannelTypes.ElasticChannelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithElasticChannelConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ChannelFactory, T1, T2, T3, InnerChannelElasticChannelConfigurationFactory> WithElasticChannelConfiguration<T1, T2, T3>(this CombinedResult<ChannelFactory, T1, T2, T3> combinedResult, Action<Humidifier.Chime.ChannelTypes.ElasticChannelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithElasticChannelConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ChannelFactory, T2, T3, InnerChannelElasticChannelConfigurationFactory> WithElasticChannelConfiguration<T1, T2, T3>(this CombinedResult<T1, ChannelFactory, T2, T3> combinedResult, Action<Humidifier.Chime.ChannelTypes.ElasticChannelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithElasticChannelConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ChannelFactory, T3, InnerChannelElasticChannelConfigurationFactory> WithElasticChannelConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, ChannelFactory, T3> combinedResult, Action<Humidifier.Chime.ChannelTypes.ElasticChannelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithElasticChannelConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ChannelFactory, InnerChannelElasticChannelConfigurationFactory> WithElasticChannelConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, ChannelFactory> combinedResult, Action<Humidifier.Chime.ChannelTypes.ElasticChannelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithElasticChannelConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ChannelFactory, T1, T2, T3, T4, InnerChannelElasticChannelConfigurationFactory> WithElasticChannelConfiguration<T1, T2, T3, T4>(this CombinedResult<ChannelFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Chime.ChannelTypes.ElasticChannelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithElasticChannelConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ChannelFactory, T2, T3, T4, InnerChannelElasticChannelConfigurationFactory> WithElasticChannelConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, ChannelFactory, T2, T3, T4> combinedResult, Action<Humidifier.Chime.ChannelTypes.ElasticChannelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithElasticChannelConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ChannelFactory, T3, T4, InnerChannelElasticChannelConfigurationFactory> WithElasticChannelConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, ChannelFactory, T3, T4> combinedResult, Action<Humidifier.Chime.ChannelTypes.ElasticChannelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithElasticChannelConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ChannelFactory, T4, InnerChannelElasticChannelConfigurationFactory> WithElasticChannelConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ChannelFactory, T4> combinedResult, Action<Humidifier.Chime.ChannelTypes.ElasticChannelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithElasticChannelConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ChannelFactory, InnerChannelElasticChannelConfigurationFactory> WithElasticChannelConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ChannelFactory> combinedResult, Action<Humidifier.Chime.ChannelTypes.ElasticChannelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithElasticChannelConfiguration(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<ChannelFactory, T1, InnerChannelExpirationSettingsFactory> WithExpirationSettings<T1>(this CombinedResult<ChannelFactory, T1> combinedResult, Action<Humidifier.Chime.ChannelTypes.ExpirationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithExpirationSettings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ChannelFactory, InnerChannelExpirationSettingsFactory> WithExpirationSettings<T1>(this CombinedResult<T1, ChannelFactory> combinedResult, Action<Humidifier.Chime.ChannelTypes.ExpirationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithExpirationSettings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ChannelFactory, T1, T2, InnerChannelExpirationSettingsFactory> WithExpirationSettings<T1, T2>(this CombinedResult<ChannelFactory, T1, T2> combinedResult, Action<Humidifier.Chime.ChannelTypes.ExpirationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExpirationSettings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ChannelFactory, T2, InnerChannelExpirationSettingsFactory> WithExpirationSettings<T1, T2>(this CombinedResult<T1, ChannelFactory, T2> combinedResult, Action<Humidifier.Chime.ChannelTypes.ExpirationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExpirationSettings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ChannelFactory, InnerChannelExpirationSettingsFactory> WithExpirationSettings<T1, T2>(this CombinedResult<T1, T2, ChannelFactory> combinedResult, Action<Humidifier.Chime.ChannelTypes.ExpirationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExpirationSettings(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ChannelFactory, T1, T2, T3, InnerChannelExpirationSettingsFactory> WithExpirationSettings<T1, T2, T3>(this CombinedResult<ChannelFactory, T1, T2, T3> combinedResult, Action<Humidifier.Chime.ChannelTypes.ExpirationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExpirationSettings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ChannelFactory, T2, T3, InnerChannelExpirationSettingsFactory> WithExpirationSettings<T1, T2, T3>(this CombinedResult<T1, ChannelFactory, T2, T3> combinedResult, Action<Humidifier.Chime.ChannelTypes.ExpirationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExpirationSettings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ChannelFactory, T3, InnerChannelExpirationSettingsFactory> WithExpirationSettings<T1, T2, T3>(this CombinedResult<T1, T2, ChannelFactory, T3> combinedResult, Action<Humidifier.Chime.ChannelTypes.ExpirationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExpirationSettings(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ChannelFactory, InnerChannelExpirationSettingsFactory> WithExpirationSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, ChannelFactory> combinedResult, Action<Humidifier.Chime.ChannelTypes.ExpirationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExpirationSettings(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ChannelFactory, T1, T2, T3, T4, InnerChannelExpirationSettingsFactory> WithExpirationSettings<T1, T2, T3, T4>(this CombinedResult<ChannelFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Chime.ChannelTypes.ExpirationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExpirationSettings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ChannelFactory, T2, T3, T4, InnerChannelExpirationSettingsFactory> WithExpirationSettings<T1, T2, T3, T4>(this CombinedResult<T1, ChannelFactory, T2, T3, T4> combinedResult, Action<Humidifier.Chime.ChannelTypes.ExpirationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExpirationSettings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ChannelFactory, T3, T4, InnerChannelExpirationSettingsFactory> WithExpirationSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, ChannelFactory, T3, T4> combinedResult, Action<Humidifier.Chime.ChannelTypes.ExpirationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExpirationSettings(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ChannelFactory, T4, InnerChannelExpirationSettingsFactory> WithExpirationSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ChannelFactory, T4> combinedResult, Action<Humidifier.Chime.ChannelTypes.ExpirationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExpirationSettings(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ChannelFactory, InnerChannelExpirationSettingsFactory> WithExpirationSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ChannelFactory> combinedResult, Action<Humidifier.Chime.ChannelTypes.ExpirationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExpirationSettings(combinedResult.T5, subFactoryAction).T2);
}
