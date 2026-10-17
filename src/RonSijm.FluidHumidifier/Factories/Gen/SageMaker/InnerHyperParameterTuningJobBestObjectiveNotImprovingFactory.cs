// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerHyperParameterTuningJobBestObjectiveNotImprovingFactory(Action<Humidifier.SageMaker.HyperParameterTuningJobTypes.BestObjectiveNotImproving> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.HyperParameterTuningJobTypes.BestObjectiveNotImproving>
{

    protected override Humidifier.SageMaker.HyperParameterTuningJobTypes.BestObjectiveNotImproving Create()
    {
        var bestObjectiveNotImprovingResult = CreateBestObjectiveNotImproving();
        factoryAction?.Invoke(bestObjectiveNotImprovingResult);

        return bestObjectiveNotImprovingResult;
    }

    private Humidifier.SageMaker.HyperParameterTuningJobTypes.BestObjectiveNotImproving CreateBestObjectiveNotImproving()
    {
        var bestObjectiveNotImprovingResult = new Humidifier.SageMaker.HyperParameterTuningJobTypes.BestObjectiveNotImproving();

        return bestObjectiveNotImprovingResult;
    }

} // End Of Class

public static class InnerHyperParameterTuningJobBestObjectiveNotImprovingFactoryExtensions
{
}
