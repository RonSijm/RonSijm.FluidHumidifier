// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMR;

public class InnerClusterEbsConfigurationFactory(Action<Humidifier.EMR.ClusterTypes.EbsConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.EMR.ClusterTypes.EbsConfiguration>
{

    protected override Humidifier.EMR.ClusterTypes.EbsConfiguration Create()
    {
        var ebsConfigurationResult = CreateEbsConfiguration();
        factoryAction?.Invoke(ebsConfigurationResult);

        return ebsConfigurationResult;
    }

    private Humidifier.EMR.ClusterTypes.EbsConfiguration CreateEbsConfiguration()
    {
        var ebsConfigurationResult = new Humidifier.EMR.ClusterTypes.EbsConfiguration();

        return ebsConfigurationResult;
    }

} // End Of Class

public static class InnerClusterEbsConfigurationFactoryExtensions
{
}
