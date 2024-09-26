// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LookoutMetrics;

public class InnerAnomalyDetectorVpcConfigurationFactory(Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.VpcConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.LookoutMetrics.AnomalyDetectorTypes.VpcConfiguration>
{

    protected override Humidifier.LookoutMetrics.AnomalyDetectorTypes.VpcConfiguration Create()
    {
        var vpcConfigurationResult = CreateVpcConfiguration();
        factoryAction?.Invoke(vpcConfigurationResult);

        return vpcConfigurationResult;
    }

    private Humidifier.LookoutMetrics.AnomalyDetectorTypes.VpcConfiguration CreateVpcConfiguration()
    {
        var vpcConfigurationResult = new Humidifier.LookoutMetrics.AnomalyDetectorTypes.VpcConfiguration();

        return vpcConfigurationResult;
    }

} // End Of Class

public static class InnerAnomalyDetectorVpcConfigurationFactoryExtensions
{
}
