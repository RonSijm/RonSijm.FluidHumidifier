// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FIS;

public class InnerExperimentTemplateExperimentTemplateStopConditionFactory(Action<Humidifier.FIS.ExperimentTemplateTypes.ExperimentTemplateStopCondition> factoryAction = null) : SubResourceFactory<Humidifier.FIS.ExperimentTemplateTypes.ExperimentTemplateStopCondition>
{

    protected override Humidifier.FIS.ExperimentTemplateTypes.ExperimentTemplateStopCondition Create()
    {
        var experimentTemplateStopConditionResult = CreateExperimentTemplateStopCondition();
        factoryAction?.Invoke(experimentTemplateStopConditionResult);

        return experimentTemplateStopConditionResult;
    }

    private Humidifier.FIS.ExperimentTemplateTypes.ExperimentTemplateStopCondition CreateExperimentTemplateStopCondition()
    {
        var experimentTemplateStopConditionResult = new Humidifier.FIS.ExperimentTemplateTypes.ExperimentTemplateStopCondition();

        return experimentTemplateStopConditionResult;
    }

} // End Of Class

public static class InnerExperimentTemplateExperimentTemplateStopConditionFactoryExtensions
{
}
