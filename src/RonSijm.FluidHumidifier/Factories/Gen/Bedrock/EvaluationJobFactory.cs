// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class EvaluationJobFactory(string resourceName = null, Action<Humidifier.Bedrock.EvaluationJob> factoryAction = null) : ResourceFactory<Humidifier.Bedrock.EvaluationJob>(resourceName)
{

    protected override Humidifier.Bedrock.EvaluationJob Create()
    {
        var evaluationJobResult = CreateEvaluationJob();
        factoryAction?.Invoke(evaluationJobResult);

        return evaluationJobResult;
    }

    private Humidifier.Bedrock.EvaluationJob CreateEvaluationJob()
    {
        var evaluationJobResult = new Humidifier.Bedrock.EvaluationJob
        {
            GivenName = InputResourceName,
        };

        return evaluationJobResult;
    }

} // End Of Class

public static class EvaluationJobFactoryExtensions
{
}
