// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerServiceCanaryConfigurationFactory(Action<Humidifier.ECS.ServiceTypes.CanaryConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ECS.ServiceTypes.CanaryConfiguration>
{

    protected override Humidifier.ECS.ServiceTypes.CanaryConfiguration Create()
    {
        var canaryConfigurationResult = CreateCanaryConfiguration();
        factoryAction?.Invoke(canaryConfigurationResult);

        return canaryConfigurationResult;
    }

    private Humidifier.ECS.ServiceTypes.CanaryConfiguration CreateCanaryConfiguration()
    {
        var canaryConfigurationResult = new Humidifier.ECS.ServiceTypes.CanaryConfiguration();

        return canaryConfigurationResult;
    }

} // End Of Class

public static class InnerServiceCanaryConfigurationFactoryExtensions
{
}
