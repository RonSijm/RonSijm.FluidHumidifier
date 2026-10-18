// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FIS;

public class InnerExperimentExperimentOptionsFactory(Action<Humidifier.FIS.ExperimentTypes.ExperimentOptions> factoryAction = null) : SubResourceFactory<Humidifier.FIS.ExperimentTypes.ExperimentOptions>
{

    protected override Humidifier.FIS.ExperimentTypes.ExperimentOptions Create()
    {
        var experimentOptionsResult = CreateExperimentOptions();
        factoryAction?.Invoke(experimentOptionsResult);

        return experimentOptionsResult;
    }

    private Humidifier.FIS.ExperimentTypes.ExperimentOptions CreateExperimentOptions()
    {
        var experimentOptionsResult = new Humidifier.FIS.ExperimentTypes.ExperimentOptions();

        return experimentOptionsResult;
    }

} // End Of Class

public static class InnerExperimentExperimentOptionsFactoryExtensions
{
}
