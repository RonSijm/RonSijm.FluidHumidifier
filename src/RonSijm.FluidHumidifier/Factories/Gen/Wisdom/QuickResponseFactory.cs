// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Wisdom;

public class QuickResponseFactory(string resourceName = null, Action<Humidifier.Wisdom.QuickResponse> factoryAction = null) : ResourceFactory<Humidifier.Wisdom.QuickResponse>(resourceName)
{

    internal InnerQuickResponseQuickResponseContentProviderFactory ContentFactory { get; set; }

    internal InnerQuickResponseGroupingConfigurationFactory GroupingConfigurationFactory { get; set; }

    protected override Humidifier.Wisdom.QuickResponse Create()
    {
        var quickResponseResult = CreateQuickResponse();
        factoryAction?.Invoke(quickResponseResult);

        return quickResponseResult;
    }

    private Humidifier.Wisdom.QuickResponse CreateQuickResponse()
    {
        var quickResponseResult = new Humidifier.Wisdom.QuickResponse
        {
            GivenName = InputResourceName,
        };

        return quickResponseResult;
    }
    public override void CreateChildren(Humidifier.Wisdom.QuickResponse result)
    {
        base.CreateChildren(result);

        result.Content ??= ContentFactory?.Build();
        result.GroupingConfiguration ??= GroupingConfigurationFactory?.Build();
    }

} // End Of Class

public static class QuickResponseFactoryExtensions
{
    public static CombinedResult<QuickResponseFactory, InnerQuickResponseQuickResponseContentProviderFactory> WithContent(this QuickResponseFactory parentFactory, Action<Humidifier.Wisdom.QuickResponseTypes.QuickResponseContentProvider> subFactoryAction = null)
    {
        parentFactory.ContentFactory = new InnerQuickResponseQuickResponseContentProviderFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ContentFactory);
    }

    public static CombinedResult<QuickResponseFactory, InnerQuickResponseGroupingConfigurationFactory> WithGroupingConfiguration(this QuickResponseFactory parentFactory, Action<Humidifier.Wisdom.QuickResponseTypes.GroupingConfiguration> subFactoryAction = null)
    {
        parentFactory.GroupingConfigurationFactory = new InnerQuickResponseGroupingConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.GroupingConfigurationFactory);
    }

    public static CombinedResult<QuickResponseFactory, T1, InnerQuickResponseQuickResponseContentProviderFactory> WithContent<T1>(this CombinedResult<QuickResponseFactory, T1> combinedResult, Action<Humidifier.Wisdom.QuickResponseTypes.QuickResponseContentProvider> subFactoryAction = null) => new (combinedResult, combinedResult, WithContent(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, QuickResponseFactory, InnerQuickResponseQuickResponseContentProviderFactory> WithContent<T1>(this CombinedResult<T1, QuickResponseFactory> combinedResult, Action<Humidifier.Wisdom.QuickResponseTypes.QuickResponseContentProvider> subFactoryAction = null) => new (combinedResult, combinedResult, WithContent(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<QuickResponseFactory, T1, T2, InnerQuickResponseQuickResponseContentProviderFactory> WithContent<T1, T2>(this CombinedResult<QuickResponseFactory, T1, T2> combinedResult, Action<Humidifier.Wisdom.QuickResponseTypes.QuickResponseContentProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, QuickResponseFactory, T2, InnerQuickResponseQuickResponseContentProviderFactory> WithContent<T1, T2>(this CombinedResult<T1, QuickResponseFactory, T2> combinedResult, Action<Humidifier.Wisdom.QuickResponseTypes.QuickResponseContentProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, QuickResponseFactory, InnerQuickResponseQuickResponseContentProviderFactory> WithContent<T1, T2>(this CombinedResult<T1, T2, QuickResponseFactory> combinedResult, Action<Humidifier.Wisdom.QuickResponseTypes.QuickResponseContentProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<QuickResponseFactory, T1, T2, T3, InnerQuickResponseQuickResponseContentProviderFactory> WithContent<T1, T2, T3>(this CombinedResult<QuickResponseFactory, T1, T2, T3> combinedResult, Action<Humidifier.Wisdom.QuickResponseTypes.QuickResponseContentProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, QuickResponseFactory, T2, T3, InnerQuickResponseQuickResponseContentProviderFactory> WithContent<T1, T2, T3>(this CombinedResult<T1, QuickResponseFactory, T2, T3> combinedResult, Action<Humidifier.Wisdom.QuickResponseTypes.QuickResponseContentProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, QuickResponseFactory, T3, InnerQuickResponseQuickResponseContentProviderFactory> WithContent<T1, T2, T3>(this CombinedResult<T1, T2, QuickResponseFactory, T3> combinedResult, Action<Humidifier.Wisdom.QuickResponseTypes.QuickResponseContentProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, QuickResponseFactory, InnerQuickResponseQuickResponseContentProviderFactory> WithContent<T1, T2, T3>(this CombinedResult<T1, T2, T3, QuickResponseFactory> combinedResult, Action<Humidifier.Wisdom.QuickResponseTypes.QuickResponseContentProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<QuickResponseFactory, T1, T2, T3, T4, InnerQuickResponseQuickResponseContentProviderFactory> WithContent<T1, T2, T3, T4>(this CombinedResult<QuickResponseFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Wisdom.QuickResponseTypes.QuickResponseContentProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, QuickResponseFactory, T2, T3, T4, InnerQuickResponseQuickResponseContentProviderFactory> WithContent<T1, T2, T3, T4>(this CombinedResult<T1, QuickResponseFactory, T2, T3, T4> combinedResult, Action<Humidifier.Wisdom.QuickResponseTypes.QuickResponseContentProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, QuickResponseFactory, T3, T4, InnerQuickResponseQuickResponseContentProviderFactory> WithContent<T1, T2, T3, T4>(this CombinedResult<T1, T2, QuickResponseFactory, T3, T4> combinedResult, Action<Humidifier.Wisdom.QuickResponseTypes.QuickResponseContentProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, QuickResponseFactory, T4, InnerQuickResponseQuickResponseContentProviderFactory> WithContent<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, QuickResponseFactory, T4> combinedResult, Action<Humidifier.Wisdom.QuickResponseTypes.QuickResponseContentProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, QuickResponseFactory, InnerQuickResponseQuickResponseContentProviderFactory> WithContent<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, QuickResponseFactory> combinedResult, Action<Humidifier.Wisdom.QuickResponseTypes.QuickResponseContentProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<QuickResponseFactory, T1, InnerQuickResponseGroupingConfigurationFactory> WithGroupingConfiguration<T1>(this CombinedResult<QuickResponseFactory, T1> combinedResult, Action<Humidifier.Wisdom.QuickResponseTypes.GroupingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithGroupingConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, QuickResponseFactory, InnerQuickResponseGroupingConfigurationFactory> WithGroupingConfiguration<T1>(this CombinedResult<T1, QuickResponseFactory> combinedResult, Action<Humidifier.Wisdom.QuickResponseTypes.GroupingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithGroupingConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<QuickResponseFactory, T1, T2, InnerQuickResponseGroupingConfigurationFactory> WithGroupingConfiguration<T1, T2>(this CombinedResult<QuickResponseFactory, T1, T2> combinedResult, Action<Humidifier.Wisdom.QuickResponseTypes.GroupingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGroupingConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, QuickResponseFactory, T2, InnerQuickResponseGroupingConfigurationFactory> WithGroupingConfiguration<T1, T2>(this CombinedResult<T1, QuickResponseFactory, T2> combinedResult, Action<Humidifier.Wisdom.QuickResponseTypes.GroupingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGroupingConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, QuickResponseFactory, InnerQuickResponseGroupingConfigurationFactory> WithGroupingConfiguration<T1, T2>(this CombinedResult<T1, T2, QuickResponseFactory> combinedResult, Action<Humidifier.Wisdom.QuickResponseTypes.GroupingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGroupingConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<QuickResponseFactory, T1, T2, T3, InnerQuickResponseGroupingConfigurationFactory> WithGroupingConfiguration<T1, T2, T3>(this CombinedResult<QuickResponseFactory, T1, T2, T3> combinedResult, Action<Humidifier.Wisdom.QuickResponseTypes.GroupingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGroupingConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, QuickResponseFactory, T2, T3, InnerQuickResponseGroupingConfigurationFactory> WithGroupingConfiguration<T1, T2, T3>(this CombinedResult<T1, QuickResponseFactory, T2, T3> combinedResult, Action<Humidifier.Wisdom.QuickResponseTypes.GroupingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGroupingConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, QuickResponseFactory, T3, InnerQuickResponseGroupingConfigurationFactory> WithGroupingConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, QuickResponseFactory, T3> combinedResult, Action<Humidifier.Wisdom.QuickResponseTypes.GroupingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGroupingConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, QuickResponseFactory, InnerQuickResponseGroupingConfigurationFactory> WithGroupingConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, QuickResponseFactory> combinedResult, Action<Humidifier.Wisdom.QuickResponseTypes.GroupingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGroupingConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<QuickResponseFactory, T1, T2, T3, T4, InnerQuickResponseGroupingConfigurationFactory> WithGroupingConfiguration<T1, T2, T3, T4>(this CombinedResult<QuickResponseFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Wisdom.QuickResponseTypes.GroupingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGroupingConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, QuickResponseFactory, T2, T3, T4, InnerQuickResponseGroupingConfigurationFactory> WithGroupingConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, QuickResponseFactory, T2, T3, T4> combinedResult, Action<Humidifier.Wisdom.QuickResponseTypes.GroupingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGroupingConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, QuickResponseFactory, T3, T4, InnerQuickResponseGroupingConfigurationFactory> WithGroupingConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, QuickResponseFactory, T3, T4> combinedResult, Action<Humidifier.Wisdom.QuickResponseTypes.GroupingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGroupingConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, QuickResponseFactory, T4, InnerQuickResponseGroupingConfigurationFactory> WithGroupingConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, QuickResponseFactory, T4> combinedResult, Action<Humidifier.Wisdom.QuickResponseTypes.GroupingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGroupingConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, QuickResponseFactory, InnerQuickResponseGroupingConfigurationFactory> WithGroupingConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, QuickResponseFactory> combinedResult, Action<Humidifier.Wisdom.QuickResponseTypes.GroupingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGroupingConfiguration(combinedResult.T5, subFactoryAction).T2);
}
