// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerServiceLogConfigurationFactory(Action<Humidifier.ECS.ServiceTypes.LogConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ECS.ServiceTypes.LogConfiguration>
{

    protected override Humidifier.ECS.ServiceTypes.LogConfiguration Create()
    {
        var logConfigurationResult = CreateLogConfiguration();
        factoryAction?.Invoke(logConfigurationResult);

        return logConfigurationResult;
    }

    private Humidifier.ECS.ServiceTypes.LogConfiguration CreateLogConfiguration()
    {
        var logConfigurationResult = new Humidifier.ECS.ServiceTypes.LogConfiguration();

        return logConfigurationResult;
    }

} // End Of Class

public static class InnerServiceLogConfigurationFactoryExtensions
{
}
