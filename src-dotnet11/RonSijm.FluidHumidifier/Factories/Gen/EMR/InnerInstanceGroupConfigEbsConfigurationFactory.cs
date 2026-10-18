// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMR;

public class InnerInstanceGroupConfigEbsConfigurationFactory(Action<Humidifier.EMR.InstanceGroupConfigTypes.EbsConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.EMR.InstanceGroupConfigTypes.EbsConfiguration>
{

    protected override Humidifier.EMR.InstanceGroupConfigTypes.EbsConfiguration Create()
    {
        var ebsConfigurationResult = CreateEbsConfiguration();
        factoryAction?.Invoke(ebsConfigurationResult);

        return ebsConfigurationResult;
    }

    private Humidifier.EMR.InstanceGroupConfigTypes.EbsConfiguration CreateEbsConfiguration()
    {
        var ebsConfigurationResult = new Humidifier.EMR.InstanceGroupConfigTypes.EbsConfiguration();

        return ebsConfigurationResult;
    }

} // End Of Class

public static class InnerInstanceGroupConfigEbsConfigurationFactoryExtensions
{
}
