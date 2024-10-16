// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMR;

public class InnerInstanceFleetConfigEbsConfigurationFactory(Action<Humidifier.EMR.InstanceFleetConfigTypes.EbsConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.EMR.InstanceFleetConfigTypes.EbsConfiguration>
{

    protected override Humidifier.EMR.InstanceFleetConfigTypes.EbsConfiguration Create()
    {
        var ebsConfigurationResult = CreateEbsConfiguration();
        factoryAction?.Invoke(ebsConfigurationResult);

        return ebsConfigurationResult;
    }

    private Humidifier.EMR.InstanceFleetConfigTypes.EbsConfiguration CreateEbsConfiguration()
    {
        var ebsConfigurationResult = new Humidifier.EMR.InstanceFleetConfigTypes.EbsConfiguration();

        return ebsConfigurationResult;
    }

} // End Of Class

public static class InnerInstanceFleetConfigEbsConfigurationFactoryExtensions
{
}
