// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerEvaluatorRatingScaleFactory(Action<Humidifier.BedrockAgentCore.EvaluatorTypes.RatingScale> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.EvaluatorTypes.RatingScale>
{

    protected override Humidifier.BedrockAgentCore.EvaluatorTypes.RatingScale Create()
    {
        var ratingScaleResult = CreateRatingScale();
        factoryAction?.Invoke(ratingScaleResult);

        return ratingScaleResult;
    }

    private Humidifier.BedrockAgentCore.EvaluatorTypes.RatingScale CreateRatingScale()
    {
        var ratingScaleResult = new Humidifier.BedrockAgentCore.EvaluatorTypes.RatingScale();

        return ratingScaleResult;
    }

} // End Of Class

public static class InnerEvaluatorRatingScaleFactoryExtensions
{
}
