// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRooms;

public class InnerIntermediateTableIntermediateTableAnalysisRulePolicyFactory(Action<Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRulePolicy> factoryAction = null) : SubResourceFactory<Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRulePolicy>
{

    internal InnerIntermediateTableIntermediateTableAnalysisRulePolicyV1Factory V1Factory { get; set; }

    protected override Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRulePolicy Create()
    {
        var intermediateTableAnalysisRulePolicyResult = CreateIntermediateTableAnalysisRulePolicy();
        factoryAction?.Invoke(intermediateTableAnalysisRulePolicyResult);

        return intermediateTableAnalysisRulePolicyResult;
    }

    private Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRulePolicy CreateIntermediateTableAnalysisRulePolicy()
    {
        var intermediateTableAnalysisRulePolicyResult = new Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRulePolicy();

        return intermediateTableAnalysisRulePolicyResult;
    }
    public override void CreateChildren(Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRulePolicy result)
    {
        base.CreateChildren(result);

        result.V1 ??= V1Factory?.Build();
    }

} // End Of Class

public static class InnerIntermediateTableIntermediateTableAnalysisRulePolicyFactoryExtensions
{
    public static CombinedResult<InnerIntermediateTableIntermediateTableAnalysisRulePolicyFactory, InnerIntermediateTableIntermediateTableAnalysisRulePolicyV1Factory> WithV1(this InnerIntermediateTableIntermediateTableAnalysisRulePolicyFactory parentFactory, Action<Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRulePolicyV1> subFactoryAction = null)
    {
        parentFactory.V1Factory = new InnerIntermediateTableIntermediateTableAnalysisRulePolicyV1Factory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.V1Factory);
    }

    public static CombinedResult<InnerIntermediateTableIntermediateTableAnalysisRulePolicyFactory, T1, InnerIntermediateTableIntermediateTableAnalysisRulePolicyV1Factory> WithV1<T1>(this CombinedResult<InnerIntermediateTableIntermediateTableAnalysisRulePolicyFactory, T1> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRulePolicyV1> subFactoryAction = null) => new (combinedResult, combinedResult, WithV1(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerIntermediateTableIntermediateTableAnalysisRulePolicyFactory, InnerIntermediateTableIntermediateTableAnalysisRulePolicyV1Factory> WithV1<T1>(this CombinedResult<T1, InnerIntermediateTableIntermediateTableAnalysisRulePolicyFactory> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRulePolicyV1> subFactoryAction = null) => new (combinedResult, combinedResult, WithV1(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerIntermediateTableIntermediateTableAnalysisRulePolicyFactory, T1, T2, InnerIntermediateTableIntermediateTableAnalysisRulePolicyV1Factory> WithV1<T1, T2>(this CombinedResult<InnerIntermediateTableIntermediateTableAnalysisRulePolicyFactory, T1, T2> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRulePolicyV1> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithV1(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerIntermediateTableIntermediateTableAnalysisRulePolicyFactory, T2, InnerIntermediateTableIntermediateTableAnalysisRulePolicyV1Factory> WithV1<T1, T2>(this CombinedResult<T1, InnerIntermediateTableIntermediateTableAnalysisRulePolicyFactory, T2> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRulePolicyV1> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithV1(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerIntermediateTableIntermediateTableAnalysisRulePolicyFactory, InnerIntermediateTableIntermediateTableAnalysisRulePolicyV1Factory> WithV1<T1, T2>(this CombinedResult<T1, T2, InnerIntermediateTableIntermediateTableAnalysisRulePolicyFactory> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRulePolicyV1> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithV1(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerIntermediateTableIntermediateTableAnalysisRulePolicyFactory, T1, T2, T3, InnerIntermediateTableIntermediateTableAnalysisRulePolicyV1Factory> WithV1<T1, T2, T3>(this CombinedResult<InnerIntermediateTableIntermediateTableAnalysisRulePolicyFactory, T1, T2, T3> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRulePolicyV1> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithV1(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerIntermediateTableIntermediateTableAnalysisRulePolicyFactory, T2, T3, InnerIntermediateTableIntermediateTableAnalysisRulePolicyV1Factory> WithV1<T1, T2, T3>(this CombinedResult<T1, InnerIntermediateTableIntermediateTableAnalysisRulePolicyFactory, T2, T3> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRulePolicyV1> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithV1(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerIntermediateTableIntermediateTableAnalysisRulePolicyFactory, T3, InnerIntermediateTableIntermediateTableAnalysisRulePolicyV1Factory> WithV1<T1, T2, T3>(this CombinedResult<T1, T2, InnerIntermediateTableIntermediateTableAnalysisRulePolicyFactory, T3> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRulePolicyV1> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithV1(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerIntermediateTableIntermediateTableAnalysisRulePolicyFactory, InnerIntermediateTableIntermediateTableAnalysisRulePolicyV1Factory> WithV1<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerIntermediateTableIntermediateTableAnalysisRulePolicyFactory> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRulePolicyV1> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithV1(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerIntermediateTableIntermediateTableAnalysisRulePolicyFactory, T1, T2, T3, T4, InnerIntermediateTableIntermediateTableAnalysisRulePolicyV1Factory> WithV1<T1, T2, T3, T4>(this CombinedResult<InnerIntermediateTableIntermediateTableAnalysisRulePolicyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRulePolicyV1> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithV1(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerIntermediateTableIntermediateTableAnalysisRulePolicyFactory, T2, T3, T4, InnerIntermediateTableIntermediateTableAnalysisRulePolicyV1Factory> WithV1<T1, T2, T3, T4>(this CombinedResult<T1, InnerIntermediateTableIntermediateTableAnalysisRulePolicyFactory, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRulePolicyV1> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithV1(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerIntermediateTableIntermediateTableAnalysisRulePolicyFactory, T3, T4, InnerIntermediateTableIntermediateTableAnalysisRulePolicyV1Factory> WithV1<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerIntermediateTableIntermediateTableAnalysisRulePolicyFactory, T3, T4> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRulePolicyV1> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithV1(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerIntermediateTableIntermediateTableAnalysisRulePolicyFactory, T4, InnerIntermediateTableIntermediateTableAnalysisRulePolicyV1Factory> WithV1<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerIntermediateTableIntermediateTableAnalysisRulePolicyFactory, T4> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRulePolicyV1> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithV1(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerIntermediateTableIntermediateTableAnalysisRulePolicyFactory, InnerIntermediateTableIntermediateTableAnalysisRulePolicyV1Factory> WithV1<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerIntermediateTableIntermediateTableAnalysisRulePolicyFactory> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRulePolicyV1> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithV1(combinedResult.T5, subFactoryAction).T2);
}
