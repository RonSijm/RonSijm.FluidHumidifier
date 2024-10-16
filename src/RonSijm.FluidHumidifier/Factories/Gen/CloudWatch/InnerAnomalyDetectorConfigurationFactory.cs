// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudWatch;

public class InnerAnomalyDetectorConfigurationFactory(Action<Humidifier.CloudWatch.AnomalyDetectorTypes.Configuration> factoryAction = null) : SubResourceFactory<Humidifier.CloudWatch.AnomalyDetectorTypes.Configuration>
{

    protected override Humidifier.CloudWatch.AnomalyDetectorTypes.Configuration Create()
    {
        var configurationResult = CreateConfiguration();
        factoryAction?.Invoke(configurationResult);

        return configurationResult;
    }

    private Humidifier.CloudWatch.AnomalyDetectorTypes.Configuration CreateConfiguration()
    {
        var configurationResult = new Humidifier.CloudWatch.AnomalyDetectorTypes.Configuration();

        return configurationResult;
    }

} // End Of Class

public static class InnerAnomalyDetectorConfigurationFactoryExtensions
{
}
