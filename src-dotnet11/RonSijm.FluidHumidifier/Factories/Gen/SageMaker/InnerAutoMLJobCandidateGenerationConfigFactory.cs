// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerAutoMLJobCandidateGenerationConfigFactory(Action<Humidifier.SageMaker.AutoMLJobTypes.CandidateGenerationConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.AutoMLJobTypes.CandidateGenerationConfig>
{

    protected override Humidifier.SageMaker.AutoMLJobTypes.CandidateGenerationConfig Create()
    {
        var candidateGenerationConfigResult = CreateCandidateGenerationConfig();
        factoryAction?.Invoke(candidateGenerationConfigResult);

        return candidateGenerationConfigResult;
    }

    private Humidifier.SageMaker.AutoMLJobTypes.CandidateGenerationConfig CreateCandidateGenerationConfig()
    {
        var candidateGenerationConfigResult = new Humidifier.SageMaker.AutoMLJobTypes.CandidateGenerationConfig();

        return candidateGenerationConfigResult;
    }

} // End Of Class

public static class InnerAutoMLJobCandidateGenerationConfigFactoryExtensions
{
}
