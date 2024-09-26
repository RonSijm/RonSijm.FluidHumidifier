// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRooms;

public class InnerConfiguredTableAnalysisRuleCustomFactory(Action<Humidifier.CleanRooms.ConfiguredTableTypes.AnalysisRuleCustom> factoryAction = null) : SubResourceFactory<Humidifier.CleanRooms.ConfiguredTableTypes.AnalysisRuleCustom>
{

    internal InnerConfiguredTableDifferentialPrivacyFactory DifferentialPrivacyFactory { get; set; }

    protected override Humidifier.CleanRooms.ConfiguredTableTypes.AnalysisRuleCustom Create()
    {
        var analysisRuleCustomResult = CreateAnalysisRuleCustom();
        factoryAction?.Invoke(analysisRuleCustomResult);

        return analysisRuleCustomResult;
    }

    private Humidifier.CleanRooms.ConfiguredTableTypes.AnalysisRuleCustom CreateAnalysisRuleCustom()
    {
        var analysisRuleCustomResult = new Humidifier.CleanRooms.ConfiguredTableTypes.AnalysisRuleCustom();

        return analysisRuleCustomResult;
    }
    public override void CreateChildren(Humidifier.CleanRooms.ConfiguredTableTypes.AnalysisRuleCustom result)
    {
        base.CreateChildren(result);

        result.DifferentialPrivacy ??= DifferentialPrivacyFactory?.Build();
    }

} // End Of Class

public static class InnerConfiguredTableAnalysisRuleCustomFactoryExtensions
{
    public static CombinedResult<InnerConfiguredTableAnalysisRuleCustomFactory, InnerConfiguredTableDifferentialPrivacyFactory> WithDifferentialPrivacy(this InnerConfiguredTableAnalysisRuleCustomFactory parentFactory, Action<Humidifier.CleanRooms.ConfiguredTableTypes.DifferentialPrivacy> subFactoryAction = null)
    {
        parentFactory.DifferentialPrivacyFactory = new InnerConfiguredTableDifferentialPrivacyFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DifferentialPrivacyFactory);
    }

    public static CombinedResult<InnerConfiguredTableAnalysisRuleCustomFactory, T1, InnerConfiguredTableDifferentialPrivacyFactory> WithDifferentialPrivacy<T1>(this CombinedResult<InnerConfiguredTableAnalysisRuleCustomFactory, T1> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.DifferentialPrivacy> subFactoryAction = null) => new (combinedResult, combinedResult, WithDifferentialPrivacy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConfiguredTableAnalysisRuleCustomFactory, InnerConfiguredTableDifferentialPrivacyFactory> WithDifferentialPrivacy<T1>(this CombinedResult<T1, InnerConfiguredTableAnalysisRuleCustomFactory> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.DifferentialPrivacy> subFactoryAction = null) => new (combinedResult, combinedResult, WithDifferentialPrivacy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerConfiguredTableAnalysisRuleCustomFactory, T1, T2, InnerConfiguredTableDifferentialPrivacyFactory> WithDifferentialPrivacy<T1, T2>(this CombinedResult<InnerConfiguredTableAnalysisRuleCustomFactory, T1, T2> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.DifferentialPrivacy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDifferentialPrivacy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConfiguredTableAnalysisRuleCustomFactory, T2, InnerConfiguredTableDifferentialPrivacyFactory> WithDifferentialPrivacy<T1, T2>(this CombinedResult<T1, InnerConfiguredTableAnalysisRuleCustomFactory, T2> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.DifferentialPrivacy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDifferentialPrivacy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConfiguredTableAnalysisRuleCustomFactory, InnerConfiguredTableDifferentialPrivacyFactory> WithDifferentialPrivacy<T1, T2>(this CombinedResult<T1, T2, InnerConfiguredTableAnalysisRuleCustomFactory> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.DifferentialPrivacy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDifferentialPrivacy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerConfiguredTableAnalysisRuleCustomFactory, T1, T2, T3, InnerConfiguredTableDifferentialPrivacyFactory> WithDifferentialPrivacy<T1, T2, T3>(this CombinedResult<InnerConfiguredTableAnalysisRuleCustomFactory, T1, T2, T3> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.DifferentialPrivacy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDifferentialPrivacy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConfiguredTableAnalysisRuleCustomFactory, T2, T3, InnerConfiguredTableDifferentialPrivacyFactory> WithDifferentialPrivacy<T1, T2, T3>(this CombinedResult<T1, InnerConfiguredTableAnalysisRuleCustomFactory, T2, T3> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.DifferentialPrivacy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDifferentialPrivacy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConfiguredTableAnalysisRuleCustomFactory, T3, InnerConfiguredTableDifferentialPrivacyFactory> WithDifferentialPrivacy<T1, T2, T3>(this CombinedResult<T1, T2, InnerConfiguredTableAnalysisRuleCustomFactory, T3> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.DifferentialPrivacy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDifferentialPrivacy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConfiguredTableAnalysisRuleCustomFactory, InnerConfiguredTableDifferentialPrivacyFactory> WithDifferentialPrivacy<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerConfiguredTableAnalysisRuleCustomFactory> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.DifferentialPrivacy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDifferentialPrivacy(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerConfiguredTableAnalysisRuleCustomFactory, T1, T2, T3, T4, InnerConfiguredTableDifferentialPrivacyFactory> WithDifferentialPrivacy<T1, T2, T3, T4>(this CombinedResult<InnerConfiguredTableAnalysisRuleCustomFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.DifferentialPrivacy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDifferentialPrivacy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConfiguredTableAnalysisRuleCustomFactory, T2, T3, T4, InnerConfiguredTableDifferentialPrivacyFactory> WithDifferentialPrivacy<T1, T2, T3, T4>(this CombinedResult<T1, InnerConfiguredTableAnalysisRuleCustomFactory, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.DifferentialPrivacy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDifferentialPrivacy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConfiguredTableAnalysisRuleCustomFactory, T3, T4, InnerConfiguredTableDifferentialPrivacyFactory> WithDifferentialPrivacy<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerConfiguredTableAnalysisRuleCustomFactory, T3, T4> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.DifferentialPrivacy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDifferentialPrivacy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConfiguredTableAnalysisRuleCustomFactory, T4, InnerConfiguredTableDifferentialPrivacyFactory> WithDifferentialPrivacy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerConfiguredTableAnalysisRuleCustomFactory, T4> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.DifferentialPrivacy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDifferentialPrivacy(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerConfiguredTableAnalysisRuleCustomFactory, InnerConfiguredTableDifferentialPrivacyFactory> WithDifferentialPrivacy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerConfiguredTableAnalysisRuleCustomFactory> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.DifferentialPrivacy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDifferentialPrivacy(combinedResult.T5, subFactoryAction));
}
