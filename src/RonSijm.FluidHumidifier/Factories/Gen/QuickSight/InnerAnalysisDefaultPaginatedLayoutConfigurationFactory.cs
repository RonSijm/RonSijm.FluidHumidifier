// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerAnalysisDefaultPaginatedLayoutConfigurationFactory(Action<Humidifier.QuickSight.AnalysisTypes.DefaultPaginatedLayoutConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.AnalysisTypes.DefaultPaginatedLayoutConfiguration>
{

    internal InnerAnalysisDefaultSectionBasedLayoutConfigurationFactory SectionBasedFactory { get; set; }

    protected override Humidifier.QuickSight.AnalysisTypes.DefaultPaginatedLayoutConfiguration Create()
    {
        var defaultPaginatedLayoutConfigurationResult = CreateDefaultPaginatedLayoutConfiguration();
        factoryAction?.Invoke(defaultPaginatedLayoutConfigurationResult);

        return defaultPaginatedLayoutConfigurationResult;
    }

    private Humidifier.QuickSight.AnalysisTypes.DefaultPaginatedLayoutConfiguration CreateDefaultPaginatedLayoutConfiguration()
    {
        var defaultPaginatedLayoutConfigurationResult = new Humidifier.QuickSight.AnalysisTypes.DefaultPaginatedLayoutConfiguration();

        return defaultPaginatedLayoutConfigurationResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.AnalysisTypes.DefaultPaginatedLayoutConfiguration result)
    {
        base.CreateChildren(result);

        result.SectionBased ??= SectionBasedFactory?.Build();
    }

} // End Of Class

public static class InnerAnalysisDefaultPaginatedLayoutConfigurationFactoryExtensions
{
    public static CombinedResult<InnerAnalysisDefaultPaginatedLayoutConfigurationFactory, InnerAnalysisDefaultSectionBasedLayoutConfigurationFactory> WithSectionBased(this InnerAnalysisDefaultPaginatedLayoutConfigurationFactory parentFactory, Action<Humidifier.QuickSight.AnalysisTypes.DefaultSectionBasedLayoutConfiguration> subFactoryAction = null)
    {
        parentFactory.SectionBasedFactory = new InnerAnalysisDefaultSectionBasedLayoutConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SectionBasedFactory);
    }

    public static CombinedResult<InnerAnalysisDefaultPaginatedLayoutConfigurationFactory, T1, InnerAnalysisDefaultSectionBasedLayoutConfigurationFactory> WithSectionBased<T1>(this CombinedResult<InnerAnalysisDefaultPaginatedLayoutConfigurationFactory, T1> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.DefaultSectionBasedLayoutConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithSectionBased(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAnalysisDefaultPaginatedLayoutConfigurationFactory, InnerAnalysisDefaultSectionBasedLayoutConfigurationFactory> WithSectionBased<T1>(this CombinedResult<T1, InnerAnalysisDefaultPaginatedLayoutConfigurationFactory> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.DefaultSectionBasedLayoutConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithSectionBased(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerAnalysisDefaultPaginatedLayoutConfigurationFactory, T1, T2, InnerAnalysisDefaultSectionBasedLayoutConfigurationFactory> WithSectionBased<T1, T2>(this CombinedResult<InnerAnalysisDefaultPaginatedLayoutConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.DefaultSectionBasedLayoutConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSectionBased(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAnalysisDefaultPaginatedLayoutConfigurationFactory, T2, InnerAnalysisDefaultSectionBasedLayoutConfigurationFactory> WithSectionBased<T1, T2>(this CombinedResult<T1, InnerAnalysisDefaultPaginatedLayoutConfigurationFactory, T2> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.DefaultSectionBasedLayoutConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSectionBased(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAnalysisDefaultPaginatedLayoutConfigurationFactory, InnerAnalysisDefaultSectionBasedLayoutConfigurationFactory> WithSectionBased<T1, T2>(this CombinedResult<T1, T2, InnerAnalysisDefaultPaginatedLayoutConfigurationFactory> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.DefaultSectionBasedLayoutConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSectionBased(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerAnalysisDefaultPaginatedLayoutConfigurationFactory, T1, T2, T3, InnerAnalysisDefaultSectionBasedLayoutConfigurationFactory> WithSectionBased<T1, T2, T3>(this CombinedResult<InnerAnalysisDefaultPaginatedLayoutConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.DefaultSectionBasedLayoutConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSectionBased(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAnalysisDefaultPaginatedLayoutConfigurationFactory, T2, T3, InnerAnalysisDefaultSectionBasedLayoutConfigurationFactory> WithSectionBased<T1, T2, T3>(this CombinedResult<T1, InnerAnalysisDefaultPaginatedLayoutConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.DefaultSectionBasedLayoutConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSectionBased(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAnalysisDefaultPaginatedLayoutConfigurationFactory, T3, InnerAnalysisDefaultSectionBasedLayoutConfigurationFactory> WithSectionBased<T1, T2, T3>(this CombinedResult<T1, T2, InnerAnalysisDefaultPaginatedLayoutConfigurationFactory, T3> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.DefaultSectionBasedLayoutConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSectionBased(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAnalysisDefaultPaginatedLayoutConfigurationFactory, InnerAnalysisDefaultSectionBasedLayoutConfigurationFactory> WithSectionBased<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAnalysisDefaultPaginatedLayoutConfigurationFactory> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.DefaultSectionBasedLayoutConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSectionBased(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerAnalysisDefaultPaginatedLayoutConfigurationFactory, T1, T2, T3, T4, InnerAnalysisDefaultSectionBasedLayoutConfigurationFactory> WithSectionBased<T1, T2, T3, T4>(this CombinedResult<InnerAnalysisDefaultPaginatedLayoutConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.DefaultSectionBasedLayoutConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSectionBased(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAnalysisDefaultPaginatedLayoutConfigurationFactory, T2, T3, T4, InnerAnalysisDefaultSectionBasedLayoutConfigurationFactory> WithSectionBased<T1, T2, T3, T4>(this CombinedResult<T1, InnerAnalysisDefaultPaginatedLayoutConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.DefaultSectionBasedLayoutConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSectionBased(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAnalysisDefaultPaginatedLayoutConfigurationFactory, T3, T4, InnerAnalysisDefaultSectionBasedLayoutConfigurationFactory> WithSectionBased<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAnalysisDefaultPaginatedLayoutConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.DefaultSectionBasedLayoutConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSectionBased(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAnalysisDefaultPaginatedLayoutConfigurationFactory, T4, InnerAnalysisDefaultSectionBasedLayoutConfigurationFactory> WithSectionBased<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAnalysisDefaultPaginatedLayoutConfigurationFactory, T4> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.DefaultSectionBasedLayoutConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSectionBased(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerAnalysisDefaultPaginatedLayoutConfigurationFactory, InnerAnalysisDefaultSectionBasedLayoutConfigurationFactory> WithSectionBased<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAnalysisDefaultPaginatedLayoutConfigurationFactory> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.DefaultSectionBasedLayoutConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSectionBased(combinedResult.T5, subFactoryAction));
}
