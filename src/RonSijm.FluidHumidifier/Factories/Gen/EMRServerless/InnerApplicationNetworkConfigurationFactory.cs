// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMRServerless;

public class InnerApplicationNetworkConfigurationFactory(Action<Humidifier.EMRServerless.ApplicationTypes.NetworkConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.EMRServerless.ApplicationTypes.NetworkConfiguration>
{

    protected override Humidifier.EMRServerless.ApplicationTypes.NetworkConfiguration Create()
    {
        var networkConfigurationResult = CreateNetworkConfiguration();
        factoryAction?.Invoke(networkConfigurationResult);

        return networkConfigurationResult;
    }

    private Humidifier.EMRServerless.ApplicationTypes.NetworkConfiguration CreateNetworkConfiguration()
    {
        var networkConfigurationResult = new Humidifier.EMRServerless.ApplicationTypes.NetworkConfiguration();

        return networkConfigurationResult;
    }

} // End Of Class

public static class InnerApplicationNetworkConfigurationFactoryExtensions
{
}
