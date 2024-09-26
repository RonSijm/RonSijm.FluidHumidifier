// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LookoutMetrics;

public class InnerAnomalyDetectorCsvFormatDescriptorFactory(Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.CsvFormatDescriptor> factoryAction = null) : SubResourceFactory<Humidifier.LookoutMetrics.AnomalyDetectorTypes.CsvFormatDescriptor>
{

    protected override Humidifier.LookoutMetrics.AnomalyDetectorTypes.CsvFormatDescriptor Create()
    {
        var csvFormatDescriptorResult = CreateCsvFormatDescriptor();
        factoryAction?.Invoke(csvFormatDescriptorResult);

        return csvFormatDescriptorResult;
    }

    private Humidifier.LookoutMetrics.AnomalyDetectorTypes.CsvFormatDescriptor CreateCsvFormatDescriptor()
    {
        var csvFormatDescriptorResult = new Humidifier.LookoutMetrics.AnomalyDetectorTypes.CsvFormatDescriptor();

        return csvFormatDescriptorResult;
    }

} // End Of Class

public static class InnerAnomalyDetectorCsvFormatDescriptorFactoryExtensions
{
}
