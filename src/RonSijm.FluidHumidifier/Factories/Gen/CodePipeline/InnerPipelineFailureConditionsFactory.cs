// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodePipeline;

public class InnerPipelineFailureConditionsFactory(Action<Humidifier.CodePipeline.PipelineTypes.FailureConditions> factoryAction = null) : SubResourceFactory<Humidifier.CodePipeline.PipelineTypes.FailureConditions>
{

    protected override Humidifier.CodePipeline.PipelineTypes.FailureConditions Create()
    {
        var failureConditionsResult = CreateFailureConditions();
        factoryAction?.Invoke(failureConditionsResult);

        return failureConditionsResult;
    }

    private Humidifier.CodePipeline.PipelineTypes.FailureConditions CreateFailureConditions()
    {
        var failureConditionsResult = new Humidifier.CodePipeline.PipelineTypes.FailureConditions();

        return failureConditionsResult;
    }

} // End Of Class

public static class InnerPipelineFailureConditionsFactoryExtensions
{
}
