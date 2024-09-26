// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDashboardDashboardVersionDefinitionFactory(Action<Humidifier.QuickSight.DashboardTypes.DashboardVersionDefinition> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DashboardTypes.DashboardVersionDefinition>
{

    internal InnerDashboardAssetOptionsFactory OptionsFactory { get; set; }

    internal InnerDashboardAnalysisDefaultsFactory AnalysisDefaultsFactory { get; set; }

    protected override Humidifier.QuickSight.DashboardTypes.DashboardVersionDefinition Create()
    {
        var dashboardVersionDefinitionResult = CreateDashboardVersionDefinition();
        factoryAction?.Invoke(dashboardVersionDefinitionResult);

        return dashboardVersionDefinitionResult;
    }

    private Humidifier.QuickSight.DashboardTypes.DashboardVersionDefinition CreateDashboardVersionDefinition()
    {
        var dashboardVersionDefinitionResult = new Humidifier.QuickSight.DashboardTypes.DashboardVersionDefinition();

        return dashboardVersionDefinitionResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.DashboardTypes.DashboardVersionDefinition result)
    {
        base.CreateChildren(result);

        result.Options ??= OptionsFactory?.Build();
        result.AnalysisDefaults ??= AnalysisDefaultsFactory?.Build();
    }

} // End Of Class

public static class InnerDashboardDashboardVersionDefinitionFactoryExtensions
{
    public static CombinedResult<InnerDashboardDashboardVersionDefinitionFactory, InnerDashboardAssetOptionsFactory> WithOptions(this InnerDashboardDashboardVersionDefinitionFactory parentFactory, Action<Humidifier.QuickSight.DashboardTypes.AssetOptions> subFactoryAction = null)
    {
        parentFactory.OptionsFactory = new InnerDashboardAssetOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OptionsFactory);
    }

    public static CombinedResult<InnerDashboardDashboardVersionDefinitionFactory, InnerDashboardAnalysisDefaultsFactory> WithAnalysisDefaults(this InnerDashboardDashboardVersionDefinitionFactory parentFactory, Action<Humidifier.QuickSight.DashboardTypes.AnalysisDefaults> subFactoryAction = null)
    {
        parentFactory.AnalysisDefaultsFactory = new InnerDashboardAnalysisDefaultsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AnalysisDefaultsFactory);
    }

    public static CombinedResult<InnerDashboardDashboardVersionDefinitionFactory, T1, InnerDashboardAssetOptionsFactory> WithOptions<T1>(this CombinedResult<InnerDashboardDashboardVersionDefinitionFactory, T1> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.AssetOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDashboardDashboardVersionDefinitionFactory, InnerDashboardAssetOptionsFactory> WithOptions<T1>(this CombinedResult<T1, InnerDashboardDashboardVersionDefinitionFactory> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.AssetOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDashboardDashboardVersionDefinitionFactory, T1, T2, InnerDashboardAssetOptionsFactory> WithOptions<T1, T2>(this CombinedResult<InnerDashboardDashboardVersionDefinitionFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.AssetOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDashboardDashboardVersionDefinitionFactory, T2, InnerDashboardAssetOptionsFactory> WithOptions<T1, T2>(this CombinedResult<T1, InnerDashboardDashboardVersionDefinitionFactory, T2> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.AssetOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDashboardDashboardVersionDefinitionFactory, InnerDashboardAssetOptionsFactory> WithOptions<T1, T2>(this CombinedResult<T1, T2, InnerDashboardDashboardVersionDefinitionFactory> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.AssetOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDashboardDashboardVersionDefinitionFactory, T1, T2, T3, InnerDashboardAssetOptionsFactory> WithOptions<T1, T2, T3>(this CombinedResult<InnerDashboardDashboardVersionDefinitionFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.AssetOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDashboardDashboardVersionDefinitionFactory, T2, T3, InnerDashboardAssetOptionsFactory> WithOptions<T1, T2, T3>(this CombinedResult<T1, InnerDashboardDashboardVersionDefinitionFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.AssetOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDashboardDashboardVersionDefinitionFactory, T3, InnerDashboardAssetOptionsFactory> WithOptions<T1, T2, T3>(this CombinedResult<T1, T2, InnerDashboardDashboardVersionDefinitionFactory, T3> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.AssetOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDashboardDashboardVersionDefinitionFactory, InnerDashboardAssetOptionsFactory> WithOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDashboardDashboardVersionDefinitionFactory> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.AssetOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDashboardDashboardVersionDefinitionFactory, T1, T2, T3, T4, InnerDashboardAssetOptionsFactory> WithOptions<T1, T2, T3, T4>(this CombinedResult<InnerDashboardDashboardVersionDefinitionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.AssetOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDashboardDashboardVersionDefinitionFactory, T2, T3, T4, InnerDashboardAssetOptionsFactory> WithOptions<T1, T2, T3, T4>(this CombinedResult<T1, InnerDashboardDashboardVersionDefinitionFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.AssetOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDashboardDashboardVersionDefinitionFactory, T3, T4, InnerDashboardAssetOptionsFactory> WithOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDashboardDashboardVersionDefinitionFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.AssetOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDashboardDashboardVersionDefinitionFactory, T4, InnerDashboardAssetOptionsFactory> WithOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDashboardDashboardVersionDefinitionFactory, T4> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.AssetOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDashboardDashboardVersionDefinitionFactory, InnerDashboardAssetOptionsFactory> WithOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDashboardDashboardVersionDefinitionFactory> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.AssetOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerDashboardDashboardVersionDefinitionFactory, T1, InnerDashboardAnalysisDefaultsFactory> WithAnalysisDefaults<T1>(this CombinedResult<InnerDashboardDashboardVersionDefinitionFactory, T1> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.AnalysisDefaults> subFactoryAction = null) => new (combinedResult, combinedResult, WithAnalysisDefaults(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDashboardDashboardVersionDefinitionFactory, InnerDashboardAnalysisDefaultsFactory> WithAnalysisDefaults<T1>(this CombinedResult<T1, InnerDashboardDashboardVersionDefinitionFactory> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.AnalysisDefaults> subFactoryAction = null) => new (combinedResult, combinedResult, WithAnalysisDefaults(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDashboardDashboardVersionDefinitionFactory, T1, T2, InnerDashboardAnalysisDefaultsFactory> WithAnalysisDefaults<T1, T2>(this CombinedResult<InnerDashboardDashboardVersionDefinitionFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.AnalysisDefaults> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAnalysisDefaults(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDashboardDashboardVersionDefinitionFactory, T2, InnerDashboardAnalysisDefaultsFactory> WithAnalysisDefaults<T1, T2>(this CombinedResult<T1, InnerDashboardDashboardVersionDefinitionFactory, T2> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.AnalysisDefaults> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAnalysisDefaults(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDashboardDashboardVersionDefinitionFactory, InnerDashboardAnalysisDefaultsFactory> WithAnalysisDefaults<T1, T2>(this CombinedResult<T1, T2, InnerDashboardDashboardVersionDefinitionFactory> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.AnalysisDefaults> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAnalysisDefaults(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDashboardDashboardVersionDefinitionFactory, T1, T2, T3, InnerDashboardAnalysisDefaultsFactory> WithAnalysisDefaults<T1, T2, T3>(this CombinedResult<InnerDashboardDashboardVersionDefinitionFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.AnalysisDefaults> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAnalysisDefaults(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDashboardDashboardVersionDefinitionFactory, T2, T3, InnerDashboardAnalysisDefaultsFactory> WithAnalysisDefaults<T1, T2, T3>(this CombinedResult<T1, InnerDashboardDashboardVersionDefinitionFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.AnalysisDefaults> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAnalysisDefaults(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDashboardDashboardVersionDefinitionFactory, T3, InnerDashboardAnalysisDefaultsFactory> WithAnalysisDefaults<T1, T2, T3>(this CombinedResult<T1, T2, InnerDashboardDashboardVersionDefinitionFactory, T3> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.AnalysisDefaults> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAnalysisDefaults(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDashboardDashboardVersionDefinitionFactory, InnerDashboardAnalysisDefaultsFactory> WithAnalysisDefaults<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDashboardDashboardVersionDefinitionFactory> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.AnalysisDefaults> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAnalysisDefaults(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDashboardDashboardVersionDefinitionFactory, T1, T2, T3, T4, InnerDashboardAnalysisDefaultsFactory> WithAnalysisDefaults<T1, T2, T3, T4>(this CombinedResult<InnerDashboardDashboardVersionDefinitionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.AnalysisDefaults> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAnalysisDefaults(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDashboardDashboardVersionDefinitionFactory, T2, T3, T4, InnerDashboardAnalysisDefaultsFactory> WithAnalysisDefaults<T1, T2, T3, T4>(this CombinedResult<T1, InnerDashboardDashboardVersionDefinitionFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.AnalysisDefaults> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAnalysisDefaults(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDashboardDashboardVersionDefinitionFactory, T3, T4, InnerDashboardAnalysisDefaultsFactory> WithAnalysisDefaults<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDashboardDashboardVersionDefinitionFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.AnalysisDefaults> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAnalysisDefaults(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDashboardDashboardVersionDefinitionFactory, T4, InnerDashboardAnalysisDefaultsFactory> WithAnalysisDefaults<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDashboardDashboardVersionDefinitionFactory, T4> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.AnalysisDefaults> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAnalysisDefaults(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDashboardDashboardVersionDefinitionFactory, InnerDashboardAnalysisDefaultsFactory> WithAnalysisDefaults<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDashboardDashboardVersionDefinitionFactory> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.AnalysisDefaults> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAnalysisDefaults(combinedResult.T5, subFactoryAction));
}
