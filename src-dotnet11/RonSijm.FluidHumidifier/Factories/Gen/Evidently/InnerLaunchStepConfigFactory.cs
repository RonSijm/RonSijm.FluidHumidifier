// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Evidently;

public class InnerLaunchStepConfigFactory(Action<Humidifier.Evidently.LaunchTypes.StepConfig> factoryAction = null) : SubResourceFactory<Humidifier.Evidently.LaunchTypes.StepConfig>
{

    protected override Humidifier.Evidently.LaunchTypes.StepConfig Create()
    {
        var stepConfigResult = CreateStepConfig();
        factoryAction?.Invoke(stepConfigResult);

        return stepConfigResult;
    }

    private Humidifier.Evidently.LaunchTypes.StepConfig CreateStepConfig()
    {
        var stepConfigResult = new Humidifier.Evidently.LaunchTypes.StepConfig();

        return stepConfigResult;
    }

} // End Of Class

public static class InnerLaunchStepConfigFactoryExtensions
{
}
