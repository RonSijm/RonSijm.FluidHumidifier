// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerTemplateDefaultGridLayoutConfigurationFactory(Action<Humidifier.QuickSight.TemplateTypes.DefaultGridLayoutConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.TemplateTypes.DefaultGridLayoutConfiguration>
{

    internal InnerTemplateGridLayoutCanvasSizeOptionsFactory CanvasSizeOptionsFactory { get; set; }

    protected override Humidifier.QuickSight.TemplateTypes.DefaultGridLayoutConfiguration Create()
    {
        var defaultGridLayoutConfigurationResult = CreateDefaultGridLayoutConfiguration();
        factoryAction?.Invoke(defaultGridLayoutConfigurationResult);

        return defaultGridLayoutConfigurationResult;
    }

    private Humidifier.QuickSight.TemplateTypes.DefaultGridLayoutConfiguration CreateDefaultGridLayoutConfiguration()
    {
        var defaultGridLayoutConfigurationResult = new Humidifier.QuickSight.TemplateTypes.DefaultGridLayoutConfiguration();

        return defaultGridLayoutConfigurationResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.TemplateTypes.DefaultGridLayoutConfiguration result)
    {
        base.CreateChildren(result);

        result.CanvasSizeOptions ??= CanvasSizeOptionsFactory?.Build();
    }

} // End Of Class

public static class InnerTemplateDefaultGridLayoutConfigurationFactoryExtensions
{
    public static CombinedResult<InnerTemplateDefaultGridLayoutConfigurationFactory, InnerTemplateGridLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions(this InnerTemplateDefaultGridLayoutConfigurationFactory parentFactory, Action<Humidifier.QuickSight.TemplateTypes.GridLayoutCanvasSizeOptions> subFactoryAction = null)
    {
        parentFactory.CanvasSizeOptionsFactory = new InnerTemplateGridLayoutCanvasSizeOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CanvasSizeOptionsFactory);
    }

    public static CombinedResult<InnerTemplateDefaultGridLayoutConfigurationFactory, T1, InnerTemplateGridLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1>(this CombinedResult<InnerTemplateDefaultGridLayoutConfigurationFactory, T1> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.GridLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplateDefaultGridLayoutConfigurationFactory, InnerTemplateGridLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1>(this CombinedResult<T1, InnerTemplateDefaultGridLayoutConfigurationFactory> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.GridLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTemplateDefaultGridLayoutConfigurationFactory, T1, T2, InnerTemplateGridLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2>(this CombinedResult<InnerTemplateDefaultGridLayoutConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.GridLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplateDefaultGridLayoutConfigurationFactory, T2, InnerTemplateGridLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2>(this CombinedResult<T1, InnerTemplateDefaultGridLayoutConfigurationFactory, T2> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.GridLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTemplateDefaultGridLayoutConfigurationFactory, InnerTemplateGridLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2>(this CombinedResult<T1, T2, InnerTemplateDefaultGridLayoutConfigurationFactory> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.GridLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTemplateDefaultGridLayoutConfigurationFactory, T1, T2, T3, InnerTemplateGridLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3>(this CombinedResult<InnerTemplateDefaultGridLayoutConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.GridLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplateDefaultGridLayoutConfigurationFactory, T2, T3, InnerTemplateGridLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3>(this CombinedResult<T1, InnerTemplateDefaultGridLayoutConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.GridLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTemplateDefaultGridLayoutConfigurationFactory, T3, InnerTemplateGridLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3>(this CombinedResult<T1, T2, InnerTemplateDefaultGridLayoutConfigurationFactory, T3> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.GridLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTemplateDefaultGridLayoutConfigurationFactory, InnerTemplateGridLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTemplateDefaultGridLayoutConfigurationFactory> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.GridLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTemplateDefaultGridLayoutConfigurationFactory, T1, T2, T3, T4, InnerTemplateGridLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<InnerTemplateDefaultGridLayoutConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.GridLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplateDefaultGridLayoutConfigurationFactory, T2, T3, T4, InnerTemplateGridLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<T1, InnerTemplateDefaultGridLayoutConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.GridLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTemplateDefaultGridLayoutConfigurationFactory, T3, T4, InnerTemplateGridLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTemplateDefaultGridLayoutConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.GridLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTemplateDefaultGridLayoutConfigurationFactory, T4, InnerTemplateGridLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTemplateDefaultGridLayoutConfigurationFactory, T4> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.GridLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTemplateDefaultGridLayoutConfigurationFactory, InnerTemplateGridLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTemplateDefaultGridLayoutConfigurationFactory> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.GridLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T5, subFactoryAction));
}
