// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDashboardDefaultPaginatedLayoutConfigurationFactory(Action<Humidifier.QuickSight.DashboardTypes.DefaultPaginatedLayoutConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DashboardTypes.DefaultPaginatedLayoutConfiguration>
{

    internal InnerDashboardDefaultSectionBasedLayoutConfigurationFactory SectionBasedFactory { get; set; }

    protected override Humidifier.QuickSight.DashboardTypes.DefaultPaginatedLayoutConfiguration Create()
    {
        var defaultPaginatedLayoutConfigurationResult = CreateDefaultPaginatedLayoutConfiguration();
        factoryAction?.Invoke(defaultPaginatedLayoutConfigurationResult);

        return defaultPaginatedLayoutConfigurationResult;
    }

    private Humidifier.QuickSight.DashboardTypes.DefaultPaginatedLayoutConfiguration CreateDefaultPaginatedLayoutConfiguration()
    {
        var defaultPaginatedLayoutConfigurationResult = new Humidifier.QuickSight.DashboardTypes.DefaultPaginatedLayoutConfiguration();

        return defaultPaginatedLayoutConfigurationResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.DashboardTypes.DefaultPaginatedLayoutConfiguration result)
    {
        base.CreateChildren(result);

        result.SectionBased ??= SectionBasedFactory?.Build();
    }

} // End Of Class

public static class InnerDashboardDefaultPaginatedLayoutConfigurationFactoryExtensions
{
    public static CombinedResult<InnerDashboardDefaultPaginatedLayoutConfigurationFactory, InnerDashboardDefaultSectionBasedLayoutConfigurationFactory> WithSectionBased(this InnerDashboardDefaultPaginatedLayoutConfigurationFactory parentFactory, Action<Humidifier.QuickSight.DashboardTypes.DefaultSectionBasedLayoutConfiguration> subFactoryAction = null)
    {
        parentFactory.SectionBasedFactory = new InnerDashboardDefaultSectionBasedLayoutConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SectionBasedFactory);
    }

    public static CombinedResult<InnerDashboardDefaultPaginatedLayoutConfigurationFactory, T1, InnerDashboardDefaultSectionBasedLayoutConfigurationFactory> WithSectionBased<T1>(this CombinedResult<InnerDashboardDefaultPaginatedLayoutConfigurationFactory, T1> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.DefaultSectionBasedLayoutConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithSectionBased(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDashboardDefaultPaginatedLayoutConfigurationFactory, InnerDashboardDefaultSectionBasedLayoutConfigurationFactory> WithSectionBased<T1>(this CombinedResult<T1, InnerDashboardDefaultPaginatedLayoutConfigurationFactory> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.DefaultSectionBasedLayoutConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithSectionBased(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDashboardDefaultPaginatedLayoutConfigurationFactory, T1, T2, InnerDashboardDefaultSectionBasedLayoutConfigurationFactory> WithSectionBased<T1, T2>(this CombinedResult<InnerDashboardDefaultPaginatedLayoutConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.DefaultSectionBasedLayoutConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSectionBased(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDashboardDefaultPaginatedLayoutConfigurationFactory, T2, InnerDashboardDefaultSectionBasedLayoutConfigurationFactory> WithSectionBased<T1, T2>(this CombinedResult<T1, InnerDashboardDefaultPaginatedLayoutConfigurationFactory, T2> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.DefaultSectionBasedLayoutConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSectionBased(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDashboardDefaultPaginatedLayoutConfigurationFactory, InnerDashboardDefaultSectionBasedLayoutConfigurationFactory> WithSectionBased<T1, T2>(this CombinedResult<T1, T2, InnerDashboardDefaultPaginatedLayoutConfigurationFactory> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.DefaultSectionBasedLayoutConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSectionBased(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDashboardDefaultPaginatedLayoutConfigurationFactory, T1, T2, T3, InnerDashboardDefaultSectionBasedLayoutConfigurationFactory> WithSectionBased<T1, T2, T3>(this CombinedResult<InnerDashboardDefaultPaginatedLayoutConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.DefaultSectionBasedLayoutConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSectionBased(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDashboardDefaultPaginatedLayoutConfigurationFactory, T2, T3, InnerDashboardDefaultSectionBasedLayoutConfigurationFactory> WithSectionBased<T1, T2, T3>(this CombinedResult<T1, InnerDashboardDefaultPaginatedLayoutConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.DefaultSectionBasedLayoutConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSectionBased(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDashboardDefaultPaginatedLayoutConfigurationFactory, T3, InnerDashboardDefaultSectionBasedLayoutConfigurationFactory> WithSectionBased<T1, T2, T3>(this CombinedResult<T1, T2, InnerDashboardDefaultPaginatedLayoutConfigurationFactory, T3> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.DefaultSectionBasedLayoutConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSectionBased(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDashboardDefaultPaginatedLayoutConfigurationFactory, InnerDashboardDefaultSectionBasedLayoutConfigurationFactory> WithSectionBased<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDashboardDefaultPaginatedLayoutConfigurationFactory> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.DefaultSectionBasedLayoutConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSectionBased(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDashboardDefaultPaginatedLayoutConfigurationFactory, T1, T2, T3, T4, InnerDashboardDefaultSectionBasedLayoutConfigurationFactory> WithSectionBased<T1, T2, T3, T4>(this CombinedResult<InnerDashboardDefaultPaginatedLayoutConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.DefaultSectionBasedLayoutConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSectionBased(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDashboardDefaultPaginatedLayoutConfigurationFactory, T2, T3, T4, InnerDashboardDefaultSectionBasedLayoutConfigurationFactory> WithSectionBased<T1, T2, T3, T4>(this CombinedResult<T1, InnerDashboardDefaultPaginatedLayoutConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.DefaultSectionBasedLayoutConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSectionBased(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDashboardDefaultPaginatedLayoutConfigurationFactory, T3, T4, InnerDashboardDefaultSectionBasedLayoutConfigurationFactory> WithSectionBased<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDashboardDefaultPaginatedLayoutConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.DefaultSectionBasedLayoutConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSectionBased(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDashboardDefaultPaginatedLayoutConfigurationFactory, T4, InnerDashboardDefaultSectionBasedLayoutConfigurationFactory> WithSectionBased<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDashboardDefaultPaginatedLayoutConfigurationFactory, T4> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.DefaultSectionBasedLayoutConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSectionBased(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDashboardDefaultPaginatedLayoutConfigurationFactory, InnerDashboardDefaultSectionBasedLayoutConfigurationFactory> WithSectionBased<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDashboardDefaultPaginatedLayoutConfigurationFactory> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.DefaultSectionBasedLayoutConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSectionBased(combinedResult.T5, subFactoryAction));
}
