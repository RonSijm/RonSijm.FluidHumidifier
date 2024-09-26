// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LookoutMetrics;

public class InnerAnomalyDetectorJsonFormatDescriptorFactory(Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.JsonFormatDescriptor> factoryAction = null) : SubResourceFactory<Humidifier.LookoutMetrics.AnomalyDetectorTypes.JsonFormatDescriptor>
{

    protected override Humidifier.LookoutMetrics.AnomalyDetectorTypes.JsonFormatDescriptor Create()
    {
        var jsonFormatDescriptorResult = CreateJsonFormatDescriptor();
        factoryAction?.Invoke(jsonFormatDescriptorResult);

        return jsonFormatDescriptorResult;
    }

    private Humidifier.LookoutMetrics.AnomalyDetectorTypes.JsonFormatDescriptor CreateJsonFormatDescriptor()
    {
        var jsonFormatDescriptorResult = new Humidifier.LookoutMetrics.AnomalyDetectorTypes.JsonFormatDescriptor();

        return jsonFormatDescriptorResult;
    }

} // End Of Class

public static class InnerAnomalyDetectorJsonFormatDescriptorFactoryExtensions
{
}
