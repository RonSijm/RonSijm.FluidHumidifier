// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerTemplateDefaultPaginatedLayoutConfigurationFactory(Action<Humidifier.QuickSight.TemplateTypes.DefaultPaginatedLayoutConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.TemplateTypes.DefaultPaginatedLayoutConfiguration>
{

    internal InnerTemplateDefaultSectionBasedLayoutConfigurationFactory SectionBasedFactory { get; set; }

    protected override Humidifier.QuickSight.TemplateTypes.DefaultPaginatedLayoutConfiguration Create()
    {
        var defaultPaginatedLayoutConfigurationResult = CreateDefaultPaginatedLayoutConfiguration();
        factoryAction?.Invoke(defaultPaginatedLayoutConfigurationResult);

        return defaultPaginatedLayoutConfigurationResult;
    }

    private Humidifier.QuickSight.TemplateTypes.DefaultPaginatedLayoutConfiguration CreateDefaultPaginatedLayoutConfiguration()
    {
        var defaultPaginatedLayoutConfigurationResult = new Humidifier.QuickSight.TemplateTypes.DefaultPaginatedLayoutConfiguration();

        return defaultPaginatedLayoutConfigurationResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.TemplateTypes.DefaultPaginatedLayoutConfiguration result)
    {
        base.CreateChildren(result);

        result.SectionBased ??= SectionBasedFactory?.Build();
    }

} // End Of Class

public static class InnerTemplateDefaultPaginatedLayoutConfigurationFactoryExtensions
{
    public static CombinedResult<InnerTemplateDefaultPaginatedLayoutConfigurationFactory, InnerTemplateDefaultSectionBasedLayoutConfigurationFactory> WithSectionBased(this InnerTemplateDefaultPaginatedLayoutConfigurationFactory parentFactory, Action<Humidifier.QuickSight.TemplateTypes.DefaultSectionBasedLayoutConfiguration> subFactoryAction = null)
    {
        parentFactory.SectionBasedFactory = new InnerTemplateDefaultSectionBasedLayoutConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SectionBasedFactory);
    }

    public static CombinedResult<InnerTemplateDefaultPaginatedLayoutConfigurationFactory, T1, InnerTemplateDefaultSectionBasedLayoutConfigurationFactory> WithSectionBased<T1>(this CombinedResult<InnerTemplateDefaultPaginatedLayoutConfigurationFactory, T1> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.DefaultSectionBasedLayoutConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithSectionBased(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplateDefaultPaginatedLayoutConfigurationFactory, InnerTemplateDefaultSectionBasedLayoutConfigurationFactory> WithSectionBased<T1>(this CombinedResult<T1, InnerTemplateDefaultPaginatedLayoutConfigurationFactory> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.DefaultSectionBasedLayoutConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithSectionBased(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTemplateDefaultPaginatedLayoutConfigurationFactory, T1, T2, InnerTemplateDefaultSectionBasedLayoutConfigurationFactory> WithSectionBased<T1, T2>(this CombinedResult<InnerTemplateDefaultPaginatedLayoutConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.DefaultSectionBasedLayoutConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSectionBased(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplateDefaultPaginatedLayoutConfigurationFactory, T2, InnerTemplateDefaultSectionBasedLayoutConfigurationFactory> WithSectionBased<T1, T2>(this CombinedResult<T1, InnerTemplateDefaultPaginatedLayoutConfigurationFactory, T2> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.DefaultSectionBasedLayoutConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSectionBased(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTemplateDefaultPaginatedLayoutConfigurationFactory, InnerTemplateDefaultSectionBasedLayoutConfigurationFactory> WithSectionBased<T1, T2>(this CombinedResult<T1, T2, InnerTemplateDefaultPaginatedLayoutConfigurationFactory> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.DefaultSectionBasedLayoutConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSectionBased(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTemplateDefaultPaginatedLayoutConfigurationFactory, T1, T2, T3, InnerTemplateDefaultSectionBasedLayoutConfigurationFactory> WithSectionBased<T1, T2, T3>(this CombinedResult<InnerTemplateDefaultPaginatedLayoutConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.DefaultSectionBasedLayoutConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSectionBased(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplateDefaultPaginatedLayoutConfigurationFactory, T2, T3, InnerTemplateDefaultSectionBasedLayoutConfigurationFactory> WithSectionBased<T1, T2, T3>(this CombinedResult<T1, InnerTemplateDefaultPaginatedLayoutConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.DefaultSectionBasedLayoutConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSectionBased(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTemplateDefaultPaginatedLayoutConfigurationFactory, T3, InnerTemplateDefaultSectionBasedLayoutConfigurationFactory> WithSectionBased<T1, T2, T3>(this CombinedResult<T1, T2, InnerTemplateDefaultPaginatedLayoutConfigurationFactory, T3> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.DefaultSectionBasedLayoutConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSectionBased(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTemplateDefaultPaginatedLayoutConfigurationFactory, InnerTemplateDefaultSectionBasedLayoutConfigurationFactory> WithSectionBased<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTemplateDefaultPaginatedLayoutConfigurationFactory> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.DefaultSectionBasedLayoutConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSectionBased(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTemplateDefaultPaginatedLayoutConfigurationFactory, T1, T2, T3, T4, InnerTemplateDefaultSectionBasedLayoutConfigurationFactory> WithSectionBased<T1, T2, T3, T4>(this CombinedResult<InnerTemplateDefaultPaginatedLayoutConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.DefaultSectionBasedLayoutConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSectionBased(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplateDefaultPaginatedLayoutConfigurationFactory, T2, T3, T4, InnerTemplateDefaultSectionBasedLayoutConfigurationFactory> WithSectionBased<T1, T2, T3, T4>(this CombinedResult<T1, InnerTemplateDefaultPaginatedLayoutConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.DefaultSectionBasedLayoutConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSectionBased(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTemplateDefaultPaginatedLayoutConfigurationFactory, T3, T4, InnerTemplateDefaultSectionBasedLayoutConfigurationFactory> WithSectionBased<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTemplateDefaultPaginatedLayoutConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.DefaultSectionBasedLayoutConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSectionBased(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTemplateDefaultPaginatedLayoutConfigurationFactory, T4, InnerTemplateDefaultSectionBasedLayoutConfigurationFactory> WithSectionBased<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTemplateDefaultPaginatedLayoutConfigurationFactory, T4> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.DefaultSectionBasedLayoutConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSectionBased(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTemplateDefaultPaginatedLayoutConfigurationFactory, InnerTemplateDefaultSectionBasedLayoutConfigurationFactory> WithSectionBased<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTemplateDefaultPaginatedLayoutConfigurationFactory> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.DefaultSectionBasedLayoutConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSectionBased(combinedResult.T5, subFactoryAction));
}
