// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Wisdom;

public class InnerKnowledgeBaseManagedSourceConfigurationFactory(Action<Humidifier.Wisdom.KnowledgeBaseTypes.ManagedSourceConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Wisdom.KnowledgeBaseTypes.ManagedSourceConfiguration>
{

    internal InnerKnowledgeBaseWebCrawlerConfigurationFactory WebCrawlerConfigurationFactory { get; set; }

    protected override Humidifier.Wisdom.KnowledgeBaseTypes.ManagedSourceConfiguration Create()
    {
        var managedSourceConfigurationResult = CreateManagedSourceConfiguration();
        factoryAction?.Invoke(managedSourceConfigurationResult);

        return managedSourceConfigurationResult;
    }

    private Humidifier.Wisdom.KnowledgeBaseTypes.ManagedSourceConfiguration CreateManagedSourceConfiguration()
    {
        var managedSourceConfigurationResult = new Humidifier.Wisdom.KnowledgeBaseTypes.ManagedSourceConfiguration();

        return managedSourceConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Wisdom.KnowledgeBaseTypes.ManagedSourceConfiguration result)
    {
        base.CreateChildren(result);

        result.WebCrawlerConfiguration ??= WebCrawlerConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerKnowledgeBaseManagedSourceConfigurationFactoryExtensions
{
    public static CombinedResult<InnerKnowledgeBaseManagedSourceConfigurationFactory, InnerKnowledgeBaseWebCrawlerConfigurationFactory> WithWebCrawlerConfiguration(this InnerKnowledgeBaseManagedSourceConfigurationFactory parentFactory, Action<Humidifier.Wisdom.KnowledgeBaseTypes.WebCrawlerConfiguration> subFactoryAction = null)
    {
        parentFactory.WebCrawlerConfigurationFactory = new InnerKnowledgeBaseWebCrawlerConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.WebCrawlerConfigurationFactory);
    }

    public static CombinedResult<InnerKnowledgeBaseManagedSourceConfigurationFactory, T1, InnerKnowledgeBaseWebCrawlerConfigurationFactory> WithWebCrawlerConfiguration<T1>(this CombinedResult<InnerKnowledgeBaseManagedSourceConfigurationFactory, T1> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.WebCrawlerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithWebCrawlerConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerKnowledgeBaseManagedSourceConfigurationFactory, InnerKnowledgeBaseWebCrawlerConfigurationFactory> WithWebCrawlerConfiguration<T1>(this CombinedResult<T1, InnerKnowledgeBaseManagedSourceConfigurationFactory> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.WebCrawlerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithWebCrawlerConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerKnowledgeBaseManagedSourceConfigurationFactory, T1, T2, InnerKnowledgeBaseWebCrawlerConfigurationFactory> WithWebCrawlerConfiguration<T1, T2>(this CombinedResult<InnerKnowledgeBaseManagedSourceConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.WebCrawlerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithWebCrawlerConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerKnowledgeBaseManagedSourceConfigurationFactory, T2, InnerKnowledgeBaseWebCrawlerConfigurationFactory> WithWebCrawlerConfiguration<T1, T2>(this CombinedResult<T1, InnerKnowledgeBaseManagedSourceConfigurationFactory, T2> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.WebCrawlerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithWebCrawlerConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerKnowledgeBaseManagedSourceConfigurationFactory, InnerKnowledgeBaseWebCrawlerConfigurationFactory> WithWebCrawlerConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerKnowledgeBaseManagedSourceConfigurationFactory> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.WebCrawlerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithWebCrawlerConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerKnowledgeBaseManagedSourceConfigurationFactory, T1, T2, T3, InnerKnowledgeBaseWebCrawlerConfigurationFactory> WithWebCrawlerConfiguration<T1, T2, T3>(this CombinedResult<InnerKnowledgeBaseManagedSourceConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.WebCrawlerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWebCrawlerConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerKnowledgeBaseManagedSourceConfigurationFactory, T2, T3, InnerKnowledgeBaseWebCrawlerConfigurationFactory> WithWebCrawlerConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerKnowledgeBaseManagedSourceConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.WebCrawlerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWebCrawlerConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerKnowledgeBaseManagedSourceConfigurationFactory, T3, InnerKnowledgeBaseWebCrawlerConfigurationFactory> WithWebCrawlerConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerKnowledgeBaseManagedSourceConfigurationFactory, T3> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.WebCrawlerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWebCrawlerConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerKnowledgeBaseManagedSourceConfigurationFactory, InnerKnowledgeBaseWebCrawlerConfigurationFactory> WithWebCrawlerConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerKnowledgeBaseManagedSourceConfigurationFactory> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.WebCrawlerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWebCrawlerConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerKnowledgeBaseManagedSourceConfigurationFactory, T1, T2, T3, T4, InnerKnowledgeBaseWebCrawlerConfigurationFactory> WithWebCrawlerConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerKnowledgeBaseManagedSourceConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.WebCrawlerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWebCrawlerConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerKnowledgeBaseManagedSourceConfigurationFactory, T2, T3, T4, InnerKnowledgeBaseWebCrawlerConfigurationFactory> WithWebCrawlerConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerKnowledgeBaseManagedSourceConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.WebCrawlerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWebCrawlerConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerKnowledgeBaseManagedSourceConfigurationFactory, T3, T4, InnerKnowledgeBaseWebCrawlerConfigurationFactory> WithWebCrawlerConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerKnowledgeBaseManagedSourceConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.WebCrawlerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWebCrawlerConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerKnowledgeBaseManagedSourceConfigurationFactory, T4, InnerKnowledgeBaseWebCrawlerConfigurationFactory> WithWebCrawlerConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerKnowledgeBaseManagedSourceConfigurationFactory, T4> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.WebCrawlerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWebCrawlerConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerKnowledgeBaseManagedSourceConfigurationFactory, InnerKnowledgeBaseWebCrawlerConfigurationFactory> WithWebCrawlerConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerKnowledgeBaseManagedSourceConfigurationFactory> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.WebCrawlerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWebCrawlerConfiguration(combinedResult.T5, subFactoryAction));
}
