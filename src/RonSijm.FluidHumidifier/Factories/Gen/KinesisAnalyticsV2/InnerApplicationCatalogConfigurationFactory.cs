// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisAnalyticsV2;

public class InnerApplicationCatalogConfigurationFactory(Action<Humidifier.KinesisAnalyticsV2.ApplicationTypes.CatalogConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.KinesisAnalyticsV2.ApplicationTypes.CatalogConfiguration>
{

    internal InnerApplicationGlueDataCatalogConfigurationFactory GlueDataCatalogConfigurationFactory { get; set; }

    protected override Humidifier.KinesisAnalyticsV2.ApplicationTypes.CatalogConfiguration Create()
    {
        var catalogConfigurationResult = CreateCatalogConfiguration();
        factoryAction?.Invoke(catalogConfigurationResult);

        return catalogConfigurationResult;
    }

    private Humidifier.KinesisAnalyticsV2.ApplicationTypes.CatalogConfiguration CreateCatalogConfiguration()
    {
        var catalogConfigurationResult = new Humidifier.KinesisAnalyticsV2.ApplicationTypes.CatalogConfiguration();

        return catalogConfigurationResult;
    }
    public override void CreateChildren(Humidifier.KinesisAnalyticsV2.ApplicationTypes.CatalogConfiguration result)
    {
        base.CreateChildren(result);

        result.GlueDataCatalogConfiguration ??= GlueDataCatalogConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerApplicationCatalogConfigurationFactoryExtensions
{
    public static CombinedResult<InnerApplicationCatalogConfigurationFactory, InnerApplicationGlueDataCatalogConfigurationFactory> WithGlueDataCatalogConfiguration(this InnerApplicationCatalogConfigurationFactory parentFactory, Action<Humidifier.KinesisAnalyticsV2.ApplicationTypes.GlueDataCatalogConfiguration> subFactoryAction = null)
    {
        parentFactory.GlueDataCatalogConfigurationFactory = new InnerApplicationGlueDataCatalogConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.GlueDataCatalogConfigurationFactory);
    }

    public static CombinedResult<InnerApplicationCatalogConfigurationFactory, T1, InnerApplicationGlueDataCatalogConfigurationFactory> WithGlueDataCatalogConfiguration<T1>(this CombinedResult<InnerApplicationCatalogConfigurationFactory, T1> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationTypes.GlueDataCatalogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithGlueDataCatalogConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerApplicationCatalogConfigurationFactory, InnerApplicationGlueDataCatalogConfigurationFactory> WithGlueDataCatalogConfiguration<T1>(this CombinedResult<T1, InnerApplicationCatalogConfigurationFactory> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationTypes.GlueDataCatalogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithGlueDataCatalogConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerApplicationCatalogConfigurationFactory, T1, T2, InnerApplicationGlueDataCatalogConfigurationFactory> WithGlueDataCatalogConfiguration<T1, T2>(this CombinedResult<InnerApplicationCatalogConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationTypes.GlueDataCatalogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGlueDataCatalogConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerApplicationCatalogConfigurationFactory, T2, InnerApplicationGlueDataCatalogConfigurationFactory> WithGlueDataCatalogConfiguration<T1, T2>(this CombinedResult<T1, InnerApplicationCatalogConfigurationFactory, T2> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationTypes.GlueDataCatalogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGlueDataCatalogConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerApplicationCatalogConfigurationFactory, InnerApplicationGlueDataCatalogConfigurationFactory> WithGlueDataCatalogConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerApplicationCatalogConfigurationFactory> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationTypes.GlueDataCatalogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGlueDataCatalogConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerApplicationCatalogConfigurationFactory, T1, T2, T3, InnerApplicationGlueDataCatalogConfigurationFactory> WithGlueDataCatalogConfiguration<T1, T2, T3>(this CombinedResult<InnerApplicationCatalogConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationTypes.GlueDataCatalogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGlueDataCatalogConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerApplicationCatalogConfigurationFactory, T2, T3, InnerApplicationGlueDataCatalogConfigurationFactory> WithGlueDataCatalogConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerApplicationCatalogConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationTypes.GlueDataCatalogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGlueDataCatalogConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerApplicationCatalogConfigurationFactory, T3, InnerApplicationGlueDataCatalogConfigurationFactory> WithGlueDataCatalogConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerApplicationCatalogConfigurationFactory, T3> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationTypes.GlueDataCatalogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGlueDataCatalogConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerApplicationCatalogConfigurationFactory, InnerApplicationGlueDataCatalogConfigurationFactory> WithGlueDataCatalogConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerApplicationCatalogConfigurationFactory> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationTypes.GlueDataCatalogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGlueDataCatalogConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerApplicationCatalogConfigurationFactory, T1, T2, T3, T4, InnerApplicationGlueDataCatalogConfigurationFactory> WithGlueDataCatalogConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerApplicationCatalogConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationTypes.GlueDataCatalogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGlueDataCatalogConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerApplicationCatalogConfigurationFactory, T2, T3, T4, InnerApplicationGlueDataCatalogConfigurationFactory> WithGlueDataCatalogConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerApplicationCatalogConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationTypes.GlueDataCatalogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGlueDataCatalogConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerApplicationCatalogConfigurationFactory, T3, T4, InnerApplicationGlueDataCatalogConfigurationFactory> WithGlueDataCatalogConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerApplicationCatalogConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationTypes.GlueDataCatalogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGlueDataCatalogConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerApplicationCatalogConfigurationFactory, T4, InnerApplicationGlueDataCatalogConfigurationFactory> WithGlueDataCatalogConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerApplicationCatalogConfigurationFactory, T4> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationTypes.GlueDataCatalogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGlueDataCatalogConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerApplicationCatalogConfigurationFactory, InnerApplicationGlueDataCatalogConfigurationFactory> WithGlueDataCatalogConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerApplicationCatalogConfigurationFactory> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationTypes.GlueDataCatalogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGlueDataCatalogConfiguration(combinedResult.T5, subFactoryAction));
}
