// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelHubAccessConfigFactory(Action<Humidifier.SageMaker.ModelTypes.HubAccessConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelTypes.HubAccessConfig>
{

    protected override Humidifier.SageMaker.ModelTypes.HubAccessConfig Create()
    {
        var hubAccessConfigResult = CreateHubAccessConfig();
        factoryAction?.Invoke(hubAccessConfigResult);

        return hubAccessConfigResult;
    }

    private Humidifier.SageMaker.ModelTypes.HubAccessConfig CreateHubAccessConfig()
    {
        var hubAccessConfigResult = new Humidifier.SageMaker.ModelTypes.HubAccessConfig();

        return hubAccessConfigResult;
    }

} // End Of Class

public static class InnerModelHubAccessConfigFactoryExtensions
{
}
