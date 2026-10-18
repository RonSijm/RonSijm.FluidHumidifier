// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodePipeline;

public class InnerPipelineBeforeEntryConditionsFactory(Action<Humidifier.CodePipeline.PipelineTypes.BeforeEntryConditions> factoryAction = null) : SubResourceFactory<Humidifier.CodePipeline.PipelineTypes.BeforeEntryConditions>
{

    protected override Humidifier.CodePipeline.PipelineTypes.BeforeEntryConditions Create()
    {
        var beforeEntryConditionsResult = CreateBeforeEntryConditions();
        factoryAction?.Invoke(beforeEntryConditionsResult);

        return beforeEntryConditionsResult;
    }

    private Humidifier.CodePipeline.PipelineTypes.BeforeEntryConditions CreateBeforeEntryConditions()
    {
        var beforeEntryConditionsResult = new Humidifier.CodePipeline.PipelineTypes.BeforeEntryConditions();

        return beforeEntryConditionsResult;
    }

} // End Of Class

public static class InnerPipelineBeforeEntryConditionsFactoryExtensions
{
}
