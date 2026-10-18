// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FIS;

public class InnerExperimentTemplateExperimentTemplateExperimentOptionsFactory(Action<Humidifier.FIS.ExperimentTemplateTypes.ExperimentTemplateExperimentOptions> factoryAction = null) : SubResourceFactory<Humidifier.FIS.ExperimentTemplateTypes.ExperimentTemplateExperimentOptions>
{

    protected override Humidifier.FIS.ExperimentTemplateTypes.ExperimentTemplateExperimentOptions Create()
    {
        var experimentTemplateExperimentOptionsResult = CreateExperimentTemplateExperimentOptions();
        factoryAction?.Invoke(experimentTemplateExperimentOptionsResult);

        return experimentTemplateExperimentOptionsResult;
    }

    private Humidifier.FIS.ExperimentTemplateTypes.ExperimentTemplateExperimentOptions CreateExperimentTemplateExperimentOptions()
    {
        var experimentTemplateExperimentOptionsResult = new Humidifier.FIS.ExperimentTemplateTypes.ExperimentTemplateExperimentOptions();

        return experimentTemplateExperimentOptionsResult;
    }

} // End Of Class

public static class InnerExperimentTemplateExperimentTemplateExperimentOptionsFactoryExtensions
{
}
