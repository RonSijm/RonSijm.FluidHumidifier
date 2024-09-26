// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerAnalysisParametersFactory(Action<Humidifier.QuickSight.AnalysisTypes.Parameters> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.AnalysisTypes.Parameters>
{

    protected override Humidifier.QuickSight.AnalysisTypes.Parameters Create()
    {
        var parametersResult = CreateParameters();
        factoryAction?.Invoke(parametersResult);

        return parametersResult;
    }

    private Humidifier.QuickSight.AnalysisTypes.Parameters CreateParameters()
    {
        var parametersResult = new Humidifier.QuickSight.AnalysisTypes.Parameters();

        return parametersResult;
    }

} // End Of Class

public static class InnerAnalysisParametersFactoryExtensions
{
}
