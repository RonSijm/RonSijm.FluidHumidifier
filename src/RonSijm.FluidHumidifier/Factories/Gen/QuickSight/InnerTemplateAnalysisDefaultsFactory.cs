// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerTemplateAnalysisDefaultsFactory(Action<Humidifier.QuickSight.TemplateTypes.AnalysisDefaults> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.TemplateTypes.AnalysisDefaults>
{

    internal InnerTemplateDefaultNewSheetConfigurationFactory DefaultNewSheetConfigurationFactory { get; set; }

    protected override Humidifier.QuickSight.TemplateTypes.AnalysisDefaults Create()
    {
        var analysisDefaultsResult = CreateAnalysisDefaults();
        factoryAction?.Invoke(analysisDefaultsResult);

        return analysisDefaultsResult;
    }

    private Humidifier.QuickSight.TemplateTypes.AnalysisDefaults CreateAnalysisDefaults()
    {
        var analysisDefaultsResult = new Humidifier.QuickSight.TemplateTypes.AnalysisDefaults();

        return analysisDefaultsResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.TemplateTypes.AnalysisDefaults result)
    {
        base.CreateChildren(result);

        result.DefaultNewSheetConfiguration ??= DefaultNewSheetConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerTemplateAnalysisDefaultsFactoryExtensions
{
    public static CombinedResult<InnerTemplateAnalysisDefaultsFactory, InnerTemplateDefaultNewSheetConfigurationFactory> WithDefaultNewSheetConfiguration(this InnerTemplateAnalysisDefaultsFactory parentFactory, Action<Humidifier.QuickSight.TemplateTypes.DefaultNewSheetConfiguration> subFactoryAction = null)
    {
        parentFactory.DefaultNewSheetConfigurationFactory = new InnerTemplateDefaultNewSheetConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DefaultNewSheetConfigurationFactory);
    }

    public static CombinedResult<InnerTemplateAnalysisDefaultsFactory, T1, InnerTemplateDefaultNewSheetConfigurationFactory> WithDefaultNewSheetConfiguration<T1>(this CombinedResult<InnerTemplateAnalysisDefaultsFactory, T1> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.DefaultNewSheetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefaultNewSheetConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplateAnalysisDefaultsFactory, InnerTemplateDefaultNewSheetConfigurationFactory> WithDefaultNewSheetConfiguration<T1>(this CombinedResult<T1, InnerTemplateAnalysisDefaultsFactory> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.DefaultNewSheetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefaultNewSheetConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTemplateAnalysisDefaultsFactory, T1, T2, InnerTemplateDefaultNewSheetConfigurationFactory> WithDefaultNewSheetConfiguration<T1, T2>(this CombinedResult<InnerTemplateAnalysisDefaultsFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.DefaultNewSheetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultNewSheetConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplateAnalysisDefaultsFactory, T2, InnerTemplateDefaultNewSheetConfigurationFactory> WithDefaultNewSheetConfiguration<T1, T2>(this CombinedResult<T1, InnerTemplateAnalysisDefaultsFactory, T2> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.DefaultNewSheetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultNewSheetConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTemplateAnalysisDefaultsFactory, InnerTemplateDefaultNewSheetConfigurationFactory> WithDefaultNewSheetConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerTemplateAnalysisDefaultsFactory> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.DefaultNewSheetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultNewSheetConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTemplateAnalysisDefaultsFactory, T1, T2, T3, InnerTemplateDefaultNewSheetConfigurationFactory> WithDefaultNewSheetConfiguration<T1, T2, T3>(this CombinedResult<InnerTemplateAnalysisDefaultsFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.DefaultNewSheetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultNewSheetConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplateAnalysisDefaultsFactory, T2, T3, InnerTemplateDefaultNewSheetConfigurationFactory> WithDefaultNewSheetConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerTemplateAnalysisDefaultsFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.DefaultNewSheetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultNewSheetConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTemplateAnalysisDefaultsFactory, T3, InnerTemplateDefaultNewSheetConfigurationFactory> WithDefaultNewSheetConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerTemplateAnalysisDefaultsFactory, T3> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.DefaultNewSheetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultNewSheetConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTemplateAnalysisDefaultsFactory, InnerTemplateDefaultNewSheetConfigurationFactory> WithDefaultNewSheetConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTemplateAnalysisDefaultsFactory> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.DefaultNewSheetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultNewSheetConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTemplateAnalysisDefaultsFactory, T1, T2, T3, T4, InnerTemplateDefaultNewSheetConfigurationFactory> WithDefaultNewSheetConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerTemplateAnalysisDefaultsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.DefaultNewSheetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultNewSheetConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplateAnalysisDefaultsFactory, T2, T3, T4, InnerTemplateDefaultNewSheetConfigurationFactory> WithDefaultNewSheetConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerTemplateAnalysisDefaultsFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.DefaultNewSheetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultNewSheetConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTemplateAnalysisDefaultsFactory, T3, T4, InnerTemplateDefaultNewSheetConfigurationFactory> WithDefaultNewSheetConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTemplateAnalysisDefaultsFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.DefaultNewSheetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultNewSheetConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTemplateAnalysisDefaultsFactory, T4, InnerTemplateDefaultNewSheetConfigurationFactory> WithDefaultNewSheetConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTemplateAnalysisDefaultsFactory, T4> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.DefaultNewSheetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultNewSheetConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTemplateAnalysisDefaultsFactory, InnerTemplateDefaultNewSheetConfigurationFactory> WithDefaultNewSheetConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTemplateAnalysisDefaultsFactory> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.DefaultNewSheetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultNewSheetConfiguration(combinedResult.T5, subFactoryAction));
}
