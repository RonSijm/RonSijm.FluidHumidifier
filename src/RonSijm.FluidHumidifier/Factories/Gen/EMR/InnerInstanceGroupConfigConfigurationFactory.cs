// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMR;

public class InnerInstanceGroupConfigConfigurationFactory(Action<Humidifier.EMR.InstanceGroupConfigTypes.Configuration> factoryAction = null) : SubResourceFactory<Humidifier.EMR.InstanceGroupConfigTypes.Configuration>
{

    protected override Humidifier.EMR.InstanceGroupConfigTypes.Configuration Create()
    {
        var configurationResult = CreateConfiguration();
        factoryAction?.Invoke(configurationResult);

        return configurationResult;
    }

    private Humidifier.EMR.InstanceGroupConfigTypes.Configuration CreateConfiguration()
    {
        var configurationResult = new Humidifier.EMR.InstanceGroupConfigTypes.Configuration();

        return configurationResult;
    }

} // End Of Class

public static class InnerInstanceGroupConfigConfigurationFactoryExtensions
{
}
