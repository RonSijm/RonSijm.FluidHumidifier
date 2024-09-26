// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerAnalysisAnalysisDefaultsFactory(Action<Humidifier.QuickSight.AnalysisTypes.AnalysisDefaults> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.AnalysisTypes.AnalysisDefaults>
{

    internal InnerAnalysisDefaultNewSheetConfigurationFactory DefaultNewSheetConfigurationFactory { get; set; }

    protected override Humidifier.QuickSight.AnalysisTypes.AnalysisDefaults Create()
    {
        var analysisDefaultsResult = CreateAnalysisDefaults();
        factoryAction?.Invoke(analysisDefaultsResult);

        return analysisDefaultsResult;
    }

    private Humidifier.QuickSight.AnalysisTypes.AnalysisDefaults CreateAnalysisDefaults()
    {
        var analysisDefaultsResult = new Humidifier.QuickSight.AnalysisTypes.AnalysisDefaults();

        return analysisDefaultsResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.AnalysisTypes.AnalysisDefaults result)
    {
        base.CreateChildren(result);

        result.DefaultNewSheetConfiguration ??= DefaultNewSheetConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerAnalysisAnalysisDefaultsFactoryExtensions
{
    public static CombinedResult<InnerAnalysisAnalysisDefaultsFactory, InnerAnalysisDefaultNewSheetConfigurationFactory> WithDefaultNewSheetConfiguration(this InnerAnalysisAnalysisDefaultsFactory parentFactory, Action<Humidifier.QuickSight.AnalysisTypes.DefaultNewSheetConfiguration> subFactoryAction = null)
    {
        parentFactory.DefaultNewSheetConfigurationFactory = new InnerAnalysisDefaultNewSheetConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DefaultNewSheetConfigurationFactory);
    }

    public static CombinedResult<InnerAnalysisAnalysisDefaultsFactory, T1, InnerAnalysisDefaultNewSheetConfigurationFactory> WithDefaultNewSheetConfiguration<T1>(this CombinedResult<InnerAnalysisAnalysisDefaultsFactory, T1> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.DefaultNewSheetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefaultNewSheetConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAnalysisAnalysisDefaultsFactory, InnerAnalysisDefaultNewSheetConfigurationFactory> WithDefaultNewSheetConfiguration<T1>(this CombinedResult<T1, InnerAnalysisAnalysisDefaultsFactory> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.DefaultNewSheetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefaultNewSheetConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerAnalysisAnalysisDefaultsFactory, T1, T2, InnerAnalysisDefaultNewSheetConfigurationFactory> WithDefaultNewSheetConfiguration<T1, T2>(this CombinedResult<InnerAnalysisAnalysisDefaultsFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.DefaultNewSheetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultNewSheetConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAnalysisAnalysisDefaultsFactory, T2, InnerAnalysisDefaultNewSheetConfigurationFactory> WithDefaultNewSheetConfiguration<T1, T2>(this CombinedResult<T1, InnerAnalysisAnalysisDefaultsFactory, T2> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.DefaultNewSheetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultNewSheetConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAnalysisAnalysisDefaultsFactory, InnerAnalysisDefaultNewSheetConfigurationFactory> WithDefaultNewSheetConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerAnalysisAnalysisDefaultsFactory> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.DefaultNewSheetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultNewSheetConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerAnalysisAnalysisDefaultsFactory, T1, T2, T3, InnerAnalysisDefaultNewSheetConfigurationFactory> WithDefaultNewSheetConfiguration<T1, T2, T3>(this CombinedResult<InnerAnalysisAnalysisDefaultsFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.DefaultNewSheetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultNewSheetConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAnalysisAnalysisDefaultsFactory, T2, T3, InnerAnalysisDefaultNewSheetConfigurationFactory> WithDefaultNewSheetConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerAnalysisAnalysisDefaultsFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.DefaultNewSheetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultNewSheetConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAnalysisAnalysisDefaultsFactory, T3, InnerAnalysisDefaultNewSheetConfigurationFactory> WithDefaultNewSheetConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerAnalysisAnalysisDefaultsFactory, T3> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.DefaultNewSheetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultNewSheetConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAnalysisAnalysisDefaultsFactory, InnerAnalysisDefaultNewSheetConfigurationFactory> WithDefaultNewSheetConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAnalysisAnalysisDefaultsFactory> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.DefaultNewSheetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultNewSheetConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerAnalysisAnalysisDefaultsFactory, T1, T2, T3, T4, InnerAnalysisDefaultNewSheetConfigurationFactory> WithDefaultNewSheetConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerAnalysisAnalysisDefaultsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.DefaultNewSheetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultNewSheetConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAnalysisAnalysisDefaultsFactory, T2, T3, T4, InnerAnalysisDefaultNewSheetConfigurationFactory> WithDefaultNewSheetConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerAnalysisAnalysisDefaultsFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.DefaultNewSheetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultNewSheetConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAnalysisAnalysisDefaultsFactory, T3, T4, InnerAnalysisDefaultNewSheetConfigurationFactory> WithDefaultNewSheetConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAnalysisAnalysisDefaultsFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.DefaultNewSheetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultNewSheetConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAnalysisAnalysisDefaultsFactory, T4, InnerAnalysisDefaultNewSheetConfigurationFactory> WithDefaultNewSheetConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAnalysisAnalysisDefaultsFactory, T4> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.DefaultNewSheetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultNewSheetConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerAnalysisAnalysisDefaultsFactory, InnerAnalysisDefaultNewSheetConfigurationFactory> WithDefaultNewSheetConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAnalysisAnalysisDefaultsFactory> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.DefaultNewSheetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultNewSheetConfiguration(combinedResult.T5, subFactoryAction));
}
