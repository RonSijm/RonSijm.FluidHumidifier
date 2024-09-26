// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDashboardFreeFormLayoutCanvasSizeOptionsFactory(Action<Humidifier.QuickSight.DashboardTypes.FreeFormLayoutCanvasSizeOptions> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DashboardTypes.FreeFormLayoutCanvasSizeOptions>
{

    internal InnerDashboardFreeFormLayoutScreenCanvasSizeOptionsFactory ScreenCanvasSizeOptionsFactory { get; set; }

    protected override Humidifier.QuickSight.DashboardTypes.FreeFormLayoutCanvasSizeOptions Create()
    {
        var freeFormLayoutCanvasSizeOptionsResult = CreateFreeFormLayoutCanvasSizeOptions();
        factoryAction?.Invoke(freeFormLayoutCanvasSizeOptionsResult);

        return freeFormLayoutCanvasSizeOptionsResult;
    }

    private Humidifier.QuickSight.DashboardTypes.FreeFormLayoutCanvasSizeOptions CreateFreeFormLayoutCanvasSizeOptions()
    {
        var freeFormLayoutCanvasSizeOptionsResult = new Humidifier.QuickSight.DashboardTypes.FreeFormLayoutCanvasSizeOptions();

        return freeFormLayoutCanvasSizeOptionsResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.DashboardTypes.FreeFormLayoutCanvasSizeOptions result)
    {
        base.CreateChildren(result);

        result.ScreenCanvasSizeOptions ??= ScreenCanvasSizeOptionsFactory?.Build();
    }

} // End Of Class

public static class InnerDashboardFreeFormLayoutCanvasSizeOptionsFactoryExtensions
{
    public static CombinedResult<InnerDashboardFreeFormLayoutCanvasSizeOptionsFactory, InnerDashboardFreeFormLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions(this InnerDashboardFreeFormLayoutCanvasSizeOptionsFactory parentFactory, Action<Humidifier.QuickSight.DashboardTypes.FreeFormLayoutScreenCanvasSizeOptions> subFactoryAction = null)
    {
        parentFactory.ScreenCanvasSizeOptionsFactory = new InnerDashboardFreeFormLayoutScreenCanvasSizeOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ScreenCanvasSizeOptionsFactory);
    }

    public static CombinedResult<InnerDashboardFreeFormLayoutCanvasSizeOptionsFactory, T1, InnerDashboardFreeFormLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1>(this CombinedResult<InnerDashboardFreeFormLayoutCanvasSizeOptionsFactory, T1> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.FreeFormLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDashboardFreeFormLayoutCanvasSizeOptionsFactory, InnerDashboardFreeFormLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1>(this CombinedResult<T1, InnerDashboardFreeFormLayoutCanvasSizeOptionsFactory> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.FreeFormLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDashboardFreeFormLayoutCanvasSizeOptionsFactory, T1, T2, InnerDashboardFreeFormLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1, T2>(this CombinedResult<InnerDashboardFreeFormLayoutCanvasSizeOptionsFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.FreeFormLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDashboardFreeFormLayoutCanvasSizeOptionsFactory, T2, InnerDashboardFreeFormLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1, T2>(this CombinedResult<T1, InnerDashboardFreeFormLayoutCanvasSizeOptionsFactory, T2> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.FreeFormLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDashboardFreeFormLayoutCanvasSizeOptionsFactory, InnerDashboardFreeFormLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1, T2>(this CombinedResult<T1, T2, InnerDashboardFreeFormLayoutCanvasSizeOptionsFactory> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.FreeFormLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDashboardFreeFormLayoutCanvasSizeOptionsFactory, T1, T2, T3, InnerDashboardFreeFormLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1, T2, T3>(this CombinedResult<InnerDashboardFreeFormLayoutCanvasSizeOptionsFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.FreeFormLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDashboardFreeFormLayoutCanvasSizeOptionsFactory, T2, T3, InnerDashboardFreeFormLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1, T2, T3>(this CombinedResult<T1, InnerDashboardFreeFormLayoutCanvasSizeOptionsFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.FreeFormLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDashboardFreeFormLayoutCanvasSizeOptionsFactory, T3, InnerDashboardFreeFormLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1, T2, T3>(this CombinedResult<T1, T2, InnerDashboardFreeFormLayoutCanvasSizeOptionsFactory, T3> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.FreeFormLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDashboardFreeFormLayoutCanvasSizeOptionsFactory, InnerDashboardFreeFormLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDashboardFreeFormLayoutCanvasSizeOptionsFactory> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.FreeFormLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDashboardFreeFormLayoutCanvasSizeOptionsFactory, T1, T2, T3, T4, InnerDashboardFreeFormLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<InnerDashboardFreeFormLayoutCanvasSizeOptionsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.FreeFormLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDashboardFreeFormLayoutCanvasSizeOptionsFactory, T2, T3, T4, InnerDashboardFreeFormLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<T1, InnerDashboardFreeFormLayoutCanvasSizeOptionsFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.FreeFormLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDashboardFreeFormLayoutCanvasSizeOptionsFactory, T3, T4, InnerDashboardFreeFormLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDashboardFreeFormLayoutCanvasSizeOptionsFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.FreeFormLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDashboardFreeFormLayoutCanvasSizeOptionsFactory, T4, InnerDashboardFreeFormLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDashboardFreeFormLayoutCanvasSizeOptionsFactory, T4> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.FreeFormLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDashboardFreeFormLayoutCanvasSizeOptionsFactory, InnerDashboardFreeFormLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDashboardFreeFormLayoutCanvasSizeOptionsFactory> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.FreeFormLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T5, subFactoryAction));
}
