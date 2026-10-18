// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Personalize;

public class InnerSolutionAlgorithmHyperParameterRangesFactory(Action<Humidifier.Personalize.SolutionTypes.AlgorithmHyperParameterRanges> factoryAction = null) : SubResourceFactory<Humidifier.Personalize.SolutionTypes.AlgorithmHyperParameterRanges>
{

    protected override Humidifier.Personalize.SolutionTypes.AlgorithmHyperParameterRanges Create()
    {
        var algorithmHyperParameterRangesResult = CreateAlgorithmHyperParameterRanges();
        factoryAction?.Invoke(algorithmHyperParameterRangesResult);

        return algorithmHyperParameterRangesResult;
    }

    private Humidifier.Personalize.SolutionTypes.AlgorithmHyperParameterRanges CreateAlgorithmHyperParameterRanges()
    {
        var algorithmHyperParameterRangesResult = new Humidifier.Personalize.SolutionTypes.AlgorithmHyperParameterRanges();

        return algorithmHyperParameterRangesResult;
    }

} // End Of Class

public static class InnerSolutionAlgorithmHyperParameterRangesFactoryExtensions
{
}
