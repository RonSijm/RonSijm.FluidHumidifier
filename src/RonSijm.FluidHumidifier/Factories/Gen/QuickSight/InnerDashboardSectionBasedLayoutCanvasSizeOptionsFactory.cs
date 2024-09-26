// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDashboardSectionBasedLayoutCanvasSizeOptionsFactory(Action<Humidifier.QuickSight.DashboardTypes.SectionBasedLayoutCanvasSizeOptions> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DashboardTypes.SectionBasedLayoutCanvasSizeOptions>
{

    internal InnerDashboardSectionBasedLayoutPaperCanvasSizeOptionsFactory PaperCanvasSizeOptionsFactory { get; set; }

    protected override Humidifier.QuickSight.DashboardTypes.SectionBasedLayoutCanvasSizeOptions Create()
    {
        var sectionBasedLayoutCanvasSizeOptionsResult = CreateSectionBasedLayoutCanvasSizeOptions();
        factoryAction?.Invoke(sectionBasedLayoutCanvasSizeOptionsResult);

        return sectionBasedLayoutCanvasSizeOptionsResult;
    }

    private Humidifier.QuickSight.DashboardTypes.SectionBasedLayoutCanvasSizeOptions CreateSectionBasedLayoutCanvasSizeOptions()
    {
        var sectionBasedLayoutCanvasSizeOptionsResult = new Humidifier.QuickSight.DashboardTypes.SectionBasedLayoutCanvasSizeOptions();

        return sectionBasedLayoutCanvasSizeOptionsResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.DashboardTypes.SectionBasedLayoutCanvasSizeOptions result)
    {
        base.CreateChildren(result);

        result.PaperCanvasSizeOptions ??= PaperCanvasSizeOptionsFactory?.Build();
    }

} // End Of Class

public static class InnerDashboardSectionBasedLayoutCanvasSizeOptionsFactoryExtensions
{
    public static CombinedResult<InnerDashboardSectionBasedLayoutCanvasSizeOptionsFactory, InnerDashboardSectionBasedLayoutPaperCanvasSizeOptionsFactory> WithPaperCanvasSizeOptions(this InnerDashboardSectionBasedLayoutCanvasSizeOptionsFactory parentFactory, Action<Humidifier.QuickSight.DashboardTypes.SectionBasedLayoutPaperCanvasSizeOptions> subFactoryAction = null)
    {
        parentFactory.PaperCanvasSizeOptionsFactory = new InnerDashboardSectionBasedLayoutPaperCanvasSizeOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PaperCanvasSizeOptionsFactory);
    }

    public static CombinedResult<InnerDashboardSectionBasedLayoutCanvasSizeOptionsFactory, T1, InnerDashboardSectionBasedLayoutPaperCanvasSizeOptionsFactory> WithPaperCanvasSizeOptions<T1>(this CombinedResult<InnerDashboardSectionBasedLayoutCanvasSizeOptionsFactory, T1> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.SectionBasedLayoutPaperCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithPaperCanvasSizeOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDashboardSectionBasedLayoutCanvasSizeOptionsFactory, InnerDashboardSectionBasedLayoutPaperCanvasSizeOptionsFactory> WithPaperCanvasSizeOptions<T1>(this CombinedResult<T1, InnerDashboardSectionBasedLayoutCanvasSizeOptionsFactory> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.SectionBasedLayoutPaperCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithPaperCanvasSizeOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDashboardSectionBasedLayoutCanvasSizeOptionsFactory, T1, T2, InnerDashboardSectionBasedLayoutPaperCanvasSizeOptionsFactory> WithPaperCanvasSizeOptions<T1, T2>(this CombinedResult<InnerDashboardSectionBasedLayoutCanvasSizeOptionsFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.SectionBasedLayoutPaperCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPaperCanvasSizeOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDashboardSectionBasedLayoutCanvasSizeOptionsFactory, T2, InnerDashboardSectionBasedLayoutPaperCanvasSizeOptionsFactory> WithPaperCanvasSizeOptions<T1, T2>(this CombinedResult<T1, InnerDashboardSectionBasedLayoutCanvasSizeOptionsFactory, T2> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.SectionBasedLayoutPaperCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPaperCanvasSizeOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDashboardSectionBasedLayoutCanvasSizeOptionsFactory, InnerDashboardSectionBasedLayoutPaperCanvasSizeOptionsFactory> WithPaperCanvasSizeOptions<T1, T2>(this CombinedResult<T1, T2, InnerDashboardSectionBasedLayoutCanvasSizeOptionsFactory> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.SectionBasedLayoutPaperCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPaperCanvasSizeOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDashboardSectionBasedLayoutCanvasSizeOptionsFactory, T1, T2, T3, InnerDashboardSectionBasedLayoutPaperCanvasSizeOptionsFactory> WithPaperCanvasSizeOptions<T1, T2, T3>(this CombinedResult<InnerDashboardSectionBasedLayoutCanvasSizeOptionsFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.SectionBasedLayoutPaperCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPaperCanvasSizeOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDashboardSectionBasedLayoutCanvasSizeOptionsFactory, T2, T3, InnerDashboardSectionBasedLayoutPaperCanvasSizeOptionsFactory> WithPaperCanvasSizeOptions<T1, T2, T3>(this CombinedResult<T1, InnerDashboardSectionBasedLayoutCanvasSizeOptionsFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.SectionBasedLayoutPaperCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPaperCanvasSizeOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDashboardSectionBasedLayoutCanvasSizeOptionsFactory, T3, InnerDashboardSectionBasedLayoutPaperCanvasSizeOptionsFactory> WithPaperCanvasSizeOptions<T1, T2, T3>(this CombinedResult<T1, T2, InnerDashboardSectionBasedLayoutCanvasSizeOptionsFactory, T3> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.SectionBasedLayoutPaperCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPaperCanvasSizeOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDashboardSectionBasedLayoutCanvasSizeOptionsFactory, InnerDashboardSectionBasedLayoutPaperCanvasSizeOptionsFactory> WithPaperCanvasSizeOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDashboardSectionBasedLayoutCanvasSizeOptionsFactory> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.SectionBasedLayoutPaperCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPaperCanvasSizeOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDashboardSectionBasedLayoutCanvasSizeOptionsFactory, T1, T2, T3, T4, InnerDashboardSectionBasedLayoutPaperCanvasSizeOptionsFactory> WithPaperCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<InnerDashboardSectionBasedLayoutCanvasSizeOptionsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.SectionBasedLayoutPaperCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPaperCanvasSizeOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDashboardSectionBasedLayoutCanvasSizeOptionsFactory, T2, T3, T4, InnerDashboardSectionBasedLayoutPaperCanvasSizeOptionsFactory> WithPaperCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<T1, InnerDashboardSectionBasedLayoutCanvasSizeOptionsFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.SectionBasedLayoutPaperCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPaperCanvasSizeOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDashboardSectionBasedLayoutCanvasSizeOptionsFactory, T3, T4, InnerDashboardSectionBasedLayoutPaperCanvasSizeOptionsFactory> WithPaperCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDashboardSectionBasedLayoutCanvasSizeOptionsFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.SectionBasedLayoutPaperCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPaperCanvasSizeOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDashboardSectionBasedLayoutCanvasSizeOptionsFactory, T4, InnerDashboardSectionBasedLayoutPaperCanvasSizeOptionsFactory> WithPaperCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDashboardSectionBasedLayoutCanvasSizeOptionsFactory, T4> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.SectionBasedLayoutPaperCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPaperCanvasSizeOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDashboardSectionBasedLayoutCanvasSizeOptionsFactory, InnerDashboardSectionBasedLayoutPaperCanvasSizeOptionsFactory> WithPaperCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDashboardSectionBasedLayoutCanvasSizeOptionsFactory> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.SectionBasedLayoutPaperCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPaperCanvasSizeOptions(combinedResult.T5, subFactoryAction));
}
