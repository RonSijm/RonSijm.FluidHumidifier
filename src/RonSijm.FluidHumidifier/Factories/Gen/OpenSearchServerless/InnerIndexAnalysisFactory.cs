// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OpenSearchServerless;

public class InnerIndexAnalysisFactory(Action<Humidifier.OpenSearchServerless.IndexTypes.Analysis> factoryAction = null) : SubResourceFactory<Humidifier.OpenSearchServerless.IndexTypes.Analysis>
{

    protected override Humidifier.OpenSearchServerless.IndexTypes.Analysis Create()
    {
        var analysisResult = CreateAnalysis();
        factoryAction?.Invoke(analysisResult);

        return analysisResult;
    }

    private Humidifier.OpenSearchServerless.IndexTypes.Analysis CreateAnalysis()
    {
        var analysisResult = new Humidifier.OpenSearchServerless.IndexTypes.Analysis();

        return analysisResult;
    }

} // End Of Class

public static class InnerIndexAnalysisFactoryExtensions
{
}
