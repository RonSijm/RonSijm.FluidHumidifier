// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRooms;

public class InnerIntermediateTablePopulationAnalysisSqlParametersFactory(Action<Humidifier.CleanRooms.IntermediateTableTypes.PopulationAnalysisSqlParameters> factoryAction = null) : SubResourceFactory<Humidifier.CleanRooms.IntermediateTableTypes.PopulationAnalysisSqlParameters>
{

    protected override Humidifier.CleanRooms.IntermediateTableTypes.PopulationAnalysisSqlParameters Create()
    {
        var populationAnalysisSqlParametersResult = CreatePopulationAnalysisSqlParameters();
        factoryAction?.Invoke(populationAnalysisSqlParametersResult);

        return populationAnalysisSqlParametersResult;
    }

    private Humidifier.CleanRooms.IntermediateTableTypes.PopulationAnalysisSqlParameters CreatePopulationAnalysisSqlParameters()
    {
        var populationAnalysisSqlParametersResult = new Humidifier.CleanRooms.IntermediateTableTypes.PopulationAnalysisSqlParameters();

        return populationAnalysisSqlParametersResult;
    }

} // End Of Class

public static class InnerIntermediateTablePopulationAnalysisSqlParametersFactoryExtensions
{
}
