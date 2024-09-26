// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMR;

public class InnerClusterConfigurationFactory(Action<Humidifier.EMR.ClusterTypes.Configuration> factoryAction = null) : SubResourceFactory<Humidifier.EMR.ClusterTypes.Configuration>
{

    protected override Humidifier.EMR.ClusterTypes.Configuration Create()
    {
        var configurationResult = CreateConfiguration();
        factoryAction?.Invoke(configurationResult);

        return configurationResult;
    }

    private Humidifier.EMR.ClusterTypes.Configuration CreateConfiguration()
    {
        var configurationResult = new Humidifier.EMR.ClusterTypes.Configuration();

        return configurationResult;
    }

} // End Of Class

public static class InnerClusterConfigurationFactoryExtensions
{
}
