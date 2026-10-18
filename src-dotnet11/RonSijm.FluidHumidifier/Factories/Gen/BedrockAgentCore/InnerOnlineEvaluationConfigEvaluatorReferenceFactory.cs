// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerOnlineEvaluationConfigEvaluatorReferenceFactory(Action<Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.EvaluatorReference> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.EvaluatorReference>
{

    protected override Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.EvaluatorReference Create()
    {
        var evaluatorReferenceResult = CreateEvaluatorReference();
        factoryAction?.Invoke(evaluatorReferenceResult);

        return evaluatorReferenceResult;
    }

    private Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.EvaluatorReference CreateEvaluatorReference()
    {
        var evaluatorReferenceResult = new Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.EvaluatorReference();

        return evaluatorReferenceResult;
    }

} // End Of Class

public static class InnerOnlineEvaluationConfigEvaluatorReferenceFactoryExtensions
{
}
