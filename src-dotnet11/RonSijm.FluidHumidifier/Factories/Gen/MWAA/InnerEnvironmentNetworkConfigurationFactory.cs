// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MWAA;

public class InnerEnvironmentNetworkConfigurationFactory(Action<Humidifier.MWAA.EnvironmentTypes.NetworkConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MWAA.EnvironmentTypes.NetworkConfiguration>
{

    protected override Humidifier.MWAA.EnvironmentTypes.NetworkConfiguration Create()
    {
        var networkConfigurationResult = CreateNetworkConfiguration();
        factoryAction?.Invoke(networkConfigurationResult);

        return networkConfigurationResult;
    }

    private Humidifier.MWAA.EnvironmentTypes.NetworkConfiguration CreateNetworkConfiguration()
    {
        var networkConfigurationResult = new Humidifier.MWAA.EnvironmentTypes.NetworkConfiguration();

        return networkConfigurationResult;
    }

} // End Of Class

public static class InnerEnvironmentNetworkConfigurationFactoryExtensions
{
}
