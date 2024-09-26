// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Evidently;

public class InnerExperimentRunningStatusObjectFactory(Action<Humidifier.Evidently.ExperimentTypes.RunningStatusObject> factoryAction = null) : SubResourceFactory<Humidifier.Evidently.ExperimentTypes.RunningStatusObject>
{

    protected override Humidifier.Evidently.ExperimentTypes.RunningStatusObject Create()
    {
        var runningStatusObjectResult = CreateRunningStatusObject();
        factoryAction?.Invoke(runningStatusObjectResult);

        return runningStatusObjectResult;
    }

    private Humidifier.Evidently.ExperimentTypes.RunningStatusObject CreateRunningStatusObject()
    {
        var runningStatusObjectResult = new Humidifier.Evidently.ExperimentTypes.RunningStatusObject();

        return runningStatusObjectResult;
    }

} // End Of Class

public static class InnerExperimentRunningStatusObjectFactoryExtensions
{
}
