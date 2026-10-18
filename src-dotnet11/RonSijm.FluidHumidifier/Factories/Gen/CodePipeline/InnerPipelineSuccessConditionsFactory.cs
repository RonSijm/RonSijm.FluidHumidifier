// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodePipeline;

public class InnerPipelineSuccessConditionsFactory(Action<Humidifier.CodePipeline.PipelineTypes.SuccessConditions> factoryAction = null) : SubResourceFactory<Humidifier.CodePipeline.PipelineTypes.SuccessConditions>
{

    protected override Humidifier.CodePipeline.PipelineTypes.SuccessConditions Create()
    {
        var successConditionsResult = CreateSuccessConditions();
        factoryAction?.Invoke(successConditionsResult);

        return successConditionsResult;
    }

    private Humidifier.CodePipeline.PipelineTypes.SuccessConditions CreateSuccessConditions()
    {
        var successConditionsResult = new Humidifier.CodePipeline.PipelineTypes.SuccessConditions();

        return successConditionsResult;
    }

} // End Of Class

public static class InnerPipelineSuccessConditionsFactoryExtensions
{
}
