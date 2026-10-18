// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Events;

public class InnerRuleSageMakerPipelineParametersFactory(Action<Humidifier.Events.RuleTypes.SageMakerPipelineParameters> factoryAction = null) : SubResourceFactory<Humidifier.Events.RuleTypes.SageMakerPipelineParameters>
{

    protected override Humidifier.Events.RuleTypes.SageMakerPipelineParameters Create()
    {
        var sageMakerPipelineParametersResult = CreateSageMakerPipelineParameters();
        factoryAction?.Invoke(sageMakerPipelineParametersResult);

        return sageMakerPipelineParametersResult;
    }

    private Humidifier.Events.RuleTypes.SageMakerPipelineParameters CreateSageMakerPipelineParameters()
    {
        var sageMakerPipelineParametersResult = new Humidifier.Events.RuleTypes.SageMakerPipelineParameters();

        return sageMakerPipelineParametersResult;
    }

} // End Of Class

public static class InnerRuleSageMakerPipelineParametersFactoryExtensions
{
}
