// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class HubContentVersionFactory(string resourceName = null, Action<Humidifier.SageMaker.HubContentVersion> factoryAction = null) : ResourceFactory<Humidifier.SageMaker.HubContentVersion>(resourceName)
{

    protected override Humidifier.SageMaker.HubContentVersion Create()
    {
        var hubContentVersionResult = CreateHubContentVersion();
        factoryAction?.Invoke(hubContentVersionResult);

        return hubContentVersionResult;
    }

    private Humidifier.SageMaker.HubContentVersion CreateHubContentVersion()
    {
        var hubContentVersionResult = new Humidifier.SageMaker.HubContentVersion
        {
            GivenName = InputResourceName,
        };

        return hubContentVersionResult;
    }

} // End Of Class

public static class HubContentVersionFactoryExtensions
{
}
