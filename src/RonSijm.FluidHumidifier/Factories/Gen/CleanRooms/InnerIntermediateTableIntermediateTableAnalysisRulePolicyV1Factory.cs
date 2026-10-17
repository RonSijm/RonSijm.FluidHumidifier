// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRooms;

public class InnerIntermediateTableIntermediateTableAnalysisRulePolicyV1Factory(Action<Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRulePolicyV1> factoryAction = null) : SubResourceFactory<Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRulePolicyV1>
{

    internal InnerIntermediateTableIntermediateTableAnalysisRuleCustomFactory CustomFactory { get; set; }

    protected override Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRulePolicyV1 Create()
    {
        var intermediateTableAnalysisRulePolicyV1Result = CreateIntermediateTableAnalysisRulePolicyV1();
        factoryAction?.Invoke(intermediateTableAnalysisRulePolicyV1Result);

        return intermediateTableAnalysisRulePolicyV1Result;
    }

    private Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRulePolicyV1 CreateIntermediateTableAnalysisRulePolicyV1()
    {
        var intermediateTableAnalysisRulePolicyV1Result = new Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRulePolicyV1();

        return intermediateTableAnalysisRulePolicyV1Result;
    }
    public override void CreateChildren(Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRulePolicyV1 result)
    {
        base.CreateChildren(result);

        result.Custom ??= CustomFactory?.Build();
    }

} // End Of Class

public static class InnerIntermediateTableIntermediateTableAnalysisRulePolicyV1FactoryExtensions
{
    public static CombinedResult<InnerIntermediateTableIntermediateTableAnalysisRulePolicyV1Factory, InnerIntermediateTableIntermediateTableAnalysisRuleCustomFactory> WithCustom(this InnerIntermediateTableIntermediateTableAnalysisRulePolicyV1Factory parentFactory, Action<Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRuleCustom> subFactoryAction = null)
    {
        parentFactory.CustomFactory = new InnerIntermediateTableIntermediateTableAnalysisRuleCustomFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CustomFactory);
    }

    public static CombinedResult<InnerIntermediateTableIntermediateTableAnalysisRulePolicyV1Factory, T1, InnerIntermediateTableIntermediateTableAnalysisRuleCustomFactory> WithCustom<T1>(this CombinedResult<InnerIntermediateTableIntermediateTableAnalysisRulePolicyV1Factory, T1> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRuleCustom> subFactoryAction = null) => new (combinedResult, combinedResult, WithCustom(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerIntermediateTableIntermediateTableAnalysisRulePolicyV1Factory, InnerIntermediateTableIntermediateTableAnalysisRuleCustomFactory> WithCustom<T1>(this CombinedResult<T1, InnerIntermediateTableIntermediateTableAnalysisRulePolicyV1Factory> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRuleCustom> subFactoryAction = null) => new (combinedResult, combinedResult, WithCustom(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerIntermediateTableIntermediateTableAnalysisRulePolicyV1Factory, T1, T2, InnerIntermediateTableIntermediateTableAnalysisRuleCustomFactory> WithCustom<T1, T2>(this CombinedResult<InnerIntermediateTableIntermediateTableAnalysisRulePolicyV1Factory, T1, T2> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRuleCustom> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustom(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerIntermediateTableIntermediateTableAnalysisRulePolicyV1Factory, T2, InnerIntermediateTableIntermediateTableAnalysisRuleCustomFactory> WithCustom<T1, T2>(this CombinedResult<T1, InnerIntermediateTableIntermediateTableAnalysisRulePolicyV1Factory, T2> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRuleCustom> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustom(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerIntermediateTableIntermediateTableAnalysisRulePolicyV1Factory, InnerIntermediateTableIntermediateTableAnalysisRuleCustomFactory> WithCustom<T1, T2>(this CombinedResult<T1, T2, InnerIntermediateTableIntermediateTableAnalysisRulePolicyV1Factory> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRuleCustom> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustom(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerIntermediateTableIntermediateTableAnalysisRulePolicyV1Factory, T1, T2, T3, InnerIntermediateTableIntermediateTableAnalysisRuleCustomFactory> WithCustom<T1, T2, T3>(this CombinedResult<InnerIntermediateTableIntermediateTableAnalysisRulePolicyV1Factory, T1, T2, T3> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRuleCustom> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustom(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerIntermediateTableIntermediateTableAnalysisRulePolicyV1Factory, T2, T3, InnerIntermediateTableIntermediateTableAnalysisRuleCustomFactory> WithCustom<T1, T2, T3>(this CombinedResult<T1, InnerIntermediateTableIntermediateTableAnalysisRulePolicyV1Factory, T2, T3> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRuleCustom> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustom(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerIntermediateTableIntermediateTableAnalysisRulePolicyV1Factory, T3, InnerIntermediateTableIntermediateTableAnalysisRuleCustomFactory> WithCustom<T1, T2, T3>(this CombinedResult<T1, T2, InnerIntermediateTableIntermediateTableAnalysisRulePolicyV1Factory, T3> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRuleCustom> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustom(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerIntermediateTableIntermediateTableAnalysisRulePolicyV1Factory, InnerIntermediateTableIntermediateTableAnalysisRuleCustomFactory> WithCustom<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerIntermediateTableIntermediateTableAnalysisRulePolicyV1Factory> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRuleCustom> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustom(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerIntermediateTableIntermediateTableAnalysisRulePolicyV1Factory, T1, T2, T3, T4, InnerIntermediateTableIntermediateTableAnalysisRuleCustomFactory> WithCustom<T1, T2, T3, T4>(this CombinedResult<InnerIntermediateTableIntermediateTableAnalysisRulePolicyV1Factory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRuleCustom> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustom(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerIntermediateTableIntermediateTableAnalysisRulePolicyV1Factory, T2, T3, T4, InnerIntermediateTableIntermediateTableAnalysisRuleCustomFactory> WithCustom<T1, T2, T3, T4>(this CombinedResult<T1, InnerIntermediateTableIntermediateTableAnalysisRulePolicyV1Factory, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRuleCustom> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustom(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerIntermediateTableIntermediateTableAnalysisRulePolicyV1Factory, T3, T4, InnerIntermediateTableIntermediateTableAnalysisRuleCustomFactory> WithCustom<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerIntermediateTableIntermediateTableAnalysisRulePolicyV1Factory, T3, T4> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRuleCustom> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustom(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerIntermediateTableIntermediateTableAnalysisRulePolicyV1Factory, T4, InnerIntermediateTableIntermediateTableAnalysisRuleCustomFactory> WithCustom<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerIntermediateTableIntermediateTableAnalysisRulePolicyV1Factory, T4> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRuleCustom> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustom(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerIntermediateTableIntermediateTableAnalysisRulePolicyV1Factory, InnerIntermediateTableIntermediateTableAnalysisRuleCustomFactory> WithCustom<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerIntermediateTableIntermediateTableAnalysisRulePolicyV1Factory> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRuleCustom> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustom(combinedResult.T5, subFactoryAction).T2);
}
