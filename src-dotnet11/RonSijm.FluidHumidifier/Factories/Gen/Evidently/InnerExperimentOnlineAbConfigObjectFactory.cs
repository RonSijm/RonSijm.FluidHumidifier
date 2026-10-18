// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Evidently;

public class InnerExperimentOnlineAbConfigObjectFactory(Action<Humidifier.Evidently.ExperimentTypes.OnlineAbConfigObject> factoryAction = null) : SubResourceFactory<Humidifier.Evidently.ExperimentTypes.OnlineAbConfigObject>
{

    protected override Humidifier.Evidently.ExperimentTypes.OnlineAbConfigObject Create()
    {
        var onlineAbConfigObjectResult = CreateOnlineAbConfigObject();
        factoryAction?.Invoke(onlineAbConfigObjectResult);

        return onlineAbConfigObjectResult;
    }

    private Humidifier.Evidently.ExperimentTypes.OnlineAbConfigObject CreateOnlineAbConfigObject()
    {
        var onlineAbConfigObjectResult = new Humidifier.Evidently.ExperimentTypes.OnlineAbConfigObject();

        return onlineAbConfigObjectResult;
    }

} // End Of Class

public static class InnerExperimentOnlineAbConfigObjectFactoryExtensions
{
}
