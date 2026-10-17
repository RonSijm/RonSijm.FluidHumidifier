// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApplicationSignals;

public class InnerServiceLevelObjectiveCompositeSliConfigFactory(Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.CompositeSliConfig> factoryAction = null) : SubResourceFactory<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.CompositeSliConfig>
{

    internal InnerServiceLevelObjectiveSelectionConfigFactory SelectionConfigFactory { get; set; }

    protected override Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.CompositeSliConfig Create()
    {
        var compositeSliConfigResult = CreateCompositeSliConfig();
        factoryAction?.Invoke(compositeSliConfigResult);

        return compositeSliConfigResult;
    }

    private Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.CompositeSliConfig CreateCompositeSliConfig()
    {
        var compositeSliConfigResult = new Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.CompositeSliConfig();

        return compositeSliConfigResult;
    }
    public override void CreateChildren(Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.CompositeSliConfig result)
    {
        base.CreateChildren(result);

        result.SelectionConfig ??= SelectionConfigFactory?.Build();
    }

} // End Of Class

public static class InnerServiceLevelObjectiveCompositeSliConfigFactoryExtensions
{
    public static CombinedResult<InnerServiceLevelObjectiveCompositeSliConfigFactory, InnerServiceLevelObjectiveSelectionConfigFactory> WithSelectionConfig(this InnerServiceLevelObjectiveCompositeSliConfigFactory parentFactory, Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.SelectionConfig> subFactoryAction = null)
    {
        parentFactory.SelectionConfigFactory = new InnerServiceLevelObjectiveSelectionConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SelectionConfigFactory);
    }

    public static CombinedResult<InnerServiceLevelObjectiveCompositeSliConfigFactory, T1, InnerServiceLevelObjectiveSelectionConfigFactory> WithSelectionConfig<T1>(this CombinedResult<InnerServiceLevelObjectiveCompositeSliConfigFactory, T1> combinedResult, Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.SelectionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithSelectionConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceLevelObjectiveCompositeSliConfigFactory, InnerServiceLevelObjectiveSelectionConfigFactory> WithSelectionConfig<T1>(this CombinedResult<T1, InnerServiceLevelObjectiveCompositeSliConfigFactory> combinedResult, Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.SelectionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithSelectionConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerServiceLevelObjectiveCompositeSliConfigFactory, T1, T2, InnerServiceLevelObjectiveSelectionConfigFactory> WithSelectionConfig<T1, T2>(this CombinedResult<InnerServiceLevelObjectiveCompositeSliConfigFactory, T1, T2> combinedResult, Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.SelectionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSelectionConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceLevelObjectiveCompositeSliConfigFactory, T2, InnerServiceLevelObjectiveSelectionConfigFactory> WithSelectionConfig<T1, T2>(this CombinedResult<T1, InnerServiceLevelObjectiveCompositeSliConfigFactory, T2> combinedResult, Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.SelectionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSelectionConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServiceLevelObjectiveCompositeSliConfigFactory, InnerServiceLevelObjectiveSelectionConfigFactory> WithSelectionConfig<T1, T2>(this CombinedResult<T1, T2, InnerServiceLevelObjectiveCompositeSliConfigFactory> combinedResult, Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.SelectionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSelectionConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerServiceLevelObjectiveCompositeSliConfigFactory, T1, T2, T3, InnerServiceLevelObjectiveSelectionConfigFactory> WithSelectionConfig<T1, T2, T3>(this CombinedResult<InnerServiceLevelObjectiveCompositeSliConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.SelectionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSelectionConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceLevelObjectiveCompositeSliConfigFactory, T2, T3, InnerServiceLevelObjectiveSelectionConfigFactory> WithSelectionConfig<T1, T2, T3>(this CombinedResult<T1, InnerServiceLevelObjectiveCompositeSliConfigFactory, T2, T3> combinedResult, Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.SelectionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSelectionConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServiceLevelObjectiveCompositeSliConfigFactory, T3, InnerServiceLevelObjectiveSelectionConfigFactory> WithSelectionConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerServiceLevelObjectiveCompositeSliConfigFactory, T3> combinedResult, Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.SelectionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSelectionConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerServiceLevelObjectiveCompositeSliConfigFactory, InnerServiceLevelObjectiveSelectionConfigFactory> WithSelectionConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerServiceLevelObjectiveCompositeSliConfigFactory> combinedResult, Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.SelectionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSelectionConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerServiceLevelObjectiveCompositeSliConfigFactory, T1, T2, T3, T4, InnerServiceLevelObjectiveSelectionConfigFactory> WithSelectionConfig<T1, T2, T3, T4>(this CombinedResult<InnerServiceLevelObjectiveCompositeSliConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.SelectionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSelectionConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceLevelObjectiveCompositeSliConfigFactory, T2, T3, T4, InnerServiceLevelObjectiveSelectionConfigFactory> WithSelectionConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerServiceLevelObjectiveCompositeSliConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.SelectionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSelectionConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServiceLevelObjectiveCompositeSliConfigFactory, T3, T4, InnerServiceLevelObjectiveSelectionConfigFactory> WithSelectionConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerServiceLevelObjectiveCompositeSliConfigFactory, T3, T4> combinedResult, Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.SelectionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSelectionConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerServiceLevelObjectiveCompositeSliConfigFactory, T4, InnerServiceLevelObjectiveSelectionConfigFactory> WithSelectionConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerServiceLevelObjectiveCompositeSliConfigFactory, T4> combinedResult, Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.SelectionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSelectionConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerServiceLevelObjectiveCompositeSliConfigFactory, InnerServiceLevelObjectiveSelectionConfigFactory> WithSelectionConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerServiceLevelObjectiveCompositeSliConfigFactory> combinedResult, Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.SelectionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSelectionConfig(combinedResult.T5, subFactoryAction).T2);
}
