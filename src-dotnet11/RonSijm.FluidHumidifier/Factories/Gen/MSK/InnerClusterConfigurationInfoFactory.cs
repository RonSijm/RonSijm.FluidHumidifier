// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MSK;

public class InnerClusterConfigurationInfoFactory(Action<Humidifier.MSK.ClusterTypes.ConfigurationInfo> factoryAction = null) : SubResourceFactory<Humidifier.MSK.ClusterTypes.ConfigurationInfo>
{

    protected override Humidifier.MSK.ClusterTypes.ConfigurationInfo Create()
    {
        var configurationInfoResult = CreateConfigurationInfo();
        factoryAction?.Invoke(configurationInfoResult);

        return configurationInfoResult;
    }

    private Humidifier.MSK.ClusterTypes.ConfigurationInfo CreateConfigurationInfo()
    {
        var configurationInfoResult = new Humidifier.MSK.ClusterTypes.ConfigurationInfo();

        return configurationInfoResult;
    }

} // End Of Class

public static class InnerClusterConfigurationInfoFactoryExtensions
{
}
