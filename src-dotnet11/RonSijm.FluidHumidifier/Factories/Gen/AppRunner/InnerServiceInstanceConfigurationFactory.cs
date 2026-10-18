// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppRunner;

public class InnerServiceInstanceConfigurationFactory(Action<Humidifier.AppRunner.ServiceTypes.InstanceConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.AppRunner.ServiceTypes.InstanceConfiguration>
{

    protected override Humidifier.AppRunner.ServiceTypes.InstanceConfiguration Create()
    {
        var instanceConfigurationResult = CreateInstanceConfiguration();
        factoryAction?.Invoke(instanceConfigurationResult);

        return instanceConfigurationResult;
    }

    private Humidifier.AppRunner.ServiceTypes.InstanceConfiguration CreateInstanceConfiguration()
    {
        var instanceConfigurationResult = new Humidifier.AppRunner.ServiceTypes.InstanceConfiguration();

        return instanceConfigurationResult;
    }

} // End Of Class

public static class InnerServiceInstanceConfigurationFactoryExtensions
{
}
