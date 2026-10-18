// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMR;

public class InnerInstanceGroupConfigAppConfigurationFactory(Action<Humidifier.EMR.InstanceGroupConfigTypes.AppConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.EMR.InstanceGroupConfigTypes.AppConfiguration>
{

    protected override Humidifier.EMR.InstanceGroupConfigTypes.AppConfiguration Create()
    {
        var appConfigurationResult = CreateAppConfiguration();
        factoryAction?.Invoke(appConfigurationResult);

        return appConfigurationResult;
    }

    private Humidifier.EMR.InstanceGroupConfigTypes.AppConfiguration CreateAppConfiguration()
    {
        var appConfigurationResult = new Humidifier.EMR.InstanceGroupConfigTypes.AppConfiguration();

        return appConfigurationResult;
    }

} // End Of Class

public static class InnerInstanceGroupConfigAppConfigurationFactoryExtensions
{
}
