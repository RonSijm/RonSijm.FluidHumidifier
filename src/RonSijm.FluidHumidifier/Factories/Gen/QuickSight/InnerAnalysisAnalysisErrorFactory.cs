// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerAnalysisAnalysisErrorFactory(Action<Humidifier.QuickSight.AnalysisTypes.AnalysisError> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.AnalysisTypes.AnalysisError>
{

    protected override Humidifier.QuickSight.AnalysisTypes.AnalysisError Create()
    {
        var analysisErrorResult = CreateAnalysisError();
        factoryAction?.Invoke(analysisErrorResult);

        return analysisErrorResult;
    }

    private Humidifier.QuickSight.AnalysisTypes.AnalysisError CreateAnalysisError()
    {
        var analysisErrorResult = new Humidifier.QuickSight.AnalysisTypes.AnalysisError();

        return analysisErrorResult;
    }

} // End Of Class

public static class InnerAnalysisAnalysisErrorFactoryExtensions
{
}
