// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class MlflowTrackingServerFactory(string resourceName = null, Action<Humidifier.SageMaker.MlflowTrackingServer> factoryAction = null) : ResourceFactory<Humidifier.SageMaker.MlflowTrackingServer>(resourceName)
{

    protected override Humidifier.SageMaker.MlflowTrackingServer Create()
    {
        var mlflowTrackingServerResult = CreateMlflowTrackingServer();
        factoryAction?.Invoke(mlflowTrackingServerResult);

        return mlflowTrackingServerResult;
    }

    private Humidifier.SageMaker.MlflowTrackingServer CreateMlflowTrackingServer()
    {
        var mlflowTrackingServerResult = new Humidifier.SageMaker.MlflowTrackingServer
        {
            GivenName = InputResourceName,
        };

        return mlflowTrackingServerResult;
    }

} // End Of Class

public static class MlflowTrackingServerFactoryExtensions
{
}
