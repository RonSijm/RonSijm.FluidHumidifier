// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRooms;

public class InnerConfiguredTableConfiguredTableAnalysisRulePolicyFactory(Action<Humidifier.CleanRooms.ConfiguredTableTypes.ConfiguredTableAnalysisRulePolicy> factoryAction = null) : SubResourceFactory<Humidifier.CleanRooms.ConfiguredTableTypes.ConfiguredTableAnalysisRulePolicy>
{

    internal InnerConfiguredTableConfiguredTableAnalysisRulePolicyV1Factory V1Factory { get; set; }

    protected override Humidifier.CleanRooms.ConfiguredTableTypes.ConfiguredTableAnalysisRulePolicy Create()
    {
        var configuredTableAnalysisRulePolicyResult = CreateConfiguredTableAnalysisRulePolicy();
        factoryAction?.Invoke(configuredTableAnalysisRulePolicyResult);

        return configuredTableAnalysisRulePolicyResult;
    }

    private Humidifier.CleanRooms.ConfiguredTableTypes.ConfiguredTableAnalysisRulePolicy CreateConfiguredTableAnalysisRulePolicy()
    {
        var configuredTableAnalysisRulePolicyResult = new Humidifier.CleanRooms.ConfiguredTableTypes.ConfiguredTableAnalysisRulePolicy();

        return configuredTableAnalysisRulePolicyResult;
    }
    public override void CreateChildren(Humidifier.CleanRooms.ConfiguredTableTypes.ConfiguredTableAnalysisRulePolicy result)
    {
        base.CreateChildren(result);

        result.V1 ??= V1Factory?.Build();
    }

} // End Of Class

public static class InnerConfiguredTableConfiguredTableAnalysisRulePolicyFactoryExtensions
{
    public static CombinedResult<InnerConfiguredTableConfiguredTableAnalysisRulePolicyFactory, InnerConfiguredTableConfiguredTableAnalysisRulePolicyV1Factory> WithV1(this InnerConfiguredTableConfiguredTableAnalysisRulePolicyFactory parentFactory, Action<Humidifier.CleanRooms.ConfiguredTableTypes.ConfiguredTableAnalysisRulePolicyV1> subFactoryAction = null)
    {
        parentFactory.V1Factory = new InnerConfiguredTableConfiguredTableAnalysisRulePolicyV1Factory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.V1Factory);
    }

    public static CombinedResult<InnerConfiguredTableConfiguredTableAnalysisRulePolicyFactory, T1, InnerConfiguredTableConfiguredTableAnalysisRulePolicyV1Factory> WithV1<T1>(this CombinedResult<InnerConfiguredTableConfiguredTableAnalysisRulePolicyFactory, T1> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.ConfiguredTableAnalysisRulePolicyV1> subFactoryAction = null) => new (combinedResult, combinedResult, WithV1(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConfiguredTableConfiguredTableAnalysisRulePolicyFactory, InnerConfiguredTableConfiguredTableAnalysisRulePolicyV1Factory> WithV1<T1>(this CombinedResult<T1, InnerConfiguredTableConfiguredTableAnalysisRulePolicyFactory> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.ConfiguredTableAnalysisRulePolicyV1> subFactoryAction = null) => new (combinedResult, combinedResult, WithV1(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerConfiguredTableConfiguredTableAnalysisRulePolicyFactory, T1, T2, InnerConfiguredTableConfiguredTableAnalysisRulePolicyV1Factory> WithV1<T1, T2>(this CombinedResult<InnerConfiguredTableConfiguredTableAnalysisRulePolicyFactory, T1, T2> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.ConfiguredTableAnalysisRulePolicyV1> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithV1(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConfiguredTableConfiguredTableAnalysisRulePolicyFactory, T2, InnerConfiguredTableConfiguredTableAnalysisRulePolicyV1Factory> WithV1<T1, T2>(this CombinedResult<T1, InnerConfiguredTableConfiguredTableAnalysisRulePolicyFactory, T2> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.ConfiguredTableAnalysisRulePolicyV1> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithV1(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConfiguredTableConfiguredTableAnalysisRulePolicyFactory, InnerConfiguredTableConfiguredTableAnalysisRulePolicyV1Factory> WithV1<T1, T2>(this CombinedResult<T1, T2, InnerConfiguredTableConfiguredTableAnalysisRulePolicyFactory> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.ConfiguredTableAnalysisRulePolicyV1> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithV1(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerConfiguredTableConfiguredTableAnalysisRulePolicyFactory, T1, T2, T3, InnerConfiguredTableConfiguredTableAnalysisRulePolicyV1Factory> WithV1<T1, T2, T3>(this CombinedResult<InnerConfiguredTableConfiguredTableAnalysisRulePolicyFactory, T1, T2, T3> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.ConfiguredTableAnalysisRulePolicyV1> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithV1(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConfiguredTableConfiguredTableAnalysisRulePolicyFactory, T2, T3, InnerConfiguredTableConfiguredTableAnalysisRulePolicyV1Factory> WithV1<T1, T2, T3>(this CombinedResult<T1, InnerConfiguredTableConfiguredTableAnalysisRulePolicyFactory, T2, T3> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.ConfiguredTableAnalysisRulePolicyV1> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithV1(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConfiguredTableConfiguredTableAnalysisRulePolicyFactory, T3, InnerConfiguredTableConfiguredTableAnalysisRulePolicyV1Factory> WithV1<T1, T2, T3>(this CombinedResult<T1, T2, InnerConfiguredTableConfiguredTableAnalysisRulePolicyFactory, T3> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.ConfiguredTableAnalysisRulePolicyV1> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithV1(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConfiguredTableConfiguredTableAnalysisRulePolicyFactory, InnerConfiguredTableConfiguredTableAnalysisRulePolicyV1Factory> WithV1<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerConfiguredTableConfiguredTableAnalysisRulePolicyFactory> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.ConfiguredTableAnalysisRulePolicyV1> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithV1(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerConfiguredTableConfiguredTableAnalysisRulePolicyFactory, T1, T2, T3, T4, InnerConfiguredTableConfiguredTableAnalysisRulePolicyV1Factory> WithV1<T1, T2, T3, T4>(this CombinedResult<InnerConfiguredTableConfiguredTableAnalysisRulePolicyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.ConfiguredTableAnalysisRulePolicyV1> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithV1(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConfiguredTableConfiguredTableAnalysisRulePolicyFactory, T2, T3, T4, InnerConfiguredTableConfiguredTableAnalysisRulePolicyV1Factory> WithV1<T1, T2, T3, T4>(this CombinedResult<T1, InnerConfiguredTableConfiguredTableAnalysisRulePolicyFactory, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.ConfiguredTableAnalysisRulePolicyV1> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithV1(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConfiguredTableConfiguredTableAnalysisRulePolicyFactory, T3, T4, InnerConfiguredTableConfiguredTableAnalysisRulePolicyV1Factory> WithV1<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerConfiguredTableConfiguredTableAnalysisRulePolicyFactory, T3, T4> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.ConfiguredTableAnalysisRulePolicyV1> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithV1(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConfiguredTableConfiguredTableAnalysisRulePolicyFactory, T4, InnerConfiguredTableConfiguredTableAnalysisRulePolicyV1Factory> WithV1<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerConfiguredTableConfiguredTableAnalysisRulePolicyFactory, T4> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.ConfiguredTableAnalysisRulePolicyV1> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithV1(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerConfiguredTableConfiguredTableAnalysisRulePolicyFactory, InnerConfiguredTableConfiguredTableAnalysisRulePolicyV1Factory> WithV1<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerConfiguredTableConfiguredTableAnalysisRulePolicyFactory> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.ConfiguredTableAnalysisRulePolicyV1> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithV1(combinedResult.T5, subFactoryAction));
}
