// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDashboardAnalysisDefaultsFactory(Action<Humidifier.QuickSight.DashboardTypes.AnalysisDefaults> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DashboardTypes.AnalysisDefaults>
{

    internal InnerDashboardDefaultNewSheetConfigurationFactory DefaultNewSheetConfigurationFactory { get; set; }

    protected override Humidifier.QuickSight.DashboardTypes.AnalysisDefaults Create()
    {
        var analysisDefaultsResult = CreateAnalysisDefaults();
        factoryAction?.Invoke(analysisDefaultsResult);

        return analysisDefaultsResult;
    }

    private Humidifier.QuickSight.DashboardTypes.AnalysisDefaults CreateAnalysisDefaults()
    {
        var analysisDefaultsResult = new Humidifier.QuickSight.DashboardTypes.AnalysisDefaults();

        return analysisDefaultsResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.DashboardTypes.AnalysisDefaults result)
    {
        base.CreateChildren(result);

        result.DefaultNewSheetConfiguration ??= DefaultNewSheetConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerDashboardAnalysisDefaultsFactoryExtensions
{
    public static CombinedResult<InnerDashboardAnalysisDefaultsFactory, InnerDashboardDefaultNewSheetConfigurationFactory> WithDefaultNewSheetConfiguration(this InnerDashboardAnalysisDefaultsFactory parentFactory, Action<Humidifier.QuickSight.DashboardTypes.DefaultNewSheetConfiguration> subFactoryAction = null)
    {
        parentFactory.DefaultNewSheetConfigurationFactory = new InnerDashboardDefaultNewSheetConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DefaultNewSheetConfigurationFactory);
    }

    public static CombinedResult<InnerDashboardAnalysisDefaultsFactory, T1, InnerDashboardDefaultNewSheetConfigurationFactory> WithDefaultNewSheetConfiguration<T1>(this CombinedResult<InnerDashboardAnalysisDefaultsFactory, T1> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.DefaultNewSheetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefaultNewSheetConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDashboardAnalysisDefaultsFactory, InnerDashboardDefaultNewSheetConfigurationFactory> WithDefaultNewSheetConfiguration<T1>(this CombinedResult<T1, InnerDashboardAnalysisDefaultsFactory> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.DefaultNewSheetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefaultNewSheetConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDashboardAnalysisDefaultsFactory, T1, T2, InnerDashboardDefaultNewSheetConfigurationFactory> WithDefaultNewSheetConfiguration<T1, T2>(this CombinedResult<InnerDashboardAnalysisDefaultsFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.DefaultNewSheetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultNewSheetConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDashboardAnalysisDefaultsFactory, T2, InnerDashboardDefaultNewSheetConfigurationFactory> WithDefaultNewSheetConfiguration<T1, T2>(this CombinedResult<T1, InnerDashboardAnalysisDefaultsFactory, T2> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.DefaultNewSheetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultNewSheetConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDashboardAnalysisDefaultsFactory, InnerDashboardDefaultNewSheetConfigurationFactory> WithDefaultNewSheetConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerDashboardAnalysisDefaultsFactory> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.DefaultNewSheetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultNewSheetConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDashboardAnalysisDefaultsFactory, T1, T2, T3, InnerDashboardDefaultNewSheetConfigurationFactory> WithDefaultNewSheetConfiguration<T1, T2, T3>(this CombinedResult<InnerDashboardAnalysisDefaultsFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.DefaultNewSheetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultNewSheetConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDashboardAnalysisDefaultsFactory, T2, T3, InnerDashboardDefaultNewSheetConfigurationFactory> WithDefaultNewSheetConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerDashboardAnalysisDefaultsFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.DefaultNewSheetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultNewSheetConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDashboardAnalysisDefaultsFactory, T3, InnerDashboardDefaultNewSheetConfigurationFactory> WithDefaultNewSheetConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerDashboardAnalysisDefaultsFactory, T3> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.DefaultNewSheetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultNewSheetConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDashboardAnalysisDefaultsFactory, InnerDashboardDefaultNewSheetConfigurationFactory> WithDefaultNewSheetConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDashboardAnalysisDefaultsFactory> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.DefaultNewSheetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultNewSheetConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDashboardAnalysisDefaultsFactory, T1, T2, T3, T4, InnerDashboardDefaultNewSheetConfigurationFactory> WithDefaultNewSheetConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerDashboardAnalysisDefaultsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.DefaultNewSheetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultNewSheetConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDashboardAnalysisDefaultsFactory, T2, T3, T4, InnerDashboardDefaultNewSheetConfigurationFactory> WithDefaultNewSheetConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerDashboardAnalysisDefaultsFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.DefaultNewSheetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultNewSheetConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDashboardAnalysisDefaultsFactory, T3, T4, InnerDashboardDefaultNewSheetConfigurationFactory> WithDefaultNewSheetConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDashboardAnalysisDefaultsFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.DefaultNewSheetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultNewSheetConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDashboardAnalysisDefaultsFactory, T4, InnerDashboardDefaultNewSheetConfigurationFactory> WithDefaultNewSheetConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDashboardAnalysisDefaultsFactory, T4> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.DefaultNewSheetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultNewSheetConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDashboardAnalysisDefaultsFactory, InnerDashboardDefaultNewSheetConfigurationFactory> WithDefaultNewSheetConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDashboardAnalysisDefaultsFactory> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.DefaultNewSheetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultNewSheetConfiguration(combinedResult.T5, subFactoryAction));
}
