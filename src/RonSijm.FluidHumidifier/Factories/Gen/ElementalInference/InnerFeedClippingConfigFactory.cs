// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElementalInference;

public class InnerFeedClippingConfigFactory(Action<Humidifier.ElementalInference.FeedTypes.ClippingConfig> factoryAction = null) : SubResourceFactory<Humidifier.ElementalInference.FeedTypes.ClippingConfig>
{

    internal InnerFeedDataSourceConfigurationFactory DataSourceConfigurationFactory { get; set; }

    protected override Humidifier.ElementalInference.FeedTypes.ClippingConfig Create()
    {
        var clippingConfigResult = CreateClippingConfig();
        factoryAction?.Invoke(clippingConfigResult);

        return clippingConfigResult;
    }

    private Humidifier.ElementalInference.FeedTypes.ClippingConfig CreateClippingConfig()
    {
        var clippingConfigResult = new Humidifier.ElementalInference.FeedTypes.ClippingConfig();

        return clippingConfigResult;
    }
    public override void CreateChildren(Humidifier.ElementalInference.FeedTypes.ClippingConfig result)
    {
        base.CreateChildren(result);

        result.DataSourceConfiguration ??= DataSourceConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerFeedClippingConfigFactoryExtensions
{
    public static CombinedResult<InnerFeedClippingConfigFactory, InnerFeedDataSourceConfigurationFactory> WithDataSourceConfiguration(this InnerFeedClippingConfigFactory parentFactory, Action<Humidifier.ElementalInference.FeedTypes.DataSourceConfiguration> subFactoryAction = null)
    {
        parentFactory.DataSourceConfigurationFactory = new InnerFeedDataSourceConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DataSourceConfigurationFactory);
    }

    public static CombinedResult<InnerFeedClippingConfigFactory, T1, InnerFeedDataSourceConfigurationFactory> WithDataSourceConfiguration<T1>(this CombinedResult<InnerFeedClippingConfigFactory, T1> combinedResult, Action<Humidifier.ElementalInference.FeedTypes.DataSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataSourceConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerFeedClippingConfigFactory, InnerFeedDataSourceConfigurationFactory> WithDataSourceConfiguration<T1>(this CombinedResult<T1, InnerFeedClippingConfigFactory> combinedResult, Action<Humidifier.ElementalInference.FeedTypes.DataSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataSourceConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerFeedClippingConfigFactory, T1, T2, InnerFeedDataSourceConfigurationFactory> WithDataSourceConfiguration<T1, T2>(this CombinedResult<InnerFeedClippingConfigFactory, T1, T2> combinedResult, Action<Humidifier.ElementalInference.FeedTypes.DataSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataSourceConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerFeedClippingConfigFactory, T2, InnerFeedDataSourceConfigurationFactory> WithDataSourceConfiguration<T1, T2>(this CombinedResult<T1, InnerFeedClippingConfigFactory, T2> combinedResult, Action<Humidifier.ElementalInference.FeedTypes.DataSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataSourceConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerFeedClippingConfigFactory, InnerFeedDataSourceConfigurationFactory> WithDataSourceConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerFeedClippingConfigFactory> combinedResult, Action<Humidifier.ElementalInference.FeedTypes.DataSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataSourceConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerFeedClippingConfigFactory, T1, T2, T3, InnerFeedDataSourceConfigurationFactory> WithDataSourceConfiguration<T1, T2, T3>(this CombinedResult<InnerFeedClippingConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.ElementalInference.FeedTypes.DataSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataSourceConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerFeedClippingConfigFactory, T2, T3, InnerFeedDataSourceConfigurationFactory> WithDataSourceConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerFeedClippingConfigFactory, T2, T3> combinedResult, Action<Humidifier.ElementalInference.FeedTypes.DataSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataSourceConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerFeedClippingConfigFactory, T3, InnerFeedDataSourceConfigurationFactory> WithDataSourceConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerFeedClippingConfigFactory, T3> combinedResult, Action<Humidifier.ElementalInference.FeedTypes.DataSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataSourceConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerFeedClippingConfigFactory, InnerFeedDataSourceConfigurationFactory> WithDataSourceConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFeedClippingConfigFactory> combinedResult, Action<Humidifier.ElementalInference.FeedTypes.DataSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataSourceConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerFeedClippingConfigFactory, T1, T2, T3, T4, InnerFeedDataSourceConfigurationFactory> WithDataSourceConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerFeedClippingConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ElementalInference.FeedTypes.DataSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSourceConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerFeedClippingConfigFactory, T2, T3, T4, InnerFeedDataSourceConfigurationFactory> WithDataSourceConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerFeedClippingConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.ElementalInference.FeedTypes.DataSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSourceConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerFeedClippingConfigFactory, T3, T4, InnerFeedDataSourceConfigurationFactory> WithDataSourceConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFeedClippingConfigFactory, T3, T4> combinedResult, Action<Humidifier.ElementalInference.FeedTypes.DataSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSourceConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerFeedClippingConfigFactory, T4, InnerFeedDataSourceConfigurationFactory> WithDataSourceConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFeedClippingConfigFactory, T4> combinedResult, Action<Humidifier.ElementalInference.FeedTypes.DataSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSourceConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerFeedClippingConfigFactory, InnerFeedDataSourceConfigurationFactory> WithDataSourceConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFeedClippingConfigFactory> combinedResult, Action<Humidifier.ElementalInference.FeedTypes.DataSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSourceConfiguration(combinedResult.T5, subFactoryAction).T2);
}
