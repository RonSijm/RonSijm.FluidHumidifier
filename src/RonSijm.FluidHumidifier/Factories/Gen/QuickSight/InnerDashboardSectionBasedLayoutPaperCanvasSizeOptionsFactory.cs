// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDashboardSectionBasedLayoutPaperCanvasSizeOptionsFactory(Action<Humidifier.QuickSight.DashboardTypes.SectionBasedLayoutPaperCanvasSizeOptions> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DashboardTypes.SectionBasedLayoutPaperCanvasSizeOptions>
{

    internal InnerDashboardSpacingFactory PaperMarginFactory { get; set; }

    protected override Humidifier.QuickSight.DashboardTypes.SectionBasedLayoutPaperCanvasSizeOptions Create()
    {
        var sectionBasedLayoutPaperCanvasSizeOptionsResult = CreateSectionBasedLayoutPaperCanvasSizeOptions();
        factoryAction?.Invoke(sectionBasedLayoutPaperCanvasSizeOptionsResult);

        return sectionBasedLayoutPaperCanvasSizeOptionsResult;
    }

    private Humidifier.QuickSight.DashboardTypes.SectionBasedLayoutPaperCanvasSizeOptions CreateSectionBasedLayoutPaperCanvasSizeOptions()
    {
        var sectionBasedLayoutPaperCanvasSizeOptionsResult = new Humidifier.QuickSight.DashboardTypes.SectionBasedLayoutPaperCanvasSizeOptions();

        return sectionBasedLayoutPaperCanvasSizeOptionsResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.DashboardTypes.SectionBasedLayoutPaperCanvasSizeOptions result)
    {
        base.CreateChildren(result);

        result.PaperMargin ??= PaperMarginFactory?.Build();
    }

} // End Of Class

public static class InnerDashboardSectionBasedLayoutPaperCanvasSizeOptionsFactoryExtensions
{
    public static CombinedResult<InnerDashboardSectionBasedLayoutPaperCanvasSizeOptionsFactory, InnerDashboardSpacingFactory> WithPaperMargin(this InnerDashboardSectionBasedLayoutPaperCanvasSizeOptionsFactory parentFactory, Action<Humidifier.QuickSight.DashboardTypes.Spacing> subFactoryAction = null)
    {
        parentFactory.PaperMarginFactory = new InnerDashboardSpacingFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PaperMarginFactory);
    }

    public static CombinedResult<InnerDashboardSectionBasedLayoutPaperCanvasSizeOptionsFactory, T1, InnerDashboardSpacingFactory> WithPaperMargin<T1>(this CombinedResult<InnerDashboardSectionBasedLayoutPaperCanvasSizeOptionsFactory, T1> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.Spacing> subFactoryAction = null) => new (combinedResult, combinedResult, WithPaperMargin(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDashboardSectionBasedLayoutPaperCanvasSizeOptionsFactory, InnerDashboardSpacingFactory> WithPaperMargin<T1>(this CombinedResult<T1, InnerDashboardSectionBasedLayoutPaperCanvasSizeOptionsFactory> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.Spacing> subFactoryAction = null) => new (combinedResult, combinedResult, WithPaperMargin(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDashboardSectionBasedLayoutPaperCanvasSizeOptionsFactory, T1, T2, InnerDashboardSpacingFactory> WithPaperMargin<T1, T2>(this CombinedResult<InnerDashboardSectionBasedLayoutPaperCanvasSizeOptionsFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.Spacing> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPaperMargin(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDashboardSectionBasedLayoutPaperCanvasSizeOptionsFactory, T2, InnerDashboardSpacingFactory> WithPaperMargin<T1, T2>(this CombinedResult<T1, InnerDashboardSectionBasedLayoutPaperCanvasSizeOptionsFactory, T2> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.Spacing> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPaperMargin(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDashboardSectionBasedLayoutPaperCanvasSizeOptionsFactory, InnerDashboardSpacingFactory> WithPaperMargin<T1, T2>(this CombinedResult<T1, T2, InnerDashboardSectionBasedLayoutPaperCanvasSizeOptionsFactory> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.Spacing> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPaperMargin(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDashboardSectionBasedLayoutPaperCanvasSizeOptionsFactory, T1, T2, T3, InnerDashboardSpacingFactory> WithPaperMargin<T1, T2, T3>(this CombinedResult<InnerDashboardSectionBasedLayoutPaperCanvasSizeOptionsFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.Spacing> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPaperMargin(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDashboardSectionBasedLayoutPaperCanvasSizeOptionsFactory, T2, T3, InnerDashboardSpacingFactory> WithPaperMargin<T1, T2, T3>(this CombinedResult<T1, InnerDashboardSectionBasedLayoutPaperCanvasSizeOptionsFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.Spacing> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPaperMargin(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDashboardSectionBasedLayoutPaperCanvasSizeOptionsFactory, T3, InnerDashboardSpacingFactory> WithPaperMargin<T1, T2, T3>(this CombinedResult<T1, T2, InnerDashboardSectionBasedLayoutPaperCanvasSizeOptionsFactory, T3> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.Spacing> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPaperMargin(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDashboardSectionBasedLayoutPaperCanvasSizeOptionsFactory, InnerDashboardSpacingFactory> WithPaperMargin<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDashboardSectionBasedLayoutPaperCanvasSizeOptionsFactory> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.Spacing> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPaperMargin(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDashboardSectionBasedLayoutPaperCanvasSizeOptionsFactory, T1, T2, T3, T4, InnerDashboardSpacingFactory> WithPaperMargin<T1, T2, T3, T4>(this CombinedResult<InnerDashboardSectionBasedLayoutPaperCanvasSizeOptionsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.Spacing> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPaperMargin(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDashboardSectionBasedLayoutPaperCanvasSizeOptionsFactory, T2, T3, T4, InnerDashboardSpacingFactory> WithPaperMargin<T1, T2, T3, T4>(this CombinedResult<T1, InnerDashboardSectionBasedLayoutPaperCanvasSizeOptionsFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.Spacing> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPaperMargin(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDashboardSectionBasedLayoutPaperCanvasSizeOptionsFactory, T3, T4, InnerDashboardSpacingFactory> WithPaperMargin<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDashboardSectionBasedLayoutPaperCanvasSizeOptionsFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.Spacing> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPaperMargin(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDashboardSectionBasedLayoutPaperCanvasSizeOptionsFactory, T4, InnerDashboardSpacingFactory> WithPaperMargin<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDashboardSectionBasedLayoutPaperCanvasSizeOptionsFactory, T4> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.Spacing> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPaperMargin(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDashboardSectionBasedLayoutPaperCanvasSizeOptionsFactory, InnerDashboardSpacingFactory> WithPaperMargin<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDashboardSectionBasedLayoutPaperCanvasSizeOptionsFactory> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.Spacing> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPaperMargin(combinedResult.T5, subFactoryAction));
}
