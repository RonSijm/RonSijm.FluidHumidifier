// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRooms;

public class InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRulePolicyFactory(Action<Humidifier.CleanRooms.ConfiguredTableAssociationTypes.ConfiguredTableAssociationAnalysisRulePolicy> factoryAction = null) : SubResourceFactory<Humidifier.CleanRooms.ConfiguredTableAssociationTypes.ConfiguredTableAssociationAnalysisRulePolicy>
{

    internal InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRulePolicyV1Factory V1Factory { get; set; }

    protected override Humidifier.CleanRooms.ConfiguredTableAssociationTypes.ConfiguredTableAssociationAnalysisRulePolicy Create()
    {
        var configuredTableAssociationAnalysisRulePolicyResult = CreateConfiguredTableAssociationAnalysisRulePolicy();
        factoryAction?.Invoke(configuredTableAssociationAnalysisRulePolicyResult);

        return configuredTableAssociationAnalysisRulePolicyResult;
    }

    private Humidifier.CleanRooms.ConfiguredTableAssociationTypes.ConfiguredTableAssociationAnalysisRulePolicy CreateConfiguredTableAssociationAnalysisRulePolicy()
    {
        var configuredTableAssociationAnalysisRulePolicyResult = new Humidifier.CleanRooms.ConfiguredTableAssociationTypes.ConfiguredTableAssociationAnalysisRulePolicy();

        return configuredTableAssociationAnalysisRulePolicyResult;
    }
    public override void CreateChildren(Humidifier.CleanRooms.ConfiguredTableAssociationTypes.ConfiguredTableAssociationAnalysisRulePolicy result)
    {
        base.CreateChildren(result);

        result.V1 ??= V1Factory?.Build();
    }

} // End Of Class

public static class InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRulePolicyFactoryExtensions
{
    public static CombinedResult<InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRulePolicyFactory, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRulePolicyV1Factory> WithV1(this InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRulePolicyFactory parentFactory, Action<Humidifier.CleanRooms.ConfiguredTableAssociationTypes.ConfiguredTableAssociationAnalysisRulePolicyV1> subFactoryAction = null)
    {
        parentFactory.V1Factory = new InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRulePolicyV1Factory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.V1Factory);
    }

    public static CombinedResult<InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRulePolicyFactory, T1, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRulePolicyV1Factory> WithV1<T1>(this CombinedResult<InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRulePolicyFactory, T1> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableAssociationTypes.ConfiguredTableAssociationAnalysisRulePolicyV1> subFactoryAction = null) => new (combinedResult, combinedResult, WithV1(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRulePolicyFactory, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRulePolicyV1Factory> WithV1<T1>(this CombinedResult<T1, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRulePolicyFactory> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableAssociationTypes.ConfiguredTableAssociationAnalysisRulePolicyV1> subFactoryAction = null) => new (combinedResult, combinedResult, WithV1(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRulePolicyFactory, T1, T2, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRulePolicyV1Factory> WithV1<T1, T2>(this CombinedResult<InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRulePolicyFactory, T1, T2> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableAssociationTypes.ConfiguredTableAssociationAnalysisRulePolicyV1> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithV1(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRulePolicyFactory, T2, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRulePolicyV1Factory> WithV1<T1, T2>(this CombinedResult<T1, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRulePolicyFactory, T2> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableAssociationTypes.ConfiguredTableAssociationAnalysisRulePolicyV1> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithV1(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRulePolicyFactory, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRulePolicyV1Factory> WithV1<T1, T2>(this CombinedResult<T1, T2, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRulePolicyFactory> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableAssociationTypes.ConfiguredTableAssociationAnalysisRulePolicyV1> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithV1(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRulePolicyFactory, T1, T2, T3, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRulePolicyV1Factory> WithV1<T1, T2, T3>(this CombinedResult<InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRulePolicyFactory, T1, T2, T3> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableAssociationTypes.ConfiguredTableAssociationAnalysisRulePolicyV1> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithV1(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRulePolicyFactory, T2, T3, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRulePolicyV1Factory> WithV1<T1, T2, T3>(this CombinedResult<T1, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRulePolicyFactory, T2, T3> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableAssociationTypes.ConfiguredTableAssociationAnalysisRulePolicyV1> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithV1(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRulePolicyFactory, T3, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRulePolicyV1Factory> WithV1<T1, T2, T3>(this CombinedResult<T1, T2, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRulePolicyFactory, T3> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableAssociationTypes.ConfiguredTableAssociationAnalysisRulePolicyV1> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithV1(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRulePolicyFactory, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRulePolicyV1Factory> WithV1<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRulePolicyFactory> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableAssociationTypes.ConfiguredTableAssociationAnalysisRulePolicyV1> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithV1(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRulePolicyFactory, T1, T2, T3, T4, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRulePolicyV1Factory> WithV1<T1, T2, T3, T4>(this CombinedResult<InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRulePolicyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableAssociationTypes.ConfiguredTableAssociationAnalysisRulePolicyV1> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithV1(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRulePolicyFactory, T2, T3, T4, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRulePolicyV1Factory> WithV1<T1, T2, T3, T4>(this CombinedResult<T1, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRulePolicyFactory, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableAssociationTypes.ConfiguredTableAssociationAnalysisRulePolicyV1> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithV1(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRulePolicyFactory, T3, T4, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRulePolicyV1Factory> WithV1<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRulePolicyFactory, T3, T4> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableAssociationTypes.ConfiguredTableAssociationAnalysisRulePolicyV1> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithV1(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRulePolicyFactory, T4, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRulePolicyV1Factory> WithV1<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRulePolicyFactory, T4> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableAssociationTypes.ConfiguredTableAssociationAnalysisRulePolicyV1> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithV1(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRulePolicyFactory, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRulePolicyV1Factory> WithV1<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRulePolicyFactory> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableAssociationTypes.ConfiguredTableAssociationAnalysisRulePolicyV1> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithV1(combinedResult.T5, subFactoryAction));
}
