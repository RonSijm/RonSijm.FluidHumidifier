// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRooms;

public class InnerIntermediateTablePopulationAnalysisConfigurationFactory(Action<Humidifier.CleanRooms.IntermediateTableTypes.PopulationAnalysisConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.CleanRooms.IntermediateTableTypes.PopulationAnalysisConfiguration>
{

    internal InnerIntermediateTablePopulationAnalysisSqlParametersFactory SqlParametersFactory { get; set; }

    protected override Humidifier.CleanRooms.IntermediateTableTypes.PopulationAnalysisConfiguration Create()
    {
        var populationAnalysisConfigurationResult = CreatePopulationAnalysisConfiguration();
        factoryAction?.Invoke(populationAnalysisConfigurationResult);

        return populationAnalysisConfigurationResult;
    }

    private Humidifier.CleanRooms.IntermediateTableTypes.PopulationAnalysisConfiguration CreatePopulationAnalysisConfiguration()
    {
        var populationAnalysisConfigurationResult = new Humidifier.CleanRooms.IntermediateTableTypes.PopulationAnalysisConfiguration();

        return populationAnalysisConfigurationResult;
    }
    public override void CreateChildren(Humidifier.CleanRooms.IntermediateTableTypes.PopulationAnalysisConfiguration result)
    {
        base.CreateChildren(result);

        result.SqlParameters ??= SqlParametersFactory?.Build();
    }

} // End Of Class

public static class InnerIntermediateTablePopulationAnalysisConfigurationFactoryExtensions
{
    public static CombinedResult<InnerIntermediateTablePopulationAnalysisConfigurationFactory, InnerIntermediateTablePopulationAnalysisSqlParametersFactory> WithSqlParameters(this InnerIntermediateTablePopulationAnalysisConfigurationFactory parentFactory, Action<Humidifier.CleanRooms.IntermediateTableTypes.PopulationAnalysisSqlParameters> subFactoryAction = null)
    {
        parentFactory.SqlParametersFactory = new InnerIntermediateTablePopulationAnalysisSqlParametersFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SqlParametersFactory);
    }

    public static CombinedResult<InnerIntermediateTablePopulationAnalysisConfigurationFactory, T1, InnerIntermediateTablePopulationAnalysisSqlParametersFactory> WithSqlParameters<T1>(this CombinedResult<InnerIntermediateTablePopulationAnalysisConfigurationFactory, T1> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.PopulationAnalysisSqlParameters> subFactoryAction = null) => new (combinedResult, combinedResult, WithSqlParameters(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerIntermediateTablePopulationAnalysisConfigurationFactory, InnerIntermediateTablePopulationAnalysisSqlParametersFactory> WithSqlParameters<T1>(this CombinedResult<T1, InnerIntermediateTablePopulationAnalysisConfigurationFactory> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.PopulationAnalysisSqlParameters> subFactoryAction = null) => new (combinedResult, combinedResult, WithSqlParameters(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerIntermediateTablePopulationAnalysisConfigurationFactory, T1, T2, InnerIntermediateTablePopulationAnalysisSqlParametersFactory> WithSqlParameters<T1, T2>(this CombinedResult<InnerIntermediateTablePopulationAnalysisConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.PopulationAnalysisSqlParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSqlParameters(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerIntermediateTablePopulationAnalysisConfigurationFactory, T2, InnerIntermediateTablePopulationAnalysisSqlParametersFactory> WithSqlParameters<T1, T2>(this CombinedResult<T1, InnerIntermediateTablePopulationAnalysisConfigurationFactory, T2> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.PopulationAnalysisSqlParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSqlParameters(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerIntermediateTablePopulationAnalysisConfigurationFactory, InnerIntermediateTablePopulationAnalysisSqlParametersFactory> WithSqlParameters<T1, T2>(this CombinedResult<T1, T2, InnerIntermediateTablePopulationAnalysisConfigurationFactory> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.PopulationAnalysisSqlParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSqlParameters(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerIntermediateTablePopulationAnalysisConfigurationFactory, T1, T2, T3, InnerIntermediateTablePopulationAnalysisSqlParametersFactory> WithSqlParameters<T1, T2, T3>(this CombinedResult<InnerIntermediateTablePopulationAnalysisConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.PopulationAnalysisSqlParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSqlParameters(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerIntermediateTablePopulationAnalysisConfigurationFactory, T2, T3, InnerIntermediateTablePopulationAnalysisSqlParametersFactory> WithSqlParameters<T1, T2, T3>(this CombinedResult<T1, InnerIntermediateTablePopulationAnalysisConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.PopulationAnalysisSqlParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSqlParameters(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerIntermediateTablePopulationAnalysisConfigurationFactory, T3, InnerIntermediateTablePopulationAnalysisSqlParametersFactory> WithSqlParameters<T1, T2, T3>(this CombinedResult<T1, T2, InnerIntermediateTablePopulationAnalysisConfigurationFactory, T3> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.PopulationAnalysisSqlParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSqlParameters(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerIntermediateTablePopulationAnalysisConfigurationFactory, InnerIntermediateTablePopulationAnalysisSqlParametersFactory> WithSqlParameters<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerIntermediateTablePopulationAnalysisConfigurationFactory> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.PopulationAnalysisSqlParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSqlParameters(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerIntermediateTablePopulationAnalysisConfigurationFactory, T1, T2, T3, T4, InnerIntermediateTablePopulationAnalysisSqlParametersFactory> WithSqlParameters<T1, T2, T3, T4>(this CombinedResult<InnerIntermediateTablePopulationAnalysisConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.PopulationAnalysisSqlParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSqlParameters(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerIntermediateTablePopulationAnalysisConfigurationFactory, T2, T3, T4, InnerIntermediateTablePopulationAnalysisSqlParametersFactory> WithSqlParameters<T1, T2, T3, T4>(this CombinedResult<T1, InnerIntermediateTablePopulationAnalysisConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.PopulationAnalysisSqlParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSqlParameters(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerIntermediateTablePopulationAnalysisConfigurationFactory, T3, T4, InnerIntermediateTablePopulationAnalysisSqlParametersFactory> WithSqlParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerIntermediateTablePopulationAnalysisConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.PopulationAnalysisSqlParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSqlParameters(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerIntermediateTablePopulationAnalysisConfigurationFactory, T4, InnerIntermediateTablePopulationAnalysisSqlParametersFactory> WithSqlParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerIntermediateTablePopulationAnalysisConfigurationFactory, T4> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.PopulationAnalysisSqlParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSqlParameters(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerIntermediateTablePopulationAnalysisConfigurationFactory, InnerIntermediateTablePopulationAnalysisSqlParametersFactory> WithSqlParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerIntermediateTablePopulationAnalysisConfigurationFactory> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.PopulationAnalysisSqlParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSqlParameters(combinedResult.T5, subFactoryAction).T2);
}
